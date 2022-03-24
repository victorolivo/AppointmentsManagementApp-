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
    public partial class MainWindowForm : Form
    {
        //Constructor
        public MainWindowForm()
        {
            InitializeComponent();
            welcomeUserLabel.Text = "Welcome " + Program.currentUser;
        }

        //Trigger: Method executes when user selects 'View Customers' option (click on icon)
        //Action: Takes user to the Customers Form window
        private void customersPictureBox_Click(object sender, EventArgs e)
        {
            //Idea for a future version: One window(form) app
            //customersPictureBox.Visible = false;

            this.Hide();
            CustomersForm c = new CustomersForm();
            c.Show();
        }

        //Trigger: Method executes when user selects 'View Customers' option (click on text)
        //Action: Call previous method for code re-use (Takes user to the Customers Form window)
        private void customersPictureBoxLabel_Click(object sender, EventArgs e)
        {
            customersPictureBoxLabel_Click(sender,e);
        }

        //Trigger: Method executes when the user closes Main Window Form by pressing the top-right 'X' button
        //Action: Terminates the application
        private void MainWindowForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Trigger: Method executes when user selects 'View Appointments' option (click on icon)
        //Action: Takes user to the Appointments Form window
        private void appointmentsPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsForm a = new AppointmentsForm();
            a.Show();
        }

        //Trigger: Method executes when user selects 'View Appointments' option (click on text)
        //Action: Call previous method for code re-use (Takes user to the Appointment Form window)
        private void appointmentsPictureBoxLabel_Click(object sender, EventArgs e)
        {
            appointmentsPictureBox_Click(sender, e);
        }

        //Trigger: Method executes when user signs out of the application
        //Action: Takes user to the LogIn Form window
        private void signOutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm l = new LoginForm();
            l.Show();
        }

        private void creditsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Credits c = new Credits();
            c.Show();
        }
    }
}
