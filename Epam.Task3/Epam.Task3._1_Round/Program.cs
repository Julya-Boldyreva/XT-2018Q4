using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._1_Round
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This proram for calculating round parameters. Please, enter parametrs");
            try
            {
                Console.WriteLine("Enter x-coordinate for center");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter y-coordinate for center");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter round radius");
                double radius = double.Parse(Console.ReadLine());
                Round myRound = new Round(x, y, radius);
                Console.WriteLine($"------{Environment.NewLine}Your circle params is: x={myRound.X}, y={myRound.Y}, r={myRound.Radius}{Environment.NewLine}Circumference is {myRound.Circumference():f2}{Environment.NewLine}Area of the circle is {myRound.Area():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
