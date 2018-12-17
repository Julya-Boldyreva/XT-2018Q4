using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._5_ToIntOrNotToInt
{
    public class Automato
    {
        private static bool s1 = false;
        private static bool s2 = false;
        private static bool s3 = false;
        private static bool s4 = false;

        private static int position = 0;

        public static bool Check(string str)
        {
            str.ToLower();
            if (str.Length == 1 && !char.IsDigit(str[position]))
            {
                return false;
            }

            if (str[position] == '+' || char.IsDigit(str[position]))
            {
                if (str.Length == 1 && str[position] == '+')
                {
                    return false;
                }
                else
                {
                    s1 = true;
                }

                position++;
                if (position < str.Length - 1)
                {
                    Digit(str, ref position);
                }
                else
                {
                    return true;
                }
            }

            if (str[position] == '.')
            {
                if (position >= str.Length  && str[position] == '.')
                {
                    return false;
                }
                else
                {
                    s2 = true;
                }

                position++;
                if (position < str.Length - 1)
                {
                    Digit(str, ref position);
                }
                else
                {
                    return true;
                }
            }

            if (str[position] == 'e')
            {
                s2 = true;
                s3 = true;
                position++;
            }

            Console.WriteLine("!!!!!" + s2);
            if (str[position] == '+' || str[position] == '-' || char.IsDigit(str[position]))
            {
                s4 = true;
                position++;
                if (position < str.Length)
                {
                    Digit(str, ref position);
                }
                else
                {
                    return true;
                }
            }

            if (position < str.Length && !char.IsDigit(str[position]))
            {
                s4 = false;
            }

            return s1 && s2 && s3 && s4;
        }

        private static void Digit(string s, ref int pos)
        {
            while (char.IsDigit(s[pos]) && pos < s.Length - 1)
            {
                pos++;
            }
        }
    }
}
