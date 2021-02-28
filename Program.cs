using System;

namespace Bird
{
    class Program
    {
        static void Main(string[] args)
        {
            Hen h = new Hen();
            h.Age = 10;
            h.Name = "Ryaba";
            Eagle e = new Eagle();
            e.Age = 3;
            e.Name = "Vasya";
            Penguin p = new Penguin();
            p.Age = 7;
            p.Name = "Mister black";
            Duck d = new Duck();
            d.Age = 8;
            d.Name = "Jack";
            Console.WriteLine("Hen");
            Console.WriteLine("Love relationships:" + Hen.love);
            Console.WriteLine("Domestication:" + Hen.domestication);
            Console.WriteLine("Size:" + Hen.size);
            Console.WriteLine("Food:" + Hen.food);
            Console.WriteLine("Habitat:" + Hen.habitat);
            Console.WriteLine("Name:" + h.Name);
            Console.WriteLine("Age:" + h.Age +"\n");

            Console.WriteLine("Eagle");
            e.canFly();
            Console.WriteLine("Love relationships:" + Eagle.love);
            Console.WriteLine("Domestication:" + Eagle.domestication);
            Console.WriteLine("Size:" + Eagle.size);
            Console.WriteLine("Food:" + Eagle.food);
            Console.WriteLine("Habitat:" + Eagle.habitat);
            Console.WriteLine("Name:" + e.Name);
            Console.WriteLine("Age:" + e.Age+"\n");

            Console.WriteLine("Penguin");
            p.canSwim();
            Console.WriteLine("Love relationships:" + Penguin.love);
            Console.WriteLine("Domestication:" + Penguin.domestication);
            Console.WriteLine("Size:" + Penguin.size);
            Console.WriteLine("Food:" + Penguin.food);
            Console.WriteLine("Habitat:" + Penguin.habitat);
            Console.WriteLine("Name:" + p.Name);
            Console.WriteLine("Age:" + p.Age+"\n");

            Console.WriteLine("Duck");
            d.canSwim();
            d.canFly();
            Console.WriteLine("Love relationships:" + Duck.love);
            Console.WriteLine("Domestication:" + Duck.domestication);
            Console.WriteLine("Size:" + Duck.size);
            Console.WriteLine("Food:" + Duck.food);
            Console.WriteLine("Habitat:" + Duck.habitat);
            Console.WriteLine("Name:" + d.Name);
            Console.WriteLine("Age:" + d.Age + "\n");
        }
    }
}
