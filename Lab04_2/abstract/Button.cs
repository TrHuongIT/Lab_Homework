using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Button:Window
    {
        public Button()
        {

        }
        public Button(int top, int left):base(top, left)
        {

        }
        public override void DrawWindow()
        {
            Console.WriteLine("Child - Draw Window with top: {0} and left: {1}",top,left);
        }
    }
}
