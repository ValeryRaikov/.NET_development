using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public abstract class Person
    {
        private string name;
        private int age;
        private char gender;

        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        public int Age
        {
            get { return age; }
            protected set { age = value; }
        }

        public char Gender
        {
            get { return gender; }
            protected set { gender = value; }
        }

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string ToString()
        {
            return $"Person: {Name}, Age: {Age}, Gender: {Gender}";
        }
    }
}
