using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Models.InputModels;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class ListFields : Form
    {
        public string strSelectedField;
        public ListFields()
        {
            InitializeComponent();
            CachedData.SetFormTheme(this);
            lbl_auth_status.Text = DalSettings.statusMessage;
        }
        #region Form Load
        private void ListFields_Load(object sender, EventArgs e)
        {
            try
            {
                // Initialize Field autocomplete               
                if (CachedData.FieldNames != null)
                {
                    foreach (string strFieldName in CachedData.FieldNames)
                    {
                        dgvFields.Rows.Add(strFieldName);
                    }
                //    foreach (var strFiel in CachedData.FieldData)
                //    {
                //        dgvFields.Rows.Add(strFiel);
                //    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        private void dgvFields_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            dgvFields.Sort(dgvFields.Columns[1], ListSortDirection.Ascending);
        }

        private void dgvFields_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvFields.Rows[e.RowIndex];
            strSelectedField = row.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSearchField(object sender, EventArgs e)
        {
            if (txtFields.Text.Length < 3)
            {
                MessageBox.Show("Minimun 3 character required");
                return;
            }
            DataGridViewRow row = dgvFields.Rows
         .Cast<DataGridViewRow>()
        .Where(r => r.Cells[0].Value.ToString().StartsWith(txtFields.Text))
        .First();
            if (row != null)
            {               
                row.Selected= true;
                dgvFields.FirstDisplayedScrollingRowIndex= row.Index;
                dgvFields.Focus();
                txtFields.Text = string.Empty;
            }
        }
    }
}
