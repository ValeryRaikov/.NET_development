using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class SchoolClass
    {
        private static int numberOfClasses = 0;
        private int year;
        private List<Student> students;

        public int Year
        {
            get { return year; }
            protected set { year = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            protected set { students = value; }
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public SchoolClass(int year)
        {
            Year = year;
            Students = new List<Student>();

            if (numberOfClasses > 10)
                throw new Exception("Maximun number of classes reached!");

            numberOfClasses++;
        }

        public override string ToString()
        {
            return $"School class: {Year}";
        }
    }
}
