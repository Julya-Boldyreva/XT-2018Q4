using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8._1_DateExistance
{
    public class Date
    {
        public static void ShowExistance(string str)
        {
            bool res = Exists(str);
            if (res)
            {
                Console.WriteLine($"String \"{str}\" contains date in dd-mm-yyyy format");
            }
            else
            {
                Console.WriteLine($"String \"{str}\" doesn\'t contain date in dd-mm-yyyy format");
            }
        }

        private static bool Exists(string str)
        {
            bool res = false;
            Regex regex = new Regex(@"[\d]{2}\-[\d]{2}\-[\d]{4}");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                res = true;
            }

            return res;
        }
    }
}
