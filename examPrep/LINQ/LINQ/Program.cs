using LINQ.Models;
using LINQ.Services;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<BasePerson>();

            var student1 = new Student("John", "Doe", 20, "1234567890", "9FEG", 8);
            var student2 = new Student("Alice", "Johnson", 21, "1122334455", "144 SOU", 10);
            var uniStudent1 = new UniversityStudent("Jane", "Smith", 22, "0987654321", "TU-Sofia", "BCSE", "121222139", 1);
            var uniStudent2 = new UniversityStudent("Robert", "Brown", 23, "5566778899", "UNWE", "Digital Marketing", "121222147", 2);

            Console.WriteLine("Adding people...");
            PersonService.AddStudent(people, student1);
            PersonService.AddStudent(people, student2);
            PersonService.AddStudent(people, uniStudent1);
            PersonService.AddStudent(people, uniStudent2);

            Console.WriteLine("\nAttempting to add duplicate...");
            PersonService.AddStudent(people, new Student("John", "Doe", 20, "1234567890", "18 SOU", 12));

            Console.WriteLine("\nCurrent people list:");
            PersonService.DisplayPeople(people);

            Console.WriteLine("\nUpdating Alice Johnson to Alice Williams...");
            var updatedStudent = new Student("Alice", "Williams", 21, "1122334455", "32 SOU", 7);
            PersonService.UpdateStudent(people, student2, updatedStudent);

            Console.WriteLine("\nUpdated list (query syntax):");
            PersonService.DisplayPeopleQuery(people);

            Console.WriteLine("\nRemoving Jane Smith...");
            PersonService.RemoveStudent(people, uniStudent1);

            Console.WriteLine("\nFinal people list:");
            PersonService.DisplayPeople(people);

            Console.WriteLine("\nStudents only:");
            PersonService.DisplayPeople(PersonService.Students.Cast<BasePerson>().ToList());

            Console.WriteLine("\nUniversity Students only:");
            PersonService.DisplayPeople(PersonService.UniversityStudents.Cast<BasePerson>().ToList());

            Console.WriteLine("---------------------------");
            // More LINQ SQL Syntax Examples:
            var names = new List<string>
            {
                "Ivan", "Stamat", "Valery", "Maria", "Petra", "Georgi", "Vasilena", "Magdalena", "Ivaylo", "Vasil", "Mihail",
                "Grigor", "Gerasim", "Viktoriq",
            };

            var namesWithM = (
                from n in names
                where n.StartsWith("M")
                orderby n
                select n
            ).ToList();

            foreach (var name in namesWithM)
            {
                Console.Write($"{name}, ");
            }

            Console.WriteLine();

            var namesWithLength6 = (
                from n in names
                where n.Length == 6
                select n
            ).ToList();

            foreach (var name in namesWithLength6)
            {
                Console.Write($"{name}, ");
            }

            Console.WriteLine();

            var firstNameWithV = (
                from n in names
                where n.StartsWith("V")
                select n
            ).FirstOrDefault();

            Console.WriteLine(firstNameWithV);

            var check1 = (
                from n in names
                where n.Length > 5
                select n
            ).Any();

            Console.WriteLine(check1);

            var check2 = names.All(n => n.Length > 3);
            Console.WriteLine(check2);

            var check3 = names.All(n => n.Length > 5);
            Console.WriteLine(check3);

            var final = (
                from n in names
                where n.Contains("e")
                select n
            ).Count();

            Console.WriteLine(final);
        }
    }
}