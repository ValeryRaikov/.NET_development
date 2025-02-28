using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public static class UserData
    {
        static private User _testUser;
        static private List<User> _testUsers;

        public static User TestUser
        {
            get 
            { 
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        public static List<User> TestUsers
        {
            get 
            {
                ResetTestUsersData();
                return _testUsers;
            }
            set { }
        }

        static UserData()
        {
            // ResetTestUserData();
            ResetTestUsersData();
        }

        private static void ResetTestUserData()
        {
            if (_testUser == null)
                _testUser = new User("Valeri_R", "Valercho123", "121222139", UserRoles.ADMIN);
        }

        private static void ResetTestUsersData()
        {
            if (_testUsers == null)
                _testUsers = new List<User> {
                    new User("Valeri_R", "Valercho123", "121222139", UserRoles.ADMIN),
                    new User("Meggie_Ph", "Meggot$123", "121222149", UserRoles.STUDENT),
                    new User("Nikolay_N", "Niksun#123", "121222159", UserRoles.INSPECTOR),
                };
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            User foundUser = _testUsers.FirstOrDefault(u => u.Username == username && u.Password == password);

            return foundUser;
        }
    }
}
