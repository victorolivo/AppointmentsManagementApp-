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
using System.Data.SqlClient;

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

            if (accessGranted(userNameTextBox.Text, passwordTextBox.Text))
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

                Program.currentUser = userNameTextBox.Text;
                Program.currentUserID = getUserId();
                this.Hide();
                MainWindowForm m = new MainWindowForm();
                m.Show();
            }
            else
            {
                MessageBox.Show("The username and password combination does not match our records, please try again");
                
                passwordTextBox.Clear();
            }

        }

        private int getUserId()
        {
            int userID = -1;
            using (SqlConnection con = new SqlConnection(Program.conS))
            {
                //SQL Command
                string sql = "Select ID from dbo.[User] Where userName = '" + Program.currentUser + "'";


                SqlCommand command = new SqlCommand(sql, con);

                try
                {
                    //Open Database connection
                    con.Open();

                    //Read all valid users and their passwords
                    SqlDataReader cmd = command.ExecuteReader();

                    while (cmd.Read())
                    {
                        userID = cmd.GetInt32(0);
                    }

                    
                    
                    cmd.Close();
                }
                catch (Exception ex)
                {
                    //If an exception occurs, write it to the console
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("XX");
                }
                finally
                {
                    con.Close();
                }
                return userID;

            }
        }

        private bool accessGranted(string userName, string password)
        { 
            //List<Dictionary<string,string>> users = new List<Dictionary<string,string>>();
            Dictionary<string,string> users = new Dictionary<string,string>();


            using (SqlConnection con = new SqlConnection(Program.conS))
            {
                //Get all valid users sql command
                string sql = "Select * from dbo.[User]";


                SqlCommand command = new SqlCommand(sql, con);

                try
                {
                    //Open Database connection
                    con.Open();

                    //Read all valid users and their passwords
                    SqlDataReader cmd = command.ExecuteReader();
                    while (cmd.Read())
                    {
                        //Save the into a list for validation
                        users.Add(cmd.GetString(1),cmd.GetString(2));
                    }
                    cmd.Close();
                }
                catch (Exception ex)
                {
                    //If an exception occurs, write it to the console
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    con.Close();
                }

            }

            //Username and password check/validation
            foreach (KeyValuePair<string, string> user in users) 
            {
                if (userName.Equals(user.Key) && password.Equals(user.Value))
                    return true;
            }

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
