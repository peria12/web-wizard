namespace Franklin_Templeton_DAL
{
    partial class EntityPopup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntityPopup));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_key = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.lbl_value = new System.Windows.Forms.Label();
            this.btn_Addentity = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_entityName = new System.Windows.Forms.TextBox();
            this.btn_entity_search = new System.Windows.Forms.Button();
            this.lbl_entitie_value = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_text = new System.Windows.Forms.RadioButton();
            this.rb_search = new System.Windows.Forms.RadioButton();
            this.rb_custommodel = new System.Windows.Forms.RadioButton();
            this.rb_object = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_custom = new System.Windows.Forms.TextBox();
            this.listView_entity_popup = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEntitySearch = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.txt_custom);
            this.groupBox1.Controls.Add(this.listView_entity_popup);
            this.groupBox1.Controls.Add(this.listViewEntitySearch);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(624, 485);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entity";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.89474F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_key, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_key, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txt_value, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.lbl_value, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_Addentity, 4, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 102);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(554, 33);
            this.tableLayoutPanel4.TabIndex = 62;
            // 
            // lbl_key
            // 
            this.lbl_key.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(3, 8);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(30, 16);
            this.lbl_key.TabIndex = 51;
            this.lbl_key.Text = "Key";
            this.lbl_key.Visible = false;
            // 
            // txt_key
            // 
            this.txt_key.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_key.Location = new System.Drawing.Point(97, 5);
            this.txt_key.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(104, 22);
            this.txt_key.TabIndex = 4;
            this.txt_key.Visible = false;
            // 
            // txt_value
            // 
            this.txt_value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_value.Location = new System.Drawing.Point(312, 5);
            this.txt_value.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(102, 22);
            this.txt_value.TabIndex = 5;
            this.txt_value.Visible = false;
            // 
            // lbl_value
            // 
            this.lbl_value.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_value.AutoSize = true;
            this.lbl_value.Location = new System.Drawing.Point(227, 8);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(42, 16);
            this.lbl_value.TabIndex = 52;
            this.lbl_value.Text = "Value";
            this.lbl_value.Visible = false;
            // 
            // btn_Addentity
            // 
            this.btn_Addentity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Addentity.Location = new System.Drawing.Point(456, 4);
            this.btn_Addentity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Addentity.Name = "btn_Addentity";
            this.btn_Addentity.Size = new System.Drawing.Size(90, 24);
            this.btn_Addentity.TabIndex = 6;
            this.btn_Addentity.Text = "Add ";
            this.btn_Addentity.UseVisualStyleBackColor = true;
            this.btn_Addentity.Visible = false;
            this.btn_Addentity.Click += new System.EventHandler(this.btn_Addentity_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.76786F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.23214F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.Controls.Add(this.txt_entityName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_entity_search, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbl_entitie_value, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 34);
            this.tableLayoutPanel3.TabIndex = 61;
            // 
            // txt_entityName
            // 
            this.txt_entityName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_entityName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_entityName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_entityName.Location = new System.Drawing.Point(108, 6);
            this.txt_entityName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_entityName.Name = "txt_entityName";
            this.txt_entityName.Size = new System.Drawing.Size(310, 22);
            this.txt_entityName.TabIndex = 3;
            // 
            // btn_entity_search
            // 
            this.btn_entity_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_entity_search.Location = new System.Drawing.Point(459, 5);
            this.btn_entity_search.Name = "btn_entity_search";
            this.btn_entity_search.Size = new System.Drawing.Size(87, 23);
            this.btn_entity_search.TabIndex = 55;
            this.btn_entity_search.Text = "Search";
            this.btn_entity_search.UseVisualStyleBackColor = true;
            this.btn_entity_search.Click += new System.EventHandler(this.SearchEntity);
            // 
            // lbl_entitie_value
            // 
            this.lbl_entitie_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_entitie_value.AutoSize = true;
            this.lbl_entitie_value.Location = new System.Drawing.Point(32, 9);
            this.lbl_entitie_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_entitie_value.Name = "lbl_entitie_value";
            this.lbl_entitie_value.Size = new System.Drawing.Size(39, 16);
            this.lbl_entitie_value.TabIndex = 26;
            this.lbl_entitie_value.Text = "Entity";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.46073F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.53927F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_text, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_search, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_custommodel, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_object, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(594, 32);
            this.tableLayoutPanel2.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Type";
            // 
            // rb_text
            // 
            this.rb_text.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_text.AutoSize = true;
            this.rb_text.Checked = true;
            this.rb_text.Location = new System.Drawing.Point(56, 6);
            this.rb_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_text.Name = "rb_text";
            this.rb_text.Size = new System.Drawing.Size(74, 20);
            this.rb_text.TabIndex = 1;
            this.rb_text.TabStop = true;
            this.rb_text.Text = "Entity Id";
            this.rb_text.UseVisualStyleBackColor = true;
            this.rb_text.CheckedChanged += new System.EventHandler(this.rb_text_CheckedChanged);
            // 
            // rb_search
            // 
            this.rb_search.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_search.AutoSize = true;
            this.rb_search.Location = new System.Drawing.Point(168, 6);
            this.rb_search.Name = "rb_search";
            this.rb_search.Size = new System.Drawing.Size(106, 20);
            this.rb_search.TabIndex = 58;
            this.rb_search.TabStop = true;
            this.rb_search.Text = "Search Entity";
            this.rb_search.UseVisualStyleBackColor = true;
            this.rb_search.CheckedChanged += new System.EventHandler(this.rb_search_CheckedChanged);
            // 
            // rb_custommodel
            // 
            this.rb_custommodel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_custommodel.AutoSize = true;
            this.rb_custommodel.Location = new System.Drawing.Point(449, 6);
            this.rb_custommodel.Name = "rb_custommodel";
            this.rb_custommodel.Size = new System.Drawing.Size(114, 20);
            this.rb_custommodel.TabIndex = 56;
            this.rb_custommodel.TabStop = true;
            this.rb_custommodel.Text = "Custom Model";
            this.rb_custommodel.UseVisualStyleBackColor = true;
            this.rb_custommodel.CheckedChanged += new System.EventHandler(this.rb_custommodel_CheckedChanged);
            // 
            // rb_object
            // 
            this.rb_object.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rb_object.AutoSize = true;
            this.rb_object.Location = new System.Drawing.Point(306, 6);
            this.rb_object.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rb_object.Name = "rb_object";
            this.rb_object.Size = new System.Drawing.Size(131, 20);
            this.rb_object.TabIndex = 2;
            this.rb_object.TabStop = true;
            this.rb_object.Text = "Other Key Values";
            this.rb_object.UseVisualStyleBackColor = true;
            this.rb_object.CheckedChanged += new System.EventHandler(this.rb_object_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.61597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.38403F));
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_add, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 388);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 38);
            this.tableLayoutPanel1.TabIndex = 59;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_cancel.Location = new System.Drawing.Point(4, 5);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(124, 28);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.ClosePopup);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Location = new System.Drawing.Point(430, 5);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(123, 28);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.SaveEntity);
            // 
            // txt_custom
            // 
            this.txt_custom.Location = new System.Drawing.Point(23, 154);
            this.txt_custom.Multiline = true;
            this.txt_custom.Name = "txt_custom";
            this.txt_custom.Size = new System.Drawing.Size(554, 217);
            this.txt_custom.TabIndex = 57;
            // 
            // listView_entity_popup
            // 
            this.listView_entity_popup.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_entity_popup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader15,
            this.columnHeader16});
            this.listView_entity_popup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_entity_popup.FullRowSelect = true;
            this.listView_entity_popup.GridLines = true;
            this.listView_entity_popup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_entity_popup.HideSelection = false;
            this.listView_entity_popup.HoverSelection = true;
            this.listView_entity_popup.LabelEdit = true;
            this.listView_entity_popup.Location = new System.Drawing.Point(23, 142);
            this.listView_entity_popup.Margin = new System.Windows.Forms.Padding(4);
            this.listView_entity_popup.Name = "listView_entity_popup";
            this.listView_entity_popup.Size = new System.Drawing.Size(550, 108);
            this.listView_entity_popup.TabIndex = 44;
            this.listView_entity_popup.UseCompatibleStateImageBehavior = false;
            this.listView_entity_popup.View = System.Windows.Forms.View.Details;
            this.listView_entity_popup.Visible = false;
            this.listView_entity_popup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_entity_popup_MouseUp);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Entity Key";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 186;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Entity Value";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 146;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Action";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 100;
            // 
            // listViewEntitySearch
            // 
            this.listViewEntitySearch.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewEntitySearch.CheckBoxes = true;
            this.listViewEntitySearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewEntitySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEntitySearch.FullRowSelect = true;
            this.listViewEntitySearch.GridLines = true;
            this.listViewEntitySearch.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEntitySearch.HideSelection = false;
            this.listViewEntitySearch.HoverSelection = true;
            this.listViewEntitySearch.LabelEdit = true;
            this.listViewEntitySearch.Location = new System.Drawing.Point(24, 142);
            this.listViewEntitySearch.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEntitySearch.Name = "listViewEntitySearch";
            this.listViewEntitySearch.Size = new System.Drawing.Size(549, 164);
            this.listViewEntitySearch.TabIndex = 54;
            this.listViewEntitySearch.UseCompatibleStateImageBehavior = false;
            this.listViewEntitySearch.View = System.Windows.Forms.View.Details;
            this.listViewEntitySearch.Visible = false;
            this.listViewEntitySearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listViewEntitySearch_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Entity Id";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Entity Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 240;
            // 
            // EntityPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 533);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EntityPopup";
            this.Text = "Entity Details";
            this.Load += new System.EventHandler(this.EntityPopup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_entitie_value;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_entityName;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListView listView_entity_popup;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button btn_Addentity;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label lbl_key;
        private System.Windows.Forms.TextBox txt_key;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.RadioButton rb_object;
        private System.Windows.Forms.RadioButton rb_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewEntitySearch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_entity_search;
        private System.Windows.Forms.TextBox txt_custom;
        private System.Windows.Forms.RadioButton rb_custommodel;
        private System.Windows.Forms.RadioButton rb_search;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}