namespace Franklin_Templeton_DAL
{
    partial class SettingPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingPopup));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.Setting = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn_api_uat = new System.Windows.Forms.RadioButton();
            this.rBtn_api_test = new System.Windows.Forms.RadioButton();
            this.rBtn_api_prod = new System.Windows.Forms.RadioButton();
            this.rBtn_api_dev = new System.Windows.Forms.RadioButton();
            this.Setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(222, 201);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(112, 28);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.SaveSettings);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(25, 201);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 28);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.groupBox1);
            this.Setting.Controls.Add(this.btnOK);
            this.Setting.Controls.Add(this.btnCancel);
            this.Setting.Location = new System.Drawing.Point(16, 14);
            this.Setting.Margin = new System.Windows.Forms.Padding(4);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(4);
            this.Setting.Size = new System.Drawing.Size(361, 268);
            this.Setting.TabIndex = 6;
            this.Setting.TabStop = false;
            this.Setting.Text = "Setting";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtn_api_uat);
            this.groupBox1.Controls.Add(this.rBtn_api_test);
            this.groupBox1.Controls.Add(this.rBtn_api_prod);
            this.groupBox1.Controls.Add(this.rBtn_api_dev);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Environment";            
            // 
            // rBtn_api_uat
            // 
            this.rBtn_api_uat.AutoSize = true;
            this.rBtn_api_uat.Location = new System.Drawing.Point(198, 91);
            this.rBtn_api_uat.Name = "rBtn_api_uat";
            this.rBtn_api_uat.Size = new System.Drawing.Size(56, 20);
            this.rBtn_api_uat.TabIndex = 9;
            this.rBtn_api_uat.TabStop = true;
            this.rBtn_api_uat.Text = "UAT";
            this.rBtn_api_uat.UseVisualStyleBackColor = true;
            // 
            // rBtn_api_test
            // 
            this.rBtn_api_test.AutoSize = true;
            this.rBtn_api_test.Location = new System.Drawing.Point(198, 39);
            this.rBtn_api_test.Name = "rBtn_api_test";
            this.rBtn_api_test.Size = new System.Drawing.Size(55, 20);
            this.rBtn_api_test.TabIndex = 8;
            this.rBtn_api_test.TabStop = true;
            this.rBtn_api_test.Text = "Test";
            this.rBtn_api_test.UseVisualStyleBackColor = true;
            // 
            // rBtn_api_prod
            // 
            this.rBtn_api_prod.AutoSize = true;
            this.rBtn_api_prod.Location = new System.Drawing.Point(17, 39);
            this.rBtn_api_prod.Name = "rBtn_api_prod";
            this.rBtn_api_prod.Size = new System.Drawing.Size(92, 20);
            this.rBtn_api_prod.TabIndex = 6;
            this.rBtn_api_prod.TabStop = true;
            this.rBtn_api_prod.Text = "Production";
            this.rBtn_api_prod.UseVisualStyleBackColor = true;
            // 
            // rBtn_api_dev
            // 
            this.rBtn_api_dev.AutoSize = true;
            this.rBtn_api_dev.Location = new System.Drawing.Point(17, 89);
            this.rBtn_api_dev.Name = "rBtn_api_dev";
            this.rBtn_api_dev.Size = new System.Drawing.Size(109, 20);
            this.rBtn_api_dev.TabIndex = 7;
            this.rBtn_api_dev.TabStop = true;
            this.rBtn_api_dev.Text = "Development";
            this.rBtn_api_dev.UseVisualStyleBackColor = true;
            // 
            // SettingPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 306);
            this.Controls.Add(this.Setting);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingPopup";
            this.Text = "DAL Settings";
            this.Setting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox Setting;
        private System.Windows.Forms.RadioButton rBtn_api_dev;
        private System.Windows.Forms.RadioButton rBtn_api_prod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtn_api_uat;
        private System.Windows.Forms.RadioButton rBtn_api_test;
    }
}