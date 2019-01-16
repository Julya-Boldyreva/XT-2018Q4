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
            Regex regex = new Regex(@"(((0[1-9]|[12][0-9]|3[01])\-(0[13578]|1[02])\-([0-9]{4}))|((0[1-9]|1[0-9]|2[0-9])\-02\-[0-9]{4}) )|((0[1-9]|[12][0-9]|30)\-(0[469]|11)\-[0-9]{4})");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                res = true;
            }

            return res;
        }
    }
}
