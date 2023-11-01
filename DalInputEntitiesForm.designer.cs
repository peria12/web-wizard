namespace Franklin_Templeton_DAL.InputForms
{
    partial class DalInputEntitiesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.dgEntities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchEntity = new System.Windows.Forms.TextBox();
            this.txtCustomInput = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictIcn = new System.Windows.Forms.PictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.dgvSearchEntity = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKeyValue = new System.Windows.Forms.TabPage();
            this.idDateKeyValue = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKeyValue = new System.Windows.Forms.Button();
            this.tabFromExcel = new System.Windows.Forms.TabPage();
            this.txtIdType = new System.Windows.Forms.TextBox();
            this.idDate = new System.Windows.Forms.DateTimePicker();
            this.lblIdType = new System.Windows.Forms.Label();
            this.lblIdDate = new System.Windows.Forms.Label();
            this.btnSelectExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEntity)).BeginInit();
            this.tabKeyValue.SuspendLayout();
            this.tabFromExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEntities
            // 
            this.dgvEntities.AllowUserToAddRows = false;
            this.dgvEntities.AllowUserToDeleteRows = false;
            this.dgvEntities.AllowUserToOrderColumns = true;
            this.dgvEntities.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvEntities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntities.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dgvEntities.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEntities,
            this.dgDescription,
            this.dgDel});
            this.dgvEntities.EnableHeadersVisualStyles = false;
            this.dgvEntities.Location = new System.Drawing.Point(21, 425);
            this.dgvEntities.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEntities.MultiSelect = false;
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvEntities.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEntities.RowTemplate.Height = 40;
            this.dgvEntities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntities.Size = new System.Drawing.Size(1184, 297);
            this.dgvEntities.TabIndex = 99;
            this.dgvEntities.TabStop = false;
            this.dgvEntities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntities_CellContentClick);
            // 
            // dgEntities
            // 
            this.dgEntities.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgEntities.HeaderText = "Entities";
            this.dgEntities.MinimumWidth = 8;
            this.dgEntities.Name = "dgEntities";
            this.dgEntities.ReadOnly = true;
            // 
            // dgDescription
            // 
            this.dgDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescription.HeaderText = "Values";
            this.dgDescription.MinimumWidth = 550;
            this.dgDescription.Name = "dgDescription";
            this.dgDescription.ReadOnly = true;
            // 
            // dgDel
            // 
            this.dgDel.HeaderText = "";
            this.dgDel.Image = global::Franklin_Templeton_DAL.Properties.Resources.delete;
            this.dgDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgDel.MinimumWidth = 8;
            this.dgDel.Name = "dgDel";
            this.dgDel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDel.Width = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(21, 737);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 46);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "NoColor";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(17, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "&Search";
            // 
            // txtSearchEntity
            // 
            this.txtSearchEntity.Location = new System.Drawing.Point(114, 15);
            this.txtSearchEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchEntity.Name = "txtSearchEntity";
            this.txtSearchEntity.Size = new System.Drawing.Size(469, 22);
            this.txtSearchEntity.TabIndex = 1;
            this.txtSearchEntity.TextChanged += new System.EventHandler(this.txtSearchEntity_TextChanged);
            // 
            // txtCustomInput
            // 
            this.txtCustomInput.Location = new System.Drawing.Point(98, 66);
            this.txtCustomInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomInput.Multiline = true;
            this.txtCustomInput.Name = "txtCustomInput";
            this.txtCustomInput.Size = new System.Drawing.Size(873, 178);
            this.txtCustomInput.TabIndex = 10;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.Color.Black;
            this.lblValue.Location = new System.Drawing.Point(15, 57);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(63, 25);
            this.lblValue.TabIndex = 9;
            this.lblValue.Text = "&Value";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.ForeColor = System.Drawing.Color.Black;
            this.lblKey.Location = new System.Drawing.Point(17, 15);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(47, 25);
            this.lblKey.TabIndex = 4;
            this.lblKey.Text = "&Key";
            // 
            // txtKey
            // 
            this.txtKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKey.Location = new System.Drawing.Point(98, 17);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(469, 22);
            this.txtKey.TabIndex = 5;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(852, 737);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(165, 46);
            this.btnPrevious.TabIndex = 16;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(13, 807);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(204, 20);
            this.lbl_auth_status.TabIndex = 37;
            this.lbl_auth_status.Tag = "EnvironmentLabel";
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(1051, 737);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 46);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictIcn
            // 
            this.pictIcn.Image = global::Franklin_Templeton_DAL.Properties.Resources.franklin_templeton_logo;
            this.pictIcn.Location = new System.Drawing.Point(0, 14);
            this.pictIcn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictIcn.Name = "pictIcn";
            this.pictIcn.Size = new System.Drawing.Size(183, 74);
            this.pictIcn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictIcn.TabIndex = 101;
            this.pictIcn.TabStop = false;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.Color.Black;
            this.lblFormName.Location = new System.Drawing.Point(188, 36);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(157, 23);
            this.lblFormName.TabIndex = 100;
            this.lblFormName.Tag = "LabelBold";
            this.lblFormName.Text = "Entity Selection";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearch);
            this.tabControl1.Controls.Add(this.tabKeyValue);
            this.tabControl1.Controls.Add(this.tabFromExcel);
            this.tabControl1.ItemSize = new System.Drawing.Size(395, 35);
            this.tabControl1.Location = new System.Drawing.Point(17, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1188, 308);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 102;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.dgvSearchEntity);
            this.tabSearch.Controls.Add(this.txtSearchEntity);
            this.tabSearch.Controls.Add(this.lblSearch);
            this.tabSearch.Location = new System.Drawing.Point(4, 39);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1180, 265);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // dgvSearchEntity
            // 
            this.dgvSearchEntity.AllowUserToAddRows = false;
            this.dgvSearchEntity.AllowUserToDeleteRows = false;
            this.dgvSearchEntity.AllowUserToOrderColumns = true;
            this.dgvSearchEntity.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvSearchEntity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearchEntity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dgvSearchEntity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchEntity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSearchEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvSearchEntity.EnableHeadersVisualStyles = false;
            this.dgvSearchEntity.Location = new System.Drawing.Point(22, 60);
            this.dgvSearchEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearchEntity.MultiSelect = false;
            this.dgvSearchEntity.Name = "dgvSearchEntity";
            this.dgvSearchEntity.RowHeadersWidth = 62;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSearchEntity.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSearchEntity.RowTemplate.Height = 40;
            this.dgvSearchEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchEntity.Size = new System.Drawing.Size(1137, 189);
            this.dgvSearchEntity.TabIndex = 101;
            this.dgvSearchEntity.TabStop = false;
            this.dgvSearchEntity.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchEntity_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Entities";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 350;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tabKeyValue
            // 
            this.tabKeyValue.Controls.Add(this.idDateKeyValue);
            this.tabKeyValue.Controls.Add(this.label2);
            this.tabKeyValue.Controls.Add(this.btnKeyValue);
            this.tabKeyValue.Controls.Add(this.txtKey);
            this.tabKeyValue.Controls.Add(this.lblKey);
            this.tabKeyValue.Controls.Add(this.txtCustomInput);
            this.tabKeyValue.Controls.Add(this.lblValue);
            this.tabKeyValue.Location = new System.Drawing.Point(4, 39);
            this.tabKeyValue.Name = "tabKeyValue";
            this.tabKeyValue.Padding = new System.Windows.Forms.Padding(3);
            this.tabKeyValue.Size = new System.Drawing.Size(1180, 265);
            this.tabKeyValue.TabIndex = 1;
            this.tabKeyValue.Text = "Key Value Pairs";
            this.tabKeyValue.UseVisualStyleBackColor = true;
            // 
            // idDateKeyValue
            // 
            this.idDateKeyValue.Checked = false;
            this.idDateKeyValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.idDateKeyValue.CustomFormat = "yyyy-MM-dd";
            this.idDateKeyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDateKeyValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idDateKeyValue.Location = new System.Drawing.Point(706, 17);
            this.idDateKeyValue.Margin = new System.Windows.Forms.Padding(4);
            this.idDateKeyValue.Name = "idDateKeyValue";
            this.idDateKeyValue.ShowCheckBox = true;
            this.idDateKeyValue.Size = new System.Drawing.Size(265, 23);
            this.idDateKeyValue.TabIndex = 21;
            this.idDateKeyValue.Value = new System.DateTime(2023, 9, 3, 9, 44, 0, 0);
            this.idDateKeyValue.ValueChanged += new System.EventHandler(this.idDateKeyValue_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(601, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID &Date";
            // 
            // btnKeyValue
            // 
            this.btnKeyValue.ForeColor = System.Drawing.Color.White;
            this.btnKeyValue.Location = new System.Drawing.Point(989, 132);
            this.btnKeyValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKeyValue.Name = "btnKeyValue";
            this.btnKeyValue.Size = new System.Drawing.Size(167, 46);
            this.btnKeyValue.TabIndex = 14;
            this.btnKeyValue.TabStop = false;
            this.btnKeyValue.Text = "&Add Key Value";
            this.btnKeyValue.UseVisualStyleBackColor = true;
            this.btnKeyValue.Click += new System.EventHandler(this.btnKeyValue_Click);
            // 
            // tabFromExcel
            // 
            this.tabFromExcel.Controls.Add(this.txtIdType);
            this.tabFromExcel.Controls.Add(this.idDate);
            this.tabFromExcel.Controls.Add(this.lblIdType);
            this.tabFromExcel.Controls.Add(this.lblIdDate);
            this.tabFromExcel.Controls.Add(this.btnSelectExcel);
            this.tabFromExcel.Location = new System.Drawing.Point(4, 39);
            this.tabFromExcel.Name = "tabFromExcel";
            this.tabFromExcel.Size = new System.Drawing.Size(1180, 265);
            this.tabFromExcel.TabIndex = 3;
            this.tabFromExcel.Text = "Select From Excel";
            this.tabFromExcel.UseVisualStyleBackColor = true;
            // 
            // txtIdType
            // 
            this.txtIdType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIdType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIdType.Location = new System.Drawing.Point(114, 17);
            this.txtIdType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdType.Name = "txtIdType";
            this.txtIdType.Size = new System.Drawing.Size(281, 22);
            this.txtIdType.TabIndex = 17;
            // 
            // idDate
            // 
            this.idDate.Checked = false;
            this.idDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.idDate.CustomFormat = "yyyy-MM-dd";
            this.idDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.idDate.Location = new System.Drawing.Point(523, 17);
            this.idDate.Margin = new System.Windows.Forms.Padding(4);
            this.idDate.Name = "idDate";
            this.idDate.ShowCheckBox = true;
            this.idDate.Size = new System.Drawing.Size(265, 23);
            this.idDate.TabIndex = 19;
            this.idDate.Value = new System.DateTime(2023, 9, 3, 9, 44, 0, 0);
            this.idDate.ValueChanged += new System.EventHandler(this.idDate_ValueChanged);
            // 
            // lblIdType
            // 
            this.lblIdType.AutoSize = true;
            this.lblIdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdType.ForeColor = System.Drawing.Color.Black;
            this.lblIdType.Location = new System.Drawing.Point(17, 15);
            this.lblIdType.Name = "lblIdType";
            this.lblIdType.Size = new System.Drawing.Size(81, 25);
            this.lblIdType.TabIndex = 16;
            this.lblIdType.Text = "&ID Type";
            // 
            // lblIdDate
            // 
            this.lblIdDate.AutoSize = true;
            this.lblIdDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDate.ForeColor = System.Drawing.Color.Black;
            this.lblIdDate.Location = new System.Drawing.Point(423, 17);
            this.lblIdDate.Name = "lblIdDate";
            this.lblIdDate.Size = new System.Drawing.Size(77, 25);
            this.lblIdDate.TabIndex = 18;
            this.lblIdDate.Text = "ID &Date";
            // 
            // btnSelectExcel
            // 
            this.btnSelectExcel.ForeColor = System.Drawing.Color.White;
            this.btnSelectExcel.Location = new System.Drawing.Point(903, 17);
            this.btnSelectExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectExcel.Name = "btnSelectExcel";
            this.btnSelectExcel.Size = new System.Drawing.Size(191, 46);
            this.btnSelectExcel.TabIndex = 15;
            this.btnSelectExcel.Text = "Select &From Excel";
            this.btnSelectExcel.UseVisualStyleBackColor = true;
            this.btnSelectExcel.Click += new System.EventHandler(this.btnSelectExcel_Click);
            // 
            // DalInputEntitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 836);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictIcn);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.dgvEntities);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DalInputEntitiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.DalInputEntitiesForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEntity)).EndInit();
            this.tabKeyValue.ResumeLayout(false);
            this.tabKeyValue.PerformLayout();
            this.tabFromExcel.ResumeLayout(false);
            this.tabFromExcel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntities;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.TextBox txtSearchEntity;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.TextBox txtCustomInput;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescription;
        private System.Windows.Forms.DataGridViewImageColumn dgDel;
        private System.Windows.Forms.PictureBox pictIcn;
        private System.Windows.Forms.Label lblFormName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabKeyValue;
        private System.Windows.Forms.Button btnKeyValue;
        private System.Windows.Forms.TabPage tabFromExcel;
        private System.Windows.Forms.Button btnSelectExcel;
        private System.Windows.Forms.TextBox txtIdType;
        private System.Windows.Forms.DateTimePicker idDate;
        private System.Windows.Forms.Label lblIdType;
        private System.Windows.Forms.Label lblIdDate;
        private System.Windows.Forms.DateTimePicker idDateKeyValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSearchEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}