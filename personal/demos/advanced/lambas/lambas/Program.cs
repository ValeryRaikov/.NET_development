using System;
using System.Collections.Generic;
using System.Linq;

namespace lambas
{
    class Person
    {
        public string name;
        public int age;

        public Person(string _name, int _age)
        {
            name = _name;
            age = _age;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;

            if (obj is not Person other)
                return false;

            return name == other.name && age == other.age;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, age);
        }

        public override string ToString()
        {
            return $"{name} -> {age}";
        }
    }

    class Program
    {
        delegate bool IntPredicate(int number);

        static IEnumerable<int> Filter(IEnumerable<int> source, IntPredicate predicate)
        {
            List<int> list = new List<int>();

            foreach (int item in source)
            {
                if (predicate(item))
                    list.Add(item);
            }

            return list;
        }

        static void Main(string[] args)
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // 01. Anonymous delegate
            var filteredList = Filter(arr, delegate (int number)
            {
                return number % 3 == 0;
            });

            foreach (var item in filteredList)
            {
                Console.WriteLine(item);
            }

            // 02. Lambda functions

            // IntPredicate lambda = n => n % 3 == 0;

            var filteredList2 = Filter(arr, n => n % 3 == 0);

            foreach (var item in filteredList2)
            {
                Console.WriteLine(item);
            }

            var filteredList3 = Filter(arr, n => (n % 3 == 0) && (n % 5 == 0));
            foreach (var item in filteredList3)
            {
                Console.WriteLine(item);
            }

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
            string text = "someVeryVeryLongAndMessyTextToTestLambdasBlaBlaBla";
            char[] textArr = text.ToCharArray();

            var vowelsArr = textArr.Where(c => vowels.Contains(c)).ToArray();
            var syllablesArr = textArr.Where(c => !vowels.Contains(c)).ToArray();
            int totalA = textArr.Where(c => {
                // just for test
                return c == 'a';
            }).Count();

            Console.WriteLine(vowelsArr);
            Console.WriteLine(syllablesArr);
            Console.WriteLine(totalA);

            List<Person> people = new List<Person>();
            people.Add(new Person("Valery", 21));
            people.Add(new Person("Meggie", 19));
            people.Add(new Person("Petar", 35));

            Person p = new Person("Valery", 21);

            people.RemoveAll(x => x.Equals(p));

            foreach(Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
