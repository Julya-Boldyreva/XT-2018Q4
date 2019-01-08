using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8._5_TimeCounter
{
    public class TimeCounter
    {
        public static void ShowResult(string str)
        {
            MatchCollection matches;
            int res = Find(str, out matches);
            Console.WriteLine($"In the text {res} datetimes");
            foreach (var item in matches)
            {
                Console.WriteLine(item);
            }
        }

        private static int Find(string str, out MatchCollection matches)
        {
            int res = 0;
            string pattern = @"(([0-1]?[0-9])|([2][1-3]))[:][0-5][0-9]([:][0-5][0-9])?";
            Regex regex = new Regex(pattern);
            matches = regex.Matches(str);
            res = matches.Count;
            return res;
        }
    }
}
