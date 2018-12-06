using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._6_Ring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This proram for calculating ring parameters. Please, enter parametrs");
            try
            {
                Console.WriteLine("Enter x-coordinate for center");
                double x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter y-coordinate for center");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter round 1st radius");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter round 2nd radius");
                double radiusOther = double.Parse(Console.ReadLine());
                Ring myRing = new Ring(x, y, radius, radiusOther);
                Console.WriteLine($"------{Environment.NewLine}Your ring params is: x={myRing.X}, y={myRing.Y}, r1={myRing.Radius}, r2={myRing.RadiusOther}{Environment.NewLine}Circumference is {myRing.Circumference():f2}{Environment.NewLine}Area of the ring is {myRing.Area():f2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
