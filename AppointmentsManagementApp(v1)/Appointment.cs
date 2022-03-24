using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSchedulingApp_v1_
{
    internal class Appointment
    {
        int _id;
        string _title;
        string _description;
        DateTime _date;
        string _time;
        int _customerID;
        int _userID;
        
        //Properties
        public int Id { get => _id; set => _id = value; }
        public string Title { get => _title; set => _title = value; }
        public string Description { get => _description; set => _description = value; }
        public DateTime Date_MMDDYYYY { get => _date; set => _date = value; }
        public string Time { get => _time; set => _time = value; }
        public int CustomerID { get => _customerID; set => _customerID = value; }
        public int UserID { get => _userID; set => _userID = value; }

        public Appointment(string title, string desc, DateTime date, string time, int cusID, int userID)
        {
            Id = ++Program.appointmentIDcount;
            Title = title;
            Description = desc;
            Date_MMDDYYYY = date;
            Time = time;
            CustomerID = cusID;
            UserID = userID;
        }

        
    }
}
