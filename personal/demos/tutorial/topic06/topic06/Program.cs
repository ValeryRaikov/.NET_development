using System;

namespace topic06
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicyle bicycle = new Bicyle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.Go();
            bicycle.Go();
            boat.Go();

            // 02. Array of objects
            Student s1 = new Student("Valery", 21);
            Student s2 = new Student("Meggie", 19);
            Student s3 = new Student("Ivaylo", 35);

            Student[] school = new Student[3];
            school[0] = s1;
            school[1] = s2;
            school[2] = s3;

            Console.WriteLine(school[0].name);

            Console.WriteLine("School students:");
            foreach(Student st in school)
            {
                Console.WriteLine($"{st.name} - {st.age}");
            }

            // 03. Objects as arguments
            ChangeAge(s1, 50);
            Console.WriteLine($"{s1.name} - {s1.age}");

            Student st3 = CopyStudent(s1);

            foreach(Student st in school)
            {
                Console.WriteLine(st.ToString());
            }
        }

        public static void ChangeAge(Student st, int age)
        {
            st.age = age;
        }

        public static Student CopyStudent(Student st)
        {
            return new Student(st.name, st.age);
        }
    }

    // 01. Inheritance and abstraction
    abstract class Vehicle
    {
        public int speed = 0;

        // 04. Method overriding
        public virtual void Go()
        {
            Console.WriteLine("The vehicle is moving...");
        } 
    }

    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 200;

        public override void Go()
        {
            Console.WriteLine("The car is moving fast...");
        }
    }

    class Bicyle : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;

        public override void Go()
        {
            Console.WriteLine("The bicycle is moving not that fast...");
        }
    }

    class Boat : Vehicle
    {
        public int whees = 0;

        public override void Go()
        {
            Console.WriteLine("The boat is sailing...");
        }
    }
}
