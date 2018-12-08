using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._1_Lost
{
    public class Program
    {
        public static List<int> CreateList(int n)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(i);
            }

            return list;
        }

        public static void Show(List<int> list)
        {
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        public static void ReductionList(ref List<int> list)
        {
            int deleteEvery = 2;
            int start = deleteEvery - 1;
            
            while (list.Count() > 1)
            {
                for (int i = start; i < list.Count; i += deleteEvery - 1)
                {
                    list.RemoveAt(i);
                    start = i;
                }

                if (start == list.Count - 1)
                {
                    start = 0;
                }
                else
                {
                    start = 1;
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Program calculate the rest of N people in the rinf if will out each of two");
            List<int> listOfPeople;

            try
            {
                Console.WriteLine("------");
                Console.WriteLine("Enter number of people: ");
                int n = int.Parse(Console.ReadLine());
                listOfPeople = CreateList(n);
                Show(listOfPeople);
                ReductionList(ref listOfPeople);
                Show(listOfPeople);
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
