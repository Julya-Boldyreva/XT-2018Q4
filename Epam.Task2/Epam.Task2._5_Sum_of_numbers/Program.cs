using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._5_Sum_of_numbers
{
    class Program
    {
        static int SumOfCommons3Or5(int n)
        {
            int res = 0;
            for (int i = 1; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    res += i;
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            const int N = 1000;
            Console.WriteLine($"Sum of numbers with 3 or 5 commons (from 1 to {N}) is {SumOfCommons3Or5(N)}");
        }
    }
}
