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
            DynamicArray<int> myDynArr = new DynamicArray<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });

            try
            {
                Console.WriteLine("------");
                Console.WriteLine("Array:");
                myDynArr.Show();
                Console.WriteLine("--Add number 66 in array--");
                myDynArr.Add(66);
                myDynArr.Show();
                Console.WriteLine("--Add range {10, 11, 12} in array--");
                myDynArr.AddRange(new int[] { 10, 11, 12 });
                myDynArr.Show();
                Console.WriteLine("--Remove element at 0 index--");
                myDynArr.Remove(0);
                myDynArr.Show();
                Console.WriteLine("--Insert element at 0 index--");
                myDynArr.Insert(120, 0);
                myDynArr.Show();
                Console.WriteLine($"------{Environment.NewLine}Length is {myDynArr.Length}, capacity is {myDynArr.Capacity} {Environment.NewLine}------");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
