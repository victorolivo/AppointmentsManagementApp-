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
    public partial class CustomersForm : Form
    {
        //Constructor
        public CustomersForm()
        {
            InitializeComponent();
            paintDGV();
        }

        //Fills the data grid view with current data
        private void paintDGV()
        {
            customersDGV.DataSource = Program.customerList;
        }


        //Trigger: User closes the form (clicks on 'X' btn)
        //Action: Takes the user back to main menu
        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainWindowForm m = new MainWindowForm();
            m.Show();
        }

        //Trigger: User cancels the operation (clicks on 'Cancel' btn)
        //Action: Takes the user back to main menu 
        private void cancelAppointmentOperationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainWindowForm m = new MainWindowForm();
            m.Show();
        }

        //Trigger: User wants to add a new customer (clicks on 'Add' btn)
        //Action: Ensures the user has made a selection and takes the user to the 'Modify Customer Form'
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            Program.modifyMode = false;
            CustomerAddModForm frm = new CustomerAddModForm();
            frm.Show();
        }

        //Trigger: User attemps to modify customer (clicks on 'Modify' btn)
        //Action: Ensures the user has made a selection and takes the user to the 'Modify Customer Form'
        private void modifyCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersDGV.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                Program.modifyMode = true;
                CustomerAddModForm frm = new CustomerAddModForm();
                frm.Show(); 
            }
        }

        //Trigger: User attemps to delete a customer (clicks on 'Delete' btn)
        //Action: Ensures the user has made a selection and promts the user to confirm before deleting
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersDGV.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this customer?   All appointments related to this customer will also be eliminated",
                    "", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    int cusId = Program.customerList[Program.currentRowSelection].Id;
                    Program.customerList.RemoveAt(Program.currentRowSelection);
                    customersDGV.CurrentCell = null;

                    //Temporary List to delete appointments realated to a customer (Not efficcient - Will be improved in version 2.0)
                    BindingList<Appointment> tAppointmentList = new BindingList<Appointment>();

                    //Look for appointments to delete and add them to a temp list
                    foreach(Appointment a in Program.appointmentList)
                    {
                        if(a.CustomerID == cusId)
                        {
                            tAppointmentList.Add(a);
                        }
                    }

                    //Delete those appointments
                    foreach(Appointment a in tAppointmentList)
                    {
                        Program.appointmentList.Remove(a);
                    }
                }
            }
        }

        //Index Tracker
        private void customersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Program.currentRowSelection = e.RowIndex;
        }

        //Trigger: Method executes when Customer Form opens
        //Action: It clears the data grid view selection and updates its data
        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            customersDGV.CurrentCell = null;
            paintDGV();
        }

        
    }
}
