namespace AppointmentSchedulingApp_v1_
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginFormTitleLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBoxLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginGroupBox = new System.Windows.Forms.GroupBox();
            this.loginSubmitBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginFormTitleLabel
            // 
            this.loginFormTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginFormTitleLabel.AutoSize = true;
            this.loginFormTitleLabel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.loginFormTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loginFormTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormTitleLabel.Location = new System.Drawing.Point(62, 38);
            this.loginFormTitleLabel.Name = "loginFormTitleLabel";
            this.loginFormTitleLabel.Size = new System.Drawing.Size(499, 122);
            this.loginFormTitleLabel.TabIndex = 0;
            this.loginFormTitleLabel.Text = "Central Appoitments \r\nManagement System";
            this.loginFormTitleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTextBox.Location = new System.Drawing.Point(241, 474);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(161, 26);
            this.userNameTextBox.TabIndex = 1;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(241, 542);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(161, 26);
            this.passwordTextBox.TabIndex = 2;
            // 
            // usernameTextBoxLabel
            // 
            this.usernameTextBoxLabel.AutoSize = true;
            this.usernameTextBoxLabel.Location = new System.Drawing.Point(237, 451);
            this.usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            this.usernameTextBoxLabel.Size = new System.Drawing.Size(87, 20);
            this.usernameTextBoxLabel.TabIndex = 3;
            this.usernameTextBoxLabel.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // loginGroupBox
            // 
            this.loginGroupBox.Controls.Add(this.loginSubmitBtn);
            this.loginGroupBox.Location = new System.Drawing.Point(187, 420);
            this.loginGroupBox.Name = "loginGroupBox";
            this.loginGroupBox.Size = new System.Drawing.Size(249, 213);
            this.loginGroupBox.TabIndex = 5;
            this.loginGroupBox.TabStop = false;
            this.loginGroupBox.Text = "LogIn";
            // 
            // loginSubmitBtn
            // 
            this.loginSubmitBtn.Location = new System.Drawing.Point(140, 168);
            this.loginSubmitBtn.Name = "loginSubmitBtn";
            this.loginSubmitBtn.Size = new System.Drawing.Size(75, 39);
            this.loginSubmitBtn.TabIndex = 0;
            this.loginSubmitBtn.Text = "Submit";
            this.loginSubmitBtn.UseVisualStyleBackColor = true;
            this.loginSubmitBtn.Click += new System.EventHandler(this.loginSubmitBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(241, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginSubmitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(611, 724);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameTextBoxLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.loginFormTitleLabel);
            this.Controls.Add(this.loginGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Central Appointmets Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.loginGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginFormTitleLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameTextBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox loginGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginSubmitBtn;
    }
}

