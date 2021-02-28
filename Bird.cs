using System;
using System.Collections.Generic;
using System.Text;

namespace Bird
{
    enum LOVE
    {
        Polygamous, Monogamous
    }
    enum DOMESTICATION
    {
        Wild, Domestic
    }
    enum SIZE
    {
        Smal, Medium, Large
    }
    enum FOOD
    {
        Seeds, Meat, Fish
    }
    public abstract class Bird 
    {
    
        private int m_age;
        public string Name
        { get; set; }
        public int Age
        {
            get { return m_age; }
            set
            {
                if ((value < 0) || (value > 50))
                {
                    throw new ArgumentException();
                }
                else
                {
                    m_age = value;
                }

            }
        }
    }
}


