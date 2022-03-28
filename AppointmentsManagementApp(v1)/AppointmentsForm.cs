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
            using (SqlConnection con = new SqlConnection(Program.conS))
            {
                //Get all customers sql command
                string sql = "Select * from dbo.Appointment";

                SqlCommand command = new SqlCommand(sql, con);

                try
                {
                    //Open Database connection
                    con.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    appointmentDGV.DataSource = dt;

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
                    //Delete Selected Appointment
                    using (SqlConnection con = new SqlConnection(Program.conS))
                    {
                        string sql = "Delete From dbo.Appointment Where ID = " + Program.currentIDSelection;

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

        //Selection Tracker
        private void appointmentDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.currentIDSelection = (int)appointmentDGV.Rows[e.RowIndex].Cells[0].Value;
                int cusID = (int)appointmentDGV.Rows[e.RowIndex].Cells[5].Value;

                //User feedback --> Customer related to selected appointment

                using (SqlConnection con = new SqlConnection(Program.conS))
                {
                    //Get data for selected customer
                    string sql = "Select FirstName, LastName From dbo.Customer Where ID = " + cusID;
                    string userFeedBack = "";

                    SqlCommand command = new SqlCommand(sql, con);

                    try
                    {
                        //Open Database connection
                        con.Open();

                        //Read data
                        SqlDataReader cmd = command.ExecuteReader();

                        while (cmd.Read())
                        {
                            userFeedBack = cmd.GetString(0).ToString() + " " + cmd.GetString(1).ToString();
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


                    DataGridViewCell cell = appointmentDGV.Rows[e.RowIndex].Cells[5];
                    cell.ToolTipText = userFeedBack;
                }

            }
            catch (Exception)
            {
                appointmentDGV.CurrentCell = null;
            }

            
        }

        //Trigger: User cancels the operation (clicks on 'Cancel' btn)
        //Action: Takes the user back to main menu 
        private void cancelAppointmentOperationBtn_Click(object sender, EventArgs e)
        {
            MainWindowForm m = new MainWindowForm();
            m.Show();
            this.Hide();
        }


    }
}
