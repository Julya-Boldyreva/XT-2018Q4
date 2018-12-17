using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Epam.Task5._3_SortingUnit
{
    public class SortModule
    {
        public delegate int Compare<T>(T leftElem, T rightElem);

        public delegate void Finish();

        public event Finish WhenFinish;

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

        public void ShowFinish()
        {
            Console.WriteLine($">>FINISH THREAD WITH ID={Thread.CurrentThread.ManagedThreadId}");
        }

        public void Sort<T>(T[] arr, Compare<T> compare)
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

                        Console.WriteLine($"Now is sorting array with id={arr.GetHashCode()}");
                        Thread.Sleep(10);
                    }
                }
            }

            if (this.WhenFinish != null)
            {
                this.WhenFinish();
            }
        }

        public void NewThreadSort<T>(T[] arr)
        {
            Thread thread = new Thread(() => this.Sort(arr, CompareByValue<T>));
            thread.Priority = ThreadPriority.Highest;
            thread.Start();
            this.WhenFinish += this.ShowFinish;
        }
    }
}
