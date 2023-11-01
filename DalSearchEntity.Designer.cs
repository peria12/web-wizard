namespace Franklin_Templeton_DAL.InputForms
{
    partial class DalSearchEntity
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
            this.dgvSearchEntity = new System.Windows.Forms.DataGridView();
            this.Chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgEntities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_auth_status = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelectEntity = new System.Windows.Forms.Button();
            this.pictIcn = new System.Windows.Forms.PictureBox();
            this.lblFormName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearchEntity
            // 
            this.dgvSearchEntity.AllowUserToAddRows = false;
            this.dgvSearchEntity.AllowUserToDeleteRows = false;
            this.dgvSearchEntity.AllowUserToOrderColumns = true;
            this.dgvSearchEntity.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvSearchEntity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchEntity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dgvSearchEntity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchEntity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chk,
            this.dgEntities,
            this.dgDescription});
            this.dgvSearchEntity.EnableHeadersVisualStyles = false;
            this.dgvSearchEntity.Location = new System.Drawing.Point(20, 110);
            this.dgvSearchEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSearchEntity.MultiSelect = false;
            this.dgvSearchEntity.Name = "dgvSearchEntity";
            this.dgvSearchEntity.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSearchEntity.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchEntity.RowTemplate.Height = 40;
            this.dgvSearchEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchEntity.Size = new System.Drawing.Size(1213, 487);
            this.dgvSearchEntity.TabIndex = 100;
            this.dgvSearchEntity.TabStop = false;
            // 
            // Chk
            // 
            this.Chk.HeaderText = "Select";
            this.Chk.MinimumWidth = 6;
            this.Chk.Name = "Chk";
            this.Chk.Width = 125;
            // 
            // dgEntities
            // 
            this.dgEntities.HeaderText = "Entities";
            this.dgEntities.MinimumWidth = 8;
            this.dgEntities.Name = "dgEntities";
            this.dgEntities.ReadOnly = true;
            this.dgEntities.Width = 300;
            // 
            // dgDescription
            // 
            this.dgDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDescription.HeaderText = "Description";
            this.dgDescription.MinimumWidth = 350;
            this.dgDescription.Name = "dgDescription";
            this.dgDescription.ReadOnly = true;
            // 
            // lbl_auth_status
            // 
            this.lbl_auth_status.AutoSize = true;
            this.lbl_auth_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_auth_status.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_auth_status.Location = new System.Drawing.Point(20, 684);
            this.lbl_auth_status.Name = "lbl_auth_status";
            this.lbl_auth_status.Size = new System.Drawing.Size(204, 20);
            this.lbl_auth_status.TabIndex = 102;
            this.lbl_auth_status.Tag = "EnvironmentLabel";
            this.lbl_auth_status.Text = "Authenticated into DAL";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(20, 618);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 46);
            this.btnCancel.TabIndex = 103;
            this.btnCancel.TabStop = false;
            this.btnCancel.Tag = "NoColor";
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelectEntity
            // 
            this.btnSelectEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectEntity.Location = new System.Drawing.Point(1081, 618);
            this.btnSelectEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectEntity.Name = "btnSelectEntity";
            this.btnSelectEntity.Size = new System.Drawing.Size(152, 46);
            this.btnSelectEntity.TabIndex = 104;
            this.btnSelectEntity.Text = "Select Entity";
            this.btnSelectEntity.UseVisualStyleBackColor = true;
            this.btnSelectEntity.Click += new System.EventHandler(this.btnSelectEntity_Click);
            // 
            // pictIcn
            // 
            this.pictIcn.Image = global::Franklin_Templeton_DAL.Properties.Resources.franklin_templeton_logo;
            this.pictIcn.Location = new System.Drawing.Point(9, 14);
            this.pictIcn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictIcn.Name = "pictIcn";
            this.pictIcn.Size = new System.Drawing.Size(175, 74);
            this.pictIcn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictIcn.TabIndex = 106;
            this.pictIcn.TabStop = false;
            // 
            // lblFormName
            // 
            this.lblFormName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormName.AutoSize = true;
            this.lblFormName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormName.ForeColor = System.Drawing.Color.Black;
            this.lblFormName.Location = new System.Drawing.Point(188, 39);
            this.lblFormName.Name = "lblFormName";
            this.lblFormName.Size = new System.Drawing.Size(230, 23);
            this.lblFormName.TabIndex = 105;
            this.lblFormName.Tag = "LabelBold";
            this.lblFormName.Text = "Search Entity Selection";
            // 
            // DalSearchEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 725);
            this.Controls.Add(this.pictIcn);
            this.Controls.Add(this.lblFormName);
            this.Controls.Add(this.btnSelectEntity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbl_auth_status);
            this.Controls.Add(this.dgvSearchEntity);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DalSearchEntity";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictIcn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearchEntity;
        private System.Windows.Forms.Label lbl_auth_status;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntities;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDescription;
        private System.Windows.Forms.Button btnSelectEntity;
        private System.Windows.Forms.PictureBox pictIcn;
        private System.Windows.Forms.Label lblFormName;
    }
}