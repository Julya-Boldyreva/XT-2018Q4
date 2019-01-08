using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8._4_NumberValidator
{
    public class NumberValidator
    {
        public static void ShowResult(string str)
        {
            string res = Find(str);
            Console.WriteLine($"{str} is {res}");
        }

        private static string Find(string str)
        {
            string res = "";
            string pattern = @"^[\-+]?[0-9]+([\.][0-9]+)*$";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(str);
            if (matches.Count == 1)
            {
                res = "normal notation";
            }
            else
            {
                pattern = @"^[\-\+]?[0-9]+([\.][0-9]+)*[e][\-\+]?[0-9]+$";
                regex = new Regex(pattern);
                matches = regex.Matches(str);
                if (matches.Count == 1)
                {
                    res = "science notation";
                }
                else
                {
                    res = "Not a number";
                }
            }

            return res;
        }
    }
}
