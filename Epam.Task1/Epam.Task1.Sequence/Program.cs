using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task1.Sequence
{
    class Program
    {
        static string allnums(int N)
        {
            string str = "";
            for (int i = 1; i <= N; i++)
            {
                str += i;
            }
            return str;
        }

        static void Main(string[] args)
        {
            //simple examples to demonstrate the method
            Console.WriteLine("Sequence");
            Console.WriteLine(allnums(7));
        }
    }
}
