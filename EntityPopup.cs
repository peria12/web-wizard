using System;
using Franklin_Templeton_DAL.Models.InputModels;
using System.Windows.Forms;
using Franklin_Templeton_DAL.Constants;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Franklin_Templeton_DAL.Helpers;
using Franklin_Templeton_DAL.Models;
using static Franklin_Templeton_DAL.Models.EntityMaster;
using System.IdentityModel.Metadata;
using System.Xml;

namespace Franklin_Templeton_DAL
{
    public partial class EntityPopup : Form
    {
        private DALEntryForm dalform { get; set; }
        private EntityInput entityitem { get; set; }
        private List<EntityMaster.Entity> entityMaster { get; set; }

        #region Form Load
        public EntityPopup(DALEntryForm dALEntryForm, EntityInput entityitem = null)
        {
            InitializeComponent();
            dalform = dALEntryForm;
            this.entityitem = entityitem == null ? new EntityInput() { Rowcount = -1 } : entityitem;
            txt_custom.Visible= false;
            btn_entity_search.Visible= false;
            EntityAutoPopulate();
        }
       
        private void EntityPopup_Load(object sender, EventArgs e)
        {
            try
            {
                if (entityitem.Rowcount == -1)
                {
                    return;
                }

                btn_add.Text = PromptText.Update;
                if (entityitem.EntityType == EntityTypes.Text)
                {
                    txt_entityName.Text = entityitem.EntityId;
                }
                else if(entityitem.EntityType == EntityTypes.Object)
                {
                    rb_object.Checked = true;
                    foreach (KeyValuePair<string, string> kvp in entityitem.SubEntities)
                    {
                        var rowitems = new ListViewItem(new[] { kvp.Key, kvp.Value });
                        rowitems.SubItems.Add(PromptText.Delete);
                        listView_entity_popup.Items.Add(rowitems);
                    }
                }
                else if(entityitem.EntityType== EntityTypes.CustomInput)
                {
                    rb_custommodel.Checked= true;
                    txt_entityName.Text = entityitem.EntityId;
                    txt_custom.Text = entityitem.Custominputvalues;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Save Event
        private void ClosePopup(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void SaveEntity(object sender, EventArgs e)
        {
            try
            {
                if (rb_search.Checked == true)
                {
                    if (listViewEntitySearch.CheckedItems.Count == 0 && string.IsNullOrEmpty(txt_entityName.Text))
                    {
                        MessageBox.Show("Entity name is mandatory");
                        txt_entityName.Focus();
                        return;
                    }
                    if (listViewEntitySearch.CheckedItems.Count > 0)
                    {
                        var entityList = new List<EntityInput>();
                        foreach (ListViewItem item in listViewEntitySearch.CheckedItems)
                        {
                            var entity = new EntityInput()
                            {
                                EntityId = item.Text,
                                Rowcount = -1,
                                EntityType = EntityTypes.Text
                            };
                            entityList.Add(entity);
                        }
                        dalform.UpdateEntityList(entityList);
                        return;
                    }
                    entityitem.EntityId = txt_entityName.Text;
                    entityitem.EntityType = EntityTypes.Text;
                }
                if (rb_object.Checked == true)
                {
                    if (listView_entity_popup.Items.Count == 0)
                    {
                        MessageBox.Show("Add atleast one Key value");
                        txt_key.Focus();
                        return;
                    }
                    entityitem.EntityType = EntityTypes.Object;
                    entityitem.SubEntities = new Dictionary<string, string>();
                    foreach (ListViewItem Item in listView_entity_popup.Items)
                    {
                        entityitem.SubEntities.Add(Item.Text, Item.SubItems[1].Text);
                    }
                }
                if(rb_text.Checked == true)
                {
                    entityitem.EntityType = EntityTypes.Text;
                    entityitem.EntityId= txt_entityName.Text;
                }
                if (rb_custommodel.Checked == true)
                {
                    entityitem.EntityType = EntityTypes.CustomInput;
                    entityitem.EntityId=txt_entityName.Text;
                    var str = txt_custom.Text;
                    String customvalues = str.Replace(@"\", @"");
                    entityitem.Custominputvalues =customvalues;
                }
                dalform.AddOrUpdateEntity(entityitem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Dispose();
            }
        }
        #endregion

        #region Add Entity
        private void btn_Addentity_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_key.Text == string.Empty || txt_value.Text == string.Empty)
                {
                    MessageBox.Show("Key and value column is mandatory");
                    return;
                }
                var rowitems = new ListViewItem(new[] { txt_key.Text, txt_value.Text });
                rowitems.SubItems.Add(PromptText.Delete);
                listView_entity_popup.Items.Add(rowitems);
                txt_key.Text = txt_value.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listView_entity_popup_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var row = listView_entity_popup.HitTest(e.Location);
                if (row.SubItem != null && row.SubItem == row.Item.SubItems[2])
                {
                    if (UiHelper.GetDeleteConformation())
                    {
                        listView_entity_popup.Items.Remove(row.Item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Radio Button toggle visiblity

        private void rb_text_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_text.Checked == true)
            {
               lbl_entitie_value.Visible = txt_entityName.Visible = true;
               txt_custom.Visible = false; listViewEntitySearch.Visible=false;
               btn_entity_search.Visible = lbl_key.Visible = txt_key.Visible = false;                 
               lbl_value.Visible = txt_value.Visible = listView_entity_popup.Visible = btn_Addentity.Visible = false;
            }
        }

        private void rb_object_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_object.Checked == true)
            {
                lbl_key.Visible = txt_key.Visible = lbl_value.Visible = txt_value.Visible = listView_entity_popup.Visible = btn_Addentity.Visible = true;
                lbl_entitie_value.Visible = txt_entityName.Visible = listViewEntitySearch.Visible = btn_entity_search.Visible = false;
                txt_custom.Visible = false;
            }
        }
       
        private void rb_custommodel_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_custommodel.Checked == true)
            {
                lbl_entitie_value.Visible = txt_entityName.Visible = txt_custom.Visible = true;
                lbl_key.Visible = txt_key.Visible = lbl_value.Visible = txt_value.Visible = false;
                listViewEntitySearch.Visible = btn_entity_search.Visible = false;
                btn_Addentity.Visible = false;
                listView_entity_popup.Visible = false;
            }
        }

        private void rb_search_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_search.Checked == true)
            {
                listViewEntitySearch.Visible = true;
                lbl_entitie_value.Visible = txt_entityName.Visible = btn_entity_search.Visible = true;
                txt_custom.Visible = false; btn_Addentity.Visible = false;
                lbl_key.Visible = txt_key.Visible = lbl_value.Visible = txt_value.Visible = false;
                listView_entity_popup.Visible = false;
            }
        }
        #endregion

