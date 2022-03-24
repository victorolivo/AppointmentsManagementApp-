using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSchedulingApp_v1_
{
    public partial class CustomersQuickViewForm : Form
    {

        public CustomersQuickViewForm()
        {
            InitializeComponent();
        }

        
        private void paintDGV()
        {
            cusQuickViewDGV.DataSource = Program.customerList;
        }

        private void CustomersQuickViewForm_Shown(object sender, EventArgs e)
        {
            paintDGV();
            cusQuickViewDGV.CurrentCell = null;
            Program.currentCusSelection = Program.appointmentList[Program.currentRowSelection].CustomerID;
        }

        private void cusQuickViewDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.currentCusSelection = e.RowIndex;
        }

        private void submitSelectedCusBtn_Click(object sender, EventArgs e)
        {
            if (cusQuickViewDGV.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                this.Hide();
            }
        }

    }
}
