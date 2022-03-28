namespace AppointmentSchedulingApp_v1_
{
    partial class CustomersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.modifyCustomerBtn = new System.Windows.Forms.Button();
            this.deleteCustomerBtn = new System.Windows.Forms.Button();
            this.cancelAppointmentOperationBtn = new System.Windows.Forms.Button();
            this.returnHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AllowUserToResizeColumns = false;
            this.customersDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.customersDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customersDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customersDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.customersDGV.EnableHeadersVisualStyles = false;
            this.customersDGV.Location = new System.Drawing.Point(12, 66);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.ReadOnly = true;
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.RowHeadersWidth = 62;
            this.customersDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customersDGV.RowTemplate.Height = 28;
            this.customersDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(776, 324);
            this.customersDGV.TabIndex = 0;
            this.customersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersDGV_CellClick);
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(78, 396);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(75, 35);
            this.addCustomerBtn.TabIndex = 1;
            this.addCustomerBtn.Text = "Add";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // modifyCustomerBtn
            // 
            this.modifyCustomerBtn.Location = new System.Drawing.Point(363, 396);
            this.modifyCustomerBtn.Name = "modifyCustomerBtn";
            this.modifyCustomerBtn.Size = new System.Drawing.Size(75, 35);
            this.modifyCustomerBtn.TabIndex = 2;
            this.modifyCustomerBtn.Text = "Modify";
            this.modifyCustomerBtn.UseVisualStyleBackColor = true;
            this.modifyCustomerBtn.Click += new System.EventHandler(this.modifyCustomerBtn_Click);
            // 
            // deleteCustomerBtn
            // 
            this.deleteCustomerBtn.Location = new System.Drawing.Point(658, 396);
            this.deleteCustomerBtn.Name = "deleteCustomerBtn";
            this.deleteCustomerBtn.Size = new System.Drawing.Size(75, 35);
            this.deleteCustomerBtn.TabIndex = 3;
            this.deleteCustomerBtn.Text = "Delete";
            this.deleteCustomerBtn.UseVisualStyleBackColor = true;
            this.deleteCustomerBtn.Click += new System.EventHandler(this.deleteCustomerBtn_Click);
            // 
            // cancelAppointmentOperationBtn
            // 
            this.cancelAppointmentOperationBtn.Location = new System.Drawing.Point(658, 453);
            this.cancelAppointmentOperationBtn.Name = "cancelAppointmentOperationBtn";
            this.cancelAppointmentOperationBtn.Size = new System.Drawing.Size(75, 35);
            this.cancelAppointmentOperationBtn.TabIndex = 9;
            this.cancelAppointmentOperationBtn.Text = "Cancel";
            this.cancelAppointmentOperationBtn.UseVisualStyleBackColor = true;
            this.cancelAppointmentOperationBtn.Click += new System.EventHandler(this.cancelAppointmentOperationBtn_Click);
            // 
            // returnHome
            // 
            this.returnHome.Image = ((System.Drawing.Image)(resources.GetObject("returnHome.Image")));
            this.returnHome.Location = new System.Drawing.Point(13, 13);
            this.returnHome.Name = "returnHome";
            this.returnHome.Size = new System.Drawing.Size(33, 35);
            this.returnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.returnHome.TabIndex = 10;
            this.returnHome.TabStop = false;
            this.returnHome.Click += new System.EventHandler(this.cancelAppointmentOperationBtn_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.returnHome);
            this.Controls.Add(this.cancelAppointmentOperationBtn);
            this.Controls.Add(this.deleteCustomerBtn);
            this.Controls.Add(this.modifyCustomerBtn);
            this.Controls.Add(this.addCustomerBtn);
            this.Controls.Add(this.customersDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Activated += new System.EventHandler(this.CustomersForm_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomersForm_FormClosed);
            this.Shown += new System.EventHandler(this.CustomersForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.Button modifyCustomerBtn;
        private System.Windows.Forms.Button deleteCustomerBtn;
        private System.Windows.Forms.Button cancelAppointmentOperationBtn;
        private System.Windows.Forms.PictureBox returnHome;
    }
}