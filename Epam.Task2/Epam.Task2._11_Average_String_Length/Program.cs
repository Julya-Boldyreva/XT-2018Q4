﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._11_Average_String_Length
{
    public class Program
    {
        public static double AverageLen(string str)
        {
            double countOfWords = 0, sumOfLen = 0;
            int nonLetter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsPunctuation(str[i]) || char.IsSeparator(str[i]))
                {
                    nonLetter++;
                }
            }

            sumOfLen = str.Length - nonLetter;

            for (int i = 0; i < str.Length; i++)
            {
                while (i <= str.Length - 1 && (char.IsPunctuation(str[i]) || char.IsSeparator(str[i])))
                {
                    i++;
                }

                while (i <= str.Length - 1 && (!char.IsPunctuation(str[i]) && !char.IsSeparator(str[i])))
                {
                    i++;
                }

                countOfWords++;
            }

            return sumOfLen / countOfWords;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("/any symbol besides punctuations and serarations is word/");
            Console.WriteLine("Enter a string to know the average of it:");
            string str = Console.ReadLine();
            Console.WriteLine("------");
            Console.WriteLine($"Average is {AverageLen(str)}");
        }
    }
}
