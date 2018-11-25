using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2._6_Font_Ajustment
{
    class Program
    {
        [Flags]
        enum Font
        {
            none = 0x0,
            bold = 0x1,
            italic = 0x2,
            underline = 0x4
        }

        static void Main(string[] args)
        {

            Font currentFont = Font.none; //Font.none | Font.bold | Font.italic | Font.underline;//Font.none;
            Font switch_on;
            try
            {
                while (true)
                {
                    Console.WriteLine("This program helps you pseudo-format the text");
                    Console.WriteLine("choose one of this fonts: ");
                    Console.WriteLine("1. bold");
                    Console.WriteLine("2. italic");
                    Console.WriteLine("3. underline");
                    Console.WriteLine("------");
                    Console.WriteLine($"Current font is {currentFont}");
                    Console.WriteLine("------");
                    Console.WriteLine("(enter the number)");
                    switch_on = (Font)int.Parse(Console.ReadLine());
                    if (switch_on == (Font)3)
                    {
                        switch_on = (Font)4;
                    }
                    switch (switch_on)
                    {
                        case Font.bold:
                            {
                                if (currentFont.HasFlag(Font.bold))
                                {
                                    currentFont &= ~Font.bold;
                                }
                                else
                                {
                                    currentFont |= Font.bold;
                                }
                            }; break;
                        case Font.italic:
                            {
                                if (currentFont.HasFlag(Font.italic))
                                {
                                    currentFont &= ~Font.italic;
                                }
                                else
                                {
                                    currentFont |= Font.italic;
                                }
                            }; break;
                        case Font.underline:
                            {
                                if (currentFont.HasFlag(Font.underline))
                                {
                                    currentFont &= ~Font.underline;
                                }
                                else
                                {
                                    currentFont |= Font.underline;
                                }
                            }; break;
                        default: { }; break;
                    }
                    Console.WriteLine();
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("------");
                Console.WriteLine($"Error has occured! {e.Message}");
            }

        }
    }
}
