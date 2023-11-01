namespace Franklin_Templeton_DAL.InputForms
{
    partial class DalInputFieldsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DalInputFieldsForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblFields = new System.Windows.Forms.Label();
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.dgField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgBtnParams = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgDel = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnListFields = new System.Windows.Forms.Button();
            this.pictIcn = new System.Windows.Forms.PictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(12, 593);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 44);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "NoColor";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFields.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFields.Location = new System.Drawing.Point(16, 113);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(54, 25);
            this.lblFields.TabIndex = 0;
            this.lblFields.Text = "&Field";
            // 
            // dgvFields
            // 
            this.dgvFields.AllowUserToAddRows = false;
            this.dgvFields.AllowUserToOrderColumns = true;
            this.dgvFields.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvFields.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFields.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvFields.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFields.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgField,
            this.dgParams,
            this.dgBtnParams,
            this.dgDel});
            this.dgvFields.EnableHeadersVisualStyles = false;
            this.dgvFields.Location = new System.Drawing.Point(16, 164);
            this.dgvFields.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.dgvFields.MultiSelect = false;
            this.dgvFields.Name = "dgvFields";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(105)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFields.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFields.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFields.RowTemplate.Height = 40;
            this.dgvFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFields.Size = new System.Drawing.Size(1057, 407);
            this.dgvFields.TabIndex = 99;
            this.dgvFields.TabStop = false;
            this.dgvFields.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFields_CellContentClick);
            // 
            // dgField
            // 
            this.dgField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgField.HeaderText = "Fields";
            this.dgField.MinimumWidth = 8;
            this.dgField.Name = "dgField";
            this.dgField.ReadOnly = true;
            this.dgField.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgParams
            // 
            this.dgParams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgParams.HeaderText = "Parameters";
            this.dgParams.MinimumWidth = 8;
            this.dgParams.Name = "dgParams";
            this.dgParams.ReadOnly = true;
            // 
            // dgBtnParams
            // 
            this.dgBtnParams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgBtnParams.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgBtnParams.HeaderText = "";
            this.dgBtnParams.MinimumWidth = 8;
            this.dgBtnParams.Name = "dgBtnParams";
            this.dgBtnParams.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBtnParams.Text = "Parameter";
            this.dgBtnParams.UseColumnTextForButtonValue = true;
            this.dgBtnParams.Width = 150;
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
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(12, 657);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(204, 20);
            this.lbl_auth_status.TabIndex = 36;
            this.lbl_auth_status.Tag = "EnvironmentLabel";
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(908, 593);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(165, 44);
            this.btnNext.TabIndex = 5;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(513, 112);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 44);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "&Add Field";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFields
            // 
            this.txtFields.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFields.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFields.Location = new System.Drawing.Point(76, 116);
            this.txtFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFields.Name = "txtFields";
            this.txtFields.Size = new System.Drawing.Size(404, 22);
            this.txtFields.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Franklin_Templeton_DAL.Properties.Resources.delete;
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // btnListFields
            // 
            this.btnListFields.BackgroundImage = global::Franklin_Templeton_DAL.Properties.Resources.ImgList;
            this.btnListFields.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnListFields.Location = new System.Drawing.Point(701, 112);
            this.btnListFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListFields.Name = "btnListFields";
            this.btnListFields.Size = new System.Drawing.Size(40, 44);
            this.btnListFields.TabIndex = 3;
            this.btnListFields.TabStop = false;
            this.btnListFields.Tag = "NoColor";
            this.btnListFields.UseVisualStyleBackColor = true;
            this.btnListFields.Click += new System.EventHandler(this.btnListFields_Click);
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
            this.lblFormName.Location = new System.Drawing.Point(181, 36);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(152, 23);
            this.lblFormName.TabIndex = 100;
            this.lblFormName.Tag = "LabelBold";
            this.lblFormName.Text = "Field Selection";
            // 
            // DalInputFieldsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1095, 692);
            this.ControlBox = false;
            this.Controls.Add(this.pictIcn);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.txtFields);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.btnListFields);
            this.Controls.Add(this.dgvFields);
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.btnCancel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "DalInputFieldsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.Button btnListFields;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgField;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgParams;
        private System.Windows.Forms.DataGridViewButtonColumn dgBtnParams;
        private System.Windows.Forms.DataGridViewImageColumn dgDel;
        private System.Windows.Forms.PictureBox pictIcn;
        private System.Windows.Forms.Label lblFormName;
    }
}