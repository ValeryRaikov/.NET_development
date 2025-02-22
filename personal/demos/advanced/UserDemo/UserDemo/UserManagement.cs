using System;
using System.Collections.Generic;
using System.Linq;

namespace UserDemo
{
    internal class UserManagement
    {
        private HashSet<User> _users;

        public UserManagement()
        {
            _users = new HashSet<User>();
        }

        public User GetUser(string name, string pass)
        {
            return _users.FirstOrDefault(u => u.Username == name && u.Password == pass); // returns null if user not found
        }

        public void AddUser(string name, string pass)
        {
            _users.Add(new User(name, pass));
        }

        public void RemoveUser(string name, string pass)
        {
            _users.Remove(GetUser(name, pass));
        }

        public void DisplayUsers()
        {
            Console.WriteLine($"Total Users: {_users.Count()}");
            foreach (var user in _users)
                Console.WriteLine(user);
        }

        // LINQ 
        public HashSet<User> FilterUsernames(string startSymbol)
        {
            return (
                from u in _users
                where u.Username.StartsWith("@" + startSymbol, StringComparison.CurrentCultureIgnoreCase)
                select u
            ).ToHashSet();

            // return _users
            //     .Where(u => u.Username.StartsWith("@" + startSymbol, StringComparison.CurrentCultureIgnoreCase)).ToHashSet();
        }

        public HashSet<User> FilterPasswords(Func<User, bool> predicate)
        {
            HashSet<User> filteredUsers = new HashSet<User>();

            foreach (User user in _users)
                if (predicate(user))
                    filteredUsers.Add(user);

            return filteredUsers;
        }

        // This is just for test purpose instead of Count() method...
        public int CountFilteredPassword(Func<User, bool> predicate)
        {
            return _users.Aggregate(0, (acc, user) => predicate(user) ? acc + 1 : acc);
        }
    }
}
