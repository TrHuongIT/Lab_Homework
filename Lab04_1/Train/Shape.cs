using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    abstract class Shape
    {
        protected float length;
        protected float width;
        protected float radius;

        public Shape()
        {
            length = width = radius = 1f;
        }

        public Shape(float length, float width, float radius)
        {
            this.length = length;
            this.width = width;
            this.radius = radius;
        }

        public abstract float Area();
        public abstract float Cirumference();
    }
}
