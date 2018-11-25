using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._4_X_mas_Tree
{
    class Program
    {
        static void Star(int n, int space)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = space + n - i; j > 0; j--)
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

        static void Tree(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Star(i, a-i);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program print X-mas tree");
                Console.WriteLine("Please, enter number of triangles:");
                int a = int.Parse(Console.ReadLine());
                Tree(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine($"Error has occured! {e.Message}");
            }
        }
    }
}
