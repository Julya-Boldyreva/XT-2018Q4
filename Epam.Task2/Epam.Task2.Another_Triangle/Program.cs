using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Another_Triangle
{
    class Program
    {
        static void Star(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                } 
                for (int j = 1; j < i * 2; j++)
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
                Console.WriteLine("This program print *-triangle (align: center)");
                Console.WriteLine("Please, enter number of lines:");
                int a = int.Parse(Console.ReadLine());
                Star(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine($"Error has occured! {e.Message}");
            }
        }
    }
}
