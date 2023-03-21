using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Window newWindow = new Window(1, 2);
            Button newButton = new Button(3, 4);
            ListBox newListBox = new ListBox("This is first list box",5, 6);
            newWindow.DrawWindow();
            newButton.DrawWindow();
            newListBox.DrawWindow();

            Console.WriteLine();

            Window[] arrayWindow = new Window[3];
            arrayWindow[0] = new Window(7, 8);
            arrayWindow[1] = new Button(9, 10);
            arrayWindow[2] = new ListBox("This is array list box",11, 12);

            for (int i = 0; i < 3; i++)
            {
                arrayWindow[i].DrawWindow();
            }

            Console.WriteLine();
            Console.WriteLine("Sinh vien cao dang:");
            StudentCollege newstdcollege = new StudentCollege(9.2f, 9.3f, 9.4f, "Hanh", 2001);
            newstdcollege.Display();
            Console.WriteLine($"Average of Hanh: {newstdcollege.Average()}");

            Console.WriteLine();
            Console.WriteLine("Sinh vien dai hoc:");
            StudentUniversity _stdUnv = new StudentUniversity(9.1f, 9.2f, 9.3f, "Giang", 2001, 9.4f);
            _stdUnv.Display();
            Console.WriteLine($"Average of Giang: {_stdUnv.Average()}");

            Console.WriteLine();
            Circle _cc = new Circle(1f, 1f, 1f);
            _cc.InputData();
            Console.WriteLine("Ban kinh hinh tron: "+ _cc.Cirumference());
            Console.WriteLine("Chu vi hinh tron: "+ _cc.Area());
            Console.WriteLine();

            Rectangle _rect = new Rectangle();
            Console.WriteLine("Chu vi: "+_rect.Cirumference()+" Dien tich: "+_rect.Area());
            Console.WriteLine();

            Car _newcar = new Car();
            _newcar.Display();
            */

            Account _acc1 = new Account(10000000);
            _acc1.AccName = "Tuan";
            _acc1.Deposit();
            _acc1.WithDraw();
            Console.Write("Account: " + _acc1.AccName + "\nID: XXX\nBalance: "); 
            _acc1.GetBalance();
            Console.ReadKey();

            SavingMoney savingMoney = new SavingMoney(_acc1.Balance, 1/100f);
           
            savingMoney.GetInterest();

            CheckAccount checkAccount = new CheckAccount(_acc1.Balance, 3300);
            checkAccount.Deposit();
            checkAccount.WithDraw();
            checkAccount.GetBalance();
            
            
        }
    }
}
