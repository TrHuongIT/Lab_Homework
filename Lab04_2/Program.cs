using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ShowDrawWindow();
            //ShowStudent();
            //ShowSHap();
            //IPersonTest();

            Car car = new Car();
            car.Start(car);

        }

        private static void IPersonTest()
        {
            IPerson staff = new Staff();
            //Staff staff = new Staff();
            object data = "Back Khoa";
            //Object data = "Back Khoa";
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);

            IPerson stdHang = new StudentIP("HHH", "Hang", 21);
            stdHang.Display(stdHang);
            IPerson stdNam = new StudentIP("NNN", "Nam", 22);
            stdNam.Display(stdNam);
            Console.WriteLine("-----------------------------");
            stdNam.Display(stdHang);
            stdHang.Display(stdNam); //???
        }

        private static void ShowSHap()
        {
            Circle cir = new Circle();
            cir.Display();
            Rectangle rectangle = new Rectangle();
            rectangle.Display();
        }

        private static void ShowStudent()
        {
            StudentCollege stdC = new StudentCollege(7.7f, 8.8f, 9.9f, "Hoai Thuong", 2001);
            stdC.Display();

            StudentUniversity[] stdU = new StudentUniversity[3];
            stdU[0] = new StudentUniversity(7.7f, 8.8f, 9.9f, 10f, "Diem", 2001);
            stdU[1] = new StudentUniversity(7.7f, 8.8f, 9.8f, 10f, "Hang", 2001);
            stdU[2] = new StudentUniversity(7.7f, 8.8f, 9.7f, 10f, "Nga", 2001);

            foreach (StudentUniversity stdUt in stdU)
            {
                stdUt.Display();
            }
        }

        private static void ShowDrawWindow()
        {
            Button but = new Button();
            but.Top = 10;
            but.Left = 20;
            but.DrawWindow();

            Console.WriteLine("1----------------------------------------------------");
            ListBox listBox = new ListBox(5, 10, "DrawWindow with top 5 and left 10");
            listBox.DrawWindow();

            Console.WriteLine("2----------------------------------------------------");
            ListBox listBox1 = new ListBox();
            listBox1.Top = 11;
            listBox1.Left = 11;
            listBox1.Content = "This is 11-11";
            listBox1.DrawWindow();

            Console.WriteLine("3----------------------------------------------------");

            Window[] windows = new Window[3];
            windows[0] = new Window(1, 10);
            windows[1] = new Button(2, 9);
            windows[2] = new ListBox(3, 8, "This is 3-8");

            windows[0].DrawWindow();

            Console.WriteLine("4----------------------------------------------------");

            foreach (Window w in windows)
            {
                w.DrawWindow();
            }

            Console.WriteLine("5----------------------------------------------------");

            for (int i = 0; i < 3; i++)
            {
                windows[i].DrawWindow();
            }

            Console.WriteLine("6----------------------------------------------------");
        }
    }
}
