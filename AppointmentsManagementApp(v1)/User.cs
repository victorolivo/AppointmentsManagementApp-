using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSchedulingApp_v1_
{
    public class User
    {
        int _id;
        string _username;
        string _password;


        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int Id { get => _id; set => _id = value; }

        public User(string username, string password, int id)
        {
            Username = username;
            Password = password;
            Id = id;
        }


    }
}