        #region Search Entity
        private void SearchEntity(object sender, EventArgs e)
        {
            try
            {
                Application.UseWaitCursor = true;
                this.Cursor = Cursors.WaitCursor;
                if (txt_entityName.Text.Length < 3)
                {
                    return;
                }
                var apiHelper = new ApiHelper();
                var apiResponse = apiHelper.GetEntityMasterData(txt_entityName.Text);
                if(apiResponse != null && apiResponse.entities != null)
                {
                    entityMaster = apiResponse.entities;
                    entitySearchPopulate();
                }
                var idTypeAutoComplete = new AutoCompleteStringCollection();
                if (CachedData.EntityTypes != null)
                {
                    idTypeAutoComplete.AddRange(CachedData.EntityTypes.ToArray());
                }
                txt_entityName.AutoCompleteCustomSource = idTypeAutoComplete;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.UseWaitCursor = false;
                this.Cursor = Cursors.Default;
            }
            
        }
        private void EntityAutoPopulate()
        {
            try
            {
                Application.UseWaitCursor = true;
                this.Cursor = Cursors.WaitCursor;
                var apiHelper = new ApiHelper();
                var apiResponse = apiHelper.GetEntityMasterData(txt_entityName.Text);
                if (apiResponse != null && apiResponse.entities != null)
                {
                    entityMaster = apiResponse.entities;
                   // entitySearchPopulate();
                }
                var EntityTypeAutoComplete = new AutoCompleteStringCollection();
                if (CachedData.EntityTypes != null)
                {
                    EntityTypeAutoComplete.AddRange(CachedData.EntityTypes.ToArray());
                }
                txt_entityName.AutoCompleteCustomSource = EntityTypeAutoComplete;
                //entitySearchPopulate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Application.UseWaitCursor = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void entitySearchPopulate()
        {
            try
            {

                listViewEntitySearch.Items.Clear();
                foreach (var entity in entityMaster)
                {
                    var id = entity.entity_id.Substring(0, entity.entity_id.Length - 2);
                    var rowitem = new ListViewItem(new[] { id, entity.entity_name });
                    rowitem.SubItems.Add(PromptText.Select);
                    listViewEntitySearch.Items.Add(rowitem);
                }
                listViewEntitySearch.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listViewEntitySearch_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                var row = listViewEntitySearch.HitTest(e.Location);
                if (row.SubItem != null && row.SubItem == row.Item.SubItems[2])
                {
                    entityitem.EntityId = row.Item.SubItems[0].Text;
                    entityitem.EntityType = EntityTypes.Text;
                    dalform.AddOrUpdateEntity(entityitem);
                    this.Dispose();
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
