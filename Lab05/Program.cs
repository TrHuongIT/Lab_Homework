using Supply;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = "1X2Y";
            product.Name = "NoNam";
            product.Price = 20000;
            product.Quantly = 10;
            product.Discount = 5000;

            double result = product.Total;

            Console.WriteLine("Total PM: "+result);

            Product product1 = new Product() { Id = "1A2B", Name = "Trau", Price = 50000, Quantly = 5, Discount = 10000 };
            result = product1.Total;
            Console.WriteLine("Total P1: "+result);
            Console.WriteLine();

            Console.Write("Nhap vao so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so mon hoc: ");
            int m = int.Parse(Console.ReadLine());  
            Student std = new Student(n, m);
            
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap vao ten cua sinh vien[{i+1}]: ");
                std[i] = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Nhap diem mon hoc [{j+1}]:");
                    std[i, j] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            Console.ReadKey();

            //Tao doi tuong Book
            Book b1 = new Book("Life of Tom, Nai and Nun",3);

            b1[0] = new Chapter();
            b1[0].Name = "Tom";
            b1[0].Content = "That is black cat, brave and cute";

            //b1[1] = new Chapter(name = "Night", content = "That is two color cat. White and Orange. Him so lovely."); //Viet ntnay la sai
            b1[1] = new Chapter("Night", "That is two color cat. White and Orange. Him so lovely.");
            b1[2] = new Chapter("Noon", "Noon meaning Afternoon. Him so brave. Him face by face the Death.");

            Console.WriteLine("Book: "+b1.NameBook);
            Console.WriteLine("List of Chapter: ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(b1[i]);
            }

            Console.WriteLine();

            Supply.Manufacturer manu_1 = new Supply.Manufacturer();
            manu_1.Name = "A";
            manu_1.Email = "A@gmail.com";
            manu_1.Phone = "0000-xxx-yyy";
            Console.WriteLine(manu_1.Name+" --- "+manu_1.Email+" --- "+manu_1.Phone);

            Business.House house_1 = new Business.House();
            house_1.HouseNo = "RTYUIO";
            house_1.Price = 23M;
            Console.WriteLine(house_1.HouseNo+" : "+house_1.Price);

            Business.DealerShip.Car newcar = new Business.DealerShip.Car();
            newcar.CarNo = "FGHJK";
            newcar.Price = 11M;
            Console.WriteLine(newcar.CarNo+" : "+newcar.Price);
            


        }
    }
}
