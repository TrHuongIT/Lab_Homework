using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("https://www.tutorialsteacher.com/csharp/csharp-sortedlist");
            ArrayList inv = new ArrayList();

            inv.Add(new Product("A",5.9,3));
            inv.Add(new Product("B",6.9,4));
            inv.Add(new Product("C",7.9,5));
            inv.Add(new Product("D",8.9,6));

            Console.WriteLine("Product list:");
            foreach(Product p in inv)
            {
                Console.WriteLine(p.ToString());                
            }
            Console.WriteLine();
            foreach(Product p in inv)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
            Console.WriteLine("Tạo sortedlist generic:");
            SortedList<string, string> listEm = new SortedList<string, string>();
            listEm.Add("E01","Tran Thi Thuy");
            listEm.Add("E02","Le Hai Ha");
            listEm.Add("E03","Nguyen Van Hung");
            listEm.Add("E04","Hoang Thi Thom");
            listEm.Add("E05","Trinh Van Chien");

            Console.WriteLine("Danh sach nhan vien:");
            
            foreach(var key in listEm.Keys)
            {
                Console.WriteLine(key + ": " + listEm[key]);
            }

            Console.WriteLine("Danh sách nhân viên bắt đầu bằng chữ Th");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("Th"))
                {
                    Console.WriteLine(key + ": " + listEm[key]);
                }
            }

            listEm.Remove("E04");

            if (!listEm.ContainsKey("E06")) listEm.Add("E06","Nguyen Hoai Linh");

            Console.WriteLine("Danh sách nhân viên sau khi xoa, them");
            foreach(var key in listEm.Keys)
            {
                Console.WriteLine(key + ": " + listEm[key]);
            }

            Console.ReadLine();

            List<Student> list = new List<Student>()
            {
                new Student{Id="S10", FristName="Nguyen Thu", LastName="Phuong", Avg=9.5},
                new Student{Id="S12", FristName="Nguyen Viet", LastName="Anh", Avg=9.975, Gender=true},
                new Student{Id="S13", FristName="Tran Hoa", LastName="Lan", Avg=9.975},
                new Student{Id="S14", FristName="Nguyen Viet", LastName="Anh", Avg=9.975, Gender=true},
                new Student{Id="S15", FristName="Nguyen Viet", LastName="Anh", Avg=9.975, Gender=true},
                new Student{Id="S16", FristName="Nguyen Viet", LastName="Anh", Avg=9.975, Gender=true},
                new Student{Id="S11", FristName="Nguyen Viet", LastName="Anh", Avg=9.975, Gender=true}
            };

            Console.WriteLine("Danh sách sinh viên");

            //foreach(Student student in list)
            foreach(var student in list)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }

            double max = list[0].Avg;
            Student stmax = list[0];

            foreach(Student student in list)
            {
                if(student.Avg > max)
                {
                    max = student.Avg;
                    stmax = student;
                }
            }

            Console.WriteLine("Sinh vien co diem cao nhat la: " + stmax);

            list.Sort();
            Console.WriteLine("Danh sach sinh vien co diem trung binh tang dan:");
            foreach (Student student in list)
            {
                Console.WriteLine(student);
            }


        }
    }
}
