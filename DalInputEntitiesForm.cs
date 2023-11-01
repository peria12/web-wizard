using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Models.InputModels;
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
    public partial class DalInputEntitiesForm : Form
    {
        private List<EntityMaster.Entity> entityMaster { get; set; }
        private System.Data.DataTable dtEntityValues = new System.Data.DataTable();
        public System.Data.DataTable dtSearchEntity = new System.Data.DataTable();

        public DalInputEntitiesForm()
        {
            InitializeComponent();
            txtSearchEntity.Focus();
            idDate.MaxDate = DateTime.Now;
            idDateKeyValue.MaxDate = DateTime.Now;
            idDate.Value = DateTime.Now.AddDays(-1);
            idDateKeyValue.Value = DateTime.Now.AddDays(-1);
            lbl_auth_status.Text = DalSettings.statusMessage;
            lbl_auth_status.ForeColor = Color.ForestGreen;
            this.ActiveControl = txtSearchEntity;
            EntityIdTypePopulate();
            InitializeFormElements();
        }
        private void InitializeFormElements()
        {
            try
            {
                CachedData.SetFormTheme(this);

                dtEntityValues.Columns.Add("EntityName",typeof(object));
                dtEntityValues.Columns.Add("EntityValue");
                dgvEntities.Columns[0].DataPropertyName = "EntityName";
                dgvEntities.Columns[1].DataPropertyName = "EntityValue";
                if (CachedData.InputRequest.Entities != null)
                {
                    ReadParameters(CachedData.InputRequest.Entities);
                }
                dgvEntities.AutoGenerateColumns = false;
                dgvEntities.DataSource = dtEntityValues;
                if (!string.IsNullOrEmpty(CachedData.InputRequest.Id_Date))
                {
                    idDate.Value = DateTime.Parse(CachedData.InputRequest.Id_Date);
                    idDate.Checked = true;
                    idDateKeyValue.Value = DateTime.Parse(CachedData.InputRequest.Id_Date);
                    idDateKeyValue.Checked = true;
                }
                if (!string.IsNullOrEmpty(CachedData.InputRequest.Id_Type))
                {
                    txtIdType.Text = CachedData.InputRequest.Id_Type;
                }
                //txtEnityInput.AutoCompleteCustomSource = new AutoCompleteStringCollection();

                dtSearchEntity.Columns.Add("EntityName");
                dtSearchEntity.Columns.Add("EntityDesc");
                dgvSearchEntity.Columns[0].DataPropertyName = "EntityName";
                dgvSearchEntity.Columns[1].DataPropertyName = "EntityDesc";
                dgvSearchEntity.AutoGenerateColumns = false;
                dgvSearchEntity.DataSource = dtSearchEntity;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while initializing form");
            }
        }

        #region Read and Write Paramas
        private void ReadParameters(List<object> Items)
        {
            if (Items != null)
            {
                foreach (var lst in Items)
                {
                    if (lst is string)
                    {
                        var dr = dtEntityValues.NewRow();
                        dr["EntityName"] = lst.ToString();
                        dr["EntityValue"] = null;
                        dtEntityValues.Rows.Add(dr);
                    }
                    else if (lst is int || lst is long || lst is double)
                    {
                        var dr = dtEntityValues.NewRow();
                        dr["EntityName"] = lst;
                        dr["EntityValue"] = null;
                        dtEntityValues.Rows.Add(dr);
                    }
                    else
                    {
                        var dir = (Dictionary<string, object>)lst;
                        var dr = dtEntityValues.NewRow();
                        foreach (var dirItem in dir)
                        {
                            dr = dtEntityValues.NewRow();
                            dr["EntityName"] = dirItem.Key;
                            dr["Entityvalue"] = JsonConvert.SerializeObject(dirItem.Value);
                            dtEntityValues.Rows.Add(dr);
                        }
                    }
                }
            }
        }
        private void WriteParamas()
        {
            List<object> returnValues = null;

            CachedData.InputRequest.Id_Date = null;
            CachedData.InputRequest.Id_Type = null;
            if (idDate.Checked)
            {
                CachedData.InputRequest.Id_Date = idDate.Value.ToString("yyyy-MM-dd");
            }
            else if (idDateKeyValue.Checked)
            {
                CachedData.InputRequest.Id_Date = idDateKeyValue.Value.ToString("yyyy-MM-dd");
            }
            if (!string.IsNullOrEmpty(txtIdType.Text))
            {
                CachedData.InputRequest.Id_Type = txtIdType.Text.ToString();
            }
            var DataRows = dtEntityValues.Select();
            var stringTypeName = string.Empty;
            if (CachedData.InputRequest.Id_Type != null)
            {
                CachedData.EntityTypesWithValue.TryGetValue(CachedData.InputRequest.Id_Type, out stringTypeName);
            }
            if (dtEntityValues.Rows.Count > 0)
            {
                var lst = new Dictionary<string, object>();
                returnValues = new List<object>();
                foreach (var dr in dtEntityValues.Select())
                {
                    if (string.IsNullOrEmpty(dr["EntityValue"].ToString()))
                    {
                        if (string.IsNullOrEmpty(stringTypeName) == false && stringTypeName.ToLower().Contains("string"))
                        {
                            returnValues.Add(dr["EntityName"].ToString());
                        }
                        else
                        {
                            returnValues.Add(dr["EntityName"]);

                        }
                    }
                    else
                    {
                        Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
                        JsonSerializerSettings settings = new JsonSerializerSettings();
                        settings.NullValueHandling = NullValueHandling.Ignore;
                        settings.Converters.Add(new DALDictonaryJsonConverter());
                        var key = dr["EntityName"].ToString();
                        dynamic value;
                        try
                        {
                            value = JsonConvert.DeserializeObject<Dictionary<string, object>>(dr["EntityValue"].ToString(), settings);
                        }
                        catch
                        {
                            value = dr["EntityValue"].ToString().Replace("\"", "");
                        }

                        keyValuePairs.Add(key, value);
                        object obj = JsonConvert.SerializeObject(keyValuePairs);
                        returnValues.Add(keyValuePairs);
                    }
                }
            }
            CachedData.InputRequest.Entities = returnValues;

        }
        #endregion

        #region Button Event
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            this.Dispose();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            WriteParamas();
            this.Close();
            this.Dispose();
            var dateForm = new DalDateInputForm();
            dateForm.Show();

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            WriteParamas();
            this.Close();
            var form = new DalInputFieldsForm();
            form.ShowDialog();
        }
        #endregion

        #region  Fill IdType Value
        private void EntityIdTypePopulate()
        {
            try
            {
                Application.UseWaitCursor = true;
                this.Cursor = Cursors.WaitCursor;
                //var apiHelper = new ApiHelper();
                //var apiResponse = apiHelper.GetEntityMasterData(txtIdType.Text);
                //if (apiResponse != null && apiResponse.entities != null)
                //{
                //    entityMaster = apiResponse.entities;
                //}
                var idTypeAutoComplete = new AutoCompleteStringCollection();
                if (CachedData.EntityTypes != null)
                {
                    idTypeAutoComplete.AddRange(CachedData.EntityTypes.ToArray());
                }
                txtIdType.AutoCompleteCustomSource = idTypeAutoComplete;

                if (CachedData.EntityTypes != null)
                {
                    idTypeAutoComplete.AddRange(CachedData.EntityTypes.ToArray());
                }
                txtKey.AutoCompleteCustomSource = idTypeAutoComplete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.UseWaitCursor = false;
                this.Cursor = Cursors.Default;
            }
        }
        private void PopulateSearchEntity()
        {
            try
            {
                //Application.UseWaitCursor = true;
                this.Cursor = Cursors.WaitCursor;
                if (txtSearchEntity.Text.Length < 3)
                {
                    if (dtSearchEntity.Rows.Count > 0)
                    {
                        dtSearchEntity.Rows.Clear();
                        dgvSearchEntity.Refresh();
                    }
                    //MessageBox.Show("Minimun 3 character required");
                    return;
                }
                var apiHelper = new ApiHelper();
                var apiResponse = apiHelper.GetEntityMasterData(txtSearchEntity.Text, 15);
                if (apiResponse != null && apiResponse.entities != null)
                {
                    entityMaster = apiResponse.entities;
                    dtSearchEntity.Clear();

                    entitySearchPopulate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void entitySearchPopulate()
        {
            try
            {
                foreach (var entity in entityMaster)
                {
                    var id = entity.entity_id.Substring(0, entity.entity_id.Length - 2);
                    DataRow dr = dtSearchEntity.NewRow();
                    dr["EntityName"] = id;
                    dr["EntityDesc"] = entity.entity_name;
                    dtSearchEntity.Rows.Add(dr);
                }
                dgvSearchEntity.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Select Entity From Excel
        private void btnSelectExcel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var cellValues = UiHelper.GetCellRange("Select cells containing entites");
                if (cellValues != null)
                {
                    foreach (var cellValue in cellValues)
                    {
                        var dr = dtEntityValues.NewRow();
                        dr["EntityName"] = cellValue.ToString();
                        dr["EntityValue"] = null;
                        dtEntityValues.Rows.Add(dr);
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

        #region Cell Row
        private void dgvEntities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEntities.Columns[e.ColumnIndex].Name == "dgDel")
            {
                string strIdToDel = dtEntityValues.Rows[e.RowIndex][0].ToString();
                if (UiHelper.GetDeleteConformation(strIdToDel))
                {
                    dtEntityValues.Rows[e.RowIndex].Delete();
                }
            }
        }

        #endregion
        #region Add Antity

        public void AddEntity(string strValue)
        {
            DataRow dr = dtEntityValues.NewRow();
            dr["EntityName"] = strValue;
            dr["EntityValue"] = null;
            dtEntityValues.Rows.Add(dr);
            //txtEnityInput.Text = string.Empty;

        }
        private void btnAddEntity_Click(object sender, EventArgs e)
        {
            //if (txtEnityInput.Text != string.Empty)
            //{
            //    DataRow dr = dtEntityValues.NewRow();
            //    dr["EntityName"] = txtEnityInput.Text;
            //    dr["EntityValue"] = null;
            //    dtEntityValues.Rows.Add(dr);
            //    txtEnityInput.Text = string.Empty;
            //}
        }
        #endregion

        private void DalInputEntitiesForm_Shown(object sender, EventArgs e)
        {
            if (!this.Focused)
            {
                this.Focus();
            }
        }

        private void btnKeyValue_Click(object sender, EventArgs e)
        {
            if (txtKey.Text != string.Empty && txtCustomInput.Text != string.Empty)
            {
                DataRow dr = dtEntityValues.NewRow();
                dr["EntityName"] = txtKey.Text;
                dr["EntityValue"] = txtCustomInput.Text;
                dtEntityValues.Rows.Add(dr);
                txtCustomInput.Text = string.Empty;
                txtKey.Text = string.Empty;
            }

        }

        private void idDateKeyValue_ValueChanged(object sender, EventArgs e)
        {
            idDate.Checked = idDateKeyValue.Checked;
            idDate.Value = idDateKeyValue.Value;
        }

        private void idDate_ValueChanged(object sender, EventArgs e)
        {
            idDateKeyValue.Checked = idDate.Checked;
            idDateKeyValue.Value = idDate.Value;
        }

        private void txtEnityInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchEntity_TextChanged(object sender, EventArgs e)
        {
            PopulateSearchEntity();
        }

        private void dgvSearchEntity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchEntity.Rows[e.RowIndex].Cells[0].Value != null)
            {
                AddEntity(dgvSearchEntity.Rows[e.RowIndex].Cells[0].Value.ToString());
            }

        }
    }
}
