using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._6_ISeekYou
{
    public class Program
    {
        private static Random R = new Random();

        public delegate bool Condition(int elem);

        public static bool IsPositive(int number)
        {
            return number > 0;
        }

        public static List<int> FindJust(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    list.Add(arr[i]);
                }
            }

            return list;
        }

        public static List<int> FindDelegate(int[] arr, Condition condition)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (condition(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }

            return list;
        }

        public static int[] GenerateArr(int min, int max, int len)
        {
            int[] arr = new int[len];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = R.Next(min, max);
            }

            return arr;
        }
        
        public static void Main(string[] args)
        {
            int[] arr = GenerateArr(-100, 100, 1000);
            int avg = 250;

            Stopwatch sw = new Stopwatch();
            List<int> res = new List<int>();
            List<double> timing = new List<double>();

            Console.WriteLine("It\'s program that calculates avg time of different types of sorting");
            Console.WriteLine("------");
            Console.WriteLine($"Avg data on array watched {avg} times");
            Console.WriteLine($"Array params: len is {arr.Length}, min is {arr.Min()}, max is {arr.Max()}");
            Console.WriteLine("------");
            try
            {
                for (int i = 0; i < avg; i++)
                {
                    sw.Reset();
                    sw.Start();
                    res = FindJust(arr);
                    timing.Add(sw.ElapsedMilliseconds);
                }

                Console.WriteLine($"Avg = {timing.Average()} (just finding method)");

                timing.Clear();
                for (int i = 0; i < avg; i++)
                {
                    sw.Reset();
                    sw.Start();
                    Condition comp = new Condition(IsPositive);
                    res = FindDelegate(arr, comp);
                    timing.Add(sw.ElapsedMilliseconds);
                }

                Console.WriteLine($"Avg = {timing.Average()} (delegate finding method)");

                timing.Clear();
                for (int i = 0; i < avg; i++)
                {
                    sw.Reset();
                    sw.Start();
                    Condition comp = new Condition(IsPositive);
                    res = FindDelegate(arr, delegate (int number) { return number > 0; });
                    timing.Add(sw.ElapsedMilliseconds);
                }

                Console.WriteLine($"Avg = {timing.Average()} (anonymous finding method)");

                timing.Clear();
                for (int i = 0; i < avg; i++)
                {
                    sw.Reset();
                    sw.Start();
                    Condition comp = new Condition(IsPositive);
                    res = FindDelegate(arr, number => number > 0);
                    timing.Add(sw.ElapsedMilliseconds);
                }

                Console.WriteLine($"Avg = {timing.Average()} (lyambda finding method)");

                timing.Clear();
                for (int i = 0; i < 100; i++)
                {
                    sw.Reset();
                    sw.Start();
                    Condition comp = new Condition(IsPositive);
                    res = (from number in arr
                           where number > 0
                           select number).ToList();
                    timing.Add(sw.ElapsedMilliseconds);
                }

                Console.WriteLine($"Avg = {timing.Average()} (LINQ finding method)");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
