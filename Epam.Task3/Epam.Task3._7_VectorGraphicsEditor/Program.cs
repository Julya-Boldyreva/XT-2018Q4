using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This proram imitate Graph editor");
            try
            {
                List<Figure> figures = new List<Figure>();
                Editor e = new Editor();
                while (true)
                {
                    Console.WriteLine("What figure do you want create or print?");
                    Console.WriteLine("1. Circle");
                    Console.WriteLine("2. Line");
                    Console.WriteLine("3. Rectangle");
                    Console.WriteLine("4. Ring");
                    Console.WriteLine("5. Round");
                    Console.WriteLine("6. Print all figures");
                    Console.WriteLine("7. Clear the figures");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("(enter number)");
                    int a = int.Parse(Console.ReadLine());
                    switch (a)
                    {
                        case 1:
                        {
                            Circle c = new Circle();
                            c = (Circle)c.EnterFigure();
                            e.CreateFigure(c, figures);
                            Console.WriteLine("Figure create! Press any key to continue");
                        }

                            break;
                        case 2:
                        {
                            Line c = new Line();
                            c = (Line)c.EnterFigure();
                            e.CreateFigure(c, figures);
                            Console.WriteLine("Figure create! Press any key to continue");
                        }

                            break;
                        case 3:
                        {
                            Rectangle c = new Rectangle();
                            c = (Rectangle)c.EnterFigure();
                            e.CreateFigure(c, figures);
                            Console.WriteLine("Figure create! Press any key to continue");
                        }

                            break;
                        case 4:
                        {
                            Ring c = new Ring();
                            c = (Ring)c.EnterFigure();
                            e.CreateFigure(c, figures);
                            Console.WriteLine("Figure create! Press any key to continue");
                        }

                            break;
                        case 5:
                        {
                            Round c = new Round();
                            c = (Round)c.EnterFigure();
                            e.CreateFigure(c, figures);
                            Console.WriteLine("Figure create! Press any key to continue");
                        }

                            break;
                        case 6:
                        {
                            e.PrintFigures(figures);
                        }

                            break;
                        case 7:
                        {
                            figures.Clear();
                            Console.WriteLine("List was cleared!");
                        }

                            break;
                        case 0:
                        {
                            Environment.Exit(0);
                        }

                            break;
                        default:
                            break;
                    }

                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
