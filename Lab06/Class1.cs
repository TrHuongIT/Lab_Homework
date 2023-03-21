using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    internal class Class1
    {
        public void ContentClass1()
        {
            byte[] a = new byte[5];

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Khong duoc nhap ky tu cho mang so");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mang 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }

            Console.WriteLine("Mang vua nhap la: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(" {0}", a[i]);
            }
        }
    }
}
