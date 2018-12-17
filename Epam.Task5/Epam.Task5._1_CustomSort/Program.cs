using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._1_CustomSort
{
    public class Program
    {
        public delegate int Compare<T>(T leftElem, T rightElem);

        public static void Sort<T>(T[] arr, Compare<T> compare)
        {
            if (compare == null)
            {
                throw new Exception("Delegate cannot be null!");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare(arr[j], arr[i]) < 0)
                    {
                        T tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        public static int CompareByValue<T>(T leftElem, T rightElem)
        {
            var le = leftElem.ToString();
            var re = rightElem.ToString();

            if (leftElem is bool)
            {
                if (bool.Parse(le) == bool.Parse(re))
                {
                    return 0;
                }
                else if (bool.Parse(le) == true)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else if (leftElem is int || leftElem is double || leftElem is byte)
            {
                if (double.Parse(le) == double.Parse(re))
                {
                    return 0;
                }
                else if (double.Parse(le) > double.Parse(re))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else if (leftElem is char)
            {
                if (char.Parse(le).Equals(char.Parse(re)))
                {
                    return 0;
                }
                else if (char.Parse(le) > char.Parse(re))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return le.CompareTo(re);
            }
        }

        public static int CompareByLen<T>(T leftElem, T rightElem)
        {
            if (leftElem.ToString().Length == rightElem.ToString().Length)
            {
                return 0;
            }
            else if (leftElem.ToString().Length > rightElem.ToString().Length)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public static void StaticShowTableWithSort<T>(T[] arr)
        {
            Console.WriteLine($"{Environment.NewLine}------{arr.GetType()}------");
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Compare<T> compByVal = new Compare<T>(CompareByValue<T>);
            Sort(arr, compByVal);
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            
            Console.WriteLine($"{ Environment.NewLine}");
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("It\'s the array sort program (created by delegates)");
            Console.WriteLine("You needn\'t enter any data, just see results at the screen");
            Console.WriteLine($"(the 1-st line in each group - unsorted array, the 2-nd - sorted array)");
            try
            {
                int[] arr1 = new int[] { 2, 41, 5, 7, -9, 0, 4, 1, 0, 0 };
                bool[] arr2 = new bool[] { false, true, true, false, true, false };
                double[] arr3 = new double[] { 5.43, 6.88, 1.2352, 1.2343, -6, 34564.45 };
                byte[] arr4 = new byte[] { 34, 2, 8, 46, 235 };
                char[] arr5 = new char[] { 'f', 's', 'x', 'f', 'k', 'b' };
                string[] arr6 = new string[] { "wettrgrgad", "adsg", "dfh", "eee", "eee", "rrrt", "rrrg" };

                StaticShowTableWithSort<int>(arr1);
                StaticShowTableWithSort<bool>(arr2);
                StaticShowTableWithSort<double>(arr3);
                StaticShowTableWithSort<byte>(arr4);
                StaticShowTableWithSort<char>(arr5);
                StaticShowTableWithSort<string>(arr6);
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
