using System;
using System.Windows.Forms;
using Franklin_Templeton_DAL.Models.InputModels;
using Franklin_Templeton_DAL.Constants;
using System.Drawing;
using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Helpers;
using System.Collections.Generic;
using static Franklin_Templeton_DAL.Constants.FieldInputs;

namespace Franklin_Templeton_DAL
{
    public partial class FieldPopup : Form
    {
        private const string csvPlaceholderTxt = "Values should be separated by comma( , )";

        public DALEntryForm dalform { get; set; }
        public FieldInput fieldInput { get; set; }
        private bool isUpdate { get; set; }

        public FieldPopup(DALEntryForm dALEntryForm, string fieldName, FieldInput fieldInput = null)
        {
            InitializeComponent();
            dalform = dALEntryForm;
            this.fieldInput = fieldInput ?? new FieldInput(fieldName, true, false);
            txt_FieldName.Text = fieldName;

            if (fieldInput != null)
            {
                isUpdate = true;
            }

            InitializeFormElements();
        }

        #region Form load

        private void InitializeFormElements()
        {
            try
            {
                comboBox_frequency.DataSource = DateInputEnums.Frequency.InputValues;
                comboBox_Align.DataSource = DateInputEnums.AlignItems.InputValues;
                comboBox_shape.DataSource = BarraShape.InputValues;
                combo_returnWindow.DataSource = RbaReturnWindow.InputValues;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while initializing form");
            }
        }

