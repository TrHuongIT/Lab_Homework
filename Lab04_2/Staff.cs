using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Staff : IPerson
    {
        public void Delete(Object obj)
        {
            Console.WriteLine("This is Staff: Delete: " + obj);
        }

        public void Display(Object obj)
        {
            Console.WriteLine("This is Staff: Display: " + obj);

        }

        public void Insert(Object obj)
        {
            Console.WriteLine("This is Staff: Insert: " + obj);

        }

        public void Update(Object obj)
        {
            Console.WriteLine("This is Staff: Update: " + obj);

        }
    }
}
