using Franklin_Templeton_DAL.Helpers;
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
    public partial class DalInputRBACustomEntities : Form
    {
        public DalInputRBACustomEntities()
        {
            InitializeComponent();
        }
        #region Cancel Event
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
        #endregion
        #region Add Custom Entity
        private void btnAddEntity_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Add Custom Entity
        private void btnAddCustomEntity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReturnIdName.Text) || string.IsNullOrEmpty(txtReturnIdVal.Text))
            {
                MessageBox.Show("Name, Value and type are mandatory");
                return;
            }
            dgvRBAEntity.Rows.Add(txtReturnIdName.Text, txtReturnIdVal.Text);
            txtReturnIdName.Text = string.Empty;
            txtReturnIdVal.Text = string.Empty;
        }

        private void dgvRBAEntity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvRBAEntity.Columns[e.ColumnIndex].Name == "dgidDel")
            {
                if (UiHelper.GetDeleteConformation("Entity"))
                {
                    int rowindex = dgvRBAEntity.CurrentCell.RowIndex;
                    dgvRBAEntity.Rows.RemoveAt(rowindex);
                }
            }
        }
        #endregion
    }
}
