using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Models.InputModels;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Franklin_Templeton_DAL.Helpers;
using System.Security.Policy;
using System.Drawing;

namespace Franklin_Templeton_DAL.Constants
{
    /// <summary>
    /// Used to store locally cached copy of Fields and Entity types for auto complete
    /// </summary>
    internal static class CachedData
    {
        public static List<string> FieldNames { get; set; }
        public static List<string> FieldDesc { get; set; }
        public static List<string> EntityTypes { get; set; }
        public static Dictionary<string,string> EntityTypesWithValue { get; set; }
        public static List<FieldData> FieldData { get; set; }
        public static DalInputRequest InputRequest { get; set; } = new DalInputRequest();

        public static bool isJsonValid(string jsonString)
        {
            bool returnValue = false;
            try
            {
                if (!string.IsNullOrEmpty(jsonString))
                {
                    JObject.Parse(jsonString);
                    returnValue = true;
                }
                else
                {
                    try
                    {
                        DalInputRequest inputRequest = JsonConvert.DeserializeObject<DalInputRequest>(jsonString);
                        returnValue = true;
                    }
                    catch
                    {
                        returnValue = false;
                    }
                }
            }
            catch (JsonException)
            {
            }
            return returnValue;
        }
        public static bool GenerateExcel(string strJson)
        {
            bool returnValue = false;
            if (isJsonValid(strJson))
            {
                new ExcelHelper().GenReport(strJson);
                returnValue = true;
            }
            return returnValue;
        }

        #region Set Colors And Fonts
        public static void SetFormTheme(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.ControlBox = false;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.BackColor = Properties.Settings.Default.FormBgColur;
            form.BackColor = Properties.Settings.Default.FormBgColur;
            //form.Width = 1301;
            //form.Height = 730;
            ApplyToAll(form.Controls);
        }
        private static void ApplyToAll(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {

                if (control is Label)
                {
                    if (control.Tag == "EnvironmentLabel")
                    {
                        if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Production)
                        {
                            ((Label)control).ForeColor = Properties.Settings.Default.EnvironLabelColorProduction;
                        }
                        if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Development)
                        {
                            ((Label)control).ForeColor = Properties.Settings.Default.EnvironLabelColorDevelopment;
                        }
                        if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Uat)
                        {
                            ((Label)control).ForeColor = Properties.Settings.Default.EnvironLabelColorUat;
                        }
                        if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Test)
                        {
                            ((Label)control).ForeColor = Properties.Settings.Default.EnvironLabelColorTest;
                        }
                    }
                    else
                    {
                        if (control.Tag != "NoColor")
                        {
                            ((Label)control).ForeColor = Properties.Settings.Default.DefaultForeColor;
                        }
                    }
                }
                else if (control is Button)
                {
                    ((Button)control).AutoSize = false;
                    ((Button)control).FlatStyle = FlatStyle.Flat;
                    ((Button)control).Height = Properties.Settings.Default.ButtonHeight;
                    if (control.Tag != "NoColor")
                    {
                        ((Button)control).BackColor = Properties.Settings.Default.ButtonColor;
                        ((Button)control).ForeColor = Properties.Settings.Default.ButtonForeColor;
                    }
                }
                else if (control is CheckBox) { }
                else if (control is RadioButton) { }
                else if (control is ComboBox) { }
                else if (control is ListView) { }
                else if (control is TextBox)
                {                    
                    if (((TextBox)control).Multiline == false)
                    {
                        ((TextBox)control).AutoSize = false;
                        //if (((TextBox)control).AutoCompleteMode== AutoCompleteMode.None)
                        //{
                            //((TextBox)control).MaximumSize = new Size(((TextBox)control).Width, Properties.Settings.Default.TextboxHeight);
                            ((TextBox)control).Height = Properties.Settings.Default.TextboxHeight;
                        //}
                        //else
                        //{
                        //    //((TextBox)control).MaximumSize = new Size(((TextBox)control).Width, Properties.Settings.Default.TextboxHeight-10);
                        //    ((TextBox)control).Height = Properties.Settings.Default.TextboxHeight-10;
                        //}
                    }
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).BackgroundColor = Properties.Settings.Default.GridBgColor;
                    ((DataGridView)control).ColumnHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.GridHeaderColor;
                    ((DataGridView)control).RowsDefaultCellStyle.ForeColor = Properties.Settings.Default.DefaultFontColor;
                    ((DataGridView)control).AlternatingRowsDefaultCellStyle.BackColor = Properties.Settings.Default.GridAlternateColor;
                    ((DataGridView)control).RowHeadersVisible = Properties.Settings.Default.RowHeaderVisible;
                    ((DataGridView)control).RowsDefaultCellStyle.BackColor = Properties.Settings.Default.GridRowColor;
                    ((DataGridView)control).RowHeadersDefaultCellStyle.BackColor = Properties.Settings.Default.GridRowColor;
                    ((DataGridView)control).SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    ((DataGridView)control).DefaultCellStyle.Font = Properties.Settings.Default.GridColumnFont;
                    ((DataGridView)control).RowTemplate.Height = Properties.Settings.Default.GridRowHeight;
                }
                else { }
                try
                {
                    if (control.Tag == "LabelBold")
                    {
                        control.GetType().GetProperty("Font").SetValue(control, Properties.Settings.Default.LabelBold);
                    }
                    else
                    {
                        control.GetType().GetProperty("Font").SetValue(control, Properties.Settings.Default.NormalLabel);
                    }
                }
                catch (Exception ex)
                {
                }
                if (control.Controls != null && control.Controls.Count > 0)
                {
                    ApplyToAll(control.Controls);
                }
            }
        }
        #endregion

    }
}
