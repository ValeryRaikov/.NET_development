using System;

namespace topic08
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit r = new Rabbit();
            r.Hide();

            Hawk h = new Hawk();
            h.Hunt();

            Fish f = new Fish();
            f.Hide();
            f.Hunt();
        }
    }

    // .01 Interfaces
    interface IPrey
    {
        void Hide();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey 
    {
        public void Hide()
        {
            Console.WriteLine("The rabbit is searching for a place to hide...");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is hunting for its prey...");
        }
    }

    class Fish : IPrey, IPredator
    {
        public void Hide()
        {
            Console.WriteLine("Fish is in danger and must hide.");
        }

        public void Hunt()
        {
            Console.WriteLine("Fish is not in danger and others must hide.");
        }
    }
}
