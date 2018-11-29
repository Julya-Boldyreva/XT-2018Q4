using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._3_User
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Are you an user? Tell us about you!");
            try
            {
                User user = new User();
                Console.WriteLine("Enter your name");
                user.Name = Console.ReadLine();
                Console.WriteLine("Enter your middle name");
                user.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter your last name");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Enter your date of birdth in format yyyy.mm.dd");
                user.DateOfBirth = User.GetDate(Console.ReadLine());
                Console.WriteLine("------");
                Console.WriteLine("Your data:");
                Console.WriteLine($"Your name is {user.Name} {user.MiddleName} {user.LastName}");
                Console.WriteLine($"You was born in {user.DateOfBirth:r}");
                Console.WriteLine($"Now you are {user.Age:f1} years old");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
