namespace AppointmentSchedulingApp_v1_
{
    partial class CustomersQuickViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersQuickViewForm));
            this.cusQuickViewDGV = new System.Windows.Forms.DataGridView();
            this.cusQuickViewTitleLabel = new System.Windows.Forms.Label();
            this.submitSelectedCusBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cusQuickViewDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // cusQuickViewDGV
            // 
            this.cusQuickViewDGV.AllowUserToResizeColumns = false;
            this.cusQuickViewDGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.cusQuickViewDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cusQuickViewDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cusQuickViewDGV.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cusQuickViewDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cusQuickViewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cusQuickViewDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.cusQuickViewDGV.EnableHeadersVisualStyles = false;
            this.cusQuickViewDGV.Location = new System.Drawing.Point(12, 106);
            this.cusQuickViewDGV.MultiSelect = false;
            this.cusQuickViewDGV.Name = "cusQuickViewDGV";
            this.cusQuickViewDGV.ReadOnly = true;
            this.cusQuickViewDGV.RowHeadersVisible = false;
            this.cusQuickViewDGV.RowHeadersWidth = 62;
            this.cusQuickViewDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.cusQuickViewDGV.RowTemplate.Height = 28;
            this.cusQuickViewDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cusQuickViewDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cusQuickViewDGV.Size = new System.Drawing.Size(524, 270);
            this.cusQuickViewDGV.TabIndex = 0;
            this.cusQuickViewDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cusQuickViewDGV_CellClick);
            // 
            // cusQuickViewTitleLabel
            // 
            this.cusQuickViewTitleLabel.AutoSize = true;
            this.cusQuickViewTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cusQuickViewTitleLabel.Location = new System.Drawing.Point(12, 71);
            this.cusQuickViewTitleLabel.Name = "cusQuickViewTitleLabel";
            this.cusQuickViewTitleLabel.Size = new System.Drawing.Size(446, 29);
            this.cusQuickViewTitleLabel.TabIndex = 1;
            this.cusQuickViewTitleLabel.Text = "Select a customer for this appointment:";
            // 
            // submitSelectedCusBtn
            // 
            this.submitSelectedCusBtn.Location = new System.Drawing.Point(461, 382);
            this.submitSelectedCusBtn.Name = "submitSelectedCusBtn";
            this.submitSelectedCusBtn.Size = new System.Drawing.Size(75, 42);
            this.submitSelectedCusBtn.TabIndex = 2;
            this.submitSelectedCusBtn.Text = "Select";
            this.submitSelectedCusBtn.UseVisualStyleBackColor = true;
            this.submitSelectedCusBtn.Click += new System.EventHandler(this.submitSelectedCusBtn_Click);
            // 
            // CustomersQuickViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.submitSelectedCusBtn);
            this.Controls.Add(this.cusQuickViewTitleLabel);
            this.Controls.Add(this.cusQuickViewDGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomersQuickViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select a Customer";
            this.Activated += new System.EventHandler(this.CustomersQuickViewForm_Shown);
            this.Shown += new System.EventHandler(this.CustomersQuickViewForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.cusQuickViewDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cusQuickViewDGV;
        private System.Windows.Forms.Label cusQuickViewTitleLabel;
        private System.Windows.Forms.Button submitSelectedCusBtn;
    }
}