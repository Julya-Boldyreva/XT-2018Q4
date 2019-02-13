using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Epam.Task7.BLL;
using Epam.Task7.Entities;

namespace Epam.Task7.ConsolePL
{
    public class Shower
    {
        public static void ShowUsers(IEnumerable<User> list)
        {
            int count = 0;
            Console.WriteLine($"At all {list.Count<User>()} users: ");
            Console.WriteLine();
            if (list.Count<User>() > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{count}) {item.Name}, {item.Age:0.0} y.o. ({item.DateOfBirth})");
                    count++;
                    Console.WriteLine("Awards:");
                    if (item.Awards.Count < 1)
                    {
                        Console.WriteLine("-");
                    }
                    else
                    {
                        foreach (var award in item.Awards)
                        {
                            Console.WriteLine($"- {award.Title}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No users in the list");
            }

            count = 0;
        }

        public static User AskForUser()
        {
            Console.WriteLine("---Enter new user data---");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Date of birth (dd.mm.yyyy): ");
            string dob = Console.ReadLine();
            Regex regex = new Regex(@"[\d]{2}\.[\d]{2}\.[\d]{4}");
            MatchCollection matches = regex.Matches(dob);
            while (matches.Count != 1)
            {
                Console.WriteLine("It is not dd.mm.yyyy format. Please, repeat the entrance: ");
                dob = Console.ReadLine();
                matches = regex.Matches(dob);
            }

            User user = new User(name, dob);
            return user;
        }

        public static int AskForDelete(IEnumerable<User> list)
        {
            ShowUsers(list);
            Console.WriteLine("---Enter number of user, whom pretented to be deleted---");
            Console.WriteLine("User №: ");
            int no = int.Parse(Console.ReadLine());
            return no;
        }

        public static void ShowAwards(IEnumerable<Award> list)
        {
            int count = 0;
            Console.WriteLine($"At all {list.Count<Award>()} awards: ");
            Console.WriteLine();
            if (list.Count<Award>() > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine($"{count}) {item.Title}");
                    count++;
                }
            }
            else
            {
                Console.WriteLine("No awards in the list");
            }

            count = 0;
        }

        public static Award AskForAwardToAddInList()
        {
            Console.WriteLine("---Enter new award data---");
            Console.WriteLine("Title: ");
            string title = Console.ReadLine();
            Award award = new Award(title);
            return award;
        }

        public static void AskForAward(IEnumerable<User> listOfUsers, IEnumerable<Award> listOfAwards, out int noU, out int noA)
        {
            noU = -1;
            noA = -1;

            if (listOfUsers.Count<User>() < 1 || listOfAwards.Count<Award>() < 1)
            {
                Console.WriteLine("There are no User/Award");
            }
            else
            {
                ShowUsers(listOfUsers);
                Console.WriteLine();
                Console.WriteLine("---Enter id of user you want add the award---");
                Console.WriteLine("User №: ");
                noU = int.Parse(Console.ReadLine());
                while (noU < 0 && noU > listOfUsers.Count<User>())
                {
                    Console.WriteLine("Incorrect! Please, repeate the entrance. User №: ");
                    noU = int.Parse(Console.ReadLine());
                }

                Console.Clear();
                Console.WriteLine($"Add award to user № {noU}");
                Console.WriteLine("---------");
                ShowAwards(listOfAwards);
                Console.WriteLine();
                Console.WriteLine("---Enter id of award to award---");
                Console.WriteLine("Award №: ");
                noA = int.Parse(Console.ReadLine());
                while (noA < 0 && noA > listOfAwards.Count<Award>())
                {
                    Console.WriteLine("Incorrect! Please, repeate the entrance. Award №: ");
                    noA = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
