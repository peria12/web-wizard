using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models.InputModels;
using Franklin_Templeton_DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Franklin_Templeton_DAL.Constants.DateInputEnums;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using static Franklin_Templeton_DAL.Constants.FieldInputs;
using System.Drawing.Drawing2D;
using Newtonsoft.Json.Linq;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class DalDateInputForm : Form
    {
        private System.Data.DataTable dtSelectedDate = new System.Data.DataTable();
        public DalDateInputForm()
        {
            InitializeComponent();
            btnSelectDatesExcel.Visible = true;
            rbSnapshots.Checked = true;
            dtpDate.MaxDate = DateTime.Now;
            lbl_auth_status.Text =DalSettings.statusMessage;
            InitializeDataSources();
            //cbDateinfo.Items.Insert(0, "Series");
            //cbDateinfo.SelectedIndex= 0;
        }
        #region IntializeDate
        private void InitializeDataSources()
        {
            this.lblFetching.Visible = false;
            CachedData.SetFormTheme(this);
            try
            {
                cbFillMissing.DataSource =FillMissing.InputValues;
                cbFrequency.DataSource=Frequency.InputValues;
                cbAlign.DataSource = AlignItems.InputValues;
                dtSelectedDate.Columns.Add("Dates");
                if (CachedData.InputRequest.dates != null && CachedData.InputRequest.dates.Count > 0)
                {
                    foreach (string value in CachedData.InputRequest.dates)
                    {
                        dtSelectedDate.Rows.Add(value);
                    }
                }
                else if (CachedData.InputRequest.date != null)
                {
                    dtSelectedDate.Rows.Add(CachedData.InputRequest.date);
                }
                dgvDates.Columns[0].DataPropertyName = "Dates";
                dgvDates.AutoGenerateColumns = false;
                dgvDates.Columns[0].DefaultCellStyle.Format = "yyyy-MM-DD";
                dgvDates.DataSource = dtSelectedDate;
                rbSnapshots.Checked = true;
                if (CachedData.InputRequest.date_info != null)
                {
                    if(CachedData.InputRequest.date_info.DateInfoType!=null)
                    {
                        rbRange.Checked = (CachedData.InputRequest.date_info.DateInfoType.ToLower() == DateInfoType.Range.ToLower());
                        rbSnapshots.Checked = (CachedData.InputRequest.date_info.DateInfoType.ToLower() == DateInfoType.Snapshots.ToLower());
                        rbSeries.Checked = (CachedData.InputRequest.date_info.DateInfoType.ToLower() == DateInfoType.Series.ToLower());                      
                    }
                    if (CachedData.InputRequest.date_info.Frequency != null)
                    {
                        cbFrequency.SelectedItem = (CachedData.InputRequest.date_info.Frequency.unit ?? null);
                        cbAlign.SelectedItem = (CachedData.InputRequest.date_info.Frequency.align ?? null);
                        txtInterval.Text = CachedData.InputRequest.date_info.Frequency.interval.ToString();
                    }
                    cbFillMissing.SelectedItem = (CachedData.InputRequest.date_info.FillMissing ?? null);
                    txtlook.Text = CachedData.InputRequest.date_info.Lookback.ToString();
                }
                else
                {
                    rbSnapshots.Checked = true;
                }
                SetFormFieldVisiblity();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            var form = new DalInputEntitiesForm();
            form.Show();
        }
        #region Select From Excel
        private void btnSelectDatesExcel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var cellValues = UiHelper.GetCellRange("Select cells containing dates");
                if (cellValues == null)
                {
                    return;
                }
                foreach (var cellvalue in cellValues)
                {
                    if (cellvalue != null)
                    {
                        if (DateTime.TryParse(cellvalue.ToString(), out DateTime date1fromexcel))
                        {
                            var formatedDate = date1fromexcel.ToString("yyyy-MM-dd");
                            //monthCalendar.AddBoldedDate(date1fromexcel);
                            var DateRows = dtSelectedDate.Select("Dates ='" + formatedDate + "'");
                            if (DateRows.Count() > 0)
                            {
                                MessageBox.Show("Date is Already Added");
                            }
                            else
                            {
                                var tmpRow = dtSelectedDate.NewRow();
                                tmpRow["Dates"] = formatedDate;
                                dtSelectedDate.Rows.Add(tmpRow);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show();
                this.Focus();
            }
        }
        #endregion
        private void WriteData()
        {
            List<string> SelectedDate = null;
            try
            {
                var dateInput = new DALDateInfo();

                if (rbSeries.Checked)
                {
                    dateInput.Frequency = new DALFrequecy
                    {
                        align = (cbAlign.SelectedItem != null ? cbAlign.SelectedItem.ToString().ToLower() : null),
                        unit = (cbFrequency.SelectedItem != null ? cbFrequency.SelectedItem.ToString().ToLower() : null)
                    };
                    if (!string.IsNullOrEmpty(txtInterval.Text))
                    {
                        dateInput.Frequency.interval = Convert.ToInt32(txtInterval.Text);
                    }
                    dateInput.DateInfoType = rbSeries.Text.Replace("&", "").ToLower();

                }
                if (rbSnapshots.Checked)
                {
                    //dateInput.DateInfoType = rbSnapshots.Text.Replace("&", "").ToLower();
                    dateInput = null;
                }
                if (rbRange.Checked)
                {
                    dateInput.DateInfoType = rbRange.Text.Replace("&", "").ToLower();
                }
                if (cbFillMissing.SelectedIndex!=0)
                {
                    if (cbFillMissing.SelectedItem != null)
                    {
                        dateInput.FillMissing = cbFillMissing.SelectedItem.ToString().ToLower();
                    }
                }
                if (!string.IsNullOrEmpty(txtlook.Text))
                {
                    dateInput.Lookback = (int?)Convert.ToInt64(txtlook.Text);
                }
                if (dtSelectedDate.Rows.Count > 1)
                {
                    SelectedDate = dtSelectedDate.AsEnumerable().Select(x => x[0].ToString()).ToList();
                    CachedData.InputRequest.dates = SelectedDate;
                    CachedData.InputRequest.date_info = dateInput;
                }
                else
                {
                    if (dtSelectedDate.Rows.Count == 1)
                    {
                        CachedData.InputRequest.date = dtSelectedDate.Rows[0]["Dates"].ToString();
                        CachedData.InputRequest.date_info = null;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while creating request");
            }
        }

        #region Generate Excel
        private void btnFetchData_Click(object sender, EventArgs e)
        {
            try
            {
                WriteData();
                string strRequest = JsonConvert.SerializeObject(CachedData.InputRequest);
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                this.lblFetching.Visible = true;
                if (CachedData.GenerateExcel(strRequest))
                {
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Invalied Input");
                }
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                this.lblFetching.Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region Checked Event      

        private void rbSnapshots_CheckedChanged(object sender, EventArgs e)
        {
            SetFormFieldVisiblity();
        }

        private void rbRange_CheckedChanged(object sender, EventArgs e)
        {
            SetFormFieldVisiblity();
        }

        private void rbSeries_CheckedChanged_1(object sender, EventArgs e)
        {
            SetFormFieldVisiblity();
        }
        private void SetFormFieldVisiblity()
        {
            //monthCalendar.Visible = (!rbRange.Checked);
            //txtSelectDate.Visible = (!rbRange.Checked);
            //StartDate.Visible = (rbRange.Checked);
            //lblStartDate.Visible = (rbRange.Checked);
            //lblEndDate.Visible = (rbRange.Checked);
            //EndDate.Visible = (rbRange.Checked);
            //monthCalendar.Visible = false;
            //txtSelectDate.Visible = false;
            ///StartDate.Visible = false;
            //lblStartDate.Visible = false;
            //lblEndDate.Visible = false;
            //EndDate.Visible = false;
            //lblFrequency.Visible = (rbSeries.Checked);
            cbFrequency.Enabled = (rbSeries.Checked);
            //lblInterval.Visible = (rbSeries.Checked);
            txtInterval.Enabled = (rbSeries.Checked);
            //lblFillMissing.Visible = (rbSeries.Checked);
            //lblAlign.Visible = (rbSeries.Checked);
            cbFillMissing.Enabled = (rbSeries.Checked);
            cbAlign.Enabled = (rbSeries.Checked);
            //btnSelectDatesExcel.Visible = false;
            //lblLookback.Visible = (rbSeries.Checked);
            txtlook.Enabled = (rbSeries.Checked);
        }

        #endregion
        #region Add Dates
        private void btnAddBlodDates(object sender, EventArgs e)
        {
            dtSelectedDate.Rows.Add(dtpDate.Value.ToString("yyyy-MM-dd"));
        }

        private void dgvDates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDates.Columns[e.ColumnIndex].Name == "dgDelDates")
            {
                string strIdToDel = dtSelectedDate.Rows[e.RowIndex][0].ToString();
                if (UiHelper.GetDeleteConformation(strIdToDel))
                {
                    dtSelectedDate.Rows[e.RowIndex].Delete();
                }
            }
        }
        #endregion

        private void DalDateInputForm_Shown(object sender, EventArgs e)
        {
            if (!this.Focused)
            {
                this.Focus();
            }
        }
    }

}
