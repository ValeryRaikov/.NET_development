using System;
using System.Collections.Generic;
using System.Linq;
using Project_Valeri.Model;
using Project_Valeri.Others;

namespace Project_Valeri_Extended.Data
{
    internal class UserData
    {
        private List<User> _users;
        private int _nextId;

        public List<User> Users
        {
            get { return _users; }
            set { _users = value; }
        }

        public int NextId
        {
            get { return _nextId; }
            set { _nextId = value; }
        }

        public UserData()
        {
            NextId = 0;
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            user.Id = _nextId++;
            Users.Add(user);
        }

        public void DeleteUser(User user)
        {
            Users.Remove(user);
        }

        public bool ValidateUser(string name, string password)
        {
            foreach (var user in Users)
            {
                if (user.Name == name && user.Password == Utils.HashPassword(password))
                {
                    return true;
                }
            }

            return false;
        }

        public bool ValidateUserLambda(string name, string password)
        {
            return Users
                .Where(x => x.Name == name && x.Password == Utils.HashPassword(password))
                .FirstOrDefault() != null ? true : false;
        }

        public bool ValidateUserLinq(string name, string password)
        {
            var ret =
                from user in Users
                where user.Name == name && user.Password == Utils.HashPassword(password)
                select user.Id;

            return ret != null ? true : false;
        }

        public User GetUser(string name, string password)
        {
            return Users.FirstOrDefault(x => x.Name == name && x.Password == Utils.HashPassword(password));
        }

        public bool SetActive(string username, DateTime validDate)
        {
            var user = Users.FirstOrDefault(u => u.Name == username);

            if (user != null)
            {
                user.Expires = validDate;
                return true;
            }

            return false;
        }

        public bool AssignUserRole(string username, UserRolesEnum role)
        {
            var user = Users.FirstOrDefault(u => u.Name == username);
            if (user != null)
            {
                user.Role = role;
                return true;
            }

            return false;
        }
    }
}
