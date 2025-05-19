namespace MauiMVVM2.Models
{
    public class User
    {
        private static int _id = 1;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public User(string name, string email)
        {
            Id = _id;
            Name = name;
            Email = email;

            _id++;
        }
    }
}
