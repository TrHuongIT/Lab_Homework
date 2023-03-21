using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    internal class Student
    {
        private string[] name;
        private double[,] marks;

        public Student(int n, int m)
        {
            name = new string[n];
            marks = new double[n, m];

        }

        public string this[int i]
        {
            get { return name[i]; }
            set { name[i] = value; }
        }

        public double this[int i, int j]
        {
            get { return marks[i, j]; }
            set { marks[i, j] = value; }
        }
    }
}
