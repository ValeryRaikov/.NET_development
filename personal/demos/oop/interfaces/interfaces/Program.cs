using System;
using System.Collections.Generic;

// Interfaces
public interface IEnemy
{
    void Attack();
    void Defend();
}

public class Dragon : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Dragon attacks!");
        // throw new NotImplementedException();
    }

    public void Defend()
    {
        Console.WriteLine("Dragon defends!");
        // throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "This is a Dragon...";
    }
}

public class Vampire : IEnemy
{
    public void Attack()
    {
        Console.WriteLine("Vampire attacks!");
        // throw new NotImplementedException();
    }

    public void Defend()
    {
        Console.WriteLine("Vampire defends!");
        // throw new NotImplementedException();
    }

    public override string ToString()
    {
        return "This is a Vampire...";
    }
}

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnemy e1 = new Dragon();
            IEnemy e2 = new Vampire();

            e1.Attack();
            e2.Attack();

            e1.Defend();
            e2.Defend();

            List<IEnemy> enemies = new List<IEnemy>();
            enemies.Add(e1);
            enemies.Add(e2);

            foreach(IEnemy enemy in enemies)
            {
                enemy.Attack();
                Console.WriteLine(enemy.ToString());
            }
        }
    }
}
