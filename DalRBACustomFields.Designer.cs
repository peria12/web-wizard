namespace Franklin_Templeton_DAL.InputForms
{
    partial class DalRBACustomFields
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbBetaProfile = new System.Windows.Forms.RadioButton();
            this.rbBenchmarkFactor = new System.Windows.Forms.RadioButton();
            this.rbFactorEntity = new System.Windows.Forms.RadioButton();
            this.rbBenchmark = new System.Windows.Forms.RadioButton();
            this.btnAddReturnEntity = new System.Windows.Forms.Button();
            this.cbReturnWindow = new System.Windows.Forms.ComboBox();
            this.txtDataThreshold = new System.Windows.Forms.TextBox();
            this.lblDataAvailableThreshold = new System.Windows.Forms.Label();
            this.lblReturnWindow = new System.Windows.Forms.Label();
            this.dgvRBAFields = new System.Windows.Forms.DataGridView();
            this.dgField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBtnParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtReturnIdVal = new System.Windows.Forms.TextBox();
            this.txtReturnIdName = new System.Windows.Forms.TextBox();
            this.lblIDName = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.pictIcn = new System.Windows.Forms.PictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBAFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(807, 679);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 44);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "&Save Parameters";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.SaveParameters);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(23, 679);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 44);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "NoColor";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.CancelRBAField);
            // 
            // rbBetaProfile
            // 
            this.rbBetaProfile.AutoSize = true;
            this.rbBetaProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBetaProfile.ForeColor = System.Drawing.Color.Black;
            this.rbBetaProfile.Location = new System.Drawing.Point(807, 92);
            this.rbBetaProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBetaProfile.Name = "rbBetaProfile";
            this.rbBetaProfile.Size = new System.Drawing.Size(185, 29);
            this.rbBetaProfile.TabIndex = 3;
            this.rbBetaProfile.TabStop = true;
            this.rbBetaProfile.Text = "Beta &Profile Entity";
            this.rbBetaProfile.UseVisualStyleBackColor = true;
            // 
            // rbBenchmarkFactor
            // 
            this.rbBenchmarkFactor.AutoSize = true;
            this.rbBenchmarkFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBenchmarkFactor.ForeColor = System.Drawing.Color.Black;
            this.rbBenchmarkFactor.Location = new System.Drawing.Point(503, 92);
            this.rbBenchmarkFactor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBenchmarkFactor.Name = "rbBenchmarkFactor";
            this.rbBenchmarkFactor.Size = new System.Drawing.Size(245, 29);
            this.rbBenchmarkFactor.TabIndex = 2;
            this.rbBenchmarkFactor.TabStop = true;
            this.rbBenchmarkFactor.Text = "Ben&chmark Factor Entity";
            this.rbBenchmarkFactor.UseVisualStyleBackColor = true;
            // 
            // rbFactorEntity
            // 
            this.rbFactorEntity.AutoSize = true;
            this.rbFactorEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFactorEntity.ForeColor = System.Drawing.Color.Black;
            this.rbFactorEntity.Location = new System.Drawing.Point(284, 92);
            this.rbFactorEntity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFactorEntity.Name = "rbFactorEntity";
            this.rbFactorEntity.Size = new System.Drawing.Size(141, 29);
            this.rbFactorEntity.TabIndex = 1;
            this.rbFactorEntity.TabStop = true;
            this.rbFactorEntity.Text = "&Factor Entity";
            this.rbFactorEntity.UseVisualStyleBackColor = true;
            // 
            // rbBenchmark
            // 
            this.rbBenchmark.AutoSize = true;
            this.rbBenchmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBenchmark.ForeColor = System.Drawing.Color.Black;
            this.rbBenchmark.Location = new System.Drawing.Point(23, 92);
            this.rbBenchmark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbBenchmark.Name = "rbBenchmark";
            this.rbBenchmark.Size = new System.Drawing.Size(185, 29);
            this.rbBenchmark.TabIndex = 0;
            this.rbBenchmark.TabStop = true;
            this.rbBenchmark.Text = "&Benchmark Entity";
            this.rbBenchmark.UseVisualStyleBackColor = true;
            // 
            // btnAddReturnEntity
            // 
            this.btnAddReturnEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturnEntity.Location = new System.Drawing.Point(820, 148);
            this.btnAddReturnEntity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddReturnEntity.Name = "btnAddReturnEntity";
            this.btnAddReturnEntity.Size = new System.Drawing.Size(169, 44);
            this.btnAddReturnEntity.TabIndex = 8;
            this.btnAddReturnEntity.Text = "&Add Key Values";
            this.btnAddReturnEntity.UseVisualStyleBackColor = true;
            this.btnAddReturnEntity.Click += new System.EventHandler(this.btnAddReturnEntity_Click);
            // 
            // cbReturnWindow
            // 
            this.cbReturnWindow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbReturnWindow.FormattingEnabled = true;
            this.cbReturnWindow.Items.AddRange(new object[] {
            "monthly"});
            this.cbReturnWindow.Location = new System.Drawing.Point(705, 634);
            this.cbReturnWindow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbReturnWindow.Name = "cbReturnWindow";
            this.cbReturnWindow.Size = new System.Drawing.Size(285, 24);
            this.cbReturnWindow.TabIndex = 12;
            // 
            // txtDataThreshold
            // 
            this.txtDataThreshold.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDataThreshold.Location = new System.Drawing.Point(276, 634);
            this.txtDataThreshold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDataThreshold.Name = "txtDataThreshold";
            this.txtDataThreshold.Size = new System.Drawing.Size(231, 22);
            this.txtDataThreshold.TabIndex = 10;
            // 
            // lblDataAvailableThreshold
            // 
            this.lblDataAvailableThreshold.AutoSize = true;
            this.lblDataAvailableThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAvailableThreshold.ForeColor = System.Drawing.Color.Black;
            this.lblDataAvailableThreshold.Location = new System.Drawing.Point(23, 634);
            this.lblDataAvailableThreshold.Name = "lblDataAvailableThreshold";
            this.lblDataAvailableThreshold.Size = new System.Drawing.Size(231, 25);
            this.lblDataAvailableThreshold.TabIndex = 9;
            this.lblDataAvailableThreshold.Text = "&Data Available Threshold";
            // 
            // lblReturnWindow
            // 
            this.lblReturnWindow.AutoSize = true;
            this.lblReturnWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnWindow.ForeColor = System.Drawing.Color.Black;
            this.lblReturnWindow.Location = new System.Drawing.Point(537, 634);
            this.lblReturnWindow.Name = "lblReturnWindow";
            this.lblReturnWindow.Size = new System.Drawing.Size(145, 25);
            this.lblReturnWindow.TabIndex = 11;
            this.lblReturnWindow.Text = "&Return Window";
            // 
            // dgvRBAFields
            // 
            this.dgvRBAFields.AllowUserToAddRows = false;
            this.dgvRBAFields.AllowUserToOrderColumns = true;
            this.dgvRBAFields.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvRBAFields.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRBAFields.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dgvRBAFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRBAFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRBAFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRBAFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgField,
            this.dgParams,
            this.dgBtnParams,
            this.dgDel});
            this.dgvRBAFields.EnableHeadersVisualStyles = false;
            this.dgvRBAFields.Location = new System.Drawing.Point(23, 204);
            this.dgvRBAFields.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvRBAFields.MultiSelect = false;
            this.dgvRBAFields.Name = "dgvRBAFields";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRBAFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRBAFields.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRBAFields.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRBAFields.RowTemplate.Height = 40;
            this.dgvRBAFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRBAFields.Size = new System.Drawing.Size(967, 399);
            this.dgvRBAFields.TabIndex = 99;
            this.dgvRBAFields.TabStop = false;
            this.dgvRBAFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRBAFields_CellContentClick);
            // 
            // dgField
            // 
            this.dgField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgField.HeaderText = "Key";
            this.dgField.MinimumWidth = 8;
            this.dgField.Name = "dgField";
            this.dgField.ReadOnly = true;
            this.dgField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgParams
            // 
            this.dgParams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgParams.HeaderText = "Value";
            this.dgParams.MinimumWidth = 8;
            this.dgParams.Name = "dgParams";
            this.dgParams.ReadOnly = true;
            // 
            // dgBtnParams
            // 
            this.dgBtnParams.HeaderText = "Entity Type";
            this.dgBtnParams.MinimumWidth = 8;
            this.dgBtnParams.Name = "dgBtnParams";
            this.dgBtnParams.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBtnParams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgBtnParams.Width = 260;
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
            // txtReturnIdVal
            // 
            this.txtReturnIdVal.Location = new System.Drawing.Point(412, 148);
            this.txtReturnIdVal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReturnIdVal.Name = "txtReturnIdVal";
            this.txtReturnIdVal.Size = new System.Drawing.Size(368, 22);
            this.txtReturnIdVal.TabIndex = 7;
            // 
            // txtReturnIdName
            // 
            this.txtReturnIdName.Location = new System.Drawing.Point(87, 148);
            this.txtReturnIdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReturnIdName.Name = "txtReturnIdName";
            this.txtReturnIdName.Size = new System.Drawing.Size(221, 22);
            this.txtReturnIdName.TabIndex = 5;
            // 
            // lblIDName
            // 
            this.lblIDName.AutoSize = true;
            this.lblIDName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDName.ForeColor = System.Drawing.Color.Black;
            this.lblIDName.Location = new System.Drawing.Point(23, 148);
            this.lblIDName.Name = "lblIDName";
            this.lblIDName.Size = new System.Drawing.Size(47, 25);
            this.lblIDName.TabIndex = 4;
            this.lblIDName.Text = "&Key";
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.ForeColor = System.Drawing.Color.Black;
            this.lblIdValue.Location = new System.Drawing.Point(328, 148);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(63, 25);
            this.lblIdValue.TabIndex = 6;
            this.lblIdValue.Text = "&Value";
            // 
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(24, 746);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(175, 17);
            this.lbl_auth_status.TabIndex = 37;
            this.lbl_auth_status.Tag = "EnvironmentLabel";
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // pictIcn
            // 
            this.pictIcn.Image = global::Franklin_Templeton_DAL.Properties.Resources.franklin_templeton_logo;
            this.pictIcn.Location = new System.Drawing.Point(1, 12);
            this.pictIcn.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.pictIcn.Name = "pictIcn";
            this.pictIcn.Size = new System.Drawing.Size(175, 74);
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
            this.lblFormName.Location = new System.Drawing.Point(182, 37);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(348, 23);
            this.lblFormName.TabIndex = 100;
            this.lblFormName.Tag = "LabelBold";
            this.lblFormName.Text = "Return Based Analytics Parameters";
            // 
            // DalRBACustomFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1012, 785);
            this.Controls.Add(this.pictIcn);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblIDName);
            this.Controls.Add(this.txtReturnIdVal);
            this.Controls.Add(this.txtReturnIdName);
            this.Controls.Add(this.dgvRBAFields);
            this.Controls.Add(this.lblReturnWindow);
            this.Controls.Add(this.cbReturnWindow);
            this.Controls.Add(this.lblDataAvailableThreshold);
            this.Controls.Add(this.txtDataThreshold);
            this.Controls.Add(this.btnAddReturnEntity);
            this.Controls.Add(this.rbBetaProfile);
            this.Controls.Add(this.rbBenchmarkFactor);
            this.Controls.Add(this.rbFactorEntity);
            this.Controls.Add(this.rbBenchmark);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DalRBACustomFields";
            this.Load += new System.EventHandler(this.DalRBACustomFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBAFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbBetaProfile;
        private System.Windows.Forms.RadioButton rbBenchmarkFactor;
        private System.Windows.Forms.RadioButton rbFactorEntity;
        private System.Windows.Forms.RadioButton rbBenchmark;
        private System.Windows.Forms.Button btnAddReturnEntity;
        private System.Windows.Forms.ComboBox cbReturnWindow;
        private System.Windows.Forms.TextBox txtDataThreshold;
        private System.Windows.Forms.Label lblDataAvailableThreshold;
        private System.Windows.Forms.Label lblReturnWindow;
        private System.Windows.Forms.DataGridView dgvRBAFields;
        private System.Windows.Forms.TextBox txtReturnIdVal;
        private System.Windows.Forms.TextBox txtReturnIdName;
        private System.Windows.Forms.Label lblIDName;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgField;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgBtnParams;
        private System.Windows.Forms.DataGridViewImageColumn dgDel;
        private System.Windows.Forms.PictureBox pictIcn;
        private System.Windows.Forms.Label lblFormName;
    }
}