namespace Franklin_Templeton_DAL.Constants
{
    /// <summary>
    /// Contains DAL API urls for differnet environments.
    /// </summary>
    public static class ApiUrls
    {
        public enum DalEnvironment
        {
            Production = 0,
            Development = 1,
            Uat = 2,
            Test = 3
        }
    }

    /// <summary>
    /// Commonly used prompt text across the UI
    /// </summary>
    public static class PromptText
    {
        public const string Edit = "Edit";
        public const string Delete = "Delete";
        public const string Cancel = "Cancel";
        public const string Select = "Select";
        public const string Update = "Update";
    }

    public static class EntityTypes
    {
        public const string Text = "Text";
        public const string Object = "Object";
        public const string CustomInput = "CustomInput";
    }

    /// <summary>
    /// Used for selecting dropdown values under DateInfo in DAL Input form
    /// </summary>
    public static class DateInputEnums
    {
        public static class Frequency
        {
            public const string NoSelection = "";
            public const string Daily = "daily";
            public const string Weekly = "weekly";
            public const string Monthly = "monthly";
            public const string Quarterly = "quarterly";
            public const string Yearly = "yearly";
            public static readonly string[] InputValues = new[] { NoSelection, Daily, Weekly, Monthly, Quarterly, Yearly };
        }

        public static class FillMissing
        {
            public const string NoSelection = "";
            public const string No = "no";
            public const string Last = "last";
            public static readonly string[] InputValues = new[] { NoSelection, No, Last };
        }

        public static class DateInfoType
        {
            public const string NoSelection = "";
            public const string Range = "Range";
            public const string Series = "Series";
            public const string Snapshots = "Snapshots";
            public static readonly string[] InputValues = new[] { NoSelection, Snapshots, Range, Series };
        }

        public static class AlignItems
        {
            public const string NoSelection = "";
            public const string Start = "start";
            public const string End = "end";
            public static readonly string[] InputValues = new[] { NoSelection, End, Start };
        }
    }

    public static class FieldInputs
    {
        /// <summary>
        /// Used as a radio button value in Return based analytics and creation of DAL request model
        /// The use of radio button with entity type allows consolidation on the entity type list
        /// </summary>
        public static class ReturnAnalyticsEntityTypes
        {
            public const string benchmark_entities = "benchmark_entities";
            public const string factor_entities = "factor_entities";
            public const string benchmark_factor_entities = "benchmark_factor_entities";
            public const string beta_profile_entities = "beta_profile_entities";
        }

        public static class RbaReturnWindow
        {
            public const string NoSelection = "";
            public const string Daily = "daily";
            public const string Weekly = "weekly";
            public const string Monthly = "monthly";
            public const string Quarterly = "quarterly";
            public const string Yearly = "yearly";
            public static readonly string[] InputValues = new[] { NoSelection, Daily, Weekly, Monthly, Quarterly, Yearly };
        }

        public static class BarraShape
        {
            public const string NoSelection = "";
            public const string Tall = "flat";
            public const string Flat = "tall";
            public static readonly string[] InputValues = new[] { NoSelection, Tall, Flat };
        }
    }
}
