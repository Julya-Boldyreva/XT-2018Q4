using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._9_Non_negative_sum
{
    class Program
    {
        static int[] Generate(int N, int min, int max)
        {
            int[] arr = new int[N];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }
            return arr;
        }
        static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            const int N = 10;
            const int MIN = -100;
            const int MAX = 100;
            Console.WriteLine($"Array is: ");
            int[] arr = Generate(N, MIN, MAX);
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.Write(Environment.NewLine);
            Console.WriteLine("------");
            Console.WriteLine($"Sum of positive elements is: {Sum(arr)}");
        }
    }
}
