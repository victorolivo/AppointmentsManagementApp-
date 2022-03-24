using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentSchedulingApp_v1_
{
    internal static class Program
    {
        //Global use variables/collections for data traking and logic proccesing
        public static int customerIDcount = 0;
        public static int appointmentIDcount = 0;
        public static int currentRowSelection;
        public static int currentCusSelection;
        public static bool modifyMode;
        public static string currentUser = "";
        public static int currentUserID = 0;

        //BindingList is the same as a List but provides helper functions for updating and keeping data integrity (two-way data binding)
        public static BindingList<Customer> customerList = new BindingList<Customer>();
        public static BindingList<Appointment> appointmentList = new BindingList<Appointment>();
   
        //Internally create two users to testing and demostration purposes only (Not efficcient or secure - Will be improved in version 2.0)
        public static User tester = new User("victorjolivo", "password", 5823);
        public static User randomUser = new User("anotherUser", "anotherPassword", 4589);


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Database simulation; Database plans to be implemented in a future version
            LoadSampleData();


            //Launch App
            //Application.Run(new LoginForm());
            Application.Run(new MainWindowForm());


            
        }

        private static void LoadSampleData()
        {
            //Sample Customers
            Customer cusNum1 = new Customer("Mike", "Flemming", "mike.flemming@outlook.com","787-858-1111");
            Customer cusNum2 = new Customer("Zhixuan", "Wan", "zhixuan.wan@outlook.com", "659-858-2222");
            Customer cusNum3 = new Customer("Jesse", "Barry", "jesse.barry@outlook.com", "783-858-3333");
            Customer cusNum4 = new Customer("John", "Doe", "jonh.doe@hotmail.com", "959-887-4569");
            Customer cusNum5 = new Customer("Victor", "Olivo", "victor.olivo@outlook.com", "787-659-5555");

            //Sample Appointments
            DateTime time1 = new DateTime(2022,6,10);
            DateTime time2 = new DateTime(2022, 4, 01);
            DateTime time3 = new DateTime(2022, 3, 28);
            DateTime time4 = new DateTime(2022, 5, 19);
            DateTime time5 = new DateTime(2022, 7, 06);
            Appointment app1 = new Appointment("CIF","Military eqipment turn in", time1, "1:00pm", cusNum1.Id, tester.Id);
            Appointment app2 = new Appointment("Capstone", "SFL-TAP Final Out", time2, "3:00pm", cusNum5.Id, tester.Id);
            Appointment app3 = new Appointment("Transportation", "ETS trasportation planning", time3, "9:00am", cusNum1.Id, randomUser.Id);
            Appointment app4 = new Appointment("Unit Clearing", "Clear unit with all admin offices", time4, "9:00am", cusNum1.Id, tester.Id);
            Appointment app5 = new Appointment("Final Out", "Sign Out of the military installation", time5, "4:00pm", cusNum2.Id, randomUser.Id);

            //Fill the lists with the sample data
            customerList.Add(cusNum1);
            customerList.Add(cusNum2);
            customerList.Add(cusNum3);
            customerList.Add(cusNum4);
            customerList.Add(cusNum5);
            appointmentList.Add(app1);
            appointmentList.Add(app2);
            appointmentList.Add(app3);
            appointmentList.Add(app4);
            appointmentList.Add(app5);
        }
    }
}
