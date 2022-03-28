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
            
            using (SqlConnection con = new SqlConnection(Program.conS))
            {
                //Get all customers sql command
                string sql = "Select * from dbo.Customer";

                SqlCommand command = new SqlCommand(sql, con);

                try
                {
                    //Open Database connection
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    customersDGV.DataSource = dt;

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

            customersDGV.CurrentCell = null;
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
                    //Delete Selected Customer
                    using (SqlConnection con = new SqlConnection(Program.conS))
                    {
                        
                        string sql = "Delete From dbo.Customer Where ID = " + Program.currentIDSelection;

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

                    //Delete related appointments
                    using (SqlConnection con = new SqlConnection(Program.conS))
                    {
                        //Get data for selected customer
                        string sql = "Delete From dbo.Appointment Where CustomerID = " + Program.currentIDSelection;

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

                    paintDGV();
                }
                    
            }
        }

        //Index Tracker
        private void customersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                Program.currentIDSelection = (int)customersDGV.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {

                customersDGV.CurrentCell = null;
            }
        }

        //Trigger: Method executes when Customer Form opens
        //Action: It clears the data grid view selection and updates its data
        private void CustomersForm_Shown(object sender, EventArgs e)
        {
            customersDGV.CurrentCell = null;
            paintDGV();
        }


        #region beta feature 
        //private int getLastID()
        //{
        //    int id = -1;
        //    using (SqlConnection con = new SqlConnection(Program.conS))
        //    {
        //        //SQL Command
        //        string sql = "Select MAX(ID) From dbo.Customer";

        //        SqlCommand command = new SqlCommand(sql, con);

        //        try
        //        {
        //            //Open Database connection
        //            con.Open();

        //            //Read all valid users and their passwords
        //            SqlDataReader cmd = command.ExecuteReader();

        //            while (cmd.Read())
        //            {
        //                id = cmd.GetInt32(0);
        //            }



        //            cmd.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            //If an exception occurs, write it to the console
        //            Console.WriteLine(ex.ToString());
        //            MessageBox.Show("XX");
        //        }
        //        finally
        //        {
        //            con.Close();
        //        }

        //        return id;
        //    }
        //} 
        #endregion
    }
}
