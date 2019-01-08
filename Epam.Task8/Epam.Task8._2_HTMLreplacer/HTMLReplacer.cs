using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8._2_HTMLreplacer
{
    public class HTMLReplacer
    {         
        public static void ShowReplaced(string str)
        {
            Console.WriteLine(Replace(str));
        }

        private static string Replace(string str)
        {
            string pattern = @"<[/]?[a-zA-Z]+>";
            string underline = "_";
            Regex regex = new Regex(pattern);
            return regex.Replace(str, underline);
        }
    }
}
