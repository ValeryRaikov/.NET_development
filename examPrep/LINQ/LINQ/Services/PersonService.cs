using LINQ.Models;

namespace LINQ.Services
{
    public static class PersonService
    {
        public static List<Student> students = new List<Student>();
        public static List<UniversityStudent> universityStudents = new List<UniversityStudent>();

        public static void DisplayPeople(List<BasePerson> people)
        {
            people.OrderBy(p => p.FirstName)
                  .ThenBy(p => p.LastName)
                  .ToList()
                  .ForEach(p => Console.WriteLine(p));

            Console.WriteLine($"\nTotal people: {people.Count}\n");
        }

        public static void DisplayPeopleQuery(List<BasePerson> people)
        {
            var orderedPeople = 
                from p in people
                orderby p.LastName, p.FirstName
                select p;

            foreach (var person in orderedPeople)
                Console.WriteLine(person);
        
            Console.WriteLine($"\nTotal people: {people.Count}\n");
        }

        public static void AddStudent(List<BasePerson> people, BasePerson p)
        {
            if (!people.Any(person => person.Pin == p.Pin))
            {
                people.Add(p);

                if (p is Student)
                    students.Add((Student)p);
                else
                    universityStudents.Add((UniversityStudent)p);
            }
        }

        public static void AddStudentQuery(List<BasePerson> people, BasePerson p)
        {
            var exists = (
                from person in people
                where person.Pin == p.Pin
                select person
            ).Any();

            if (!exists)
            {
                people.Add(p);

                if (p is Student)
                    students.Add((Student)p);
                else
                    universityStudents.Add((UniversityStudent)p);
            }
        }

        public static void RemoveStudent(List<BasePerson> people, BasePerson p)
        {
            var personToRemove = people.FirstOrDefault(person => person.Pin == p.Pin);

            if (personToRemove != null)
            {
                people.Remove(personToRemove);

                if (p is Student)
                    students.Remove((Student)p);
                else
                    universityStudents.Remove((UniversityStudent)p);
            }
        }

        public static void UpdateStudent(List<BasePerson> people, BasePerson p1, BasePerson p2)
        {
            int index = people.FindIndex(p => p.Pin == p1.Pin);

            if (index != -1)
            {
                people[index] = p2;

                if (p1 is Student && p2 is Student)
                {
                    int index2 = students.FindIndex(p => p.Pin == p1.Pin);

                    if (index2 != -1)
                    {
                        students[index2] = (Student)p2;
                    }
                }
                else
                {
                    int index2 = universityStudents.FindIndex(p => p.Pin == p1.Pin);

                    if (index2 != -1)
                    {
                        universityStudents[index2] = (UniversityStudent)p2;
                    }
                }
            }
        }

        public static void UpdateStudentQuery(List<BasePerson> people, BasePerson p1, BasePerson p2)
        {
            var existingPerson = (
                from person in people
                where person.Pin == p1.Pin
                select person
            ).FirstOrDefault();

            if (existingPerson != null)
            {
                int index = people.IndexOf(existingPerson);

                if (index != -1)
                {
                    people[index] = p2;

                    if (p1 is Student && p2 is Student)
                    {
                        int index2 = students.FindIndex(p => p.Pin == p1.Pin);

                        if (index2 != -1)
                        {
                            students[index2] = (Student)p2;
                        }
                    }
                    else
                    {
                        int index2 = universityStudents.FindIndex(p => p.Pin == p1.Pin);

                        if (index2 != -1)
                        {
                            universityStudents[index2] = (UniversityStudent)p2;
                        }
                    }
                }
            }
        }
    }
}
