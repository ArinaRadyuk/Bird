using System;
using System.Collections.Generic;
using System.Text;

namespace Bird
{
    class Duck : Bird
    {
        public void canSwim() {

            Console.WriteLine("Duck can swim");
        }
        public void canFly()
        {
            Console.WriteLine("Duck can fly");
        }
        static public readonly LOVE love = LOVE.Polygamous;
        static public readonly DOMESTICATION domestication = DOMESTICATION.Domestic;
        static public readonly SIZE size = SIZE.Smal;
        static public readonly FOOD food = FOOD.Fish;
        static public readonly string habitat = "Garden";

    }
}
