using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._10_2D_Array
{
    public class Program
    {
        public static int[,] Generate(int width, int height, int min, int max)
        {
            int[,] arr = new int[width, height];
            Random r = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(min, max);
                }
            }

            return arr;
        }

        public static void PrintDoubleArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                     Console.Write($"{arr[i, j]} ");
                }

                Console.Write(Environment.NewLine);
            }
        }

        public static int Sum(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        sum += arr[i, j];
                    }
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {
            int width = 0, height = 0, min = 0, max = 0;
            Console.WriteLine("To start program, we need to form 2D array");
             
            try
            {
                do
                {
                    Console.WriteLine("Please, enter the height of array: ");
                    width = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please, enter the widtht of array: ");
                    height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please, enter the min number shoul be in array: ");
                    min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please, enter the max number shoul be in array: ");
                    max = int.Parse(Console.ReadLine());
                    if (width <= 0 || height <= 0)
                    {
                        Console.WriteLine("Width and height of array must be positive! Please, repeate the entrance:");
                    }
                }
                while (width <= 0 || height <= 0);
                int[,] arr = Generate(width, height, min, max);
                Console.WriteLine($"Array is:");
                PrintDoubleArray(arr);
                Console.WriteLine("------");
                Console.WriteLine($"Sum of even-position elements is {Sum(arr)}");
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine($"Error has occured! {e.Message}");
            }
        }
    }
}
