using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 01. Iterator Blocks
            /*
            var items = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int item in IteratorBlock.MyIteratorBlock(1, 200))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (int item in IteratorBlock.MyIteratorBlock2(IteratorBlock.FilterMin(items, 5)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            */

            // 02. Lambdas
            /*
            Lambdas.InTransaction(() =>
            {
                // ADD MORE BUSINESS LOGIC
                Console.WriteLine("Doing some stuff...");
            });

            Console.WriteLine();
            */

            // 03. Generics
            var stuff = new Generics<string>();
            stuff.Method("hey");

            var stuff2 = new Generics<int>();

            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var oddNum = Filter<int>(list, i => i % 2 != 0);
            var evenNum = Filter<int>(list, i => i % 2 == 0);

            /*
            Console.WriteLine("Odd numbers:");
            foreach (var item in oddNum)
                Console.WriteLine(item);

            Console.WriteLine("Even numbers:");
            foreach (var item in evenNum)
                Console.WriteLine(item);
            */

            var people = new List<Person> { new Person("Alice", "a2"), new Person("Bob", "b2"), new Person("Andrew", "c2") };
            /*
            var peopleStartingWithA = new List<Person>();
            foreach (var person in people)
            {
                if (person.FirstName.Length > 0 && person.FirstName.ToLower()[0] == 'a')
                    peopleStartingWithA.Add(person);
            }
            */

            people.Add(new Person("Lilly", "d2"));
            people.Add(new Person("Alex", "e2"));

            var peopleStartingWithA = 
                Filter(people, p => p.FirstName.StartsWith("a", StringComparison.CurrentCultureIgnoreCase));

            IEnumerable<string> firstNames = Map(people, p => p.FirstName); // var
            foreach (var name in firstNames)
                Console.WriteLine(name);

            Console.WriteLine();

            // 04. LINQ
            var firstNamesWithA = people
                .Where(p => p.FirstName.StartsWith("a", StringComparison.CurrentCultureIgnoreCase))
                .Select(p => p.FirstName);
            foreach (var name in firstNamesWithA)
                Console.WriteLine(name);

            var firstNamesWithA2 =
                from p in people
                where p.FirstName.StartsWith("a", StringComparison.CurrentCultureIgnoreCase)
                orderby p.FirstName
                select p.FirstName;
        }

        static IEnumerable<T> Filter<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (var item in source)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }

        static IEnumerable<TResult> Map<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> projection)
        {
            foreach (var item in source)
            {
                yield return projection(item);
            }
        }
    }
}
