using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class Button : Window
    {
        public Button(float top, float left) : base(top, left)
        {
        }

        public override void DrawWindow()
        {
            Console.WriteLine("DrawButton: {0} and {1}",top,left);
        }
    }
}
