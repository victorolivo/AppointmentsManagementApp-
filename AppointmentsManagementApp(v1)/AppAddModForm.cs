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
    public partial class AppointmentAddModForm : Form
    {
        public AppointmentAddModForm()
        {
            InitializeComponent();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (formValid())
            {
                if (Program.modifyMode)
                {
                    //Validation will be included in a future version
                    Program.appointmentList[Program.currentRowSelection].Title = titleTextBox.Text;
                    Program.appointmentList[Program.currentRowSelection].Description = descTextBox.Text;
                    Program.appointmentList[Program.currentRowSelection].Date_MMDDYYYY = appDateTimePicker.Value;
                    Program.appointmentList[Program.currentRowSelection].Time = appTimePicker.Text;
                    Program.appointmentList[Program.currentRowSelection].CustomerID = Convert.ToInt32(cusIDTextBox.Text);
                    Program.appointmentList[Program.currentRowSelection].UserID = Program.currentUserID;

                }
                else
                {
                    //Create new appointment and adds it to the appointment List
                    Appointment newAppointment = new Appointment(titleTextBox.Text,descTextBox.Text,appDateTimePicker.Value,appTimePicker.Text, Convert.ToInt32(cusIDTextBox.Text),Program.currentUserID);
                    Program.appointmentList.Add(newAppointment);
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("PLease complete all fields before submitting");
            }
        }

        //Trigger: User attemps to submits appointment modification or creation
        //Action: Ensures all fields are filled before making any changes
        private bool formValid()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) || string.IsNullOrWhiteSpace(descTextBox.Text)
                || string.IsNullOrWhiteSpace(appDateTimePicker.Text) || 
                (appTimePicker.Text) == "Select a Time" || string.IsNullOrEmpty(cusIDTextBox.Text))
            {
                return false;
            }
            return true;
        }

        private void AppointmentAddModForm_Load(object sender, EventArgs e)
        {
            if (Program.modifyMode)
            {
                //Change Title of Form
                appointmentAddModTitleLabel.Text = "Modify Appointment";

                //Prefill all text boxes with the existing data for the selected appointment
                idTextBox.Text = (Program.appointmentList[Program.currentRowSelection].Id).ToString();
                titleTextBox.Text = Program.appointmentList[Program.currentRowSelection].Title;
                descTextBox.Text = Program.appointmentList[Program.currentRowSelection].Description;
                appDateTimePicker.Value = Program.appointmentList[Program.currentRowSelection].Date_MMDDYYYY;
                appTimePicker.Text = Program.appointmentList[Program.currentRowSelection].Time;
                cusIDTextBox.Text = (Program.appointmentList[Program.currentRowSelection].CustomerID).ToString();
            }
            else
            {
                idTextBox.Text = (Program.appointmentIDcount + 1).ToString();
            }
        }

        private void viewCusBtn_Click(object sender, EventArgs e)
        {
            CustomersQuickViewForm qv = new CustomersQuickViewForm();
            qv.ShowDialog();
            cusIDTextBox.Text = (Program.customerList[Program.currentCusSelection].Id).ToString();
            
            
                

            
        }
    }
}
