using System;
using System.Collections.Generic;
using System.Text;

namespace Bird
{
    class Penguin : Bird
    {
        public void canSwim()
        {

            Console.WriteLine("Penguin can swim");
        }
        static public readonly LOVE love = LOVE.Monogamous;
        static public readonly DOMESTICATION domestication = DOMESTICATION.Wild;
        static public readonly SIZE size = SIZE.Large;
        static public readonly FOOD food = FOOD.Fish;
        static public readonly string habitat = "Near the ocean";
    }

}
