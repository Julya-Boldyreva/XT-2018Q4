using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task5._2_CustomSortDemo
{
    public class Program
    {
        public delegate int Compare<T>(T leftElem, T rightElem);

        public static void Sort<T>(T[] arr, Compare<T> compare1, Compare<T> compare2)
        {
            if (compare1 == null || compare2 == null)
            {
                throw new Exception("Delegate cannot be null!");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (compare1(arr[j], arr[i]) < 0)
                    {
                        T tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                    else if (compare1(arr[j], arr[i]) == 0)
                    {
                        if (compare2(arr[j], arr[i]) < 0)
                        {
                            T tmp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = tmp;
                        }
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

        public static void ShowDemoSort<T>(T[] arr)
        {
            int i = 0;
            foreach (var item in arr)
            {
                Console.SetCursorPosition(0, 4 + i);
                Console.WriteLine($"{item} ");
                i++;
            }

            i = 0;
            Compare<T> compByLen = new Compare<T>(CompareByLen<T>);
            Compare<T> compByVal = new Compare<T>(CompareByValue<T>);
            Sort(arr, compByLen, compByVal);

            foreach (var item in arr)
            {
                Console.SetCursorPosition(50, 4 + i);
                Console.WriteLine($"{item} ");
                i++;
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("It\'s the array sort demo program (created by delegates)");
            try
            {
                string[] arrExample = new string[] { "hey", "teacher", "leave", "those", "kids", "alone", "all", "in", "all", "just", "it", "another", "brick", "in", "the", "wall" };
                Console.WriteLine("-----------");
                ShowDemoSort<string>(arrExample);
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
