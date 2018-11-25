using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._4_X_mas_Tree
{
    class Program
    {
        static void star(int n, int space)
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

        static void tree(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                star(i, a-i);
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program print X-mas tree");
                Console.WriteLine("Please, enter number of triangles:");
                int a = int.Parse(Console.ReadLine());
                tree(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine($"Error has occured! {e.Message}");
            }
        }
    }
}
