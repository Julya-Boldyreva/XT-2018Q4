using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._5_ToIntOrNotToInt
{
    public static class ExtentionWithIsPositiveClass
    {
        public static bool IsPositive(this string str)
        {
            return Automato.Check(str);
        }
    }
}
