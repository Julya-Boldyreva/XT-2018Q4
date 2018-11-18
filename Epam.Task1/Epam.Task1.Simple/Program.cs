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
            //simple examples to demonstrate the method
            Console.WriteLine("Simple");
            Console.WriteLine("7 is simple? - " + simple(7));
            Console.WriteLine("45 is simple? - " + simple(45));
        }
    }
}
