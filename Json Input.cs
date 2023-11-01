using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Models.InputModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.InputForms
{
    public partial class Json_Input : Form
    {
        public Json_Input(DalInputRequest dalRequest = null)
        {
            InitializeComponent();
            this.lblFetching.Visible = false;

            if (string.IsNullOrEmpty(DalSettings.accessToken))
            {
                lbl_auth_status.Text = "Not authenticated";
                lbl_auth_status.ForeColor = Color.DarkRed;
            }
            else
            {
               if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Production)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "Production Environment";                    
                }
                if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Development)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "Development Environment";                  
                }
                if(DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Uat)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "UAT Environment";
                }
                if(DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Test)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "Test Environment";
                }
            }
            DalSettings.statusMessage = lbl_auth_status.Text;
            if (dalRequest != null)
            {
                txt_jsonInput.Text = JsonConvert.SerializeObject(dalRequest, Formatting.Indented);              
            }
            CachedData.SetFormTheme(this);
        }
        private void GenerateExcel(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
                this.lblFetching.Visible = true;
                if (!CachedData.GenerateExcel(txt_jsonInput.Text))
                {
                    lbl_json_invalid.Show();
                    return;
                }
                DalInputRequest inputRequest = JsonConvert.DeserializeObject<DalInputRequest>(txt_jsonInput.Text);
                CachedData.InputRequest = inputRequest;
                this.lblFetching.Visible = false;
                System.Windows.Forms.Cursor.Current = Cursors.Default;
                this.Close();
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

        private void SwitchToInputForm(object sender, EventArgs e)
        {
            if (!CachedData.isJsonValid(txt_jsonInput.Text))
            {
                lbl_json_invalid.Show();
                return;
            }
            DalInputRequest inputRequest = JsonConvert.DeserializeObject<DalInputRequest>(txt_jsonInput.Text);
            CachedData.InputRequest = inputRequest;
            this.Hide();
            this.Close();
            DalInputFieldsForm form = new DalInputFieldsForm();
            form.ShowDialog();

            //FTRibbon ft = new FTRibbon();
            //ft.DisplayInputForm();
            ////new DALEntryForm(fieldInputs, entityInputs).Show();
            ////this.Dispose();
            //this.Hide();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.CheckFileExists = true;
            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string strFileString = File.ReadAllText(fileDialog.FileName);
                if (CachedData.isJsonValid(strFileString))
                {
                    CachedData.InputRequest = JsonConvert.DeserializeObject<DalInputRequest>(strFileString);
                    txt_jsonInput.Text = JsonConvert.SerializeObject(CachedData.InputRequest, Formatting.Indented);
                }
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (CachedData.isJsonValid(txt_jsonInput.Text))
            {
                SaveFileDialog fileDialog = new SaveFileDialog();
                fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                fileDialog.CheckPathExists = true;
                if (fileDialog.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        CachedData.InputRequest = JsonConvert.DeserializeObject<DalInputRequest>(txt_jsonInput.Text);
                        txt_jsonInput.Text = JsonConvert.SerializeObject(CachedData.InputRequest, Formatting.Indented);
                        File.WriteAllText(fileDialog.FileName, txt_jsonInput.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid Json");
                    }
                }


            }
        }

        private void btnClearInput(object sender, EventArgs e)
        {
            CachedData.InputRequest = new DalInputRequest();
            txt_jsonInput.Text = JsonConvert.SerializeObject(CachedData.InputRequest, Formatting.Indented);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
