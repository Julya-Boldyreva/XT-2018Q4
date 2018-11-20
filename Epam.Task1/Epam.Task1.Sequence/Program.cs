using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static void allnums(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                Console.Write(i);
                if (i != N)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine(" ");
                } 
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program prints to the screen sequence of numbers until the N.\n So, please, enter the N.");
                int a;
                do
                {
                    Console.WriteLine("N must be positive integer number: ");
                    a = int.Parse(Console.ReadLine());
                } while (a <= 0);
                allnums(a);
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
