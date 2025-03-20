using System.Collections.ObjectModel;
using System.Windows;

namespace RecordBookApp.Models
{
    public class UserManager
    {
        // Simulate database users fetch
        public static ObservableCollection<User> DatabaseUsers = new ObservableCollection<User>
        {
            new User("Valery", "valery@gmail.com"),
            new User("Ivan", "ivancho@abv.bg"),
            new User("Maria", "mariiaM@gmail.com"),
            new User("Ivaylo", "ivoMitkov@yahoo.com"),
            new User("Vasilena", "vasilena@tu-sofia.bg"),
            new User("Magdalena", "meggie_phil@gmail.com"),
        };

        public static ObservableCollection<User> GetUsers()
        {
            return DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            DatabaseUsers.Add(user);
        }
    }
}
