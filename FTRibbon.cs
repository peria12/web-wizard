using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Franklin_Templeton_DAL.InputForms;
using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Models.InputModels;
using Newtonsoft.Json;
using Microsoft.Web.WebView2.WinForms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System;
using System.Threading.Tasks;

namespace Franklin_Templeton_DAL
{
    public partial class FTRibbon
    {
        private Form frm;
       

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
           
        }

        public void DisplayInputForm()
        {
            try
            {
              //  WebviewBrowser webview = new WebviewBrowser();
              // Parallel.Invoke(new Action(() => {

                   //WebviewBrowser webview = new WebviewBrowser();
                   //webview.Show();

                //CallWebWizard callWeb =new CallWebWizard(); 
                //callWeb.ShowDialog();

               // }));
                // CromiumBrowser browser1 =new CromiumBrowser();
                //  browser1.ShowDialog();
                // ElectronetBrowser browser = new ElectronetBrowser();
                // browser.ShowDialog();


                //ReactWeb customControl = new ReactWeb();
                //// Create a Form to host the UserControl 
                //Form form = new Form();

                //// Show the Form as a modal dialog
                //customControl.ShowDialog();


            }
            catch(Exception ex)
            {

            }


            //CallWebWizard form = new CallWebWizard();
            //WebviewFromReact form= new WebviewFromReact();
            //System.Windows.Forms.Cursor.Current = Cursors.Default;
            // form.ShowDialog();
            //form.Dispose();
            //return;

            //System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            //if (CachedData.InputRequest == null)
            //{
            //    CachedData.InputRequest = new Models.InputModels.DalInputRequest();
            //    string strreturn = "{\"dates\":[\"2012-09-29\",\"2022-09-29\"],\"date_info\":{\"type\":\"series\",\"freq\":{\"unit\":\"monthly\"}},\"fields\":[{\"return_based_analytics\":{\"benchmark_entities\":[{\"fs_bm_id\":\"STRGLNRXUSD\"}],\"factor_entities\":[{\"mstar_id\":\"F000013KFO\"},{\"mstar_id\":\"F00000276Y\"}],\"benchmark_factor_entities\":[{\"mstar_id\":\"F00000XSSX\"},{\"mstar_id\":\"F00000XSSX\"}],\"beta_profile_entities\":[{\"fs_bm_id\":\"105833GBP\"},{\"fs_bm_id\":\"105836USD\",\"_meta\":{\"return_type\":\"TOTAL\"}},{\"fs_bm_id\":\"105843USD\"},{\"fs_bm_id\":\"105844USD\"},{\"fs_bm_id\":\"105866USD\"},{\"fs_bm_id\":\"105869USD\"},{\"fs_bm_id\":\"105903USD\"},{\"fs_bm_id\":\"106038USD\"}],\"return_window\":{\"unit\":\"monthly\"},\"data_available_threshold\":0.44}}],\"entities\":[{\"_custom_\":{\"First Model\":[{\"weight\":20,\"mstar_id\":\"F0000175Y5\",\"_meta\":{\"return_type\":\"TOTAL\"}},{\"weight\":20,\"fs_bm_id\":\"STRGLNRXUSD\"},{\"weight\":20,\"mstar_id\":\"F00000SZHX\"},{\"weight\":20,\"fs_bm_id\":\"DJIAKUSD\",\"_meta\":{\"return_type\":\"NET\"}},{\"weight\":10,\"fs_bm_id\":\"JPM00004CADHEDGED\"},{\"weight\":10,\"mstar_id\":\"F000015PZ4\"}]}}]}";

            //    CachedData.InputRequest = JsonConvert.DeserializeObject<DalInputRequest>(strreturn);
            //}

            Json_Input form = new Json_Input(CachedData.InputRequest);
            System.Windows.Forms.Cursor.Current = Cursors.Default;
            form.ShowDialog();
            form.Dispose();
            return;

            if (frm == null || frm.IsDisposed)
            {
                //frm = new DALEntryForm();
            }

            if (!frm.Visible)
            {
                frm.Show();
            }
            else
            {
                frm.Focus();
            }
        }
        public void ShowInputForm(object sender, RibbonControlEventArgs e)
        {
         WebWizardForm webview = new WebWizardForm();
         webview.ShowDialog();
            //DisplayInputForm();
        }

        private void ShowAboutPopup(object sender, RibbonControlEventArgs e) => new AboutpopupForm().ShowDialog();

        private void ShowSettingsPopup(object sender, RibbonControlEventArgs e) => new SettingPopup().Show();
    }
}
