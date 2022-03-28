using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
                    //Save changes to DB
                    using (SqlConnection con = new SqlConnection(Program.conS))
                    {
                        //Get data for selected customer
                        string sql = "UPDATE Appointment SET " +
                                        "Title = '" + titleTextBox.Text + "', " +
                                        "Description = '" + descTextBox.Text + "', " +
                                        "Date = '" + appDateTimePicker.Text + "', " +
                                        "Time = '" + appTimePicker.Text + "', " +
                                        "CustomerID = " + Convert.ToInt32(cusIDTextBox.Text) +

                                        " WHERE ID = " + Program.currentIDSelection;


                        SqlCommand command = new SqlCommand(sql, con);

                        try
                        {
                            //Open Database connection
                            con.Open();
                            command.ExecuteNonQuery();
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


                }
                else
                {
                    //Create new customer and adds it to the DB
                    using (SqlConnection con = new SqlConnection(Program.conS))
                    {
                        //Get data for selected customer
                        string sql = "INSERT INTO Appointment (Title,Description,Date,Time,CustomerID,UserID) " +
                                        "VALUES ('" + titleTextBox.Text + "'," +
                                        "'" + descTextBox.Text + "'," +
                                        "'" + (appDateTimePicker.Value.ToShortDateString()) + "'," +
                                        "'" + appTimePicker.Text + "'," +
                                         Convert.ToInt32(cusIDTextBox.Text) + "," +
                                         Program.currentUserID + ")";



                        SqlCommand command = new SqlCommand(sql, con);

                        try
                        {
                            //Open Database connection
                            con.Open();
                            command.ExecuteNonQuery();
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


                //Prefill all text boxes with the existing data for selected appointment
                using (SqlConnection con = new SqlConnection(Program.conS))
                {
                    //Get data for selected customer
                    string sql = "Select * from dbo.Appointment Where ID = " + Program.currentIDSelection;

                    SqlCommand command = new SqlCommand(sql, con);

                    try
                    {
                        //Open Database connection
                        con.Open();

                        //Read data
                        SqlDataReader cmd = command.ExecuteReader();

                        while (cmd.Read())
                        {
                            //Prefill all text boxes with the existing data for selected customer
                            idTextBox.Text = (cmd.GetInt32(0)).ToString();
                            titleTextBox.Text = (cmd.GetString(1)).ToString();
                            descTextBox.Text = (cmd.GetString(2)).ToString();
                            appDateTimePicker.Text = (cmd.GetString(3)).ToString();
                            appTimePicker.Text = (cmd.GetString(4)).ToString();
                            cusIDTextBox.Text = (cmd.GetInt32(5)).ToString();
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


            }
            else
            {
                //New Customer (ID will be auto-generated)
                idTextBox.Visible = false;
                idLabel.Visible = false;
                DateTime today = DateTime.Today;
                appDateTimePicker.Text = today.ToString();

            }
        }

        private void viewCusBtn_Click(object sender, EventArgs e)
        {
            CustomersQuickViewForm qv = new CustomersQuickViewForm();
            qv.ShowDialog();
            cusIDTextBox.Text = (Program.currentIDSelection).ToString();
            
            
                

            
        }
    }
}
