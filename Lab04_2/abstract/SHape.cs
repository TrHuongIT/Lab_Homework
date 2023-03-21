using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    abstract class SHape
    {
        private double radius, length, width;
        public const double pi = 3.14;

        public double Radius { get { return radius; } set { radius = value; } }
        public double Length { get { return radius; } set { radius = value; } }
        public double Width { get { return radius; } set { radius = value; } }

        protected SHape()
        {

        }

        protected SHape(double radius, double length, double width)
        {
            this.radius = radius;
            this.length = length;
            this.width = width;
        }

        public abstract double Area();
        public abstract double Cirumference();
    }
}
