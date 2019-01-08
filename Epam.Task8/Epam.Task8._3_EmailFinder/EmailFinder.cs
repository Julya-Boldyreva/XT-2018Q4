using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Epam.Task8._3_EmailFinder
{
    public class EmailFinder
    {
        public static void ShowEmails(string str)
        {
            MatchCollection mc = Find(str);
            int count = mc.Count;

            if (count == 0)
            {
                Console.WriteLine("No e-mails was found");
            }
            else
            {
                Console.WriteLine($"{count} e-mails was(were) found: ");
                count = 1;
                foreach (var item in mc)
                {
                    Console.WriteLine($"{count}) {item}");
                    count++;
                }
            }
        }

        private static MatchCollection Find(string str)
        {
            string pattern = @"[a-zA-Z_][a-zA-Z0-9_\-\.]*[@]([a-zA-Z0-9\-]+[\.])+[a-zA-Z]{2,6}";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(str);
            return matches;
        }
    }
}
