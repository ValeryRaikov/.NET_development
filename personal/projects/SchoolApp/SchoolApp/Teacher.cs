using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Teacher : Person
    {
        private int experience;
        private List<SchoolClass> schoolClasses;

        public int Experience
        {
            get { return experience; }
            protected set { experience = value; }
        }

        public List<SchoolClass> SchoolClasses
        {
            get { return schoolClasses; }
            protected set { schoolClasses = value; }
        }

        public Teacher(string name, int age, char gender, int experience) : base(name, age, gender)
        {
            this.Experience = experience;
            this.SchoolClasses = new List<SchoolClass>();
        }

        public void TakeClass(SchoolClass sc)
        {
            if (SchoolClasses.Contains(sc))
            {
                Console.WriteLine("School Class already taken!");
                return;
            }

            SchoolClasses.Add(sc);
            Console.WriteLine($"{sc} taken by {this}.");
        }

        public void RemoveClass(SchoolClass sc)
        {
            if (!SchoolClasses.Contains(sc))
            {
                Console.WriteLine("School Class hasn't been taken yet!");
                return;
            }

            SchoolClasses.Remove(sc);
            Console.WriteLine($"{sc} left by {this}.");
        }

        public void Retire()
        {
            SchoolClasses.Clear();
            Console.WriteLine($"{this} retired.");
        }

        public void AddStudent(SchoolClass sc, Student st)
        {
            if (!SchoolClasses.Contains(sc))
            {
                Console.WriteLine("School class not taken yet!");
                return;
            }

            if (sc.GetStudents().Contains(st))
            {
                Console.WriteLine("Student is already in this class!");
                return;
            }

            sc.GetStudents().Add(st);
            Console.WriteLine($"{st} added to {sc}.");
        }

        public void RemoveStudent(SchoolClass sc, Student st)
        {
            if (!SchoolClasses.Contains(sc))
            {
                Console.WriteLine("School class not taken yet!");
                return;
            }

            if (!sc.GetStudents().Contains(st))
            {
                Console.WriteLine("Student is not in this class!");
                return;
            }

            sc.GetStudents().Remove(st);
            Console.WriteLine($"{st} removed from {sc}.");
        }

        public void AddStudentGrade(Student st, Grade grade)
        {
            foreach(SchoolClass sc in SchoolClasses)
            {
                if (sc.GetStudents().Contains(st))
                {
                    if (st.NoteBook.ContainsKey(grade.Subject))
                    {
                        ((List<Grade>)st.NoteBook[grade.Subject]).Add(grade);

                        Console.WriteLine($"Added {grade} for {st} in {grade.Subject}.");
                        return;
                    }

                    Console.WriteLine("No such subject in student's list!");
                    return;
                }
            }

            Console.WriteLine("Student is not in any of the teacher's classes!");
        }

        public override string ToString()
        {
            return $"Teacher: {Name}";
        }
    }
}
