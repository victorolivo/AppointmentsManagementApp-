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
    public partial class CustomerAddModForm : Form
    {
        //Constructor
        public CustomerAddModForm()
        {
            InitializeComponent();
        }

        //Trigger: User cancels the operation (clicks on 'Cancel' btn)
        //Action: Closes the window - No modification or changes are saved
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //Trigger: Form loads
        //Action: Changes form title according to function - Prefills textboxes if in modify mode
        private void CustomerAddModForm_Load(object sender, EventArgs e)
        {
            if (Program.modifyMode)
            {
                //Change Title of Form
                customerAddModTitleLabel.Text = "Modify Customer";

                //Prefill all text boxes with the existing data for selected customer
                idTextBox.Text = (Program.customerList[Program.currentRowSelection].Id).ToString();
                firstNameTextBox.Text = Program.customerList[Program.currentRowSelection].FirstName;
                lastNameTextBox.Text = Program.customerList[Program.currentRowSelection].LastName;
                emailTextBox.Text = Program.customerList[Program.currentRowSelection].Email;
                phoneTextBox.Text = Program.customerList[Program.currentRowSelection].Phone;
            }
            else
            {
                idTextBox.Text = (Program.customerIDcount + 1).ToString();
            }
        }


        //Trigger: User submits form (click on 'Submit' btn)
        //Action: Saves new or modified customer
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(formValid()){
                if (Program.modifyMode)
                {
                    //Validation will be included in a future version
                    Program.customerList[Program.currentRowSelection].FirstName = firstNameTextBox.Text;
                    Program.customerList[Program.currentRowSelection].LastName = lastNameTextBox.Text;
                    Program.customerList[Program.currentRowSelection].Email = emailTextBox.Text;
                    Program.customerList[Program.currentRowSelection].Phone = phoneTextBox.Text;

                }
                else
                {
                    //Create new customer and adds it to the customers List
                    Customer newCustomer = new Customer(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text);
                    Program.customerList.Add(newCustomer);
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("PLease complete all fields before submitting");
            }

        }


        //Trigger: User attemps to submit customer modification or creation
        //Action: Ensures all fields are filled before making any changes
        private bool formValid()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text)
                || string.IsNullOrWhiteSpace(emailTextBox.Text) || string.IsNullOrWhiteSpace(phoneTextBox.Text))
            {
                return false;
            }
            
            return true;
        }
    }
}
