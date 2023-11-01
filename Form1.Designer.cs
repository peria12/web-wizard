namespace Franklin_Templeton_DAL
{
    partial class DALEntryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DALEntryForm));
            this.dateinfo = new System.Windows.Forms.GroupBox();
            this.btn_select_dates = new System.Windows.Forms.Button();
            this.comboBox_Align = new System.Windows.Forms.ComboBox();
            this.comboBox_FillMissing = new System.Windows.Forms.ComboBox();
            this.comboBox_Dateinfo = new System.Windows.Forms.ComboBox();
            this.lbl_startdate = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_selectdate = new System.Windows.Forms.Label();
            this.selectdate = new System.Windows.Forms.DateTimePicker();
            this.lbl_align = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.textBox_Interval = new System.Windows.Forms.TextBox();
            this.lbl_Interval = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_file = new System.Windows.Forms.Label();
            this.textBox_selected_dates = new System.Windows.Forms.TextBox();
            this.lbl_Frequency = new System.Windows.Forms.Label();
            this.comboBox_frequency = new System.Windows.Forms.ComboBox();
            this.gbField = new System.Windows.Forms.GroupBox();
            this.checkBox_customInput = new System.Windows.Forms.CheckBox();
            this.checkBox_hasInputs = new System.Windows.Forms.CheckBox();
            this.fieldName_InputForm_lbl = new System.Windows.Forms.Label();
            this.txt_fieldname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_field = new System.Windows.Forms.Button();
            this.btn_genExcel = new System.Windows.Forms.Button();
            this.gbEntity = new System.Windows.Forms.GroupBox();
            this.btn_select_entity = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_entity = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idinfo = new System.Windows.Forms.GroupBox();
            this.id_Date = new System.Windows.Forms.DateTimePicker();
            this.iddate = new System.Windows.Forms.Label();
            this.txt_idType = new System.Windows.Forms.TextBox();
            this.idtype = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.dateinfo.SuspendLayout();
            this.gbField.SuspendLayout();
            this.gbEntity.SuspendLayout();
            this.idinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateinfo
            // 
            this.dateinfo.Controls.Add(this.btn_select_dates);
            this.dateinfo.Controls.Add(this.comboBox_Align);
            this.dateinfo.Controls.Add(this.comboBox_FillMissing);
            this.dateinfo.Controls.Add(this.comboBox_Dateinfo);
            this.dateinfo.Controls.Add(this.lbl_startdate);
            this.dateinfo.Controls.Add(this.startdate);
            this.dateinfo.Controls.Add(this.lbl_selectdate);
            this.dateinfo.Controls.Add(this.selectdate);
            this.dateinfo.Controls.Add(this.lbl_align);
            this.dateinfo.Controls.Add(this.monthCalendar);
            this.dateinfo.Controls.Add(this.textBox_Interval);
            this.dateinfo.Controls.Add(this.lbl_Interval);
            this.dateinfo.Controls.Add(this.end_date);
            this.dateinfo.Controls.Add(this.lbl_EndDate);
            this.dateinfo.Controls.Add(this.lbl_file);
            this.dateinfo.Controls.Add(this.textBox_selected_dates);
            this.dateinfo.Controls.Add(this.lbl_Frequency);
            this.dateinfo.Controls.Add(this.comboBox_frequency);
            this.dateinfo.Location = new System.Drawing.Point(13, 15);
            this.dateinfo.Margin = new System.Windows.Forms.Padding(4);
            this.dateinfo.Name = "dateinfo";
            this.dateinfo.Padding = new System.Windows.Forms.Padding(4);
            this.dateinfo.Size = new System.Drawing.Size(973, 260);
            this.dateinfo.TabIndex = 29;
            this.dateinfo.TabStop = false;
            this.dateinfo.Text = "Date Info";
            // 
            // btn_select_dates
            // 
            this.btn_select_dates.Location = new System.Drawing.Point(147, 19);
            this.btn_select_dates.Name = "btn_select_dates";
            this.btn_select_dates.Size = new System.Drawing.Size(162, 24);
            this.btn_select_dates.TabIndex = 28;
            this.btn_select_dates.Text = "Select Date From Excel";
            this.btn_select_dates.UseVisualStyleBackColor = true;
            this.btn_select_dates.Visible = false;
            this.btn_select_dates.Click += new System.EventHandler(this.SelectDatesFromExcel);
            // 
            // comboBox_Align
            // 
            this.comboBox_Align.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Align.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Align.FormattingEnabled = true;
            this.comboBox_Align.Location = new System.Drawing.Point(837, 17);
            this.comboBox_Align.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Align.Name = "comboBox_Align";
            this.comboBox_Align.Size = new System.Drawing.Size(128, 24);
            this.comboBox_Align.TabIndex = 5;
            this.comboBox_Align.Visible = false;
            // 
            // comboBox_FillMissing
            // 
            this.comboBox_FillMissing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FillMissing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_FillMissing.FormattingEnabled = true;
            this.comboBox_FillMissing.Location = new System.Drawing.Point(681, 16);
            this.comboBox_FillMissing.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_FillMissing.Name = "comboBox_FillMissing";
            this.comboBox_FillMissing.Size = new System.Drawing.Size(91, 24);
            this.comboBox_FillMissing.TabIndex = 4;
            this.comboBox_FillMissing.Visible = false;
            // 
            // comboBox_Dateinfo
            // 
            this.comboBox_Dateinfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Dateinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Dateinfo.FormattingEnabled = true;
            this.comboBox_Dateinfo.Location = new System.Drawing.Point(8, 20);
            this.comboBox_Dateinfo.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Dateinfo.Name = "comboBox_Dateinfo";
            this.comboBox_Dateinfo.Size = new System.Drawing.Size(132, 24);
            this.comboBox_Dateinfo.TabIndex = 1;
            this.comboBox_Dateinfo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Dateinfo_SelectedIndexChanged);
            // 
            // lbl_startdate
            // 
            this.lbl_startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_startdate.Location = new System.Drawing.Point(29, 71);
            this.lbl_startdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_startdate.Name = "lbl_startdate";
            this.lbl_startdate.Size = new System.Drawing.Size(109, 25);
            this.lbl_startdate.TabIndex = 17;
            this.lbl_startdate.Text = "Start Date";
            this.lbl_startdate.Visible = false;
            // 
            // startdate
            // 
            this.startdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(181, 71);
            this.startdate.Margin = new System.Windows.Forms.Padding(4);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(203, 23);
            this.startdate.TabIndex = 7;
            this.startdate.Visible = false;
            // 
            // lbl_selectdate
            // 
            this.lbl_selectdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectdate.Location = new System.Drawing.Point(29, 71);
            this.lbl_selectdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_selectdate.Name = "lbl_selectdate";
            this.lbl_selectdate.Size = new System.Drawing.Size(109, 25);
            this.lbl_selectdate.TabIndex = 17;
            this.lbl_selectdate.Text = "Date";
            this.lbl_selectdate.Visible = false;
            // 
            // selectdate
            // 
            this.selectdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectdate.Location = new System.Drawing.Point(181, 71);
            this.selectdate.Margin = new System.Windows.Forms.Padding(4);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(203, 23);
            this.selectdate.TabIndex = 16;
            this.selectdate.Visible = false;
            // 
            // lbl_align
            // 
            this.lbl_align.AutoSize = true;
            this.lbl_align.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_align.Location = new System.Drawing.Point(789, 21);
            this.lbl_align.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_align.Name = "lbl_align";
            this.lbl_align.Size = new System.Drawing.Size(39, 17);
            this.lbl_align.TabIndex = 27;
            this.lbl_align.Text = "Align";
            this.lbl_align.Visible = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar.ForeColor = System.Drawing.Color.Red;
            this.monthCalendar.Location = new System.Drawing.Point(8, 49);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar.MaxSelectionCount = 30;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            this.monthCalendar.TitleBackColor = System.Drawing.SystemColors.Highlight;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.monthCalendar_MouseDown);
            // 
            // textBox_Interval
            // 
            this.textBox_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Interval.Location = new System.Drawing.Point(512, 17);
            this.textBox_Interval.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Interval.Name = "textBox_Interval";
            this.textBox_Interval.Size = new System.Drawing.Size(84, 23);
            this.textBox_Interval.TabIndex = 3;
            this.textBox_Interval.Visible = false;
            // 
            // lbl_Interval
            // 
            this.lbl_Interval.AutoSize = true;
            this.lbl_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Interval.Location = new System.Drawing.Point(443, 21);
            this.lbl_Interval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Interval.Name = "lbl_Interval";
            this.lbl_Interval.Size = new System.Drawing.Size(54, 17);
            this.lbl_Interval.TabIndex = 22;
            this.lbl_Interval.Text = "Interval";
            this.lbl_Interval.Visible = false;
            // 
            // end_date
            // 
            this.end_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end_date.Location = new System.Drawing.Point(596, 71);
            this.end_date.Margin = new System.Windows.Forms.Padding(4);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(203, 23);
            this.end_date.TabIndex = 8;
            this.end_date.Visible = false;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndDate.Location = new System.Drawing.Point(443, 71);
            this.lbl_EndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(103, 25);
            this.lbl_EndDate.TabIndex = 18;
            this.lbl_EndDate.Text = "End Date";
            this.lbl_EndDate.Visible = false;
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_file.Location = new System.Drawing.Point(604, 23);
            this.lbl_file.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(69, 17);
            this.lbl_file.TabIndex = 24;
            this.lbl_file.Text = "Fill Mising";
            this.lbl_file.Visible = false;
            // 
            // textBox_selected_dates
            // 
            this.textBox_selected_dates.Location = new System.Drawing.Point(325, 49);
            this.textBox_selected_dates.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.textBox_selected_dates.Multiline = true;
            this.textBox_selected_dates.Name = "textBox_selected_dates";
            this.textBox_selected_dates.ReadOnly = true;
            this.textBox_selected_dates.Size = new System.Drawing.Size(641, 197);
            this.textBox_selected_dates.TabIndex = 9;
            this.textBox_selected_dates.TabStop = false;
            // 
            // lbl_Frequency
            // 
            this.lbl_Frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Frequency.Location = new System.Drawing.Point(163, 23);
            this.lbl_Frequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Frequency.Name = "lbl_Frequency";
            this.lbl_Frequency.Size = new System.Drawing.Size(84, 25);
            this.lbl_Frequency.TabIndex = 21;
            this.lbl_Frequency.Text = "Frequency";
            this.lbl_Frequency.Visible = false;
            // 
            // comboBox_frequency
            // 
            this.comboBox_frequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_frequency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_frequency.FormattingEnabled = true;
            this.comboBox_frequency.Location = new System.Drawing.Point(316, 20);
            this.comboBox_frequency.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_frequency.Name = "comboBox_frequency";
            this.comboBox_frequency.Size = new System.Drawing.Size(112, 24);
            this.comboBox_frequency.TabIndex = 2;
            this.comboBox_frequency.Visible = false;
            // 
            // gbField
            // 
            this.gbField.Controls.Add(this.checkBox_customInput);
            this.gbField.Controls.Add(this.checkBox_hasInputs);
            this.gbField.Controls.Add(this.fieldName_InputForm_lbl);
            this.gbField.Controls.Add(this.txt_fieldname);
            this.gbField.Controls.Add(this.label5);
            this.gbField.Controls.Add(this.listView);
            this.gbField.Controls.Add(this.label4);
            this.gbField.Controls.Add(this.label3);
            this.gbField.Controls.Add(this.label1);
            this.gbField.Controls.Add(this.btn_add_field);
            this.gbField.Location = new System.Drawing.Point(13, 282);
            this.gbField.Margin = new System.Windows.Forms.Padding(4);
            this.gbField.Name = "gbField";
            this.gbField.Padding = new System.Windows.Forms.Padding(4);
            this.gbField.Size = new System.Drawing.Size(973, 165);
            this.gbField.TabIndex = 30;
            this.gbField.TabStop = false;
            this.gbField.Text = "Fields";
            // 
            // checkBox_customInput
            // 
            this.checkBox_customInput.AutoSize = true;
            this.checkBox_customInput.Location = new System.Drawing.Point(732, 78);
            this.checkBox_customInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_customInput.Name = "checkBox_customInput";
            this.checkBox_customInput.Size = new System.Drawing.Size(112, 20);
            this.checkBox_customInput.TabIndex = 26;
            this.checkBox_customInput.Text = "Custom Inputs";
            this.checkBox_customInput.UseVisualStyleBackColor = true;
            this.checkBox_customInput.CheckedChanged += new System.EventHandler(this.checkBox_customInput_CheckedChanged);
            // 
            // checkBox_hasInputs
            // 
            this.checkBox_hasInputs.AutoSize = true;
            this.checkBox_hasInputs.Location = new System.Drawing.Point(635, 78);
            this.checkBox_hasInputs.Name = "checkBox_hasInputs";
            this.checkBox_hasInputs.Size = new System.Drawing.Size(92, 20);
            this.checkBox_hasInputs.TabIndex = 25;
            this.checkBox_hasInputs.Text = "Has Inputs";
            this.checkBox_hasInputs.UseVisualStyleBackColor = true;
            this.checkBox_hasInputs.CheckedChanged += new System.EventHandler(this.checkBox_hasInputs_CheckedChanged);
            // 
            // fieldName_InputForm_lbl
            // 
            this.fieldName_InputForm_lbl.AutoSize = true;
            this.fieldName_InputForm_lbl.Location = new System.Drawing.Point(611, 34);
            this.fieldName_InputForm_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fieldName_InputForm_lbl.Name = "fieldName_InputForm_lbl";
            this.fieldName_InputForm_lbl.Size = new System.Drawing.Size(77, 16);
            this.fieldName_InputForm_lbl.TabIndex = 24;
            this.fieldName_InputForm_lbl.Text = "Field Name";
            // 
            // txt_fieldname
            // 
            this.txt_fieldname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_fieldname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_fieldname.Location = new System.Drawing.Point(697, 31);
            this.txt_fieldname.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.txt_fieldname.Name = "txt_fieldname";
            this.txt_fieldname.Size = new System.Drawing.Size(257, 22);
            this.txt_fieldname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(772, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 22;
            // 
            // listView
            // 
            this.listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader5,
            this.columnHeader6});
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.HideSelection = false;
            this.listView.HoverSelection = true;
            this.listView.LabelEdit = true;
            this.listView.Location = new System.Drawing.Point(8, 23);
            this.listView.Margin = new System.Windows.Forms.Padding(4);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(593, 130);
            this.listView.TabIndex = 18;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Field Name";
            this.columnHeader1.Width = 281;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Action";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Action";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(789, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(773, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // btn_add_field
            // 
            this.btn_add_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_field.Location = new System.Drawing.Point(868, 74);
            this.btn_add_field.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_add_field.Name = "btn_add_field";
            this.btn_add_field.Size = new System.Drawing.Size(88, 31);
            this.btn_add_field.TabIndex = 11;
            this.btn_add_field.Text = "Add Field";
            this.btn_add_field.UseVisualStyleBackColor = true;
            this.btn_add_field.Click += new System.EventHandler(this.btn_add_field_Click);
            // 
            // btn_genExcel
            // 
            this.btn_genExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_genExcel.Location = new System.Drawing.Point(869, 623);
            this.btn_genExcel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btn_genExcel.Name = "btn_genExcel";
            this.btn_genExcel.Size = new System.Drawing.Size(117, 31);
            this.btn_genExcel.TabIndex = 15;
            this.btn_genExcel.Text = "Fetch Data";
            this.btn_genExcel.UseVisualStyleBackColor = true;
            this.btn_genExcel.Click += new System.EventHandler(this.btn_genExcel_Click);
            // 
            // gbEntity
            // 
            this.gbEntity.Controls.Add(this.btn_select_entity);
            this.gbEntity.Controls.Add(this.button1);
            this.gbEntity.Controls.Add(this.listView_entity);
            this.gbEntity.Location = new System.Drawing.Point(317, 454);
            this.gbEntity.Margin = new System.Windows.Forms.Padding(4);
            this.gbEntity.Name = "gbEntity";
            this.gbEntity.Padding = new System.Windows.Forms.Padding(4);
            this.gbEntity.Size = new System.Drawing.Size(669, 164);
            this.gbEntity.TabIndex = 32;
            this.gbEntity.TabStop = false;
            this.gbEntity.Text = "Entities";
            // 
            // btn_select_entity
            // 
            this.btn_select_entity.Location = new System.Drawing.Point(521, 69);
            this.btn_select_entity.Name = "btn_select_entity";
            this.btn_select_entity.Size = new System.Drawing.Size(131, 36);
            this.btn_select_entity.TabIndex = 21;
            this.btn_select_entity.Text = "Select From Excel";
            this.btn_select_entity.UseVisualStyleBackColor = true;
            this.btn_select_entity.Click += new System.EventHandler(this.SelectEntityFromExcel);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(521, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Entity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowEntityPopup);
            // 
            // listView_entity
            // 
            this.listView_entity.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_entity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader15,
            this.columnHeader16});
            this.listView_entity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_entity.FullRowSelect = true;
            this.listView_entity.GridLines = true;
            this.listView_entity.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_entity.HideSelection = false;
            this.listView_entity.HoverSelection = true;
            this.listView_entity.LabelEdit = true;
            this.listView_entity.Location = new System.Drawing.Point(8, 20);
            this.listView_entity.Margin = new System.Windows.Forms.Padding(4);
            this.listView_entity.Name = "listView_entity";
            this.listView_entity.Size = new System.Drawing.Size(487, 131);
            this.listView_entity.TabIndex = 20;
            this.listView_entity.UseCompatibleStateImageBehavior = false;
            this.listView_entity.View = System.Windows.Forms.View.Details;
            this.listView_entity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView_entity_MouseUp);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Entity Name";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 245;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Action";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 76;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Action";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 76;
            // 
            // idinfo
            // 
            this.idinfo.Controls.Add(this.id_Date);
            this.idinfo.Controls.Add(this.iddate);
            this.idinfo.Controls.Add(this.txt_idType);
            this.idinfo.Controls.Add(this.idtype);
            this.idinfo.Location = new System.Drawing.Point(13, 454);
            this.idinfo.Margin = new System.Windows.Forms.Padding(4);
            this.idinfo.Name = "idinfo";
            this.idinfo.Padding = new System.Windows.Forms.Padding(4);
            this.idinfo.Size = new System.Drawing.Size(296, 164);
            this.idinfo.TabIndex = 31;
            this.idinfo.TabStop = false;
            this.idinfo.Text = "Id Info";
            // 
            // id_Date
            // 
            this.id_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.id_Date.Location = new System.Drawing.Point(77, 106);
            this.id_Date.Margin = new System.Windows.Forms.Padding(4);
            this.id_Date.Name = "id_Date";
            this.id_Date.Size = new System.Drawing.Size(203, 23);
            this.id_Date.TabIndex = 13;
            this.id_Date.ValueChanged += new System.EventHandler(this.id_Date_ValueChanged);
            // 
            // iddate
            // 
            this.iddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iddate.Location = new System.Drawing.Point(8, 111);
            this.iddate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iddate.Name = "iddate";
            this.iddate.Size = new System.Drawing.Size(103, 25);
            this.iddate.TabIndex = 20;
            this.iddate.Text = "Id Date";
            // 
            // txt_idType
            // 
            this.txt_idType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_idType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_idType.Location = new System.Drawing.Point(77, 34);
            this.txt_idType.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idType.Name = "txt_idType";
            this.txt_idType.Size = new System.Drawing.Size(203, 22);
            this.txt_idType.TabIndex = 12;
            // 
            // idtype
            // 
            this.idtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtype.Location = new System.Drawing.Point(8, 37);
            this.idtype.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idtype.Name = "idtype";
            this.idtype.Size = new System.Drawing.Size(109, 25);
            this.idtype.TabIndex = 18;
            this.idtype.Text = "Id Type";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 623);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 30);
            this.button2.TabIndex = 33;
            this.button2.Text = "Switch to Input Editor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SwitchToJsonEditor);
            // 
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(536, 631);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(175, 17);
            this.lbl_auth_status.TabIndex = 34;
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn1.HeaderText = "Edit Action";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Delete Action";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 69;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(204, 625);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(118, 29);
            this.btn_Clear.TabIndex = 35;
            this.btn_Clear.Text = "Clear Input";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.ClearInputValues);
            // 
            // DALEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 665);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.idinfo);
            this.Controls.Add(this.gbEntity);
            this.Controls.Add(this.btn_genExcel);
            this.Controls.Add(this.dateinfo);
            this.Controls.Add(this.gbField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DALEntryForm";
            this.Text = "DAL Input Form";
            this.dateinfo.ResumeLayout(false);
            this.dateinfo.PerformLayout();
            this.gbField.ResumeLayout(false);
            this.gbField.PerformLayout();
            this.gbEntity.ResumeLayout(false);
            this.idinfo.ResumeLayout(false);
            this.idinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion             
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox dateinfo;
        private System.Windows.Forms.ComboBox comboBox_Align;
        private System.Windows.Forms.ComboBox comboBox_FillMissing;
        private System.Windows.Forms.ComboBox comboBox_Dateinfo;
        private System.Windows.Forms.Label lbl_startdate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label lbl_selectdate;
        private System.Windows.Forms.DateTimePicker selectdate;
        private System.Windows.Forms.Label lbl_align;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TextBox textBox_Interval;
        private System.Windows.Forms.Label lbl_Interval;
        private System.Windows.Forms.DateTimePicker end_date;
        private System.Windows.Forms.Label lbl_EndDate;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.TextBox textBox_selected_dates;
        private System.Windows.Forms.Label lbl_Frequency;
        private System.Windows.Forms.ComboBox comboBox_frequency;
        private System.Windows.Forms.GroupBox gbField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_field;
        private System.Windows.Forms.Button btn_genExcel;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox gbEntity;
        private System.Windows.Forms.ListView listView_entity;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox idinfo;
        private System.Windows.Forms.Label idtype;
        private System.Windows.Forms.Label iddate;
        private System.Windows.Forms.TextBox txt_idType;
        private System.Windows.Forms.DateTimePicker id_Date;
        private System.Windows.Forms.TextBox txt_fieldname;
        private System.Windows.Forms.Label fieldName_InputForm_lbl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.Button btn_select_entity;
        private System.Windows.Forms.Button btn_select_dates;
        private System.Windows.Forms.CheckBox checkBox_hasInputs;
        private System.Windows.Forms.CheckBox checkBox_customInput;
        private System.Windows.Forms.Button btn_Clear;
    }
}