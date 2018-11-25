using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Triangle
{
    class Program
    {
        static void star(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
            }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program print *-triangle");
                Console.WriteLine("Please, enter number of lines:");
                int a = int.Parse(Console.ReadLine());
                star(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine($"Error has occured! {e.Message}");
            }
        }
    }
}
