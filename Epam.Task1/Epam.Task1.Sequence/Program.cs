using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    public class Program
    {
        public static void Allnums(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i);
                if (i != n)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(" ");
                } 
            }
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program prints to the screen sequence of numbers until the N.\n So, please, enter the N.");
                int n;
                do
                {
                    Console.WriteLine("N must be positive integer number: ");
                    n = int.Parse(Console.ReadLine());
                }
                while (n <= 0);

                Allnums(n);
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
