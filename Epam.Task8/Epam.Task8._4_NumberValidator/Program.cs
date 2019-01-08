using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task8._4_NumberValidator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program validates numbers notation");
                Console.WriteLine("--------");
                Console.WriteLine("Please, enter the string: ");
                string str = Console.ReadLine();
                Console.WriteLine("--------");
                NumberValidator.ShowResult(str);
            }
            catch (Exception e)
            {
                Console.WriteLine("----------");
                Console.WriteLine($"Error is occured: {e.Message}");
            }
        }
    }
}
