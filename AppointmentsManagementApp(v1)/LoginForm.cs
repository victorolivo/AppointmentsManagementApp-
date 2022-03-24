using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSchedulingApp_v1_
{
    public partial class LoginForm : Form
    {
        //Constructor
        public LoginForm()
        {
            InitializeComponent();
        }

        //Trigger: Method executes when user clicks on the 'Submit' button and attempts to login
        //Action: It verifies the user credentials and logs the login attempt in a text file (loginRecords.txt)
        //Note: textfile is located (or created if does not exist) at: AppointmentSchedulingApp(v1)\bin\Debug 
        private void loginSubmitBtn_Click(object sender, EventArgs e)
        {
            if (accessGranted())
            {
                if (!File.Exists("loginRecords.txt"))
                {
                    StreamWriter sw = new StreamWriter("loginRecords.txt");
                    WriteLoginRecordFile(sw);
                }
                else
                {
                    StreamWriter sw = File.AppendText("loginRecords.txt");
                    WriteLoginRecordFile(sw);
                }

                this.Hide();
                MainWindowForm m = new MainWindowForm();
                m.Show();
            }
            else
            {
                MessageBox.Show("The username and password combination does not match our records, please try again");
                userNameTextBox.Clear();
                passwordTextBox.Clear();
            }

        }

        private bool accessGranted()
        {
            //Username and password check
            if(userNameTextBox.Text == Program.tester.Username)
            {
                Program.currentUser = Program.tester.Username;
                if (passwordTextBox.Text == Program.tester.Password)
                {
                    Program.currentUserID = Program.tester.Id;
                    return true;
                }
                    
            }
            else if (userNameTextBox.Text == Program.randomUser.Username){
                Program.currentUser = Program.randomUser.Username;
                if (passwordTextBox.Text == Program.tester.Password)
                {
                    Program.currentUserID = Program.randomUser.Id;
                    return true;
                }
                    
            }
            
            //No matches found
            return false;
            
        }

        //Trigger: Method execute when there is a login attempt
        //Action: Writes login attempt in a text file
        private void WriteLoginRecordFile(StreamWriter sw)
        {
            sw.WriteLine("new user login:");
            sw.WriteLine($"username: {userNameTextBox.Text}");
            sw.WriteLine($"password: {passwordTextBox.Text}");
            sw.WriteLine("\n");
            sw.Close();
        }

        //Trigger: Method executes when the user closes the Login window form by pressing the top-right 'X' button
        //Action: Terminates the application
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
