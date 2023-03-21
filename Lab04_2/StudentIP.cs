using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class StudentIP : IPerson
    {
        private string id, name;
        private int age;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public StudentIP(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public void Delete(object obj)
        {
            Console.WriteLine("Delete Student");
        }

        public void Display(object obj)
        {
            StudentIP st = (StudentIP)obj;
            Console.WriteLine("Display Student!");
            Console.WriteLine("ID: "+st.id);
            Console.WriteLine("Name: "+st.name);
            Console.WriteLine("Age: "+st.age);
        }

        public void Insert(object obj)
        {
            Console.WriteLine("Update Student");

        }

        public void Update(object obj)
        {
            Console.WriteLine("Update Student");

        }
    }
}
