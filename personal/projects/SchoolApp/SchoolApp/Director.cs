using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp
{
    public class Director : Person, IEquatable<Director>
    {
        public Director(string name, int age, char gender) : base(name, age, gender) {}

        public bool Equals(Director other)
        {
            if (other == null)
                return false;

            return Name == other.Name && Age == other.Age && Gender == other.Gender;
        }

        public override bool Equals(object obj)
        {
            return obj is Director other && Equals(other);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age, Gender);
        }

        public override string ToString()
        {
            return $"Director: {Name}";
        }
    }
}
