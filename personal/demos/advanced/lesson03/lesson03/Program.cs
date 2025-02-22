using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson03
{
    // class Product { }
    // 
    // class Inventory
    // {
    //     private readonly List<Product> _products;
    // 
    //     public IEnumerable<Product> Products { get { return _products; } }
    // 
    //     public Inventory()
    //     {
    //         _products = new List<Product>();
    //     }
    // }

    public static class EnumerableExtensions
    {
        public static TAcc MyAggregate<TAcc, TSource>(this IEnumerable<TSource> that, TAcc seed, Func<TAcc, TSource, TAcc> fold)
        {
            var value = seed;
            foreach (var item in that)
                value = fold(value, item);

            return value;
        }

        public static IEnumerable<T> MyConcat<T>(this IEnumerable<T> that, IEnumerable<T> rhs)
        {
            foreach (var item in that)
                yield return item;

            foreach (var item in rhs)
                yield return item;
        }

        public static IEnumerable<T> MyUnion<T>(this IEnumerable<T> that, IEnumerable<T> rhs)
        {
            return MyUnion<T>(that, rhs, EqualityComparer<T>.Default);
        }

        public static IEnumerable<T> MyUnion<T>(this IEnumerable<T> that, IEnumerable<T> rhs, IEqualityComparer<T> comparer)
        {
            HashSet<T> seen = new HashSet<T>(comparer);

            foreach (var item in that)
            {
                if (seen.Add(item)) 
                    yield return item;
            }

            foreach (var item in rhs)
            {
                if (seen.Add(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> MyExcept<T>(this IEnumerable<T> that, IEnumerable<T> rhs)
        {
            var blackList = new HashSet<T>(rhs);
            foreach (var item in that)
            {
                if (blackList.Add(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> MyIntersect<T>(this IEnumerable<T> that, IEnumerable<T> rhs)
        {
            var existingItems = new HashSet<T>(rhs);
            foreach (var item in that)
            {
                if (existingItems.Remove(item))
                    yield return item;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 01. Simple LINQ
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            IEnumerable<int> filtered = numbers.Where(x => x > 4);
            IEnumerable<int> squared = filtered.Select(x => x * x);

            foreach (int num in squared)
                Console.WriteLine(num);

            // Convert to List
            List<int> odd = numbers.Where(x => x % 2 != 0).ToList();
            List<int> even = numbers.Where(x => x % 2 == 0).ToList();

            // LINQ query
            List<int> even2 = (
                from x in numbers
                where x % 2 == 0
                select x
            ).ToList();

            foreach (int num in even2)
                Console.WriteLine(num);

            numbers.Clear();

            Console.WriteLine();

            // var inventory = new Inventory();
            // var products = inventory.Products;

            // 02. Aggregate functions
            var numList = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            var sum = numList.Aggregate(0, (acc, i) => acc + i); // accumulator, item
            Console.WriteLine(sum);

            var customSum = numList.MyAggregate(sum, (acc, i) => acc + i); // start from prev sum
            Console.WriteLine(customSum);

            // Max
            var max = numList.MyAggregate(0, (acc, i) => i > acc ? i : acc);
            Console.WriteLine(max);

            // Concat 
            Console.WriteLine("\nConcat:");
            var list1 = new List<char> { 'a', 'b', 'c' };
            var list2 = new List<char> { 'c', 'd', 'e' };
            var combined = list1.MyConcat(list2);
            foreach (var ch in combined)
                Console.Write("{0}, ", ch);

            // Union
            Console.WriteLine("\nUnion:");
            var union = list1.MyUnion(list2, EqualityComparer<char>.Default);
            foreach (var ch in union)
                Console.Write("{0}, ", ch);

            Console.WriteLine();
            var strList1 = new List<string> { "Hello", "World" };
            var strList2 = new List<string> { "HELLO", "hello", "how", "Are", "YOU", "You" };
            foreach (var item in strList1.MyUnion(strList2, StringComparer.CurrentCultureIgnoreCase))
                Console.Write("{0}, ", item);

            // Except
            Console.WriteLine("\nExcept:");
            foreach (var ch in list1.MyExcept(list2))
                Console.Write("{0}, ", ch);

            // Intersect
            Console.WriteLine("\nIntersect:");
            foreach (var ch in list1.MyIntersect(list2))
                Console.Write("{0}, ", ch);
        }
    }
}
