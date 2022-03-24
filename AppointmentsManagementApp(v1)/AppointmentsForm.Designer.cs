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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentsForm));
            this.deleteAppointmentBtn = new System.Windows.Forms.Button();
            this.modifyAppointmentBtn = new System.Windows.Forms.Button();
            this.addAppointmentBtn = new System.Windows.Forms.Button();
            this.appointmentDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateMMDDYYYYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cancelAppointmentOperationBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.returnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            this.appointmentDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.appointmentDGV.AutoGenerateColumns = false;
            this.appointmentDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.appointmentDGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appointmentDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.appointmentDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.dateMMDDYYYYDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.appointmentDGV.DataSource = this.appointmentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.appointmentDGV.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.appointmentDGV.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDGV_CellMouseEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateMMDDYYYYDataGridViewTextBoxColumn
            // 
            this.dateMMDDYYYYDataGridViewTextBoxColumn.DataPropertyName = "Date_MMDDYYYY";
            this.dateMMDDYYYYDataGridViewTextBoxColumn.HeaderText = "Date_MMDDYYYY";
            this.dateMMDDYYYYDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateMMDDYYYYDataGridViewTextBoxColumn.Name = "dateMMDDYYYYDataGridViewTextBoxColumn";
            this.dateMMDDYYYYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataSource = typeof(AppointmentSchedulingApp_v1_.Appointment);
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
            // AppointmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 500);
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
            this.Enter += new System.EventHandler(this.AppointmentsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteAppointmentBtn;
        private System.Windows.Forms.Button modifyAppointmentBtn;
        private System.Windows.Forms.Button addAppointmentBtn;
        private System.Windows.Forms.DataGridView appointmentDGV;
        private System.Windows.Forms.Button cancelAppointmentOperationBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateMMDDYYYYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.PictureBox returnHome;
    }
}