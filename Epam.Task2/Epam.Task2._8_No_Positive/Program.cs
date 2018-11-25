using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._8_No_Positive
{
    class Program
    {
        static int[,,] Generate(int width, int height, int depth, int min, int max)
        {
            int[,,] arr = new int[width,height,depth];
            Random r = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        arr[i,j,k] = r.Next(min, max);
                    }
                }
            }
            return arr;
        }
        static void NoPositive(ref int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        if (arr[i, j, k] > 0)
                        {
                            arr[i, j, k] = 0;
                        }
                         
                    }
                }
            }
        }
        static void PrintTripleArray(int[,,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    for (int k = 0; k < arr.GetLength(2); k++)
                    {
                        Console.Write($"{arr[i, j, k]} ");
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.Write(Environment.NewLine);
            }
        }
        static void Main(string[] args)
        {
            const int A = 4, B = 2, C = 3;
            const int MIN = -100;
            const int MAX = 100;
            Console.WriteLine($"Array is:{Environment.NewLine}");
            int[,,] arr = Generate(A, B, C, MIN, MAX);
            PrintTripleArray(arr);
            Console.Write(Environment.NewLine);
            Console.WriteLine("------");
            Console.WriteLine($"No-positive array is:{Environment.NewLine}");
            NoPositive(ref arr);
            PrintTripleArray(arr);
            Console.WriteLine();
        }
    }
}
