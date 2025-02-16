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

        public static User TestUser
        {
            get 
            { 
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        static UserData()
        {
            ResetTestUserData();
        }

        private static void ResetTestUserData()
        {
            if (_testUser == null)
                _testUser = new User("Valeri_R", "Valercho123", "121222139", 1);
        }
    }
}
