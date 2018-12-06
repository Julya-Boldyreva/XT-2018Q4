using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._5_Employee
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Are you an employeer? Tell us about you!");
            try
            {
                Employee employee = new Employee();
                Console.WriteLine("Enter your name");
                employee.Name = Console.ReadLine();
                Console.WriteLine("Enter your middle name");
                employee.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter your last name");
                employee.LastName = Console.ReadLine();
                Console.WriteLine("Enter your date of birdth in format yyyy.mm.dd");
                employee.DateOfBirth = User.GetDate(Console.ReadLine());
                Console.WriteLine("Enter your appointment");
                employee.Appointment = Console.ReadLine();
                Console.WriteLine("Enter your date of starting work in format yyyy.mm.dd");
                employee.StartWorking = User.GetDate(Console.ReadLine());
                Console.WriteLine("------");
                Console.WriteLine("Your data:");
                Console.WriteLine($"Your name is {employee.Name} {employee.MiddleName} {employee.LastName}");
                Console.WriteLine($"You was born in {employee.DateOfBirth:r}");
                Console.WriteLine($"Now you are {employee.Age:f1} years old");
                Console.WriteLine($"Your appointment is {employee.Appointment}");
                Console.WriteLine($"You start working in {employee.StartWorking:f1}");
                Console.WriteLine($"Your period of working is {employee.PeriodOfWorking:f1}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
