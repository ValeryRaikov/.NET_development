using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FacultyNumber { get; set; }
        public int UserRole { get; set; }

        public User(string _username, string _password, string _facultyNumber, int _userRole)
        {
            Username = _username;
            Password = _password;
            FacultyNumber = _facultyNumber;
            UserRole = _userRole;
        }
    }
}
