using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {

        }
        public Rectangle(float length, float width, float radius) : base(length, width, radius)
        {
        }

        public void InputData()
        {
            Console.Write("Moi nhap vao chieu dai: ");
            length = float.Parse(Console.ReadLine());
            Console.Write("Moi nhap vao chieu rong: ");
            width = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return length * width;
        }

        public override float Cirumference()
        {
            return (length + width) * 2;
        }
    }
}
