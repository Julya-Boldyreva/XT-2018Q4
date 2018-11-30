using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Rectangle
{
    public class Program
    {
        public static double Area(double a, double b) => a * b;

        public static void Main(string[] args)
        {
            Console.WriteLine("This is the area-rectangle program.");
            try
            {
                double a = 0, b = 0;
                do
                {
                    Console.WriteLine("Please, enter width of rectangle (>0)");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please, enter height of rectangle (>0)");
                    b = double.Parse(Console.ReadLine());
                    if (a <= 0 || b <= 0)
                    {
                        Console.WriteLine("------");
                        Console.WriteLine("Incorrect! One of operators less or equals than zero. Please, repeat enter");
                    }
                }
                while (a <= 0 || b <= 0);
                Console.WriteLine($"area of rectangle with sides {a} ana {b} is {Area(a,b)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("-----");
                Console.WriteLine("The error has occured! " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
