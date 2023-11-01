namespace Franklin_Templeton_DAL.Constants
{
    /// <summary>
    /// This class contains Settings that will persist an Application shutdown
    /// </summary>
    internal static class DalSettings
    {
        /// <summary>
        /// Access token for Okta
        /// </summary>
        public static string accessToken { get; set; }        

        /// <summary>
        /// Username for Okta access. Usually email id of franklintempleton
        /// </summary>
        public static string username { get; set; }

        /// <summary>
        /// Password for Okta access. Usually same as the login password for FT Laptop
        /// </summary>
        public static string password { get; set; }

        /// <summary>
        /// API url for the selected environment
        /// </summary>
        public static string SelectedApiUrl { get; set; }
        public static string statusMessage { get; set; } = "Not authenticated";
        public static ApiUrls.DalEnvironment dalEnvironment { get; set; }
    }
    
}
