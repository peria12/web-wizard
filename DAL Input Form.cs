using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Franklin_Templeton_DAL.Constants;
using Franklin_Templeton_DAL.Models;
using Franklin_Templeton_DAL.Models.InputModels;
using Franklin_Templeton_DAL.Helpers;
using static Franklin_Templeton_DAL.Constants.DateInputEnums;
using Franklin_Templeton_DAL.InputForms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Franklin_Templeton_DAL
{
    public partial class DALEntryForm : Form
    {
        private List<EntityInput> entityInputs { get; set; }
        private List<FieldInput> fieldInputs { get; set; }
        private IdInput idInput { get; set; }
        private static Json_Input _json_Input;
        

        public DALEntryForm()
        {
            InitializeDalInputForm();
        }

        public DALEntryForm(List<FieldInput> fieldInputs, List<EntityInput> entityInputs)
        {
            InitializeDalInputForm();
            this.fieldInputs = fieldInputs;
            this.entityInputs = entityInputs;
            PopuplateFromInputList();
            
        }

        #region Initialization
        private void InitializeDalInputForm()
        {
            InitializeComponent();
            // iniitalize variables
            entityInputs = new List<EntityInput>();
            fieldInputs = new List<FieldInput>();
            idInput = new IdInput()
            {
                IdType = null,
                IdDate = null
            };

            // adding validations
            monthCalendar.MaxDate = DateTime.Now;
            startdate.MaxDate = DateTime.Now;
            end_date.MaxDate = DateTime.Now;
            id_Date.MaxDate = DateTime.Now;
            selectdate.MaxDate = DateTime.Now;

            if (string.IsNullOrEmpty(DalSettings.accessToken))
            {
                lbl_auth_status.Text = "Not authenticated";
                lbl_auth_status.ForeColor = Color.DarkRed;
            }
            else
            {
                if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Production)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "Production Environment";
                }
                if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Development)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "Development Environment";
                }
                if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Uat)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "UAT Environment";
                }
                if (DalSettings.dalEnvironment == ApiUrls.DalEnvironment.Test)
                {
                    lbl_auth_status.Text = "Authenticated into DAL" + " " + "Test Environment";
                }
                lbl_auth_status.ForeColor = Color.ForestGreen;
            }

            InitializeDataSources();

        }

        private void InitializeDataSources()
        {
            try
            {
                // Initialize dropdowns
                comboBox_Dateinfo.DataSource = DateInfoType.InputValues;
                comboBox_frequency.DataSource = Frequency.InputValues;
                comboBox_FillMissing.DataSource = FillMissing.InputValues;
                comboBox_Align.DataSource = AlignItems.InputValues;

                // Initialize Field autocomplete
                var fieldAutoComplete = new AutoCompleteStringCollection();
                if (CachedData.FieldNames != null)
                {
                    fieldAutoComplete.AddRange(CachedData.FieldNames.ToArray());
                }
                txt_fieldname.AutoCompleteCustomSource = fieldAutoComplete;

                // Initialize Id type autocomplete
                var idTypeAutoComplete = new AutoCompleteStringCollection();
                if (CachedData.EntityTypes != null)
                {
                    idTypeAutoComplete.AddRange(CachedData.EntityTypes.ToArray());
                }
                txt_idType.AutoCompleteCustomSource = idTypeAutoComplete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PopuplateFromInputList()
        {
            foreach (var field in fieldInputs)
            {
                AddFieldToListView(field.FieldName);
            }

            foreach (var entity in entityInputs)
            {
                AddEntityToListView(entity);
            }
        }

        #endregion

        #region Add field

        public void AddField(FieldInput field)
        {
            AddFieldToListView(field.FieldName);
            fieldInputs.Add(field);
        }
        private void AddFieldToListView(string fieldName)
        {
            var row = new ListViewItem(fieldName);
            row.SubItems.AddRange(new[] { PromptText.Edit, PromptText.Delete });
            listView.Items.Add(row);
            
        }

        private void btn_add_field_Click(object sender, EventArgs e)
        {
            try
            {                
                //var fieldData = CachedData.FieldNames.FirstOrDefault(field => field == txt_fieldname.Text);
                //if(fieldData == null)
                //{
                //    MessageBox.Show("Invalid Field Name");
                //    return;
                //}

                if (checkBox_hasInputs.Checked)
                {
                    new FieldPopup(this, txt_fieldname.Text, null).ShowDialog();
                }
                else if (checkBox_customInput.Checked)
                {
                   // new DalRBACustomFields( txt_fieldname.Text).ShowDialog();
                }
                else
                {
                    AddField(new FieldInput(txt_fieldname.Text, false));
                }

                txt_fieldname.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateField(FieldInput updatedField)
        {
            var index = fieldInputs.FindIndex(item => item.rowcount == updatedField.rowcount);
            fieldInputs[index] = updatedField;
            listView.Items[updatedField.rowcount].SubItems[0].Text = updatedField.FieldName;
        }

        #endregion

        #region Generate Excel
        private DALRequest GetRequestString()
        {
            try
            {
                idInput.IdType = txt_idType.Text == "" ? null : txt_idType.Text;

                var dateInput = new DALDateInput()
                {
                    DateInfoType = comboBox_Dateinfo.Text,
                    StartDate = startdate.Value,
                    EndDate = end_date.Value,
                    MultiDate = textBox_selected_dates.Text,
                    Frequency = null,
                    Interval = null,
                    Align = null,
                    FillMissing = null
                };

                if (comboBox_frequency.Visible && comboBox_frequency.SelectedValue != null)
                {
                    dateInput.Frequency = comboBox_frequency.SelectedValue.ToString();
                }
                if (!string.IsNullOrEmpty(textBox_Interval.Text))
                {
                    dateInput.Interval = Convert.ToInt32(textBox_Interval.Text);
                }
                if (!string.IsNullOrEmpty(comboBox_Align.SelectedValue.ToString()))
                {
                    dateInput.Align = comboBox_Align.SelectedValue.ToString();
                }
                if (!string.IsNullOrEmpty(comboBox_FillMissing.SelectedValue.ToString()))
                {
                    dateInput.FillMissing = comboBox_FillMissing.SelectedValue.ToString();
                }

                return new DALRequest(fieldInputs, entityInputs, dateInput, idInput);
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured while creating request");
                return null;
            }
        }

        private void btn_genExcel_Click(object sender, EventArgs e)
        {
            if (listView.Items.Count == 0)
            {
                MessageBox.Show("Fields is mandatory");
                return;
            }

            GenExcel();
        }

        private void GenExcel()
        {
            try
            {
                this.Hide();
                Application.UseWaitCursor = true;
                this.Cursor = Cursors.WaitCursor;

                var dalReq = GetRequestString();
                new ExcelHelper().GenReport(JsonConvert.SerializeObject(dalReq));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.UseWaitCursor = false;
                this.Cursor = Cursors.Default;
               // this.Dispose();
            }
        }

        #endregion

        #region Date info
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendar.CalendarDimensions = new Size(1, 1);
            this.monthCalendar.TrailingForeColor = Color.Yellow;
        }

        private void monthCalendar_MouseDown(object sender, MouseEventArgs e)
        {
            var info = monthCalendar.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (monthCalendar.BoldedDates.Contains(info.Time))
                {
                    monthCalendar.RemoveBoldedDate(info.Time);
                }
                else
                {
                    monthCalendar.AddBoldedDate(info.Time);
                }
                monthCalendar.UpdateBoldedDates();
                UpdateDateSnapshotText();
            }
        }

        private void comboBox_Dateinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
            textBox_selected_dates.Visible = false;
            startdate.Visible = false;
            lbl_startdate.Visible = false;
            lbl_EndDate.Visible = false;
            end_date.Visible = false;
            lbl_Frequency.Visible = false;
            comboBox_frequency.Visible = false;
            lbl_Interval.Visible = false;
            textBox_Interval.Visible = false;
            lbl_file.Visible = false;
            lbl_align.Visible = false;
            comboBox_FillMissing.Visible = false;
            comboBox_Align.Visible = false;
            selectdate.Visible = false;
            lbl_selectdate.Visible = false;
            btn_select_dates.Visible = false;

            if (comboBox_Dateinfo.SelectedItem.ToString() == DateInfoType.Snapshots)
            {
                monthCalendar.Visible = true;
                textBox_selected_dates.Visible = true;
                btn_select_dates.Visible = true;
            }
            if (comboBox_Dateinfo.SelectedItem.ToString() == DateInfoType.Range)
            {
                startdate.Visible = true;
                lbl_startdate.Visible = true;
                lbl_EndDate.Visible = true;
                end_date.Visible = true;
            }
            if (comboBox_Dateinfo.SelectedItem.ToString() == DateInfoType.Series)
            {
                monthCalendar.Visible = true;
                textBox_selected_dates.Visible = true;
                lbl_Frequency.Visible = true;
                comboBox_frequency.Visible = true;
                lbl_Interval.Visible = true;
                textBox_Interval.Visible = true;
                lbl_file.Visible = true;
                lbl_align.Visible = true;
                comboBox_FillMissing.Visible = true;
                comboBox_Align.Visible = true;
            }
        }

        private void SelectDatesFromExcel(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var cellValues = UiHelper.GetCellRange("Select cells containing dates");
                if (cellValues == null)
                {
                    return;
                }
                foreach (var cellvalue in cellValues)
                {
                    if (cellvalue != null)
                    {
                        if (DateTime.TryParse(cellvalue.ToString(), out DateTime date1fromexcel))
                        {
                            var formatedDate = date1fromexcel.ToString("yyyy-MM-dd");
                            monthCalendar.AddBoldedDate(date1fromexcel);
                        }
                    }
                }

                monthCalendar.UpdateBoldedDates();
                UpdateDateSnapshotText();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show();
                this.Focus();
            }
        }

        private void UpdateDateSnapshotText()
        {
            var boldDates = new List<string>();
            foreach (var day in monthCalendar.BoldedDates)
            {
                boldDates.Add(day.ToString("yyyy-MM-dd"));
            }
            textBox_selected_dates.Text = string.Join(",", boldDates);
        }

        #endregion

        #region Fields

        public void listView_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var row = listView.HitTest(e.Location);
                if (row.SubItem == null)
                {
                    return;
                }
                if (row.SubItem.Text == PromptText.Edit)
                {
                    var fieldinput = fieldInputs.FirstOrDefault(field => field.FieldName == row.Item.SubItems[0].Text);
                                        
                    if (fieldinput.HasInputs)
                    {
                        new FieldPopup(this, row.Item.SubItems[0].Text, fieldinput).ShowDialog();
                    }
                    else if (fieldinput.CustomInputs)
                    {
                       // new CustomModel(this, row.Item.SubItems[0].Text, fieldinput).ShowDialog();
                    }
                    else
                    {
                        listView.Items.Remove(row.Item);
                        fieldInputs.Remove(fieldinput);
                        txt_fieldname.Text = row.Item.SubItems[0].Text;
                        txt_fieldname.Focus();
                    }
                }
                else if (row.SubItem.Text == PromptText.Delete)
                {
                    if (UiHelper.GetDeleteConformation("Field"))
                    {
                        listView.Items.Remove(row.Item);
                        var fieldinput = fieldInputs.FirstOrDefault(field => field.FieldName == row.Item.SubItems[0].Text);
                        fieldInputs.Remove(fieldinput);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Entities

        private void AddEntity(EntityInput entityInput)
        {
            try
            {
                AddEntityToListView(entityInput);
                entityInputs.Add(entityInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddEntityToListView(EntityInput entityInput)
        {
            entityInput.Rowcount = listView_entity.Items.Count;

            var entityListViewItem = new ListViewItem();
            if (entityInput.EntityType == EntityTypes.Text)
            {
                entityListViewItem.SubItems[0].Text = entityInput.EntityId;
            }
            if (entityInput.EntityType == EntityTypes.Object)
            {
                entityListViewItem.SubItems[0].Text = string.Join(", ", entityInput.SubEntities.Select(pair => pair.Key));
            }
            if(entityInput.EntityType==EntityTypes.CustomInput)
            {
                entityListViewItem.SubItems[0].Text = entityInput.EntityId;
            }
            entityListViewItem.SubItems.AddRange(new[] { PromptText.Edit, PromptText.Delete });
            listView_entity.Items.Add(entityListViewItem);
        }

        private void listView_entity_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var row = listView_entity.HitTest(e.Location);
                if (row.SubItem == null)
                {
                    return;
                }

                if (row.SubItem.Text == PromptText.Edit)
                {
                    var entities = entityInputs.SingleOrDefault(entitylist => entitylist.Rowcount == row.Item.Index);
                    new EntityPopup(this, entities).ShowDialog();
                }
                else if (row.SubItem.Text == PromptText.Delete)
                {
                    if (UiHelper.GetDeleteConformation("entity"))
                    {
                        listView_entity.Items.Remove(row.Item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateEntityList(List<EntityInput> entities)
        {
            foreach (var entity in entities)
            {
                AddEntity(entity);
            }
        }

        public void AddOrUpdateEntity(EntityInput entity)
        {
            if (entity.Rowcount == -1)
            {
                AddEntity(entity);
            }
            else
            {
                listView_entity.Items[entity.Rowcount].SubItems[0].Text = entity.EntityId;
                var index = entityInputs.FindIndex(item => item.Rowcount == entity.Rowcount);
                entityInputs[index] = entity;
            }
        }

        private void ShowEntityPopup(object sender, EventArgs e)
        {
            new EntityPopup(this).ShowDialog();
        }

        private void SelectEntityFromExcel(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                var cellValues = UiHelper.GetCellRange("Select cells containing entites");
                if (cellValues != null)
                {
                    foreach (var cellValue in cellValues)
                    {
                        var entity = new EntityInput()
                        {
                            Rowcount = -1,
                            EntityType = EntityTypes.Text,
                            EntityId = cellValue.ToString()
                        };
                        AddEntity(entity);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Show();
                this.Focus();
            }
        }

        #endregion

        #region Json Editor

        private void id_Date_ValueChanged(object sender, EventArgs e)
        {
            idInput.IdDate = id_Date.Value;
        }

        private void SwitchToJsonEditor(object sender, EventArgs e)
        {
            //if (_json_Input == null || _json_Input.IsDisposed)
            //{
            //    _json_Input = new Json_Input(GetRequestString(), fieldInputs, entityInputs);
               
            //}
            //_json_Input.Show();
            //this.Hide();
            //this.Dispose();
        }
        #endregion

        #region Custom Model Inputs     
        //Set to the hasInput and CustomInput
        private void checkBox_hasInputs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hasInputs.Checked == true)
            {
                checkBox_customInput.Checked = false;
            }
        }
        private void checkBox_customInput_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_customInput.Checked == true)
            {
                checkBox_hasInputs.Checked = false;
            }
        }

        #endregion

        private void ClearInputValues(object sender, EventArgs e)
        {
            try
            {
                monthCalendar.RemoveAllBoldedDates();
                monthCalendar.UpdateBoldedDates();

                textBox_Interval.Text = string.Empty;
                textBox_selected_dates.Text = string.Empty;
                txt_idType.Text = string.Empty;
                listView.Items.Clear();
                listView_entity.Items.Clear();
                checkBox_hasInputs.Checked = false;
                checkBox_customInput.Checked = false;
                //if (_json_Input != null && _json_Input.IsDisposed==false)
                //{
                //    _json_Input.Dispose();
                //    _json_Input = new Json_Input(GetRequestString(), fieldInputs, entityInputs);
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               
            }

        }
    }
}