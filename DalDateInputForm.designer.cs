namespace Franklin_Templeton_DAL.InputForms
{
    partial class DalDateInputForm
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
            this.lbDateInfo = new System.Windows.Forms.Label();
            this.lblLookback = new System.Windows.Forms.Label();
            this.cbAlign = new System.Windows.Forms.ComboBox();
            this.txtInterval = new System.Windows.Forms.TextBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblFillMissing = new System.Windows.Forms.Label();
            this.cbFillMissing = new System.Windows.Forms.ComboBox();
            this.cbFrequency = new System.Windows.Forms.ComboBox();
            this.lblAlign = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.btnSelectDatesExcel = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFetchData = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.rbSeries = new System.Windows.Forms.RadioButton();
            this.rbSnapshots = new System.Windows.Forms.RadioButton();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.dgvDates = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDelDates = new System.Windows.Forms.DataGridViewImageColumn();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAddDates = new System.Windows.Forms.Button();
            this.txtlook = new System.Windows.Forms.TextBox();
            this.lblFetching = new System.Windows.Forms.Label();
            this.pictIcn = new System.Windows.Forms.PictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDateInfo
            // 
            this.lbDateInfo.AutoSize = true;
            this.lbDateInfo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateInfo.ForeColor = System.Drawing.Color.Black;
            this.lbDateInfo.Location = new System.Drawing.Point(25, 92);
            this.lbDateInfo.Name = "lbDateInfo";
            this.lbDateInfo.Size = new System.Drawing.Size(97, 24);
            this.lbDateInfo.TabIndex = 0;
            this.lbDateInfo.Text = "Date &Type";
            // 
            // lblLookback
            // 
            this.lblLookback.AutoSize = true;
            this.lblLookback.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookback.ForeColor = System.Drawing.Color.Black;
            this.lblLookback.Location = new System.Drawing.Point(568, 421);
            this.lblLookback.Name = "lblLookback";
            this.lblLookback.Size = new System.Drawing.Size(97, 24);
            this.lblLookback.TabIndex = 16;
            this.lblLookback.Text = "Look &Back";
            // 
            // cbAlign
            // 
            this.cbAlign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAlign.FormattingEnabled = true;
            this.cbAlign.Location = new System.Drawing.Point(716, 322);
            this.cbAlign.Margin = new System.Windows.Forms.Padding(4);
            this.cbAlign.Name = "cbAlign";
            this.cbAlign.Size = new System.Drawing.Size(207, 24);
            this.cbAlign.TabIndex = 13;
            // 
            // txtInterval
            // 
            this.txtInterval.Location = new System.Drawing.Point(716, 369);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInterval.Multiline = true;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.Size = new System.Drawing.Size(207, 31);
            this.txtInterval.TabIndex = 15;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.ForeColor = System.Drawing.Color.Black;
            this.lblInterval.Location = new System.Drawing.Point(568, 369);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(76, 24);
            this.lblInterval.TabIndex = 14;
            this.lblInterval.Text = "&Interval";
            // 
            // lblFillMissing
            // 
            this.lblFillMissing.AutoSize = true;
            this.lblFillMissing.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillMissing.ForeColor = System.Drawing.Color.Black;
            this.lblFillMissing.Location = new System.Drawing.Point(568, 274);
            this.lblFillMissing.Name = "lblFillMissing";
            this.lblFillMissing.Size = new System.Drawing.Size(104, 24);
            this.lblFillMissing.TabIndex = 10;
            this.lblFillMissing.Text = "Fill &Missing";
            // 
            // cbFillMissing
            // 
            this.cbFillMissing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFillMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFillMissing.FormattingEnabled = true;
            this.cbFillMissing.Location = new System.Drawing.Point(716, 274);
            this.cbFillMissing.Margin = new System.Windows.Forms.Padding(4);
            this.cbFillMissing.Name = "cbFillMissing";
            this.cbFillMissing.Size = new System.Drawing.Size(207, 24);
            this.cbFillMissing.TabIndex = 11;
            // 
            // cbFrequency
            // 
            this.cbFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFrequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFrequency.FormattingEnabled = true;
            this.cbFrequency.Items.AddRange(new object[] {
            "daily",
            "weekly",
            "monthly",
            "quarterly",
            "yearly"});
            this.cbFrequency.Location = new System.Drawing.Point(716, 228);
            this.cbFrequency.Margin = new System.Windows.Forms.Padding(4);
            this.cbFrequency.Name = "cbFrequency";
            this.cbFrequency.Size = new System.Drawing.Size(207, 24);
            this.cbFrequency.TabIndex = 9;
            // 
            // lblAlign
            // 
            this.lblAlign.AutoSize = true;
            this.lblAlign.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlign.ForeColor = System.Drawing.Color.Black;
            this.lblAlign.Location = new System.Drawing.Point(568, 322);
            this.lblAlign.Name = "lblAlign";
            this.lblAlign.Size = new System.Drawing.Size(55, 24);
            this.lblAlign.TabIndex = 12;
            this.lblAlign.Text = "A&lign";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrequency.ForeColor = System.Drawing.Color.Black;
            this.lblFrequency.Location = new System.Drawing.Point(568, 228);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(111, 27);
            this.lblFrequency.TabIndex = 8;
            this.lblFrequency.Text = "F&requency";
            // 
            // btnSelectDatesExcel
            // 
            this.btnSelectDatesExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDatesExcel.Location = new System.Drawing.Point(716, 133);
            this.btnSelectDatesExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectDatesExcel.Name = "btnSelectDatesExcel";
            this.btnSelectDatesExcel.Size = new System.Drawing.Size(207, 46);
            this.btnSelectDatesExcel.TabIndex = 7;
            this.btnSelectDatesExcel.Text = "Select Fr&om Excel";
            this.btnSelectDatesExcel.UseVisualStyleBackColor = true;
            this.btnSelectDatesExcel.Visible = false;
            this.btnSelectDatesExcel.Click += new System.EventHandler(this.btnSelectDatesExcel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(29, 528);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Tag = "NoColor";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btnFetchData
            // 
            this.btnFetchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchData.ForeColor = System.Drawing.Color.Black;
            this.btnFetchData.Location = new System.Drawing.Point(757, 528);
            this.btnFetchData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFetchData.Name = "btnFetchData";
            this.btnFetchData.Size = new System.Drawing.Size(165, 46);
            this.btnFetchData.TabIndex = 20;
            this.btnFetchData.TabStop = false;
            this.btnFetchData.Text = "&Fetch Data";
            this.btnFetchData.UseVisualStyleBackColor = true;
            this.btnFetchData.Click += new System.EventHandler(this.btnFetchData_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(565, 528);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(165, 46);
            this.btnPrevious.TabIndex = 19;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "&Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(112, 137);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(216, 30);
            this.dtpDate.TabIndex = 5;
            // 
            // rbSeries
            // 
            this.rbSeries.AutoSize = true;
            this.rbSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSeries.ForeColor = System.Drawing.Color.Black;
            this.rbSeries.Location = new System.Drawing.Point(155, 92);
            this.rbSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSeries.Name = "rbSeries";
            this.rbSeries.Size = new System.Drawing.Size(89, 29);
            this.rbSeries.TabIndex = 1;
            this.rbSeries.TabStop = true;
            this.rbSeries.Text = "&Series";
            this.rbSeries.UseVisualStyleBackColor = true;
            this.rbSeries.CheckedChanged += new System.EventHandler(this.rbSeries_CheckedChanged_1);
            // 
            // rbSnapshots
            // 
            this.rbSnapshots.AutoSize = true;
            this.rbSnapshots.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSnapshots.ForeColor = System.Drawing.Color.Black;
            this.rbSnapshots.Location = new System.Drawing.Point(276, 92);
            this.rbSnapshots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSnapshots.Name = "rbSnapshots";
            this.rbSnapshots.Size = new System.Drawing.Size(118, 24);
            this.rbSnapshots.TabIndex = 2;
            this.rbSnapshots.TabStop = true;
            this.rbSnapshots.Text = "Sna&pshots";
            this.rbSnapshots.UseVisualStyleBackColor = true;
            this.rbSnapshots.CheckedChanged += new System.EventHandler(this.rbSnapshots_CheckedChanged);
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRange.ForeColor = System.Drawing.Color.Black;
            this.rbRange.Location = new System.Drawing.Point(435, 92);
            this.rbRange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(83, 24);
            this.rbRange.TabIndex = 3;
            this.rbRange.TabStop = true;
            this.rbRange.Text = "Ra&nge";
            this.rbRange.UseVisualStyleBackColor = true;
            this.rbRange.CheckedChanged += new System.EventHandler(this.rbRange_CheckedChanged);
            // 
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(25, 597);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(204, 20);
            this.lbl_auth_status.TabIndex = 68;
            this.lbl_auth_status.Tag = "EnvironmentLabel";
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // dgvDates
            // 
            this.dgvDates.AllowUserToAddRows = false;
            this.dgvDates.AllowUserToOrderColumns = true;
            this.dgvDates.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvDates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDates.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dgvDates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgDelDates});
            this.dgvDates.EnableHeadersVisualStyles = false;
            this.dgvDates.Location = new System.Drawing.Point(29, 192);
            this.dgvDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDates.MultiSelect = false;
            this.dgvDates.Name = "dgvDates";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDates.RowHeadersWidth = 99;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDates.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDates.RowTemplate.Height = 40;
            this.dgvDates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDates.Size = new System.Drawing.Size(488, 299);
            this.dgvDates.TabIndex = 69;
            this.dgvDates.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDates_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Selected Dates";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgDelDates
            // 
            this.dgDelDates.HeaderText = "";
            this.dgDelDates.Image = global::Franklin_Templeton_DAL.Properties.Resources.delete;
            this.dgDelDates.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dgDelDates.MinimumWidth = 8;
            this.dgDelDates.Name = "dgDelDates";
            this.dgDelDates.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDelDates.Width = 50;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(25, 137);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 24);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Da&te";
            // 
            // btnAddDates
            // 
            this.btnAddDates.AutoSize = true;
            this.btnAddDates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDates.Location = new System.Drawing.Point(360, 133);
            this.btnAddDates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddDates.Name = "btnAddDates";
            this.btnAddDates.Size = new System.Drawing.Size(157, 46);
            this.btnAddDates.TabIndex = 6;
            this.btnAddDates.TabStop = false;
            this.btnAddDates.Text = "&Add Date";
            this.btnAddDates.UseVisualStyleBackColor = false;
            this.btnAddDates.Click += new System.EventHandler(this.btnAddBlodDates);
            // 
            // txtlook
            // 
            this.txtlook.Location = new System.Drawing.Point(716, 418);
            this.txtlook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlook.Multiline = true;
            this.txtlook.Name = "txtlook";
            this.txtlook.Size = new System.Drawing.Size(207, 31);
            this.txtlook.TabIndex = 74;
            // 
            // lblFetching
            // 
            this.lblFetching.AutoSize = true;
            this.lblFetching.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFetching.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblFetching.Location = new System.Drawing.Point(272, 542);
            this.lblFetching.Name = "lblFetching";
            this.lblFetching.Size = new System.Drawing.Size(222, 17);
            this.lblFetching.TabIndex = 75;
            this.lblFetching.Tag = "NoColor";
            this.lblFetching.Text = "Please wait getting the data!!!";
            this.lblFetching.Visible = false;
            // 
            // pictIcn
            // 
            this.pictIcn.Image = global::Franklin_Templeton_DAL.Properties.Resources.franklin_templeton_logo;
            this.pictIcn.Location = new System.Drawing.Point(11, 0);
            this.pictIcn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictIcn.Name = "pictIcn";
            this.pictIcn.Size = new System.Drawing.Size(175, 74);
            this.pictIcn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictIcn.TabIndex = 77;
            this.pictIcn.TabStop = false;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.Color.Black;
            this.lblFormName.Location = new System.Drawing.Point(191, 27);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(152, 23);
            this.lblFormName.TabIndex = 76;
            this.lblFormName.Tag = "LabelBold";
            this.lblFormName.Text = "Date Selection";
            // 
            // DalDateInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 646);
            this.Controls.Add(this.pictIcn);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.lblFetching);
            this.Controls.Add(this.txtlook);
            this.Controls.Add(this.btnAddDates);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvDates);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.rbRange);
            this.Controls.Add(this.rbSnapshots);
            this.Controls.Add(this.rbSeries);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFetchData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelectDatesExcel);
            this.Controls.Add(this.lbDateInfo);
            this.Controls.Add(this.lblLookback);
            this.Controls.Add(this.cbAlign);
            this.Controls.Add(this.txtInterval);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.lblFillMissing);
            this.Controls.Add(this.cbFillMissing);
            this.Controls.Add(this.cbFrequency);
            this.Controls.Add(this.lblAlign);
            this.Controls.Add(this.lblFrequency);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DalDateInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.DalDateInputForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDateInfo;
        private System.Windows.Forms.Label lblLookback;
        private System.Windows.Forms.ComboBox cbAlign;
        private System.Windows.Forms.TextBox txtInterval;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblFillMissing;
        private System.Windows.Forms.ComboBox cbFillMissing;
        private System.Windows.Forms.ComboBox cbFrequency;
        private System.Windows.Forms.Label lblAlign;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Button btnSelectDatesExcel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFetchData;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.RadioButton rbSeries;
        private System.Windows.Forms.RadioButton rbSnapshots;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.DataGridView dgvDates;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAddDates;
        private System.Windows.Forms.TextBox txtlook;
        private System.Windows.Forms.Label lblFetching;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dgDelDates;
        private System.Windows.Forms.PictureBox pictIcn;
        private System.Windows.Forms.Label lblFormName;
    }
}