using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models.InputModels;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Franklin_Templeton_DAL.Constants.FieldInputs;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class DalInputParameters : Form
    {
        public DALFieldParameters fieldParameters { get; set; }
        private System.Data.DataTable dtSubFields = new System.Data.DataTable();
        private System.Data.DataTable dtIds = new System.Data.DataTable();
        private System.Data.DataTable dtDataItemIds = new System.Data.DataTable();
        private string fieldName;
        Dictionary<string, object> subFieldkeyValuePairs = new Dictionary<string, object>();
        List<DALFields> listDalFields = new List<DALFields>();
        public DalInputParameters(string _fieldName, DALFieldParameters parameters)
        {
            InitializeComponent();
            fieldName = _fieldName;
            fieldParameters = parameters;
            txtIdType.Focus();
            lbl_auth_status.Text = DalSettings.statusMessage;
            InitializeFormElements();
        }
        private void InitializeFormElements()
        {
            CachedData.SetFormTheme(this);
            dgvDateItem.BackgroundColor = Properties.Settings.Default.GridBgColor;
            dgvDateItem.ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.GridHeaderColor;
            dgvDateItem.RowsDefaultCellStyle.ForeColor = Properties.Settings.Default.DefaultFontColor;
            dgvDateItem.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.GridAlternateColor;
            dgvDateItem.RowsDefaultCellStyle.BackColor = Properties.Settings.Default.GridRowColor;
            dgvFilterIds.BackgroundColor = Properties.Settings.Default.GridBgColor;
            dgvFilterIds.ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.GridHeaderColor;
            dgvFilterIds.RowsDefaultCellStyle.ForeColor = Properties.Settings.Default.DefaultFontColor;
            dgvFilterIds.AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.GridAlternateColor;
            dgvFilterIds.RowsDefaultCellStyle.BackColor = Properties.Settings.Default.GridRowColor;
            try
            {
                #region Operations for Sub Fields

                dtSubFields.Columns.Add("Sub Field");
                dtDataItemIds.Columns.Add("Sub Field");
                dtDataItemIds.Columns.Add("FieldValue");
                if (fieldParameters.Sub_Fields != null && fieldParameters.Sub_Fields.Count > 0)
                {
                    foreach (object value in fieldParameters.Sub_Fields)
                    {
                        if (value is string)
                        {
                            dtSubFields.Rows.Add(value);
                        }
                        else if (value is DALFields)
                        {
                            listDalFields.Add((DALFields)value);
                        }
                        else
                        {
                            var dir = (Dictionary<string, object>)value;

                            var dr = dtDataItemIds.NewRow();
                            foreach (var dirItem in dir)
                            {
                                var dir1 = JsonConvert.SerializeObject(dirItem.Value);
                                var dir2 = JsonConvert.DeserializeObject<DALFieldParameters>(dir1);
                                DALFields dALFields = new DALFields()
                                {
                                    FieldName = dirItem.Key,
                                    fieldParameters = (DALFieldParameters)dirItem.Value
                                };
                                listDalFields.Add(dALFields);
                                //dr = dtDataItemIds.NewRow();
                                //dr["Sub Field"] = dirItem.Key;
                                //dr["FieldValue"] = JsonConvert.SerializeObject(dirItem.Value);
                                //dtDataItemIds.Rows.Add(dr);
                            }
                        }
                    }
                }
                var keyValuePairs = fieldParameters.GetAdditionalData();
                if (keyValuePairs.Count > 0)
                {
                    var dr = dtDataItemIds.NewRow();
                    foreach (var dirItem in keyValuePairs)
                    {
                        dr = dtDataItemIds.NewRow();
                        dr["Sub Field"] = dirItem.Key;
                        dr["FieldValue"] = JsonConvert.SerializeObject(dirItem.Value);
                        dtDataItemIds.Rows.Add(dr);
                    }

                }

                dgvSubFields.Columns[0].DataPropertyName = "Sub Field";
                dgvSubFields.AutoGenerateColumns = false;
                dgvSubFields.DataSource = dtSubFields;
                dgvDateItem.AutoGenerateColumns = false;
                dgvDateItem.Columns[0].DataPropertyName = "Sub Field";
                dgvDateItem.Columns[1].DataPropertyName = "FieldValue";
                dgvDateItem.DataSource = dtDataItemIds;

                #endregion

                #region Operations for Filter

                dtIds.Columns.Add("Id");
                if (fieldParameters.Filters != null)
                {
                    if (fieldParameters.Filters.ids != null && fieldParameters.Filters.ids.Count > 0)
                    {
                        foreach (string value in fieldParameters.Filters.ids)
                        {
                            dtIds.Rows.Add(value);
                        }
                    }
                    txtIdType.Text = fieldParameters.Filters.id_type;
                }
                dgvFilterIds.AutoGenerateColumns = false;
                dgvFilterIds.Columns[0].DataPropertyName = "Id";
                dgvFilterIds.DataSource = dtIds;

                #endregion

                #region Operation for Others                              

                lblParameterForm.Text = "Parameter For" + " " + fieldName;
                EnableDisableControls();
                #endregion

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while initializing form");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Add SubField
        private void btnAddSubField_Click(object sender, EventArgs e)
        {
            if (txtSubField.Text != string.Empty)
            {
                //DataRow[] tempDataRows = dtSubFields.Select("[Sub Field] = '" + txtSubFields.Text + "' ");
                if (dtSubFields.Select("[Sub Field] = '" + txtSubField.Text + "'").Count() <= 0)
                {
                    DataRow dr = dtSubFields.NewRow();
                    dr["Sub Field"] = txtSubField.Text;
                    dtSubFields.Rows.Add(dr);
                }
                else
                {
                    MessageBox.Show("<" + txtSubField.Text + "> is already added.");
                }
                txtSubField.Text = string.Empty;
            }
        }
        private void btnIds_Click(object sender, EventArgs e)
        {
            if (txtfilterIds.Text != string.Empty)
            {
                if (dtIds.Select("Id = '" + txtfilterIds.Text + "'").Count() <= 0)
                {
                    dtIds.Rows.Add(txtfilterIds.Text);
                }
                else
                {
                    MessageBox.Show("<" + txtfilterIds.Text + "> is already added.");
                }
                txtfilterIds.Text = string.Empty;
            }
        }
        #endregion
        #region Cell content Click
        private void dgvSubField_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubFields.Columns[e.ColumnIndex].Name == "dgDel")
            {
                string strSubFieldToDel = dtSubFields.Rows[e.RowIndex][0].ToString();
                if (UiHelper.GetDeleteConformation(strSubFieldToDel))
                {
                    dtSubFields.Rows[e.RowIndex].Delete();
                }
            }
        }
        private void dgvFilterIds_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFilterIds.Columns[e.ColumnIndex].Name == "dgDelIds")
            {
                string strIdToDel = dtIds.Rows[e.RowIndex][0].ToString();
                if (UiHelper.GetDeleteConformation(strIdToDel))
                {
                    dtIds.Rows[e.RowIndex].Delete();
                }
            }
        }
        #endregion
        #region Save Parameters
        private void btnSaveParams_Click(object sender, EventArgs e)
        {
            List<object> sub_fields = null;
            DALFilters filter = null;
            fieldParameters = null;
            Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
            if (dtSubFields.Rows.Count > 0)
            {
                //sub_fields = dtSubFields.AsEnumerable().Select(x => x[0].ToString()).ToList();
                var lst = new Dictionary<string, object>();
                sub_fields = new List<object>();
                foreach (var dr in dtSubFields.Select())
                {
                    sub_fields.Add(dr["Sub Field"].ToString());
                }
            }
            if (dtDataItemIds.Rows.Count > 0 )
            {
                foreach (var dr in dtDataItemIds.Select())
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.NullValueHandling = NullValueHandling.Ignore;
                    settings.Converters.Add(new DALDictonaryJsonConverter());
                    var key = dr["Sub Field"].ToString();
                    dynamic value;

                    try
                    {
                        //value = JsonConvert.DeserializeObject<Dictionary<string, object>>(dr["FieldValue"].ToString(), settings);
                        //value = dr["FieldValue"].ToString();//.Replace("\"", "");
                        value = JsonConvert.DeserializeObject(dr["FieldValue"].ToString());
                    }
                    catch
                    {
                        value = dr["FieldValue"].ToString().Replace("\"", "");
                    }
                    keyValuePairs.Add(key, value);
                }
            }
            if (listDalFields != null && listDalFields.Count > 0)
            {
                foreach (var dr in listDalFields)
                {
                    JsonSerializerSettings settings = new JsonSerializerSettings();
                    settings.NullValueHandling = NullValueHandling.Ignore;
                    settings.Converters.Add(new DALDictonaryJsonConverter());
                    Dictionary<string,object> keyValues= new Dictionary<string,object>();
                    keyValues.Add(dr.FieldName, dr.fieldParameters);
                    sub_fields.Add(keyValues);
                }
            }
            if (!string.IsNullOrEmpty(txtIdType.Text) || dtIds.Rows.Count > 0)
            {
                filter = new DALFilters();
                if (dtIds.Rows.Count > 0)
                {
                    filter.ids = dtIds.AsEnumerable().Select(x => x[0].ToString()).ToList();
                }
                filter.id_type = (!string.IsNullOrEmpty(txtIdType.Text) ? txtIdType.Text : null);
            }

            if (sub_fields != null || filter != null || keyValuePairs.Count > 0)
            {
                fieldParameters = new DALFieldParameters
                {
                    Sub_Fields = sub_fields,
                    Filters = filter
                };
                fieldParameters.setAdditionalData(keyValuePairs);

            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        private void dgvDateItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDateItem.Columns[e.ColumnIndex].Name == "dgDataidDel")
            {
                string strIdToDel = dtDataItemIds.Rows[e.RowIndex][0].ToString();
                if (UiHelper.GetDeleteConformation(strIdToDel))
                {
                    dtDataItemIds.Rows[e.RowIndex].Delete();
                }
            }
        }

        private void EnableDisableControls()
        {
            //txtKey.Enabled = chkKeyValuePair.Checked;
            //.Enabled = chkKeyValuePair.Checked;
        }

        private void btnKeyValue_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKey.Text) && !string.IsNullOrEmpty(txtValue.Text))
            {
                DataRow dr = dtDataItemIds.NewRow();
                dr["Sub Field"] = txtKey.Text;
                dr["FieldValue"] = txtValue.Text;
                dtDataItemIds.Rows.Add(dr);
                txtKey.Text = string.Empty;
                txtValue.Text = string.Empty;
            }
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            DalInputFieldsForm frmParam = new DalInputFieldsForm(listDalFields);
            frmParam.ShowDialog();
            if (frmParam.DialogResult == DialogResult.OK)
            {
                listDalFields = frmParam.CurrentFields;
            }
            frmParam.Dispose();

        }
    }

}
