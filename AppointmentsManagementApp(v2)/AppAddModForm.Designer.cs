namespace AppointmentSchedulingApp_v1_
{
    partial class AppointmentAddModForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentAddModForm));
            this.cancelBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.appointmentAddModTitleLabel = new System.Windows.Forms.Label();
            this.appDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.appTimePicker = new System.Windows.Forms.DomainUpDown();
            this.cusIDTextBox = new System.Windows.Forms.TextBox();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.viewCusBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(360, 657);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(122, 35);
            this.cancelBtn.TabIndex = 25;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(360, 564);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(122, 35);
            this.submitBtn.TabIndex = 24;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(298, 357);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(295, 26);
            this.descTextBox.TabIndex = 21;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(298, 321);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(184, 26);
            this.titleTextBox.TabIndex = 20;
            // 
            // idTextBox
            // 
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(298, 275);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(83, 26);
            this.idTextBox.TabIndex = 19;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(250, 321);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(42, 20);
            this.titleLabel.TabIndex = 18;
            this.titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(202, 363);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(93, 20);
            this.descriptionLabel.TabIndex = 17;
            this.descriptionLabel.Text = "Description:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(243, 402);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 16;
            this.emailLabel.Text = "Date:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(245, 440);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(47, 20);
            this.phoneLabel.TabIndex = 15;
            this.phoneLabel.Text = "Time:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(262, 281);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(30, 20);
            this.idLabel.TabIndex = 14;
            this.idLabel.Text = "ID:";
            // 
            // appointmentAddModTitleLabel
            // 
            this.appointmentAddModTitleLabel.AutoSize = true;
            this.appointmentAddModTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentAddModTitleLabel.Location = new System.Drawing.Point(188, 147);
            this.appointmentAddModTitleLabel.Name = "appointmentAddModTitleLabel";
            this.appointmentAddModTitleLabel.Size = new System.Drawing.Size(331, 49);
            this.appointmentAddModTitleLabel.TabIndex = 13;
            this.appointmentAddModTitleLabel.Text = "Add Appointment";
            // 
            // appDateTimePicker
            // 
            this.appDateTimePicker.Location = new System.Drawing.Point(298, 399);
            this.appDateTimePicker.MinDate = new System.DateTime(2022, 3, 17, 0, 0, 0, 0);
            this.appDateTimePicker.Name = "appDateTimePicker";
            this.appDateTimePicker.Size = new System.Drawing.Size(295, 26);
            this.appDateTimePicker.TabIndex = 22;
            this.appDateTimePicker.Value = new System.DateTime(2022, 3, 17, 9, 33, 38, 0);
            // 
            // appTimePicker
            // 
            this.appTimePicker.Items.Add("8:00am");
            this.appTimePicker.Items.Add("9:00am");
            this.appTimePicker.Items.Add("10:00am");
            this.appTimePicker.Items.Add("11:00am");
            this.appTimePicker.Items.Add("1:00pm");
            this.appTimePicker.Items.Add("2:00pm");
            this.appTimePicker.Items.Add("3:00pm");
            this.appTimePicker.Items.Add("4:00pm");
            this.appTimePicker.Items.Add("5:00pm");
            this.appTimePicker.Location = new System.Drawing.Point(298, 438);
            this.appTimePicker.Name = "appTimePicker";
            this.appTimePicker.Size = new System.Drawing.Size(184, 26);
            this.appTimePicker.TabIndex = 23;
            this.appTimePicker.Text = "Select a Time";
            // 
            // cusIDTextBox
            // 
            this.cusIDTextBox.Enabled = false;
            this.cusIDTextBox.Location = new System.Drawing.Point(299, 490);
            this.cusIDTextBox.Name = "cusIDTextBox";
            this.cusIDTextBox.Size = new System.Drawing.Size(83, 26);
            this.cusIDTextBox.TabIndex = 26;
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(193, 490);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(99, 20);
            this.customerIDLabel.TabIndex = 27;
            this.customerIDLabel.Text = "Customer ID";
            // 
            // viewCusBtn
            // 
            this.viewCusBtn.Location = new System.Drawing.Point(388, 484);
            this.viewCusBtn.Name = "viewCusBtn";
            this.viewCusBtn.Size = new System.Drawing.Size(154, 39);
            this.viewCusBtn.TabIndex = 28;
            this.viewCusBtn.Text = "View Customers";
            this.viewCusBtn.UseVisualStyleBackColor = true;
            this.viewCusBtn.Click += new System.EventHandler(this.viewCusBtn_Click);
            // 
            // AppointmentAddModForm
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(684, 812);
            this.Controls.Add(this.viewCusBtn);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.cusIDTextBox);
            this.Controls.Add(this.appTimePicker);
            this.Controls.Add(this.appDateTimePicker);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.appointmentAddModTitleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentAddModForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.AppointmentAddModForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label appointmentAddModTitleLabel;
        private System.Windows.Forms.DateTimePicker appDateTimePicker;
        private System.Windows.Forms.DomainUpDown appTimePicker;
        private System.Windows.Forms.TextBox cusIDTextBox;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Button viewCusBtn;
    }
}