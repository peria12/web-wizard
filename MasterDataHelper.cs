using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Models;

namespace Franklin_Templeton_DAL.Helpers
{
    internal sealed class MasterDataHelper
    {
        public MasterDataHelper()
        {

        }

        /// <summary>
        /// Updates DalSettings, access token and cached data
        /// </summary>
        public void UpdateMasterData()
        {
            try
            {
                DalSettings.dalEnvironment = (ApiUrls.DalEnvironment)Properties.Settings.Default.SelectedEnvironment;

            }
            catch (Exception)
            {
                MessageBox.Show("Error occured while loading data from FT DAL");
            }
        }
       
    }
}
