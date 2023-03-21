using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._1
{
    internal class Student : IComparable<Student>
    {
        public string Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg { get; set; }
        public override string ToString()
        {
            return "ID: " + Id + "\nName" + FristName + " " + LastName + "\nGender: " + (Gender ? "Male" : "Female") + "\nAverage mark: " + Avg;
        }
        public int CompareTo(Student other)
        {
            return this.Avg.CompareTo(other.Avg);
            //return other.Avg.CompareTo(this.Avg);
        }
    }
}
