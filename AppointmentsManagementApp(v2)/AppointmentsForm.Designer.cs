namespace AppointmentSchedulingApp_v1_
{
    partial class AppointmentsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            this.deleteAppointmentBtn = new System.Windows.Forms.Button();
            this.modifyAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            this.cancelAppointmentOperationBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.returnHome = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteAppointmentBtn
            // 
            this.deleteAppointmentBtn.Location = new System.Drawing.Point(658, 396);
            this.deleteAppointmentBtn.Name = "deleteAppointmentBtn";
            this.deleteAppointmentBtn.Size = new System.Drawing.Size(75, 35);
            this.deleteAppointmentBtn.TabIndex = 7;
            this.deleteAppointmentBtn.Text = "Delete";
            this.deleteAppointmentBtn.UseVisualStyleBackColor = true;
            this.deleteAppointmentBtn.Click += new System.EventHandler(this.deleteAppointmentBtn_Click);
            // 
            // modifyAppointmentBtn
            // 
            this.modifyAppointmentBtn.Location = new System.Drawing.Point(363, 396);
            this.modifyAppointmentBtn.Name = "modifyAppointmentBtn";
            this.modifyAppointmentBtn.Size = new System.Drawing.Size(75, 35);
            this.modifyAppointmentBtn.TabIndex = 6;
            this.modifyAppointmentBtn.Text = "Modify";
            this.modifyAppointmentBtn.UseVisualStyleBackColor = true;
            this.modifyAppointmentBtn.Click += new System.EventHandler(this.modifyAppointmentBtn_Click);
            // 
            // addAppointmentBtn
            // 
            this.addAppointmentBtn.Location = new System.Drawing.Point(78, 396);
            this.addAppointmentBtn.Name = "addAppointmentBtn";
            this.addAppointmentBtn.Size = new System.Drawing.Size(75, 35);
            this.addAppointmentBtn.TabIndex = 5;
            this.addAppointmentBtn.Text = "Add";
            this.addAppointmentBtn.UseVisualStyleBackColor = true;
            this.addAppointmentBtn.Click += new System.EventHandler(this.addAppointmentBtn_Click);
            // 
            // appointmentDGV
            // 
            this.appointmentDGV.AllowUserToResizeColumns = false;
            this.appointmentDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.appointmentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.appointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentDGV.DefaultCellStyle = dataGridViewCellStyle18;
            this.appointmentDGV.EnableHeadersVisualStyles = false;
            this.appointmentDGV.Location = new System.Drawing.Point(12, 66);
            this.appointmentDGV.MultiSelect = false;
            this.appointmentDGV.Name = "appointmentDGV";
            this.appointmentDGV.ReadOnly = true;
            this.appointmentDGV.RowHeadersVisible = false;
            this.appointmentDGV.RowHeadersWidth = 62;
            this.appointmentDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.appointmentDGV.RowTemplate.Height = 28;
            this.appointmentDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.appointmentDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointmentDGV.Size = new System.Drawing.Size(776, 324);
            this.appointmentDGV.TabIndex = 0;
            this.appointmentDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDGV_CellClick);
            // 
            // cancelAppointmentOperationBtn
            // 
            this.cancelAppointmentOperationBtn.Location = new System.Drawing.Point(658, 453);
            this.cancelAppointmentOperationBtn.Name = "cancelAppointmentOperationBtn";
            this.cancelAppointmentOperationBtn.Size = new System.Drawing.Size(75, 35);
            this.cancelAppointmentOperationBtn.TabIndex = 8;
            this.cancelAppointmentOperationBtn.Text = "Cancel";
            this.cancelAppointmentOperationBtn.UseVisualStyleBackColor = true;
            this.cancelAppointmentOperationBtn.Click += new System.EventHandler(this.cancelAppointmentOperationBtn_Click);
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(12, 464);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(24, 24);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh.TabIndex = 9;
            this.refresh.TabStop = false;
            this.refresh.Click += new System.EventHandler(this.AppointmentsForm_Shown);
            // 
            // returnHome
            // 
            this.returnHome.Image = ((System.Drawing.Image)(resources.GetObject("returnHome.Image")));
            this.returnHome.Location = new System.Drawing.Point(12, 12);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(33, 35);
            this.returnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnHome.TabIndex = 11;
            this.returnHome.TabStop = false;
            this.returnHome.Click += new System.EventHandler(this.cancelAppointmentOperationBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(337, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "(MM-DD-YYYY)";
            // 
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.cancelAppointmentOperationBtn);
            this.Controls.Add(this.deleteAppointmentBtn);
            this.Controls.Add(this.modifyAppointmentBtn);
            this.Controls.Add(this.addAppointmentBtn);
            this.Controls.Add(this.appointmentDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppointmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Activated += new System.EventHandler(this.AppointmentsForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AppointmentsForm_FormClosed);
            this.Shown += new System.EventHandler(this.AppointmentsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteAppointmentBtn;
        private System.Windows.Forms.Button modifyAppointmentBtn;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Button cancelAppointmentOperationBtn;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.PictureBox returnHome;
        private System.Windows.Forms.Label label1;
    }
}