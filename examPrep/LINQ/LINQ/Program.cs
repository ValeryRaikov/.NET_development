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

            PersonService.AddStudent(people, new Student("John", "Doe", 20, "1234567890", "18 SOU", 12));
            PersonService.DisplayPeople(people);

            Console.WriteLine("\nUpdating Alice Johnson to Alice Williams...");
            var updatedStudent = new Student("Alice", "Williams", 21, "1122334455", "32 SOU", 7);
            PersonService.UpdateStudent(people, student2, updatedStudent);
            PersonService.DisplayPeopleQuery(people);

            Console.WriteLine("\nRemoving Jane Smith...");
            PersonService.RemoveStudent(people, uniStudent1);
            PersonService.DisplayPeople(people);
        }
    }
}
