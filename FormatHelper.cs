using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Models.DalResponse;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Reflection;
using static Franklin_Templeton_DAL.Models.DalResponse.ReturnBasedAnalytics;
using static Franklin_Templeton_DAL.Models.DALResponse;

namespace Franklin_Templeton_DAL.Helpers
{
    internal sealed class FormatHelper
    {
        public FormatHelper()
        {

        }

        /// <summary>
        /// Converts DAL Field response to DataTable
        /// </summary>
        /// <param name="fieldDetail"></param>
        /// <returns></returns>
        public DataTable ConvertToDataTable(DALResponse.FieldDetail fieldDetail)
        {
            try
            {
                var dataTable = new DataTable();

                foreach (var col in fieldDetail.columns)
                {
                    dataTable.Columns.Add(col);
                }
                foreach (var row in fieldDetail.values)
                {
                    dataTable.Rows.Add(row.ToArray());
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Creates DataTable from RBA response
        /// </summary>
        /// <param name="resData"></param>
        /// <returns></returns>
        public List<DataTable> ConvertToDataTable(ReturnBasedAnalytics resData)
        {
            try
            {
                var tables = new List<DataTable>();

                if (resData.data_checks != null && resData.data_checks.records.Count > 0)
                {
                    var dataTable = new DataTable("Data Checks");

                    foreach (var col in resData.data_checks.columns)
                    {
                        dataTable.Columns.Add(col);
                    }
                    foreach (var row in resData.data_checks.records)
                    {
                        dataTable.Rows.Add(row.ToArray());
                    }

                    tables.Add(dataTable);
                }

                if (resData.returns != null && resData.returns.records.Count > 0)
                {
                    var dataTable = new DataTable("Returns");

                    foreach (var col in resData.returns.columns)
                    {
                        dataTable.Columns.Add(col);
                    }
                    foreach (var row in resData.returns.records)
                    {
                        dataTable.Rows.Add(row.ToArray());
                    }

                    tables.Add(dataTable);
                }

                if (resData.entity_info != null && resData.entity_info.records.Count > 0)
                {
                    var dataTable = new DataTable("Entity Info");

                    foreach (var col in resData.entity_info.columns)
                    {
                        dataTable.Columns.Add(col);
                    }
                    foreach (var row in resData.entity_info.records)
                    {
                        dataTable.Rows.Add(row.ToArray());
                    }

                    tables.Add(dataTable);
                }

                var index = 1;
                foreach(var pair in resData.pairs)
                {
                    if(pair == null)
                    {
                        continue;
                    }

                    var suffix = index > 1 ? $"({index})" : string.Empty ;

                    if (pair.beta_profile != null && pair.beta_profile.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Beta Profile" + suffix, pair.beta_profile);
                        tables.Add(dataTable);
                    }

                    if (pair.yearly_perf != null && pair.yearly_perf.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Yearly Perf" + suffix, pair.yearly_perf);
                        tables.Add(dataTable);
                    }

                    if (pair.model_correlations != null && pair.model_correlations.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Model Correlations" + suffix, pair.model_correlations);
                        tables.Add(dataTable);
                    }

                    if (pair.factor_response_rel_quintiles != null && pair.factor_response_rel_quintiles.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Factor Response rel quintiles" + suffix, pair.factor_response_rel_quintiles);
                        tables.Add(dataTable);
                    }

                    if (pair.rel_returns_rolling != null && pair.rel_returns_rolling.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Rel Returns Rolling" + suffix, pair.rel_returns_rolling);
                        tables.Add(dataTable);
                    }

                    if (pair.rolling_stats != null && pair.rolling_stats.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Rolling Stats" + suffix, pair.rolling_stats);
                        tables.Add(dataTable);
                    }

                    if (pair.point_in_time_perf != null && pair.point_in_time_perf.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Point in time perf" + suffix, pair.point_in_time_perf);
                        tables.Add(dataTable);
                    }

                    if (pair.rolling_18m_a_b != null && pair.rolling_18m_a_b.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Rolling 18m_a_b" + suffix, pair.rolling_18m_a_b);
                        tables.Add(dataTable);
                    }

                    if (pair.factor_response_quintiles != null && pair.factor_response_quintiles.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Factor Response Quintiles" + suffix, pair.factor_response_quintiles);
                        tables.Add(dataTable);
                    }

                    if (pair.component_info != null && pair.component_info.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Component Info" + suffix, pair.component_info);
                        tables.Add(dataTable);
                    }

                    if (pair.stats != null && pair.stats.records.Count > 0)
                    {
                        var dataTable = RecordColumnsToDataTable("Stats" + suffix,pair.stats);
                        tables.Add(dataTable);
                    }

                    index++;
                }

                return tables;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Creates Datatable from <see cref="RecordsColumns"/> and returns it
        /// Part of RBA to DataTable workflow
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="recordsColumns"></param>
        /// <returns></returns>
        private DataTable RecordColumnsToDataTable(string tableName, RecordsColumns recordsColumns)
        {
            var dataTable = new DataTable(tableName);
            foreach (var col in recordsColumns.columns)
            {
                dataTable.Columns.Add(col);
            }
            foreach (var row in recordsColumns.records)
            {
                dataTable.Rows.Add(row.ToArray());
            }
            return dataTable;
        }

        /// <summary>
        /// Creates a datatable from any list of classes
        /// The variable names of the classes will be used as column name and the values will be converted to rows.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="models"></param>
        /// <returns></returns>
        public DataTable ConvertToDataTable<T>(List<T> models)
        {
            try
            {
                // creating a data table instance and typed it as our incoming model   
                // as I make it generic, if you want, you can make it the model typed you want.  
                var dataTable = new DataTable(typeof(T).Name);

                //Get all the properties of that model  
                var Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                // Loop through all the properties              
                // Adding Column name to our datatable  
                foreach (var prop in Props)
                {
                    //Setting column names as Property names    
                    dataTable.Columns.Add(prop.Name);
                }
                // Adding Row and its value to our dataTable  
                foreach (T item in models)
                {
                    var values = new object[Props.Length];
                    for (var i = 0; i < Props.Length; i++)
                    {
                        //inserting property values to datatable rows    
                        values[i] = Props[i].GetValue(item, null);
                    }
                    // Finally add value to datatable    
                    dataTable.Rows.Add(values);
                }
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Replaces underscore with spaces and converts the name to titlecase
        /// Used for generating workbook names or table names in DataTable
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public string ToTitleCase(string inputString)
        {
            var result = inputString.Replace("_", " ");
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(result.ToLower());
        }
    }
}
