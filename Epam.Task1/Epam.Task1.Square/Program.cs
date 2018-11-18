using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    class Program
    {
        static void stars(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (i != (N / 2 + 1) || j != (N / 2 + 1))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //simple examples to demonstrate the method
            Console.WriteLine("Square Stars Without One");
            stars(7);
        }
    }
}
