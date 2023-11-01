namespace Franklin_Templeton_DAL.InputForms
{
    partial class DalInputRBACustomEntities
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblParamaterForm = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddEntity = new System.Windows.Forms.Button();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.lblEntityName = new System.Windows.Forms.Label();
            this.txtReturnIdVal = new System.Windows.Forms.TextBox();
            this.txtReturnIdName = new System.Windows.Forms.TextBox();
            this.btnAddCustomEntity = new System.Windows.Forms.Button();
            this.dgvRBAEntity = new System.Windows.Forms.DataGridView();
            this.dgEntity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCustomInput = new System.Windows.Forms.TextBox();
            this.lblCustom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBAEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParamaterForm
            // 
            this.lblParamaterForm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblParamaterForm.AutoSize = true;
            this.lblParamaterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParamaterForm.ForeColor = System.Drawing.Color.White;
            this.lblParamaterForm.Location = new System.Drawing.Point(282, 27);
            this.lblParamaterForm.Name = "lblParamaterForm";
            this.lblParamaterForm.Size = new System.Drawing.Size(340, 25);
            this.lblParamaterForm.TabIndex = 22;
            this.lblParamaterForm.Text = "Retrun Based Analytics Custom Entity";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(29, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 36);
            this.button2.TabIndex = 32;
            this.button2.Text = "&Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddEntity
            // 
            this.btnAddEntity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntity.Location = new System.Drawing.Point(575, 645);
            this.btnAddEntity.Name = "btnAddEntity";
            this.btnAddEntity.Size = new System.Drawing.Size(215, 36);
            this.btnAddEntity.TabIndex = 33;
            this.btnAddEntity.Text = "&Save Custom Entity";
            this.btnAddEntity.UseVisualStyleBackColor = true;
            this.btnAddEntity.Click += new System.EventHandler(this.btnAddEntity_Click);
            // 
            // lblIdValue
            // 
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.ForeColor = System.Drawing.Color.White;
            this.lblIdValue.Location = new System.Drawing.Point(323, 90);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(63, 25);
            this.lblIdValue.TabIndex = 38;
            this.lblIdValue.Text = "&Value";
            // 
            // lblEntityName
            // 
            this.lblEntityName.AutoSize = true;
            this.lblEntityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityName.ForeColor = System.Drawing.Color.White;
            this.lblEntityName.Location = new System.Drawing.Point(28, 91);
            this.lblEntityName.Name = "lblEntityName";
            this.lblEntityName.Size = new System.Drawing.Size(47, 25);
            this.lblEntityName.TabIndex = 37;
            this.lblEntityName.Text = "&Key";
            // 
            // txtReturnIdVal
            // 
            this.txtReturnIdVal.Location = new System.Drawing.Point(422, 94);
            this.txtReturnIdVal.Name = "txtReturnIdVal";
            this.txtReturnIdVal.Size = new System.Drawing.Size(165, 22);
            this.txtReturnIdVal.TabIndex = 36;
            // 
            // txtReturnIdName
            // 
            this.txtReturnIdName.Location = new System.Drawing.Point(156, 94);
            this.txtReturnIdName.Name = "txtReturnIdName";
            this.txtReturnIdName.Size = new System.Drawing.Size(143, 22);
            this.txtReturnIdName.TabIndex = 35;
            // 
            // btnAddCustomEntity
            // 
            this.btnAddCustomEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomEntity.Location = new System.Drawing.Point(620, 90);
            this.btnAddCustomEntity.Name = "btnAddCustomEntity";
            this.btnAddCustomEntity.Size = new System.Drawing.Size(170, 36);
            this.btnAddCustomEntity.TabIndex = 34;
            this.btnAddCustomEntity.Text = "&Add Key Values";
            this.btnAddCustomEntity.UseVisualStyleBackColor = true;
            this.btnAddCustomEntity.Click += new System.EventHandler(this.btnAddCustomEntity_Click);
            // 
            // dgvRBAEntity
            // 
            this.dgvRBAEntity.AllowUserToAddRows = false;
            this.dgvRBAEntity.AllowUserToOrderColumns = true;
            this.dgvRBAEntity.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.dgvRBAEntity.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRBAEntity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.dgvRBAEntity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRBAEntity.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRBAEntity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRBAEntity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgEntity,
            this.dgParams,
            this.dgDel});
            this.dgvRBAEntity.EnableHeadersVisualStyles = false;
            this.dgvRBAEntity.Location = new System.Drawing.Point(29, 152);
            this.dgvRBAEntity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRBAEntity.MultiSelect = false;
            this.dgvRBAEntity.Name = "dgvRBAEntity";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRBAEntity.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRBAEntity.RowHeadersWidth = 62;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRBAEntity.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRBAEntity.RowTemplate.Height = 40;
            this.dgvRBAEntity.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRBAEntity.Size = new System.Drawing.Size(761, 177);
            this.dgvRBAEntity.TabIndex = 39;
            this.dgvRBAEntity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRBAEntity_CellContentClick);
            // 
            // dgEntity
            // 
            this.dgEntity.HeaderText = "Key";
            this.dgEntity.MinimumWidth = 8;
            this.dgEntity.Name = "dgEntity";
            this.dgEntity.ReadOnly = true;
            this.dgEntity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgEntity.Width = 250;
            // 
            // dgParams
            // 
            this.dgParams.HeaderText = "Value";
            this.dgParams.MinimumWidth = 8;
            this.dgParams.Name = "dgParams";
            this.dgParams.ReadOnly = true;
            this.dgParams.Width = 250;
            // 
            // dgDel
            // 
            this.dgDel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgDel.HeaderText = "";
            this.dgDel.MinimumWidth = 8;
            this.dgDel.Name = "dgDel";
            this.dgDel.Text = "Remove";
            this.dgDel.UseColumnTextForButtonValue = true;
            // 
            // txtCustomInput
            // 
            this.txtCustomInput.Location = new System.Drawing.Point(33, 389);
            this.txtCustomInput.Multiline = true;
            this.txtCustomInput.Name = "txtCustomInput";
            this.txtCustomInput.Size = new System.Drawing.Size(757, 163);
            this.txtCustomInput.TabIndex = 23;
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.ForeColor = System.Drawing.Color.White;
            this.lblCustom.Location = new System.Drawing.Point(60, 331);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(0, 25);
            this.lblCustom.TabIndex = 40;
            // 
            // DalInputRBACustomEntities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(926, 726);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.dgvRBAEntity);
            this.Controls.Add(this.lblIdValue);
            this.Controls.Add(this.lblEntityName);
            this.Controls.Add(this.txtReturnIdVal);
            this.Controls.Add(this.txtReturnIdName);
            this.Controls.Add(this.btnAddCustomEntity);
            this.Controls.Add(this.btnAddEntity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCustomInput);
            this.Controls.Add(this.lblParamaterForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DalInputRBACustomEntities";
            this.Text = "CustomEntities";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRBAEntity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParamaterForm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddEntity;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label lblEntityName;
        private System.Windows.Forms.TextBox txtReturnIdVal;
        private System.Windows.Forms.TextBox txtReturnIdName;
        private System.Windows.Forms.Button btnAddCustomEntity;
        private System.Windows.Forms.DataGridView dgvRBAEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEntity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgParams;
        private System.Windows.Forms.DataGridViewButtonColumn dgDel;
        private System.Windows.Forms.TextBox txtCustomInput;
        private System.Windows.Forms.Label lblCustom;
    }
}