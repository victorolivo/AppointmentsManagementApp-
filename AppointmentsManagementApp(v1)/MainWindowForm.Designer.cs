namespace AppointmentSchedulingApp_v1_
{
    partial class MainWindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.customersPictureBox = new System.Windows.Forms.PictureBox();
            this.appointmentsPictureBox = new System.Windows.Forms.PictureBox();
            this.customersPictureBoxLabel = new System.Windows.Forms.Label();
            this.appointmentsPictureBoxLabel = new System.Windows.Forms.Label();
            this.signOutLabel = new System.Windows.Forms.LinkLabel();
            this.welcomeUserLabel = new System.Windows.Forms.Label();
            this.creditsLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.customersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // customersPictureBox
            // 
            this.customersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("customersPictureBox.Image")));
            this.customersPictureBox.Location = new System.Drawing.Point(105, 93);
            this.customersPictureBox.Name = "customersPictureBox";
            this.customersPictureBox.Size = new System.Drawing.Size(228, 234);
            this.customersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.customersPictureBox.TabIndex = 0;
            this.customersPictureBox.TabStop = false;
            this.customersPictureBox.Click += new System.EventHandler(this.customersPictureBox_Click);
            // 
            // appointmentsPictureBox
            // 
            this.appointmentsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("appointmentsPictureBox.Image")));
            this.appointmentsPictureBox.Location = new System.Drawing.Point(475, 93);
            this.appointmentsPictureBox.Name = "appointmentsPictureBox";
            this.appointmentsPictureBox.Size = new System.Drawing.Size(228, 234);
            this.appointmentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appointmentsPictureBox.TabIndex = 1;
            this.appointmentsPictureBox.TabStop = false;
            this.appointmentsPictureBox.Click += new System.EventHandler(this.appointmentsPictureBox_Click);
            // 
            // customersPictureBoxLabel
            // 
            this.customersPictureBoxLabel.AutoSize = true;
            this.customersPictureBoxLabel.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersPictureBoxLabel.Location = new System.Drawing.Point(135, 342);
            this.customersPictureBoxLabel.Name = "customersPictureBoxLabel";
            this.customersPictureBoxLabel.Size = new System.Drawing.Size(165, 40);
            this.customersPictureBoxLabel.TabIndex = 2;
            this.customersPictureBoxLabel.Text = "Customers";
            this.customersPictureBoxLabel.Click += new System.EventHandler(this.customersPictureBoxLabel_Click);
            // 
            // appointmentsPictureBoxLabel
            // 
            this.appointmentsPictureBoxLabel.AutoSize = true;
            this.appointmentsPictureBoxLabel.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsPictureBoxLabel.Location = new System.Drawing.Point(488, 342);
            this.appointmentsPictureBoxLabel.Name = "appointmentsPictureBoxLabel";
            this.appointmentsPictureBoxLabel.Size = new System.Drawing.Size(215, 40);
            this.appointmentsPictureBoxLabel.TabIndex = 3;
            this.appointmentsPictureBoxLabel.Text = "Appointments";
            this.appointmentsPictureBoxLabel.Click += new System.EventHandler(this.appointmentsPictureBoxLabel_Click);
            // 
            // signOutLabel
            // 
            this.signOutLabel.AutoSize = true;
            this.signOutLabel.Location = new System.Drawing.Point(717, 9);
            this.signOutLabel.Name = "signOutLabel";
            this.signOutLabel.Size = new System.Drawing.Size(71, 20);
            this.signOutLabel.TabIndex = 4;
            this.signOutLabel.TabStop = true;
            this.signOutLabel.Text = "Sign Out";
            this.signOutLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signOutLabel_LinkClicked);
            // 
            // welcomeUserLabel
            // 
            this.welcomeUserLabel.AutoSize = true;
            this.welcomeUserLabel.Location = new System.Drawing.Point(13, 8);
            this.welcomeUserLabel.Name = "welcomeUserLabel";
            this.welcomeUserLabel.Size = new System.Drawing.Size(110, 20);
            this.welcomeUserLabel.TabIndex = 5;
            this.welcomeUserLabel.Text = "Welcome user";
            // 
            // creditsLinkLabel
            // 
            this.creditsLinkLabel.AutoSize = true;
            this.creditsLinkLabel.LinkColor = System.Drawing.Color.Silver;
            this.creditsLinkLabel.Location = new System.Drawing.Point(735, 425);
            this.creditsLinkLabel.Name = "creditsLinkLabel";
            this.creditsLinkLabel.Size = new System.Drawing.Size(59, 20);
            this.creditsLinkLabel.TabIndex = 6;
            this.creditsLinkLabel.TabStop = true;
            this.creditsLinkLabel.Text = "Credits";
            this.creditsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.creditsLinkLabel_LinkClicked);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creditsLinkLabel);
            this.Controls.Add(this.welcomeUserLabel);
            this.Controls.Add(this.signOutLabel);
            this.Controls.Add(this.appointmentsPictureBoxLabel);
            this.Controls.Add(this.customersPictureBoxLabel);
            this.Controls.Add(this.appointmentsPictureBox);
            this.Controls.Add(this.customersPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindowForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.customersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox customersPictureBox;
        private System.Windows.Forms.PictureBox appointmentsPictureBox;
        private System.Windows.Forms.Label customersPictureBoxLabel;
        private System.Windows.Forms.Label appointmentsPictureBoxLabel;
        private System.Windows.Forms.LinkLabel signOutLabel;
        private System.Windows.Forms.Label welcomeUserLabel;
        private System.Windows.Forms.LinkLabel creditsLinkLabel;
    }
}