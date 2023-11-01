using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models.InputModels;
using Newtonsoft.Json;
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
using static Franklin_Templeton_DAL.Constants.DateInputEnums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class DalInputFieldsForm : Form
    {
        private BindingList<DALFields> lstFieldInput;
        private List<DALFields> passedDalField = null;
        public List<DALFields> CurrentFields
        {
            get
            {
                return passedDalField;
            }
            set
            {
                passedDalField = value;
            }
        }
        public DalInputFieldsForm(List<DALFields> paraDalField = null)
        {
            InitializeComponent();            
            lbl_auth_status.Text = DalSettings.statusMessage;
            if(paraDalField != null )
            {
                passedDalField=paraDalField;
            }
            InitializeDataSources();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgFields_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string strFieldName = lstFieldInput[e.RowIndex].FieldName;
            if (dgvFields.Columns[e.ColumnIndex].Name == "dgBtnParams")
            {
                Form frmParam;
                DALFieldParameters fieldParameters;
                if (lstFieldInput[e.RowIndex].fieldParameters == null)
                {
                    fieldParameters = new DALFieldParameters();
                }
                else
                {
                    fieldParameters = lstFieldInput[e.RowIndex].fieldParameters;
                }
                if (strFieldName == "return_based_analytics")
                {
                    //frmParam = new DalRBACustomFields(strFieldName, fieldParameters);
                    frmParam = new DalInputParameters(strFieldName, fieldParameters);
                }
                else
                {
                    frmParam = new DalInputParameters(strFieldName, fieldParameters);
                }
                frmParam.ShowDialog();
                if (frmParam.DialogResult == DialogResult.OK)
                {
                    if (frmParam is DalInputParameters)
                    {
                        lstFieldInput[e.RowIndex].fieldParameters = ((DalInputParameters)frmParam).fieldParameters;
                    }
                    if (frmParam is DalRBACustomFields)
                    {
                        lstFieldInput[e.RowIndex].fieldParameters = ((DalRBACustomFields)frmParam).fieldParameters;
                    }
                }
                frmParam.Dispose();
            }
            else if (dgvFields.Columns[e.ColumnIndex].Name == "dgDel")
            {
                if (UiHelper.GetDeleteConformation(strFieldName))
                {
                    lstFieldInput.RemoveAt(e.RowIndex);
                }
            }


        }
        #region Next Field Form
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (passedDalField == null)
            {
                CachedData.InputRequest.Fields = lstFieldInput.ToList();
                this.DialogResult = DialogResult.OK;
                this.Close();
                var EntityForm = new DalInputEntitiesForm();
                EntityForm.Show();
                EntityForm.Focus();
            }
            else
            {
                passedDalField = lstFieldInput.ToList();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnListFields_Click(object sender, EventArgs e)
        {
            var listFields = new ListFields();
            listFields.ShowDialog();
            if (listFields.DialogResult == DialogResult.OK)
            {
                AddField(listFields.strSelectedField);
            }
        }
        #endregion
        #region Field Auto Search

        private void InitializeDataSources()
        {
            CachedData.SetFormTheme(this);
            try
            {
                lstFieldInput = new BindingList<DALFields>();
                if(passedDalField != null)
                {
                    foreach (var fields in passedDalField)
                    {
                        lstFieldInput.Add(fields);
                    }
                }
                else if (CachedData.InputRequest.Fields != null)
                {
                    foreach (var fields in CachedData.InputRequest.Fields)
                    {
                        lstFieldInput.Add(fields);
                    }
                }
                // Initialize Field autocomplete
                var fieldAutoComplete = new AutoCompleteStringCollection();
                if (CachedData.FieldNames != null)
                {
                    fieldAutoComplete.AddRange(CachedData.FieldNames.ToArray());
                }
                //txtFields.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtFields.AutoCompleteCustomSource = fieldAutoComplete;
                dgvFields.AutoGenerateColumns = false;
                dgvFields.Columns[0].DataPropertyName = "FieldName";
                dgvFields.DataSource = lstFieldInput;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Add Field
        private void AddField(string strFieldName)
        {
            if (string.IsNullOrEmpty(strFieldName) == false)
            {
                if (lstFieldInput.Where(x => x.FieldName == strFieldName).FirstOrDefault() == null)
                {
                    lstFieldInput.Add(new DALFields { FieldName = strFieldName });
                    dgvFields.Refresh();
                }
                else
                {
                    MessageBox.Show("<" + strFieldName + "> Field is already added.");
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFields.Text != string.Empty)
            {
                AddField(txtFields.Text);
                txtFields.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please Enter Or Select Field Name");
            }
        }
       #endregion
    }
}
