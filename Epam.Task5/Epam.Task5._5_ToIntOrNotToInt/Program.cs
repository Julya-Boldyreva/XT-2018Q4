using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._5_ToIntOrNotToInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("It\'s the extention string with is positive method program");
            Console.WriteLine("------");
            try
            {
                string str;
                string res;

                while (true)
                {
                    Console.WriteLine("Please, enter the number:");
                    str = Console.ReadLine();
                    Console.WriteLine($"{ Environment.NewLine}------");
                    res = str.IsPositive() ? "yes" : "no";
                    Console.WriteLine($"Is it right that your string is number? - {res}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
