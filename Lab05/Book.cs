using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    internal class Book
    {
        private string nameBook;
        private Chapter[] numChapter;

        public Book()
        {
        }

        public Book(string nameBook, int numChapter)
        {
            this.nameBook = nameBook;
            this.numChapter = new Chapter[numChapter];
        }

        //Ten sach
        public string NameBook
        {
            get { return nameBook; }
            set 
            {
                if (value == null) { throw new ArgumentNullException(); }
                nameBook = value;
            }
        }

        //So chuong sach
        public Chapter this[int index]
        {
            get
            {
                if(index < 0 || index > numChapter.Length - 1)
                    return null;
                return numChapter[index];
            }

            set
            {
                if (index < 0 || index > numChapter.Length - 1) { throw new ArgumentOutOfRangeException(); }
                numChapter[index] = value;
            }
        }

        //Ten cua chuong sach
        public Chapter this[string name]
        {
            get
            {
                foreach(Chapter ch in numChapter)
                {
                    if (ch.Name == name)
                    {
                        return ch;
                    }
                }
                return null;
            }
        }
    }
}
