using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;

namespace Franklin_Templeton_DAL
{
    public partial class SettingPopup : Form
    {
        #region Initialize Popup

        public SettingPopup()
        {
            InitializeComponent();           
            PopulateInputs();
        }

        private void PopulateInputs()
        {         
            switch (DalSettings.dalEnvironment)
            {
                case ApiUrls.DalEnvironment.Production:
                    rBtn_api_prod.Checked = true;
                    break;
                case ApiUrls.DalEnvironment.Development:
                    rBtn_api_dev.Checked = true;
                    break;
                case ApiUrls.DalEnvironment.Uat:
                    rBtn_api_uat.Checked = true;
                    break;
                case ApiUrls.DalEnvironment.Test:
                    rBtn_api_test.Checked = true;
                    break;
                default:
                    rBtn_api_prod.Checked = true;
                    break;
            }
            rBtn_api_prod.ForeColor = Properties.Settings.Default.EnvironLabelColorProduction;
            rBtn_api_dev.ForeColor = Properties.Settings.Default.EnvironLabelColorDevelopment;
            rBtn_api_uat.ForeColor = Properties.Settings.Default.EnvironLabelColorUat;
            rBtn_api_test.ForeColor = Properties.Settings.Default.EnvironLabelColorTest;
        }

        #endregion

        private void SaveSettings(object sender, EventArgs e)
        {
            try
            {
                SetApiUrl();
                Properties.Settings.Default.SelectedEnvironment = ((int)DalSettings.dalEnvironment);
                Properties.Settings.Default.Save();
                new MasterDataHelper().UpdateMasterData();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SetApiUrl()
        {
            if (rBtn_api_dev.Checked)
            {
                DalSettings.dalEnvironment = ApiUrls.DalEnvironment.Development;
            }
            else if (rBtn_api_test.Checked)
            {
                DalSettings.dalEnvironment = ApiUrls.DalEnvironment.Test;
            }
            else if (rBtn_api_uat.Checked)
            {
                DalSettings.dalEnvironment = ApiUrls.DalEnvironment.Uat;
            }
            else
            {
                DalSettings.dalEnvironment = ApiUrls.DalEnvironment.Production;
            }
            return;
        }       
    }
}
