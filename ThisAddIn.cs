using System;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Helpers;
using System.Threading;

namespace Franklin_Templeton_DAL
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, EventArgs e)
        {
            var thread = new Thread(() => new MasterDataHelper().UpdateMasterData());
            thread.Start();
           
        }

        private void ThisAddIn_Shutdown(object sender, EventArgs e)
        {
            // Saving data from DalSettings class into Application settings
            var encryptionHelper = new EncryptionHelper();
            Properties.Settings.Default.username = encryptionHelper.Encrypt(DalSettings.username);
            Properties.Settings.Default.password = encryptionHelper.Encrypt(DalSettings.password);
            Properties.Settings.Default.apiUrl = DalSettings.SelectedApiUrl;

            Properties.Settings.Default.Save();
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
