using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._4_NumberArraySum
{
    public static class ExtentionWithSumClass
    {
        public static double Sum(this double[] num)
        {
            double res = 0;
            for (int i = 0; i < num.Length; i++)
            {
                res += num[i];
            }

            return res;
        }

        public static int Sum(this int[] num)
        {
            int res = 0;
            for (int i = 0; i < num.Length; i++)
            {
                res += num[i];
            }

            return res;
        }

        public static float Sum(this float[] num)
        {
            float res = 0;
            for (int i = 0; i < num.Length; i++)
            {
                res += num[i];
            }

            return res;
        }
    }
}
