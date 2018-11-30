using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Square
{
    public class Program
    {
        public static void Stars(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i != (n / 2 + 1) || j != (n / 2 + 1))
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

        public static void Main(string[] args)
        {
            try
            {
             Console.WriteLine("Square Stars Without One");
                int a;
                do
                {
                    Console.WriteLine("N must be positive odd integer number more than 1: ");
                    a = int.Parse(Console.ReadLine());
                }
                while (a % 2 == 0 || a <= 1);

                Stars(a);
            }
            catch (Exception e)
            {
                Console.WriteLine("There are en error occured: \n" + e.Message);
                Console.WriteLine("Tap any key to exit program");
                Console.ReadKey();
            }
        }
    }
}
