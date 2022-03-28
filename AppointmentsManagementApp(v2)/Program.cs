using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AppointmentSchedulingApp_v1_
{
    internal static class Program
    {
        //Global use variables/collections for data traking and logic proccesing
        public static int currentIDSelection;
        public static bool modifyMode;
        public static string currentUser = "";
        public static int currentUserID = 0;
        public static string conS = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = AppointmentsManagementDB; Integrated Security = True;";




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Launch App
            Application.Run(new LoginForm());

        }


      
    }
}
