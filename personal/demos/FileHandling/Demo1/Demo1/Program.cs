using System;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace Demo1
{
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        public Person(string name, int age, char gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public override string ToString()
        {
            return $"{_name}, {_age}, {_gender}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Path.Combine(Environment.CurrentDirectory, "testfile.txt");

            if (File.Exists(filePath))
                Console.WriteLine("File created successfully!");
            else
                Console.WriteLine("Unable to create the file!");

            // Write single line
            File.WriteAllText(filePath, "Hello there...");

            // Write multiple lines
            string[] lines = new string[]
            {
                "Hello again...",
                "My name is Valery.",
                "How are you?",
                DateTime.Now.ToString(),
            };

            File.WriteAllLines(filePath, lines);

            // Write List of user defined object
            List<Person> people = new List<Person>()
            {
                new Person("Stamat", 47, 'M'),
                new Person("Dimitar", 29, 'M'),
                new Person("Mihaela", 34, 'F'),
                new Person("Kristina", 51, 'F'),
            };

            List<string> peopleStr = people.ConvertAll(p => p.ToString());
            File.WriteAllLines(filePath, peopleStr);

            // Read the content of the file
            string[] content = File.ReadAllLines(filePath);

            foreach (var line in content)
            {
                Console.WriteLine(line);
            }

            // Delete the file
            File.Delete(filePath);
        }
    }
}
