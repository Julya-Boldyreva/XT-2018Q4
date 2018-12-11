using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._3_DynamicArray
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Static program demonstrate own Dynamic Array");
            DynamicArray<int> my_dynamic_arr = new DynamicArray<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });

            try
            {
                Console.WriteLine("------");
                Console.WriteLine("Array:");
                my_dynamic_arr.Show();
                Console.WriteLine("--Add number 66 in array--");
                my_dynamic_arr.Add(66);
                my_dynamic_arr.Show();
                Console.WriteLine("--Add range {10, 11, 12} in array--");
                my_dynamic_arr.AddRange(new int[] { 10, 11, 12 });
                my_dynamic_arr.Show();
                Console.WriteLine("--Remove element at 0 index--");
                my_dynamic_arr.Remove(0);
                my_dynamic_arr.Show();
                Console.WriteLine("--Insert element at 0 index--");
                my_dynamic_arr.Insert(120, 0);
                my_dynamic_arr.Show();
                Console.WriteLine($"------{Environment.NewLine}Length is {my_dynamic_arr.Length}, capacity is {my_dynamic_arr.Capacity} {Environment.NewLine}------");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
