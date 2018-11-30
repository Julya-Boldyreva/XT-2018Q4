using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._12_Char_Doubler
{
    public class Program
    {
        public static string DoubleMaker(string main, string key)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < main.Length; i++)
            {
                if (!key.Contains(main[i]))
                {
                    sb.Append(main[i]);
                }
                else
                {
                    sb.Append(main[i], 2);
                }
            }

            return sb.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Char doubler program");
            Console.WriteLine("Please, enter the main string: ");
            string main = Console.ReadLine();
            Console.WriteLine("Please, enter the key string: ");
            string key = Console.ReadLine();
            Console.WriteLine("------");
            Console.WriteLine(DoubleMaker(main, key));
        }
    }
}
