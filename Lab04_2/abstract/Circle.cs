using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Circle : SHape
    {
        public override double Area()
        {
            return Radius*Radius*pi;
        }

        public override double Cirumference()
        {
            return Radius * 2 * pi;
        }

        public void Display()
        {
            Console.Write("Nhap vao ban kinh hinh tron: ");
            Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Chu vi: {Cirumference()} va Dien tich: {Area()}");
        }
    }
}
