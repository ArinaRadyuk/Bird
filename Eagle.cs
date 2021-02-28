using System;
using System.Collections.Generic;
using System.Text;

namespace Bird
{
    class Eagle : Bird
    {
        public void canFly()
        {
            Console.WriteLine("Duck can fly");
        }
        static public readonly LOVE love = LOVE.Polygamous;
        static public readonly DOMESTICATION domestication = DOMESTICATION.Wild;
        static public readonly SIZE size = SIZE.Medium;
        static public readonly FOOD food = FOOD.Meat;
        static public readonly string habitat = "Field";
    }
}
