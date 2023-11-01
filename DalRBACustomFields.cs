using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models.InputModels;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Franklin_Templeton_DAL.Constants.FieldInputs;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class DalRBACustomFields : Form
    {
        public DALFieldParameters fieldParameters { get; set; }
        private System.Data.DataTable dtReturnValues = new System.Data.DataTable();
        private string fieldName;
        private bool isUpdate { get; set; }

        public DalRBACustomFields(string _fieldName, DALFieldParameters parameters)
        {
            InitializeComponent();
            fieldName = _fieldName;
            fieldParameters = parameters;            
            lbl_auth_status.Text = DalSettings.statusMessage;
            InitializeFormElements();
        }
        private void InitializeFormElements()
        {
            CachedData.SetFormTheme(this);

            try
            {
                cbReturnWindow.DataSource = RbaReturnWindow.InputValues;
                #region Operation for Benchmark Entity
                dtReturnValues.Columns.Add("FieldType");
                dtReturnValues.Columns.Add("FieldName");
                dtReturnValues.Columns.Add("FieldValue");
                //ReadParameters(rbBenchmark.Text.Replace("&", ""), fieldParameters.benchmark_entities);
                //ReadParameters(rbFactorEntity.Text.Replace("&", ""), fieldParameters.factor_entities);
                //ReadParameters(rbBenchmarkFactor.Text.Replace("&", ""), fieldParameters.benchmark_factor_entities);
                //ReadParameters(rbBetaProfile.Text.Replace("&", ""), fieldParameters.beta_profile_entities);
               //if(fieldParameters.data_available_threshold!= null)
               // {
               //     txtDataThreshold.Text = fieldParameters.data_available_threshold.ToString();
               // }
               // if (fieldParameters.returnWindowsUnit !=null && fieldParameters.returnWindowsUnit.Unit!= null
               //     && !string.IsNullOrEmpty(fieldParameters.returnWindowsUnit.Unit))
               // {
               //     cbReturnWindow.SelectedItem = fieldParameters.returnWindowsUnit.Unit;
               // }
                dgvRBAFields.Columns[0].DataPropertyName = "FieldName";
                dgvRBAFields.Columns[1].DataPropertyName = "FieldValue";
                dgvRBAFields.Columns[2].DataPropertyName = "FieldType";
                dgvRBAFields.AutoGenerateColumns = false;
                dgvRBAFields.DataSource = dtReturnValues;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while initializing form");
            }
        }

        #region Save RBA Field
        private void SaveParameters(object sender, EventArgs e)
        {
            try
            {
                fieldParameters = null;
                if (dtReturnValues.Rows.Count > 0)
                {
                    fieldParameters = new DALFieldParameters();
                    //fieldParameters.benchmark_entities = WriteParamas(rbBenchmark.Text.Replace("&", ""));
                    //fieldParameters.factor_entities = WriteParamas(rbFactorEntity.Text.Replace("&", ""));
                    //fieldParameters.benchmark_factor_entities = WriteParamas(rbBenchmarkFactor.Text.Replace("&", ""));
                    //fieldParameters.beta_profile_entities = WriteParamas(rbBetaProfile.Text.Replace("&", ""));
                }
                // below lines were commented by Apurva as return based analytics is changed to key value pairs
                //fieldParameters.data_available_threshold = null;
                //if (!string.IsNullOrEmpty(txtDataThreshold.Text))
                //    fieldParameters.data_available_threshold = Convert.ToDouble(txtDataThreshold.Text);
                if (!string.IsNullOrEmpty(cbReturnWindow.SelectedItem.ToString()))
                {
                    //fieldParameters.returnWindowsUnit = new ReturnWindow { Unit = cbReturnWindow.SelectedItem.ToString() };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
        #endregion

        #region Cancel Event
        private void CancelRBAField(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
            this.Close();
        }
        #endregion

        #region Add Key Values           
        private void btnAddReturnEntity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReturnIdName.Text) || string.IsNullOrEmpty(txtReturnIdVal.Text))
            {
                MessageBox.Show("Name, Value and type are mandatory");
                return;
            }
            DataRow dr = dtReturnValues.NewRow();
            if (rbBenchmark.Checked)
            {
                dr["FieldType"] = rbBenchmark.Text.Replace("&", "");
            }
            if (rbFactorEntity.Checked)
            {
                dr["FieldType"] = rbFactorEntity.Text.Replace("&", "");
            }
            if (rbBenchmarkFactor.Checked)
            {
                dr["FieldType"] = rbBenchmarkFactor.Text.Replace("&", "");
            }
            if (rbBetaProfile.Checked)
            {
                dr["FieldType"] = rbBetaProfile.Text.Replace("&", "");
            }
            dr["FieldName"] = txtReturnIdName.Text;
            dr["FieldValue"] = txtReturnIdVal.Text;
            dtReturnValues.Rows.Add(dr);

            txtReturnIdName.Text = string.Empty;
            txtReturnIdVal.Text = string.Empty;
        }

        private void dgvRBAFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRBAFields.Columns[e.ColumnIndex].Name == "dgDel")
            {
                string strIdToDel = dtReturnValues.Rows[e.RowIndex][0].ToString();
                if (UiHelper.GetDeleteConformation(strIdToDel))
                {
                    dtReturnValues.Rows[e.RowIndex].Delete();
                }
            }
        }
        #endregion

        #region Read and Write Paramas
        private void ReadParameters(string fieldtype, List<object> Items)
        {
            if (Items != null)
            {
                foreach (var lst in Items)
                {
                    foreach (var dir in Items)
                    {
                        foreach (var Entry in (Dictionary<string, object>)dir)
                        {
                            var dr = dtReturnValues.NewRow();
                            dr[0] = fieldtype;
                            dr[1] = Entry.Key;
                            dr[2] = JsonConvert.SerializeObject(Entry.Value);
                            dtReturnValues.Rows.Add(dr);

                        }
                    }
                }
            }
        }

        private List<object> WriteParamas(string fieldtype)
        {
            List<object> returnValues = null;

            var DataRows = dtReturnValues.Select("FieldType ='" + fieldtype + "'");
            if (DataRows.Count() > 0)
            {
                var lst = new Dictionary<string, object>();
                returnValues = new List<object>();
                foreach (var dr in dtReturnValues.Select("FieldType ='" + fieldtype + "'"))
                {
                    Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                    keyValuePairs.Add(dr[1].ToString(), JsonConvert.DeserializeObject<Object>(dr[2].ToString()));
                    object obj = JsonConvert.SerializeObject(keyValuePairs);
                    returnValues.Add(obj);
                }
            }
            return returnValues;

        }

        private void DalRBACustomFields_Load(object sender, EventArgs e)
        {

        }
    }
    #endregion

}
