using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._7_Array_Processing
{
    public class Program
    {
        public static int[] Generate(int n, int min, int max)
        {
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(min, max);
            }

            return arr;
        }

        public static int Max(int[] arr)
        {
            int res = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (res < arr[i])
                {
                    res = arr[i];
                }
            }

            return res;
        }

        public static int Min(int[] arr)
        {
            int res = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (res > arr[i])
                {
                    res = arr[i];
                }
            }

            return res;
        }

        public static void Sort(ref int[] arr)
        {
            int tmp = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            const int N = 10;
            const int MIN = -100;
            const int MAX = 100;
            Console.WriteLine("Array is:");
            int[] arr = Generate(N, MIN, MAX);
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.Write(Environment.NewLine);
            Console.WriteLine("------");
            Console.WriteLine($"Max = {Max(arr)}; {Environment.NewLine}Min = {Min(arr)};");
            Console.WriteLine("------");
            Console.WriteLine("Sort array is:");
            Sort(ref arr);
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
