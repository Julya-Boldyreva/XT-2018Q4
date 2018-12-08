using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task4._2_WordFrequency
{
    public class Program
    {
        public static Dictionary<string, int> CountWords(string str)
        {
            Dictionary<int, string> list = ToList(str);
            Dictionary<string, int> counted = new Dictionary<string, int>();
            foreach (var item in list)
            {
               if (!counted.ContainsKey(item.Value))
                {
                    counted.Add(item.Value, 1);
                }
                else
                {
                    counted[item.Value]++;
                }
            }

            return counted;
        }

        public static Dictionary<int, string> ToList(string str)
        {
            Dictionary<int, string> listOfWords = new Dictionary<int, string>();
            StringBuilder tmp = new StringBuilder();
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                while (char.IsPunctuation(str[i]) && char.IsSeparator(str[i]))
                {
                    i++;
                }

                while (i < str.Length && !char.IsPunctuation(str[i]) && !char.IsSeparator(str[i]))
                {
                    tmp.Append(str[i]);
                    i++;
                }

                listOfWords.Add(i, tmp.ToString());
                tmp.Clear();
            }

            return listOfWords;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Program calculate words frequency");

            try
            {
                Console.WriteLine("------");
                Console.WriteLine("Enter sentence: ");
                string str = Console.ReadLine();
                Dictionary<string, int> listOfWords = CountWords(str);
                foreach (var item in listOfWords)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
