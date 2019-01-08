using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task8._3_EmailFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This program finds all e-mails in the string");
                Console.WriteLine("--------");
                Console.WriteLine("Please, enter the string: ");
                string str = Console.ReadLine();
                Console.WriteLine("--------");
                EmailFinder.ShowEmails(str);
            }
            catch (Exception e)
            {
                Console.WriteLine("----------");
                Console.WriteLine($"Error is occured: {e.Message}");
            }
        }
    }
}
