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
    public partial class CustomersQuickViewForm : Form
    {

        public CustomersQuickViewForm()
        {
            InitializeComponent();
        }

        
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
                    cusQuickViewDGV.DataSource = dt;

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

        private void CustomersQuickViewForm_Shown(object sender, EventArgs e)
        {
            paintDGV();
            cusQuickViewDGV.CurrentCell = null;
        }

        private void cusQuickViewDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Program.currentIDSelection = (int)cusQuickViewDGV.Rows[e.RowIndex].Cells[0].Value;
            }
            catch (Exception)
            {

                cusQuickViewDGV.CurrentCell = null;
            }
        }

        private void submitSelectedCusBtn_Click(object sender, EventArgs e)
        {
            if (cusQuickViewDGV.CurrentCell == null)
            {
                MessageBox.Show("Please make a selection");
            }
            else
            {
                this.Hide();
            }
        }

    }
}
