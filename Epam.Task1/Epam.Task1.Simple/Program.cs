using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{

    class Program
    {
        static bool simple(int N)
        {
            bool res = true;
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0)
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program calculate if number is simple or not.\n So, please, enter the N.");
                int a;
                do
                {
                    Console.WriteLine("N must be positive integer number more than 1: ");
                    a = int.Parse(Console.ReadLine());
                } while (a < 2);

                Console.WriteLine(a + " is simple? - " + simple(a));
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
