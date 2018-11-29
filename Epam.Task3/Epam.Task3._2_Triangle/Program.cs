using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._2_Triangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This proram for calculating triangle parameters. Please, enter parametrs");
            try
            {
                Console.WriteLine("Enter length of the first side");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter length of the second side");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter length of the third side");
                double c = double.Parse(Console.ReadLine());
                Triangle myTriangle = new Triangle(a, b, c);
                Console.WriteLine($"------{Environment.NewLine}Your triangle params is: a={myTriangle.A}, b={myTriangle.B}, c={myTriangle.C}{Environment.NewLine}Perimetr is {myTriangle.Perimetr():f2}{Environment.NewLine}Area is {myTriangle.Area():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
