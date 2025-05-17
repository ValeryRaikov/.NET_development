using LINQ.Models;

namespace LINQ.Services
{
    public static class PersonService
    {
        public static List<Student> Students { get; } = new List<Student>();
        public static List<UniversityStudent> UniversityStudents { get; } = new List<UniversityStudent>();

        public static void DisplayPeople(List<BasePerson> people)
        {
            if (people == null || !people.Any())
            {
                Console.WriteLine("No people to display.");
                return;
            }

            Console.WriteLine("\nPeople List (Method Syntax):");
            Console.WriteLine("---------------------------");

            people.OrderBy(p => p.FirstName)
                .ThenBy(p => p.LastName)
                .ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine($"\nTotal people: {people.Count}");
        }

        public static void DisplayPeopleQuery(List<BasePerson> people)
        {
            if (people == null || !people.Any())
            {
                Console.WriteLine("No people to display.");
                return;
            }

            Console.WriteLine("\nPeople List (Query Syntax):");
            Console.WriteLine("--------------------------");

            var orderedPeople = from p in people
                                orderby p.LastName, p.FirstName
                                select p;

            foreach (var person in orderedPeople)
            {
                Console.WriteLine(person);
            }

            Console.WriteLine($"\nTotal people: {people.Count}");
        }

        public static void AddStudent(List<BasePerson> people, BasePerson person)
        {
            if (people == null) return;

            if (!people.Any(p => p.Pin == person.Pin))
            {
                people.Add(person);
                AddToSpecializedList(person);
                Console.WriteLine($"Added: {person}");
            }
            else
            {
                Console.WriteLine($"Duplicate PIN {person.Pin} - not added");
            }
        }

        private static void AddToSpecializedList(BasePerson person)
        {
            switch (person)
            {
                case UniversityStudent uniStudent:
                    UniversityStudents.Add(uniStudent);
                    break;
                case Student student:
                    Students.Add(student);
                    break;
            }
        }

        public static void RemoveStudent(List<BasePerson> people, BasePerson person)
        {
            if (people == null) return;

            var personToRemove = people.FirstOrDefault(p => p.Pin == person.Pin);
            if (personToRemove == null)
            {
                Console.WriteLine($"Person with PIN {person.Pin} not found");
                return;
            }

            people.Remove(personToRemove);
            RemoveFromSpecializedList(personToRemove);
            Console.WriteLine($"Removed: {personToRemove}");
        }

        private static void RemoveFromSpecializedList(BasePerson person)
        {
            switch (person)
            {
                case UniversityStudent uniStudent:
                    UniversityStudents.Remove(uniStudent);
                    break;
                case Student student:
                    Students.Remove(student);
                    break;
            }
        }

        public static void UpdateStudent(List<BasePerson> people, BasePerson oldPerson, BasePerson newPerson)
        {
            if (people == null) return;
            if (oldPerson.Pin != newPerson.Pin)
            {
                Console.WriteLine("Error: Cannot change PIN during update");
                return;
            }

            int index = people.FindIndex(p => p.Pin == oldPerson.Pin);
            if (index == -1)
            {
                Console.WriteLine($"Person with PIN {oldPerson.Pin} not found");
                return;
            }

            people[index] = newPerson;
            UpdateSpecializedList(oldPerson, newPerson);
            Console.WriteLine($"Updated: {oldPerson} to {newPerson}");
        }

        private static void UpdateSpecializedList(BasePerson oldPerson, BasePerson newPerson)
        {
            switch (oldPerson)
            {
                case UniversityStudent oldUni when newPerson is UniversityStudent newUni:
                    var uniIndex = UniversityStudents.FindIndex(s => s.Pin == oldUni.Pin);
                    if (uniIndex != -1) UniversityStudents[uniIndex] = newUni;
                    break;
                case Student oldStd when newPerson is Student newStd:
                    var stdIndex = Students.FindIndex(s => s.Pin == oldStd.Pin);
                    if (stdIndex != -1) Students[stdIndex] = newStd;
                    break;
            }
        }
    }
}