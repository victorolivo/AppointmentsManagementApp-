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
    public partial class AppointmentsForm : Form
    {
        //Constructor
        public AppointmentsForm()
        {
            InitializeComponent();
            paintDGV();
        }

        private void paintDGV()
        {
            appointmentDGV.DataSource = Program.appointmentList;
        }

        //Trigger: Method executes when the user closes the Appointments window form by pressing the top-right 'X' button
        //Action: Terminates the application
        private void AppointmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindowForm m = new MainWindowForm();
            m.Show();
        }

        

        private void addAppointmentBtn_Click(object sender, EventArgs e)
        {
            Program.modifyMode = false;
            AppointmentAddModForm m = new AppointmentAddModForm();
            m.Show();
        }

        private void modifyAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (appointmentDGV.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                Program.modifyMode = true;
                AppointmentAddModForm frm = new AppointmentAddModForm();
                frm.Show();
            }
        }

        //Trigger: Method executes when Appointment Form opens
        //Action: It clears the data grid view selection
        private void AppointmentsForm_Shown(object sender, EventArgs e)
        {
            appointmentDGV.CurrentCell = null;
            paintDGV();
        }

        private void deleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            if (appointmentDGV.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete/cancel this appointment?",
                    "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    Program.appointmentList.RemoveAt(Program.currentRowSelection);
                    appointmentDGV.CurrentCell = null;
                }
            }
        }

        //Index Tracker
        private void appointmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.currentRowSelection = e.RowIndex;
            
        }

        //Trigger: User cancels the operation (clicks on 'Cancel' btn)
        //Action: Takes the user back to main menu 
        private void cancelAppointmentOperationBtn_Click(object sender, EventArgs e)
        {
            MainWindowForm m = new MainWindowForm();
            m.Show();
            this.Hide();
        }


        //review (beta feature) --REVIEWED - FUNCTIONAL!
        private void appointmentDGV_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int cusId = Program.appointmentList[e.RowIndex].CustomerID;
                string userFeedBack = "";

                //Look for that CustomerID in the customer list
                //Write user feedback message
                foreach (Customer c in Program.customerList)
                {
                    if (c.Id == cusId)
                        userFeedBack = c.FirstName + " " + c.LastName;
                }
                

                DataGridViewCell cell = this.appointmentDGV.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = userFeedBack;

            }
            catch (IndexOutOfRangeException)
            {

            }
            catch (ArgumentOutOfRangeException)
            {

            }
        }
    }
}
