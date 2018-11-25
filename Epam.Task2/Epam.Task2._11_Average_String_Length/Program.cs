using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._11_Average_String_Length
{
    class Program
    {
        static double AverageLen(string str)
        {
            double countOfWords = 0, sumOfLen = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsPunctuation(str[i]) && !char.IsSeparator(str[i]))
                {
                    sumOfLen++;
                    if (i == str.Length - 1)
                    {
                        countOfWords++;
                    }
                    if (i == str.Length || i<str.Length-1 && (char.IsPunctuation(str[i+1]) || char.IsSeparator(str[i+1])))
                    {
                        countOfWords++;
                    }
                }
                else
                {
                    while (i < str.Length - 1 && (char.IsPunctuation(str[i]) || char.IsSeparator(str[i])))
                    {
                        i++;                        
                    }
                    i--;
                    
                }
            }
            Console.WriteLine($"Common len = {sumOfLen};{Environment.NewLine}Words = {countOfWords}");
            Console.WriteLine("------");
            return sumOfLen / countOfWords;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("/any symbol besides punctuations and serarations is word/");
            Console.WriteLine("Enter a string to know the average of it:");
            string str = Console.ReadLine();
            Console.WriteLine("------");
            Console.WriteLine($"Average is {AverageLen(str)}");
        }
    }
}
