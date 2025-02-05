using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace topic06
{
    class Student
    {
        public String name;
        public int age;

        public Student(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 05. ToString()
        public override string ToString()
        {
            return $"Student: {name} at the age of {age}";
        }
    }
}
