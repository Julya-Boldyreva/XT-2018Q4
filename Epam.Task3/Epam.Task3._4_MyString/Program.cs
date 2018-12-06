using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._4_MyString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Own string constructor program.");
            try
            {
                MyString str = new MyString();
                Console.WriteLine("Please, enter your string (if there is no entrance, the string will be \"Unknown\"): ");
                str.MyStr = Console.ReadLine().ToCharArray();
                int n = 0;
                char ch = 'h';
                MyString compStr = new MyString("hello");
                Console.WriteLine("------");
                Console.WriteLine("Example of class functions:");
                Console.WriteLine($"Your string: {str}");
                Console.WriteLine($"Compare to string \"hello\": {str.CompareTo(compStr)}");
                Console.WriteLine($"Your string concat with string \"CATS-ARE-CUTE\": {str + "CATS-ARE-CUTE"}");
                Console.WriteLine($"Symbol № {n} in your string \"{str}\": {str.FindByInt(n)}");
                Console.WriteLine($"Symbol \'{ch}\' position in your string \"{str}\": {str.FindByChar(ch)}");
                char[] charArr = str.ToCharArray();
                Console.Write("Your string in char array: ");
                foreach (var item in charArr)
                {
                    Console.Write($"{item} ");
                }

                StringBuilder sb = str.ToStringBuilder();
                Console.WriteLine($"{Environment.NewLine}Your string in String Builder: {sb}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
