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
        public UserRoles UserRole { get; set; }

        public User(string username, string password, string facultyNumber, UserRoles userRole)
        {
            Username = username;
            Password = password;
            FacultyNumber = facultyNumber;
            UserRole = userRole;
        }
    }
}
