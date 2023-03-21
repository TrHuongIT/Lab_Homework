using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lab_4._2
{
    internal class ListBox:Window
    {
        private string content;

        public ListBox()
        {

        }

        public ListBox(int top, int left, string content):base(top, left)
        {
            this.content = content;
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public override void DrawWindow()
        {
           base.DrawWindow();
           Console.WriteLine(content);
        }
    }
}
