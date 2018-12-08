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
            Console.WriteLine("Program demonstrate own Dynamic Array");

            try
            {
                Console.WriteLine("------");
                Console.WriteLine("Enter sentence: ");
                string str = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
    }
}
