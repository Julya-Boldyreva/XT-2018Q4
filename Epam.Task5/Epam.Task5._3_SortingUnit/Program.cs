using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5._3_SortingUnit
{
    public class Program
    {
        public static void ShowOneArr<T>(T[] arr)
        {
            Console.WriteLine($"----Type of {arr}----");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine($"{Environment.NewLine}------------");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("It\'s the array sort program with thread execution");
            try
            {
                int[] arr1 = new int[] { 2, 41, 5, 7, -9, 0, 4, 1, 90, 144, 8, -87, 7, 7, 32, 0, 8, 1, 46 };
                string[] arr2 = new string[] { "hey", "teacher", "leave", "those", "kids", "alone", "all", "in", "all", "just", "it", "another", "brick", "in", "the", "wall" };
                bool[] arr3 = new bool[] { true, true, false, true, false, false, true, false, false, true, false, false, true };
                Console.WriteLine("Now it is some arrays:");
                ShowOneArr<int>(arr1);
                ShowOneArr<string>(arr2);
                ShowOneArr<bool>(arr3);
                Console.WriteLine("Press any key to see thread process of its sorting...");
                Console.ReadLine();
                SortModule module = new SortModule();

                module.NewThreadSort<int>(arr1);
                module.NewThreadSort<string>(arr2);
                module.NewThreadSort<bool>(arr3);
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
