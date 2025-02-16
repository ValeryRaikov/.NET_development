using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class School
    {
        private string name;
        private Director director;
        private List<Teacher> teachers;

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public Director Director
        {
            get { return director; }
            protected set { director = value; }
        }

        public List<Teacher> Teachers
        {
            get { return teachers; }
            protected set { teachers = value; }
        }

        public School(string name, Director director)
        {
            this.Name = name;
            this.Director = director;
            Teachers = new List<Teacher>();
        }

        public void ChangeDirector(Director d)
        {
            if (d == null)
            {
                Console.WriteLine("Cannot assign a null director!");
                return;
            }

            if (Director != null && Director.Equals(d))
            {
                Console.WriteLine("Cannot change director with the same director!");
                return;
            }

            Director = d;
            Console.WriteLine($"Director changed to: {Director}");

            List<Director> directors = FileManager.LoadDirectors();
            directors.Add(d);
            FileManager.SaveDirectors(directors);
        }

        public void HireNewTeacher(Teacher t)
        {
            if (Teachers.Contains(t))
            {
                Console.WriteLine("Teacher already hired in this school!");
                return;
            }

            Teachers.Add(t);
            Console.WriteLine($"{t} hired in {this}");

            List<Teacher> teachers = FileManager.LoadTeachers();
            teachers.Add(t);
            FileManager.SaveTeachers(teachers);
        }

        public void FireTeacher(Teacher t)
        {
            if (!Teachers.Contains(t))
            {
                Console.WriteLine("No such teacher hired in the school!");
                return;
            }

            Teachers.Remove(t);
            Console.WriteLine($"{t} fired from {this}.");

            List<Teacher> teachers = FileManager.LoadTeachers();
            teachers.RemoveAll(x => x.Equals(t));
            FileManager.SaveTeachers(teachers);
        }

        public void DisplayStaff()
        {
            Console.WriteLine(Director);

            if (Teachers.Count() == 0)
            {
                Console.WriteLine("No teachers hired yet!");
                return;
            }

            Console.WriteLine($"Teachers {Teachers.Count()}");
            foreach(Teacher t in Teachers)
            {
                Console.WriteLine(t);
            }
        }

        public override string ToString()
        {
            return $"School: {Name}";
        }
    }
}
