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
                using (SqlConnection con = new SqlConnection(Program.conS))
                {
                    //Get data for selected customer
                    string sql = "Select * from dbo.Customer Where ID = " + Program.currentIDSelection;
                    
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
                            firstNameTextBox.Text = (cmd.GetString(1)).ToString();
                            lastNameTextBox.Text = (cmd.GetString(2)).ToString();
                            emailTextBox.Text = (cmd.GetString(3)).ToString();
                            phoneTextBox.Text = (cmd.GetString(4)).ToString();
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
                
            }
        }


        //Trigger: User submits form (click on 'Submit' btn)
        //Action: Saves new or modified customer
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if(formValid())
            {
                if (Program.modifyMode)
                {
                    //Save changes to DB
                    using (SqlConnection con = new SqlConnection(Program.conS))
                    {
                        //Get data for selected customer
                        string sql = "UPDATE Customer SET " +
                                        "FirstName = '" + firstNameTextBox.Text + "', " +
                                        "LastName = '" + lastNameTextBox.Text + "', " +
                                        "Email = '" + emailTextBox.Text + "', " +
                                        "Phone = '" + phoneTextBox.Text + "' " +

                                        "WHERE ID = " + Program.currentIDSelection;

                        
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
                        string sql = "INSERT INTO Customer (FirstName,LastName,Email,Phone) " +
                                        "VALUES ('" + firstNameTextBox.Text + "'," +
                                        "'" + lastNameTextBox.Text + "'," +
                                        "'" + emailTextBox.Text + "'," +
                                        "'" + phoneTextBox.Text + "')";
                                        

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
