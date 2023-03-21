using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Rectangle : SHape
    {
        public override double Area()
        {
            return Length*Width;
        }

        public override double Cirumference()
        {
            return (Length+Width)/2;
        }

        public void Display()
        {
            Console.Write("Nhap vao chieu dai: ");
            Length = double.Parse(Console.ReadLine());
            Console.Write("Nhap vao chieu rong: ");
            Width = double.Parse(Console.ReadLine());

            Console.WriteLine($"Chu vi: {Cirumference()} va Dien tich: {Area()}");
        }
    }
}
