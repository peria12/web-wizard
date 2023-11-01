namespace Franklin_Templeton_DAL.InputForms
{
    partial class ListFields
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
            this.dgvFields = new System.Windows.Forms.DataGridView();
            this.dgField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.lblFields = new System.Windows.Forms.Label();
            this.pictIcn = new System.Windows.Forms.PictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFields
            // 
            this.dgvFields.AllowUserToAddRows = false;
            this.dgvFields.AllowUserToOrderColumns = true;
            this.dgvFields.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFields.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFields.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
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
            this.dgvFields.ColumnHeadersVisible = false;
            this.dgvFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgField});
            this.dgvFields.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFields.EnableHeadersVisualStyles = false;
            this.dgvFields.Location = new System.Drawing.Point(25, 162);
            this.dgvFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFields.MultiSelect = false;
            this.dgvFields.Name = "dgvFields";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFields.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFields.RowHeadersVisible = false;
            this.dgvFields.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFields.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFields.RowTemplate.Height = 40;
            this.dgvFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFields.Size = new System.Drawing.Size(1071, 518);
            this.dgvFields.TabIndex = 10;
            this.dgvFields.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFields_CellContentDoubleClick);
            this.dgvFields.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dgvFields_SortCompare);
            // 
            // dgField
            // 
            this.dgField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgField.HeaderText = "Fields";
            this.dgField.MinimumWidth = 8;
            this.dgField.Name = "dgField";
            this.dgField.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(25, 692);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "NoColor";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(20, 756);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(204, 20);
            this.lbl_auth_status.TabIndex = 38;
            this.lbl_auth_status.Tag = "EnvironmentLabel";
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(576, 107);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "&Search Field";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnSearchField);
            // 
            // txtFields
            // 
            this.txtFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFields.Location = new System.Drawing.Point(161, 112);
            this.txtFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFields.Name = "txtFields";
            this.txtFields.Size = new System.Drawing.Size(389, 30);
            this.txtFields.TabIndex = 1;
            // 
            // lblFields
            // 
            this.lblFields.AutoSize = true;
            this.lblFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFields.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFields.Location = new System.Drawing.Point(23, 113);
            this.lblFields.Name = "lblFields";
            this.lblFields.Size = new System.Drawing.Size(54, 25);
            this.lblFields.TabIndex = 0;
            this.lblFields.Text = "&Field";
            // 
            // pictIcn
            // 
            this.pictIcn.Image = global::Franklin_Templeton_DAL.Properties.Resources.franklin_templeton_logo;
            this.pictIcn.Location = new System.Drawing.Point(4, 14);
            this.pictIcn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictIcn.Name = "pictIcn";
            this.pictIcn.Size = new System.Drawing.Size(175, 74);
            this.pictIcn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictIcn.TabIndex = 40;
            this.pictIcn.TabStop = false;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.Color.Black;
            this.lblFormName.Location = new System.Drawing.Point(184, 40);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(125, 23);
            this.lblFormName.TabIndex = 39;
            this.lblFormName.Tag = "LabelBold";
            this.lblFormName.Text = "List of Fields";
            // 
            // ListFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1128, 786);
            this.Controls.Add(this.pictIcn);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFields);
            this.Controls.Add(this.lblFields);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.dgvFields);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListFields";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ListFields_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFields;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgField;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.Label lblFields;
        private System.Windows.Forms.PictureBox pictIcn;
        private System.Windows.Forms.Label lblFormName;
    }
}