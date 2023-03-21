using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Lab32
    {
        public void Lab32Show()
        {
            int[,] matrix = new int[4, 4]
        {
            { 2, 4, 6, 8 },
            { 10, 12, 14, 16 },
            { 18, 20, 22, 24 },
            { 26, 28, 30, 35 }
        };

            Console.WriteLine("Ma trận theo hàng cột:");
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Các phần tử trên đường chéo chính:");
            int sumDiagonal = 0;
            for (int i = 0; i < 4; i++)
            {
                sumDiagonal += matrix[i, i];
            }
            Console.WriteLine("Tổng các phần tử trên đường chéo chính: " + sumDiagonal);

            Console.WriteLine("Các phần tử nhỏ nhất trên từng cột:");
            for (int col = 0; col < 4; col++)
            {
                int min = matrix[0, col];
                for (int row = 1; row < 4; row++)
                {
                    if (matrix[row, col] < min)
                    {
                        min = matrix[row, col];
                    }
                }
                Console.WriteLine("Cột " + col + ": " + min);
            }

            Console.WriteLine("Các phần tử chia hết cho 7:");
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (matrix[row, col] % 7 == 0)
                    {
                        Console.WriteLine(matrix[row, col]);
                    }
                }
            }

            Console.WriteLine("Tổng các phần tử trên đường viền:");
            int sumBorder = 0;
            for (int i = 0; i < 4; i++)
            {
                sumBorder += matrix[0, i];          // top row
                sumBorder += matrix[3, i];          // bottom row
                if (i > 0 && i < 3)
                {
                    sumBorder += matrix[i, 0];      // left column
                    sumBorder += matrix[i, 3];      // right column
                }
            }
            Console.WriteLine(sumBorder);

            Console.WriteLine("Mảng 1 chiều được chuyển từ mảng 2 chiều:");
            int[] flattenedArray = new int[16];
            int index = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    flattenedArray[index++] = matrix[row, col];
                }
            }
            Array.Sort(flattenedArray);
            foreach (int n in flattenedArray)
            {
                Console.Write(n + " ");
            }
        }
    }
}
