using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lab31();
            Lab32 lab32 = new Lab32();
            lab32.Lab32Show();
        }

        private static void Lab31()
        {
            int[] arr = { 3, 6, 8, 1, -5, 10, 7, 4, 9, -2 };

            Console.WriteLine($"Min: {arr.Min()}");
            Array.Reverse(arr);
            Console.WriteLine($"Reversed: {string.Join(", ", arr)}");
            Array.Sort(arr);
            Console.WriteLine($"Ascending: {string.Join(", ", arr)}");
            Array.Sort(arr, (a, b) => -1 * a.CompareTo(b));
            Console.WriteLine($"Descending: {string.Join(", ", arr)}");
            Console.WriteLine($"Prime numbers: {string.Join(", ", arr.Where(IsPrime))}");
            Console.WriteLine($"Longest positive sequence length: {LongestPositiveSequenceLength(arr)}");
            Console.WriteLine($"Average of positive numbers: {AverageOfPositiveNumbers(arr)}");
            Console.WriteLine($"Alternating positive and negative elements: {IsAlternatingPositiveAndNegative(arr)}");
        }

        static bool IsPrime(int n) => n > 1 && Enumerable.Range(2, (int)Math.Sqrt(n)).All(i => n % i != 0);

        static int LongestPositiveSequenceLength(int[] arr) => string.Join("", arr.Select(i => i > 0 ? "1" : "0")).Split('0').Max(s => s.Length);

        static double AverageOfPositiveNumbers(int[] arr) => arr.Where(i => i > 0).DefaultIfEmpty().Average();

        static bool IsAlternatingPositiveAndNegative(int[] arr) => arr.Select((i, j) => i * arr[Math.Max(0, j - 1)]).All(x => x < 0);
    }
}
