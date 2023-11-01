using Franklin_Templeton_DAL.Models;
using System;
using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models.InputModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Microsoft.Office.Interop.Excel;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class DalSearchEntity : Form
    {
        public string strSelectedEntity;
        public string strSelectedValue;
        private List<EntityMaster.Entity> entityMaster { get; set; }
        private string EntityDesc;
        public System.Data.DataTable dtSearchEntity = new System.Data.DataTable();
        private bool isUpdate { get; set; }

        #region InitializeComponent
        public DalSearchEntity(string searchentityName)
        {
            InitializeComponent();
            EntityDesc = searchentityName;
            InitializeFormElements();
            PopulateSearchEntity();
            CachedData.SetFormTheme(this);
            lbl_auth_status.Text = DalSettings.statusMessage;
        }           

        private void InitializeFormElements()
        {
            dtSearchEntity.Columns.Add("IsSelect", typeof(bool));
            dtSearchEntity.Columns.Add("EntityName");
            dtSearchEntity.Columns.Add("EntityDesc");
            dgvSearchEntity.Columns[0].DataPropertyName = "IsSelect";
            dgvSearchEntity.Columns[1].DataPropertyName = "EntityName";
            dgvSearchEntity.Columns[2].DataPropertyName = "EntityDesc";
            dgvSearchEntity.AutoGenerateColumns = false;
            dgvSearchEntity.DataSource = dtSearchEntity;
        }
        #endregion
        
        #region Entity Search 
        private void PopulateSearchEntity()
        {
            try
            {
                //Application.UseWaitCursor = true;
                this.Cursor = Cursors.WaitCursor;
                if (EntityDesc.Length < 3)
                {
                    MessageBox.Show("Minimun 3 character required");
                    return;
                }
                var apiHelper = new ApiHelper();
                var apiResponse = apiHelper.GetEntityMasterData(EntityDesc);
                if (apiResponse != null && apiResponse.entities != null)
                {
                    entityMaster = apiResponse.entities;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Button Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        #endregion

        #region SearchEntity    
        private void btnSelectEntity_Click(object sender, EventArgs e)
        {
           this.DialogResult= DialogResult.OK;
           this.Close();
        }
        #endregion
    }
}
