using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Circle : Shape
    {
        const float pi = 3.14f;

        public Circle(float length, float width, float radius) : base(length, width, radius)
        {
        }

        public void InputData()
        {
            Console.Write("Moi nhap vao ban kinh - radius: ");
            radius = float.Parse(Console.ReadLine());
        }

        public override float Area()
        {
            return radius * radius * pi;
        }

        public override float Cirumference()
        {
            return radius * 2 * pi;
        }
    }
}