        public void FieldPopup_Load(object sender, EventArgs e)
        {
            try
            {
                if (isUpdate)
                {
                    btn_Add.Text = PromptText.Update;

                    // Filters
                    if (!string.IsNullOrEmpty(fieldInput.Filter.shape))
                    {
                        comboBox_shape.Text = fieldInput.Filter.shape;
                    }

                    if (!string.IsNullOrEmpty(fieldInput.Filter.ids))
                    {
                        txt_Ids.Text = fieldInput.Filter.ids;
                        txt_Ids.ForeColor = Color.Black;
                    }
                    txt_posn.Text = fieldInput.Filter.posn_info_typ_cd ?? string.Empty;
                    txt_Id_type.Text = fieldInput.Filter.id_type ?? string.Empty;

                    if (!string.IsNullOrEmpty(fieldInput.SubField))
                    {
                        txt_SubField.Text = fieldInput.SubField;
                        txt_SubField.ForeColor = Color.Black;
                    }

                    if (!string.IsNullOrEmpty(fieldInput.DataItemIds))
                    {
                        txt_Data_item_ids.Text = isUpdate ? fieldInput.DataItemIds : "";
                        txt_Data_item_ids.ForeColor = isUpdate ? Color.Black : Color.Silver;
                    }

                    if (fieldInput.raInput != null)
                    {
                        PopulateReturnAnalytics(fieldInput.raInput);
                    }

                    txt_Period_type.Text = fieldInput.PeriodType ?? string.Empty;
                    txt_ds_field.Text = fieldInput.dsField ?? string.Empty;
                    comboBox_Align.Text = fieldInput.Align ?? string.Empty;
                    comboBox_frequency.Text = fieldInput.Frequency ?? string.Empty;
                    txt_Level.Text = fieldInput.Level ?? string.Empty;
                    comboBox_frequency.Text = fieldInput.Frequency ?? string.Empty;

                    if (fieldInput.ListOnly == true)
                    {
                        listOnly_checkBox.Checked = true;
                    }

                    if (fieldInput.Desc == true)
                    {
                        desc_checkBox.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region AddField

        private void add_button_Click(object sender, EventArgs e)
        {
            try
            {
                fieldInput.FieldName = txt_FieldName.Text;
                fieldInput.HasInputs = true;
                fieldInput.CustomInputs = false;
                fieldInput.SubField = txt_SubField.Text == csvPlaceholderTxt ? null : txt_SubField.Text;
                fieldInput.Filter = new Filter
                {
                    posn_info_typ_cd = txt_posn.Text,
                    id_type = txt_Id_type.Text,
                    ids = txt_Ids.Text == csvPlaceholderTxt ? null : txt_Ids.Text,
                    shape = comboBox_shape.Text
                };
                fieldInput.Frequency = comboBox_frequency.Text;
                fieldInput.Align = comboBox_Align.Text;

                if (listOnly_checkBox.Checked)
                {
                    fieldInput.ListOnly = true;
                }
                else
                {
                    fieldInput.ListOnly = null;
                }
                if (desc_checkBox.Checked)
                {
                    fieldInput.Desc = true;
                }
                else
                {
                    fieldInput.Desc = null;
                }
                fieldInput.Level = txt_Level.Text;
                fieldInput.DataItemIds = txt_Data_item_ids.Text == csvPlaceholderTxt ? null : txt_Data_item_ids.Text;
                fieldInput.PeriodType = txt_Period_type.Text;
                fieldInput.dsField = txt_ds_field.Text;

                if (listView_returnAnalytics.Items.Count > 0)
                {
                    AddReturnAnalyticsToFieldInput();
                }

                if (btn_Add.Text == PromptText.Update)
                {
                    dalform.UpdateField(fieldInput);
                }
                else
                {
                    dalform.AddField(fieldInput);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Cancel Button
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion

        #region Place Holder

        private void txt_Subfields_Enter(object sender, EventArgs e)
        {
            if (txt_SubField.Text == csvPlaceholderTxt)
            {
                txt_SubField.Text = "";
                txt_SubField.ForeColor = Color.Black;
            }
        }

        private void txt_SubField_Leave(object sender, EventArgs e)
        {
            if (txt_SubField.Text == "")
            {
                txt_SubField.Text = csvPlaceholderTxt;
                txt_SubField.ForeColor = Color.Silver;
            }
        }

        private void txt_Ids_Enter(object sender, EventArgs e)
        {
            if (txt_Ids.Text == csvPlaceholderTxt)
            {
                txt_Ids.Text = "";
                txt_Ids.ForeColor = Color.Black;
            }
        }

        private void txt_Ids_Leave(object sender, EventArgs e)
        {
            if (txt_Ids.Text == "")
            {
                txt_Ids.Text = csvPlaceholderTxt;
                txt_Ids.ForeColor = Color.Silver;
            }
        }

        private void txt_Data_item_ids_Enter(object sender, EventArgs e)
        {
            if (txt_Data_item_ids.Text == csvPlaceholderTxt)
            {
                txt_Data_item_ids.Text = "";
                txt_Data_item_ids.ForeColor = Color.Black;
            }
        }

        private void txt_Data_item_ids_Leave(object sender, EventArgs e)
        {
            if (txt_Data_item_ids.Text == "")
            {
                txt_Data_item_ids.Text = csvPlaceholderTxt;
                txt_Data_item_ids.ForeColor = Color.Silver;
            }
        }


        #endregion

        #region Return Analytics

        private void PopulateReturnAnalytics(ReturnAnalyticsInput raInput)
        {
            txtInut_dataThreshold.Text = raInput.data_available_threshold.ToString();
            combo_returnWindow.Text = raInput.returnWindowsUnit;
            foreach (var dict in raInput.benchmark_entities)
            {
                foreach (var item in dict)
                {
                    AddRaEntityToList(item.Key, item.Value, ReturnAnalyticsEntityTypes.benchmark_entities);
                }
            }
            foreach (var dict in raInput.factor_entities)
            {
                foreach (var item in dict)
                {
                    AddRaEntityToList(item.Key, item.Value, ReturnAnalyticsEntityTypes.factor_entities);
                }
            }
            foreach (var dict in raInput.benchmark_factor_entities)
            {
                foreach (var item in dict)
                {
                    AddRaEntityToList(item.Key, item.Value, ReturnAnalyticsEntityTypes.benchmark_factor_entities);
                }
            }
            foreach (var dict in raInput.beta_profile_entities)
            {
                foreach (var item in dict)
                {
                    AddRaEntityToList(item.Key, item.Value, ReturnAnalyticsEntityTypes.beta_profile_entities);
                }
            }
        }

        private void AddReturnAnalyticsToFieldInput()
        {
            fieldInput.raInput = new ReturnAnalyticsInput()
            {
                benchmark_entities = new List<Dictionary<string, string>>(),
                factor_entities = new List<Dictionary<string, string>>(),
                benchmark_factor_entities = new List<Dictionary<string, string>>(),
                beta_profile_entities = new List<Dictionary<string, string>>(),
                returnWindowsUnit = combo_returnWindow.Text
            };

            if (string.IsNullOrEmpty(txtInut_dataThreshold.Text))
            {
                MessageBox.Show("DataThreshold cannot be empty");
                return;
            }

            fieldInput.raInput.data_available_threshold = Convert.ToDouble(txtInut_dataThreshold.Text);

            foreach (ListViewItem item in listView_returnAnalytics.Items)
            {
                var dictionary = new Dictionary<string, string>();
                dictionary.Add(item.SubItems[0].Text, item.SubItems[1].Text);

                switch (item.SubItems[2].Text)
                {
                    case ReturnAnalyticsEntityTypes.benchmark_entities:
                        fieldInput.raInput.benchmark_entities.Add(dictionary);
                        break;
                    case ReturnAnalyticsEntityTypes.factor_entities:
                        fieldInput.raInput.factor_entities.Add(dictionary);
                        break;
                    case ReturnAnalyticsEntityTypes.benchmark_factor_entities:
                        fieldInput.raInput.benchmark_factor_entities.Add(dictionary);
                        break;
                    case ReturnAnalyticsEntityTypes.beta_profile_entities:
                        fieldInput.raInput.beta_profile_entities.Add(dictionary);
                        break;
                }
            }
        }

        private void AddReturnAnalyticsEntity(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtInput_returnIdName.Text) || string.IsNullOrEmpty(txtInput_returnIdVal.Text) || string.IsNullOrEmpty(getSelectedEntityType()))
                {
                    MessageBox.Show("Name, Value and type are mandatory");
                    return;
                }

                AddRaEntityToList(txtInput_returnIdName.Text, txtInput_returnIdVal.Text, getSelectedEntityType());

                txtInput_returnIdName.Text = string.Empty;
                txtInput_returnIdVal.Text = string.Empty;
            }
            catch (Exception ex)
            {

            }
        }

        private void AddRaEntityToList(string idName, string idValue, string entityType)
        {
            var listItem = new ListViewItem(new[] { idName, idValue, entityType, PromptText.Delete });
            listView_returnAnalytics.Items.Add(listItem);
        }

        private string getSelectedEntityType()
        {
            if (radioBtn_benchmark.Checked)
            {
                return ReturnAnalyticsEntityTypes.benchmark_entities;
            }
            if (radioBtn_factorEntity.Checked)
            {
                return ReturnAnalyticsEntityTypes.factor_entities;
            }
            if (radioBtn_benchmarkFactor.Checked)
            {
                return ReturnAnalyticsEntityTypes.benchmark_factor_entities;
            }
            if (radioBtn_betaProfile.Checked)
            {
                return ReturnAnalyticsEntityTypes.beta_profile_entities;
            }
            return null;
        }

        private void deleteReturnAnalyticsEntity(object sender, MouseEventArgs e)
        {
            try
            {
                var row = listView_returnAnalytics.HitTest(e.Location);
                if (row.SubItem == null)
                {
                    return;
                }
                if (row.SubItem.Text == PromptText.Delete)
                {
                    if (UiHelper.GetDeleteConformation("Field"))
                    {
                        listView_returnAnalytics.Items.Remove(row.Item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion


    }
}
