using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Models.DalResponse;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.Helpers
{
    internal sealed class ExcelHelper
    {
        private readonly Workbook activeWorkbook;
        private int currentRow;
        public enum ExcelFileType
        {
            FileAsPath,
            FileAsBase64
        }
        public ExcelHelper()
        {
            if (Globals.ThisAddIn.Application.Workbooks.Count == 0)
            {
                throw new Exception("Application Error: Cannot get Excel instance");
            }
            activeWorkbook = Globals.ThisAddIn.Application.ActiveWorkbook;
        }

        public void AddBase64File(string base64String)
        {
            byte[] excelFile = Convert.FromBase64String(base64String);
            if (excelFile == null)
            {
                throw new Exception("File not found");
            }
            MemoryStream memoryStream = new MemoryStream(excelFile);
            //Globals.ThisAddIn.Application.Workbooks.Open(base64String, memoryStream);
            FileStream fs = new FileStream("c:\\Documents\\temp.xlsx",FileMode.Create, FileAccess.Write);
            memoryStream.CopyTo(fs);
            fs.Flush();
            fs.Close();
            Globals.ThisAddIn.Application.Workbooks.Open("c:\\Documents\\temp.xlsx");
        }

        /// <summary>
        /// Creates worksheets for each <see cref="System.Data.DataTable"/> in the <see cref="DataSet"/> in the current Excel file
        /// </summary>
        /// <param name="dataSet"></param>
        private void DatasetToExcel(DataSet dataSet)
        {
            try
            {
                // Screen updating and calculation are turned off to improve the performance of workbook generation
                Globals.ThisAddIn.Application.Calculation = XlCalculation.xlCalculationManual;
                Globals.ThisAddIn.Application.EnableEvents = false;
                Globals.ThisAddIn.Application.ScreenUpdating = false;

                foreach (System.Data.DataTable table in dataSet.Tables)
                {
                    //adding new sheets
                    Worksheet currentSheet = activeWorkbook.Sheets.Add();
                    currentSheet.Name = GetWorksheetName(table.TableName);
                    currentRow = 1;

                    // Table Heading
                    Range selectedRange = currentSheet.Range[currentSheet.Cells[currentRow, 1], currentSheet.Cells[currentRow, table.Columns.Count]];
                    selectedRange.Merge();
                    //selectedRange.Font.Bold = true;
                    selectedRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    //selectedRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGreen);
                    currentSheet.Cells[currentRow, 1] = table.TableName;
                    currentRow++;

                    selectedRange = currentSheet.Range[currentSheet.Cells[currentRow, 1], currentSheet.Cells[currentRow, table.Columns.Count]];
                    //selectedRange.Font.Bold = true;
                    selectedRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Adding column heading
                    var colNames = new string[table.Columns.Count];
                    for (var i = 0; i < table.Columns.Count; i++)
                    {
                        colNames[i] = table.Columns[i].ColumnName;
                    }
                    selectedRange = currentSheet.Range[currentSheet.Cells[currentRow, 1], currentSheet.Cells[currentRow, table.Columns.Count]];
                    selectedRange.Value = colNames;
                    currentRow++;

                    // Adding Rows
                    for (var j = 0; j < table.Rows.Count; j++)
                    {
                        Range myRange = currentSheet.Range[currentSheet.Cells[currentRow, 1], currentSheet.Cells[currentRow, table.Columns.Count]];
                        myRange.Value = table.Rows[j].ItemArray;
                        currentRow++;
                    }

                    // Border
                    Range last = currentSheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing);
                    Range range = currentSheet.Range["A2", last];
                    range.Cells.Borders.LineStyle = XlLineStyle.xlLineStyleNone;
                    range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    range.Columns.AutoFit();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Globals.ThisAddIn.Application.Calculation = XlCalculation.xlCalculationAutomatic;
                Globals.ThisAddIn.Application.EnableEvents = true;
                Globals.ThisAddIn.Application.ScreenUpdating = true;
            }
        }

        /// <summary>
        /// Checks for existing name and word length and returns a safe to use name for worksheet
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string GetWorksheetName(string name)
        {
            name = name.Replace(" ", string.Empty).Trim();
            if (name.Length > 22)
            {
                name = name.Substring(0, 22);
            }

            var sheetName = name;
            for (var i = 1; WorkSheetExists(sheetName); i++)
            {
                sheetName = name + $"({i})";
            }
            return sheetName;
        }

        /// <summary>
        /// Checks if a worksheet exists with the specified name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private bool WorkSheetExists(string name)
        {
            foreach (Worksheet sheet in activeWorkbook.Sheets)
            {
                if (sheet.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Generates Excel sheets from the DAL request string.
        /// </summary>
        /// <param name="request">Request string for DAL</param>
        public void GenReport(string request)
        {
            try
            {
                var apiData = new ApiHelper().GetData(request);
                if (apiData == null)
                {
                    MessageBox.Show("Unable to fetch data");
                    return;
                }
                if (apiData.error != string.Empty)
                {
                    MessageBox.Show("Error from API: " + apiData.error);
                    return;
                }

                var fields = (JObject)apiData.fields;
                if (fields.Children().Count() == 0)
                {
                    MessageBox.Show("No records found");
                    return;
                }

                var dataSet = new DataSet();
                System.Data.DataTable mappingTable = null;
                var formatHelper = new FormatHelper();

                foreach (var property in fields.Children())
                {
                    var tableName = formatHelper.ToTitleCase(property.Path);

                    if (tableName == "Return Based Analytics")
                    {
                        foreach (var fieldData in property.Children())
                        {
                            var returnBasedAnalytics = fieldData.ToObject<ReturnBasedAnalytics>();
                            var datatables = formatHelper.ConvertToDataTable(returnBasedAnalytics);
                            dataSet.Tables.AddRange(datatables.ToArray());
                        }
                    }
                    else
                    {
                        foreach (var fieldData in property.Children())
                        {
                            var datatable = formatHelper.ConvertToDataTable(fieldData.ToObject<DALResponse.FieldDetail>());
                            datatable.TableName = tableName;
                            if (tableName == "Mappings")
                            {
                                mappingTable = datatable;
                            }
                            else
                            {
                                dataSet.Tables.Add(datatable);
                            }
                        }
                    }
                }

                // addign mapping at the last so that it would be first Worksheet after generation
                if (mappingTable != null)
                {
                    dataSet.Tables.Add(mappingTable);
                }
                DatasetToExcel(dataSet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool PopulateExcelFromString(string strResponse)
        {
            var responseObject = JsonConvert.DeserializeObject<DALResponse>(strResponse);
            var fields = (JObject)responseObject.fields;
            if (fields.Children().Count() == 0)
            {
                MessageBox.Show("No records found");
                return false;
            }

            var dataSet = new DataSet();
            System.Data.DataTable mappingTable = null;
            var formatHelper = new FormatHelper();

            foreach (var property in fields.Children())
            {
                var tableName = formatHelper.ToTitleCase(property.Path);

                if (tableName == "Return Based Analytics")
                {
                    foreach (var fieldData in property.Children())
                    {
                        var returnBasedAnalytics = fieldData.ToObject<ReturnBasedAnalytics>();
                        var datatables = formatHelper.ConvertToDataTable(returnBasedAnalytics);
                        dataSet.Tables.AddRange(datatables.ToArray());
                    }
                }
                else
                {
                    foreach (var fieldData in property.Children())
                    {
                        var datatable = formatHelper.ConvertToDataTable(fieldData.ToObject<DALResponse.FieldDetail>());
                        datatable.TableName = tableName;
                        if (tableName == "Mappings")
                        {
                            mappingTable = datatable;
                        }
                        else
                        {
                            dataSet.Tables.Add(datatable);
                        }
                    }
                }
            }

            // addign mapping at the last so that it would be first Worksheet after generation
            if (mappingTable != null)
            {
                dataSet.Tables.Add(mappingTable);
            }
            DatasetToExcel(dataSet);
            return true;
        }

        public void AddBase64File(string base64String, ExcelFileType excelFileType = ExcelFileType.FileAsBase64)
        {
            string fileName = System.IO.Path.GetTempPath();
            if (excelFileType == ExcelFileType.FileAsBase64)
            {
                byte[] excelFile = Convert.FromBase64String(base64String);
                if (excelFile == null)
                {
                    throw new Exception("File not found");
                }
                MemoryStream memoryStream = new MemoryStream(excelFile);
                //Globals.ThisAddIn.Application.Workbooks.Open(base64String, memoryStream);
                fileName = System.IO.Path.GetTempPath() + Guid.NewGuid().ToString() + ".tmp";
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                memoryStream.CopyTo(fs);
                fs.Flush();
                fs.Close();



            }
            else
            {
                fileName = base64String;
            }
            var currWb = Globals.ThisAddIn.Application.ActiveWorkbook;
            var wk = Globals.ThisAddIn.Application.Workbooks.Open(fileName);
            //currWb.Activate();
            foreach (Worksheet wb in wk.Worksheets)
            {
                if (wb.UsedRange.Count > 1)
                {
                    wb.Copy(currWb.Worksheets[1], Type.Missing);
                }
            }
            wk.Close();
            System.IO.File.Delete(fileName);
        }
        public string GetCellRange(string title)
        {
            try
            {
                var inputResult = Globals.ThisAddIn.Application.InputBox(title, Title: "Range Selector", Type: 8);



                if (typeof(bool) == inputResult.GetType() && inputResult == false)
                {
                    return null;
                }





                var result = new List<object>();
                var cellvalues = (Array)((Range)inputResult).Cells.Value;
                foreach (var cellVal in cellvalues)
                {
                    if (cellVal != null)
                    {
                        result.Add(cellVal);
                    }
                }
                string returnValue = string.Join(",", result);
                return returnValue;





            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
        }


       

    }
}
