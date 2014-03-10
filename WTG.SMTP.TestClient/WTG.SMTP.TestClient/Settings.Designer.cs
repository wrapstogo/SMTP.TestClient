namespace WTG.SMTP.TestClient
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.lblSettingsFromEmail = new System.Windows.Forms.Label();
            this.txtSetttingsFromEmail = new System.Windows.Forms.TextBox();
            this.txtSettingsHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSettingsPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSettingsUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSettingsPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetttingsSave = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSettingsFromEmail
            // 
            this.lblSettingsFromEmail.AutoSize = true;
            this.lblSettingsFromEmail.Location = new System.Drawing.Point(13, 13);
            this.lblSettingsFromEmail.Name = "lblSettingsFromEmail";
            this.lblSettingsFromEmail.Size = new System.Drawing.Size(60, 13);
            this.lblSettingsFromEmail.TabIndex = 0;
            this.lblSettingsFromEmail.Text = "From email:";
            // 
            // txtSetttingsFromEmail
            // 
            this.txtSetttingsFromEmail.Location = new System.Drawing.Point(80, 7);
            this.txtSetttingsFromEmail.Name = "txtSetttingsFromEmail";
            this.txtSetttingsFromEmail.Size = new System.Drawing.Size(170, 20);
            this.txtSetttingsFromEmail.TabIndex = 1;
            // 
            // txtSettingsHost
            // 
            this.txtSettingsHost.Location = new System.Drawing.Point(80, 45);
            this.txtSettingsHost.Name = "txtSettingsHost";
            this.txtSettingsHost.Size = new System.Drawing.Size(170, 20);
            this.txtSettingsHost.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host:";
            // 
            // txtSettingsPort
            // 
            this.txtSettingsPort.Location = new System.Drawing.Point(80, 81);
            this.txtSettingsPort.Name = "txtSettingsPort";
            this.txtSettingsPort.Size = new System.Drawing.Size(170, 20);
            this.txtSettingsPort.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port:";
            // 
            // txtSettingsUserName
            // 
            this.txtSettingsUserName.Location = new System.Drawing.Point(80, 121);
            this.txtSettingsUserName.Name = "txtSettingsUserName";
            this.txtSettingsUserName.Size = new System.Drawing.Size(170, 20);
            this.txtSettingsUserName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UserName";
            // 
            // txtSettingsPassword
            // 
            this.txtSettingsPassword.Location = new System.Drawing.Point(80, 158);
            this.txtSettingsPassword.Name = "txtSettingsPassword";
            this.txtSettingsPassword.Size = new System.Drawing.Size(170, 20);
            this.txtSettingsPassword.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // btnSetttingsSave
            // 
            this.btnSetttingsSave.Location = new System.Drawing.Point(175, 216);
            this.btnSetttingsSave.Name = "btnSetttingsSave";
            this.btnSetttingsSave.Size = new System.Drawing.Size(75, 23);
            this.btnSetttingsSave.TabIndex = 10;
            this.btnSetttingsSave.Text = "Save";
            this.btnSetttingsSave.UseVisualStyleBackColor = true;
            this.btnSetttingsSave.Click += new System.EventHandler(this.btnSetttingsSave_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(80, 216);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 11;
            this.btnSettingsCancel.Text = "Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 262);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSetttingsSave);
            this.Controls.Add(this.txtSettingsPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSettingsUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSettingsPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSettingsHost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSetttingsFromEmail);
            this.Controls.Add(this.lblSettingsFromEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettingsFromEmail;
        private System.Windows.Forms.TextBox txtSetttingsFromEmail;
        private System.Windows.Forms.TextBox txtSettingsHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSettingsPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSettingsUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSettingsPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetttingsSave;
        private System.Windows.Forms.Button btnSettingsCancel;
    }
}