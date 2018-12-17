using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._4_NumberArraySum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] arr = new double[] { 2, 6, 2.4, 1.1, 6.3, -0.7 };
            Console.WriteLine("It\'s the extention arrays with sum method program");
            Console.WriteLine("------");
            try
            {
                Console.WriteLine("This is example array:");
                foreach (var item in arr)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine($"{ Environment.NewLine}------");
                Console.WriteLine($"Sum of its elements is {arr.Sum()}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
