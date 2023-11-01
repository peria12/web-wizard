using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace Franklin_Templeton_DAL.Helpers
{
    internal sealed class ApiHelper
    {
        private readonly HttpClient client;

        public ApiHelper()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + DalSettings.accessToken);
            client.BaseAddress = new Uri(DalSettings.SelectedApiUrl);
        }

        /// <summary>
        /// Returns data from DAL for the given JSON input
        /// </summary>
        /// <param name="inputJson">must be a valid JSON</param>
        /// <returns></returns>
        public DALResponse GetData(string inputJson)
        {
            try
            {
                var response = client.GetAsync("dal/get-data?req=" + inputJson).Result;
                response.EnsureSuccessStatusCode();
                var responseBody = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<DALResponse>(responseBody);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error getting data from DAL" + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Obtains list of entities using a search string
        /// </summary>
        /// <param name="searchString">Search text for entities</param>
        /// <param name="pagesize">no of entities to be returned</param>
        /// <returns></returns>
        public EntityMaster.ApiResponse GetEntityMasterData(string searchString, int pagesize = 30)
        {
            try
            {
                var response = client.GetAsync($"entity-master/entities?page_size={pagesize}&is_active=true&search_string={searchString}").Result;
                response.EnsureSuccessStatusCode();
                var responseBody = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<EntityMaster.ApiResponse>(responseBody);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting entity data" + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Fetches list of fields and entity types from the API
        /// </summary>
        /// <returns></returns>
        public FieldResponse GetFieldDataList()
        {
            try
            {
                var response = client.GetAsync("dal/fields").Result;
                response.EnsureSuccessStatusCode();
                var responseBody = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<FieldResponse>(responseBody);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch Field Data. Error - " + ex.Message);
                return null;
            }
        }
    }
}
