using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Simple
{
    public class Program
    {
        public static bool Simple(int n)
        {
            bool res = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    res = false;
                    break;
                }
            }

            return res;
        }

        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program calculate if number is simple or not.\n So, please, enter the N.");
                int a;
                do
                {
                    Console.WriteLine("N must be positive integer number more than 1: ");
                    a = int.Parse(Console.ReadLine());
                }
                while (a < 2);

                Console.WriteLine(a + " is simple? - " + Simple(a));
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
