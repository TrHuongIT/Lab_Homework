using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Window
    {
        protected int top;
        protected int left;

        public Window()
        {

        }

        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        public int Left
        {
            get { return left; }
            set { left = value; }
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Parent - Draw Window with top: {0} and left: {1}",top,left);
        }
    }
}
