using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._4_DynamicArrayHardcore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("DYNAMIC ARRAY: HARD MODE REALIZATION SHOW");
            DynamicArray<int> myDynArr = new DynamicArray<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });

            try
            {
                Console.WriteLine("------");
                Console.WriteLine($"Array: (Length is {myDynArr.Length}, capacity is {myDynArr.Capacity})");
                myDynArr.Show();
                Console.WriteLine("------");
                Console.WriteLine($"--Access at negative element--{Environment.NewLine}element [-1] is {myDynArr[-1]}");
                Console.WriteLine($"--Change capacity--{Environment.NewLine}array with new capacity:");
                myDynArr.Capacity = 4;
                myDynArr.Show();
                Console.WriteLine($"(length is { myDynArr.Length}, capacity is { myDynArr.Capacity})");
                Console.WriteLine("--Clone array--");
                DynamicArray<int> myDynArr2 = (DynamicArray<int>)myDynArr.Clone();
                myDynArr2.Show();
                Console.WriteLine("--To usual array method--");
                int[] usualArray = myDynArr.ToArray();
                foreach (var item in usualArray)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine($"{Environment.NewLine}--Cicled array class--");
                CycledDynamicArray<int> myCyclArr = new CycledDynamicArray<int>(new int[] { 9, 8, 7, 6, 5 });
                myCyclArr.ShowCycle();
                Console.WriteLine("-----");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{Environment.NewLine}------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
