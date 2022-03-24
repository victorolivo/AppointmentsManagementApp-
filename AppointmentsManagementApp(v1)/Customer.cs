using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSchedulingApp_v1_
{
    internal class Customer
    {
        int _id;
        string _firstName;
        string _lastName;
        string _email;
        string _phone;

        //Properties
        public int Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }


        public Customer(string fname, string lname, string email, string phone)
        {
            Id = ++Program.customerIDcount;
            FirstName = fname;
            LastName = lname;
            Email = email;
            Phone = phone;
        }

        
    }
}
