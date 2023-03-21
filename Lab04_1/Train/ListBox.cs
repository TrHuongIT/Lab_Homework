using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._1
{
    internal class ListBox : Window
    {
        private string content;
        public ListBox(string content, float top, float left) : base(top, left)
        {
            this.content = content;
        }

        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Conten: "+content);
        }
    }
}
