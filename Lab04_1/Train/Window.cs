using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Window
    {
        protected float top;
        protected float left;

        public Window(float top, float left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("DrawWindow: {0} and {1}",top,left);
        }
    }
}
