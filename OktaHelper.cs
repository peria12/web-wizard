using Franklin_Templeton_DAL.Constants;
using System;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.Helpers
{
    internal sealed class OktaHelper
    {        
        /// <summary>
        /// Fetches access token from okta and updated in <see cref="DalSettings"/>
        /// </summary>
        public void UpdateAccessToken()
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                var client = new HttpClient();
                client.DefaultRequestHeaders.Add("username", DalSettings.username);
                client.DefaultRequestHeaders.Add("password", DalSettings.password);
                var data = new StringContent(content: string.Empty);
                
                var response = client.PostAsync($"{DalSettings.SelectedApiUrl}auth/generate_token", data).Result;
                response.EnsureSuccessStatusCode();

                var responseBody = response.Content.ReadAsStringAsync().Result;
                var apiData = JsonConvert.DeserializeObject<ResponseData>(responseBody);
                if (apiData.info == "Access token generated")
                {
                    DalSettings.accessToken = apiData.access_token;
                }
                else
                {
                    //MessageBox.Show($"DAL Addin - Failed to get access token. {apiData.info}");
                    DalSettings.accessToken = null;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("DAL Addin - Failed to get access token. Error - " + ex.Message);
                DalSettings.accessToken = null;
            }

        }

        private sealed class ResponseData
        {
            public string access_token { get; set; }
            public string info { get; set; }
        }
    }
}
