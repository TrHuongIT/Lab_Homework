using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    abstract class Student
    {
        protected string name;
        protected int year;

        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        protected void Display()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Year: "+year);
        }

        public abstract float Average();
        
    }
}
