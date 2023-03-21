using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_06
{
    public class InvalidInputNumber : Exception
    {
        public InvalidInputNumber():base("Hay nhap mot so lon hon 0"){}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 content = new Class1();
            content.ContentClass1();

            int intCnt;
            int intNum = 0;

            Console.Write("Nhap mot so bat ky:");

            try
            {
                intNum = int.Parse(Console.ReadLine());

                if (intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch(InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch(System.FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    for (intCnt = 1; intCnt <= 10; intCnt++)
                    {
                        Console.WriteLine(intCnt*intNum);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
