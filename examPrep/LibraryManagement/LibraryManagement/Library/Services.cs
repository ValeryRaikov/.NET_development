﻿using System.Text.Json;

namespace LibraryManagement.Library
{
    public class Services
    {
        private List<User> users = new List<User>();
        private List<string> usernames = new List<string>();
        private List<Book> books = new List<Book>();
        private List<string> bookTitles = new List<string>();

        private readonly string baseDataPath = Path.Combine(AppContext.BaseDirectory, "Data");
        private readonly DirectoryInfo usersDir;
        private readonly DirectoryInfo booksDir;

        public Services()
        {
            usersDir = new DirectoryInfo(Path.Combine(baseDataPath, "Users"));
            booksDir = new DirectoryInfo(Path.Combine(baseDataPath, "Books"));

            if (!Directory.Exists(baseDataPath))
            {
                Directory.CreateDirectory(baseDataPath);
            }

            if (!usersDir.Exists)
            {
                usersDir.Create();
            }

            if (!booksDir.Exists)
            {
                booksDir.Create();
            }
        }

        public void AddUser(User u)
        {
            users.Add(u);
            usernames.Add(u.Name);
        }

        public int Login(string phoneNumber, string email)
        {
            int found = -1;
            foreach (User u in users)
            {
                if (u.PhoneNumber.Equals(phoneNumber) && u.Email.Equals(email))
                {
                    found = users.IndexOf(u);
                    break;
                }
            }

            return found;
        }

        public User getUser(int found)
        {
            return users[found];
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            bookTitles.Add(book.Title);
        }

        public void LoadUsersFromFile()
        {
            try
            {
                string filePath = Path.Combine(usersDir.FullName, "users.json");

                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    List<User>? loadedUsers = JsonSerializer.Deserialize<List<User>>(json);

                    if (loadedUsers != null)
                    {
                        users = loadedUsers;
                        usernames = loadedUsers.Select(u => u.ToString()).ToList();
                    }
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SaveUsersToFile()
        {
            try
            {
                string filePath = Path.Combine(usersDir.FullName, "users.json");

                string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(filePath, json);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
