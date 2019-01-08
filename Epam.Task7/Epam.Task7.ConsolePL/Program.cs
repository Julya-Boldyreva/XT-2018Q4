using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL;
using Epam.Task7.Common;
using Epam.Task7.Entities;

namespace Epam.Task7.ConsolePL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var userLogic = Dependencies.UserLogic;
                var awardLogic = Dependencies.AwardLogic;
                
                while (true)
                {
                    Console.WriteLine("This is the program which can work with list of Users and Awards");
                    Console.WriteLine("--------");
                    Console.WriteLine("1. Show all users");
                    Console.WriteLine("2. Add user");
                    Console.WriteLine("3. Remove user");
                    Console.WriteLine("4. Show all awards");
                    Console.WriteLine("5. Add award to list");
                    Console.WriteLine("6. Add award to User");
                    Console.WriteLine("0. Exit");
                    Console.WriteLine("Choose an option: ");
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------");
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Clear();
                                var list = userLogic.GetAll();
                                Shower.ShowUsers(list);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                            break;
                        case 2:
                            {
                                Console.Clear();
                                User user = Shower.AskForUser();
                                userLogic.Add(user);
                                Console.WriteLine("---User is added---");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                            break;
                        case 3:
                            {
                                Console.Clear();
                                int lenBefore = userLogic.GetAll().Count<User>();
                                int no = Shower.AskForDelete(userLogic.GetAll());
                                userLogic.DeleteByNo(no);
                                int lenAfter = userLogic.GetAll().Count<User>();
                                if (lenBefore != lenAfter)
                                {
                                    Console.WriteLine("---User is deleted---");
                                }
                                else
                                {
                                    Console.WriteLine("---User wasn\'t deleted---");
                                }

                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                            break;
                        case 4:
                            {
                                Console.Clear();
                                var list = awardLogic.GetAll();
                                Shower.ShowAwards(list);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                            break;
                        case 5:
                            {
                                Console.Clear();
                                Award award = Shower.AskForAwardToAddInList();
                                awardLogic.AddToAwards(award);
                                Console.WriteLine("---Award is added---");
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                            break;
                        case 6:
                            {
                                Console.Clear();
                                int userNo, awardNo;
                                Shower.AskForAward(userLogic.GetAll(), awardLogic.GetAll(), out userNo, out awardNo);
                                User user = userLogic.GetByNo(userNo);
                                Award award = awardLogic.GetByNo(awardNo);
                                if (user.Awards.Contains(award))
                                {
                                    Console.WriteLine("Award already exists");
                                    Console.WriteLine($"---Award isn\'t added to {user.Name}---");
                                }
                                else
                                {
                                    awardLogic.AddToUser(user, award);
                                    Console.WriteLine($"---Award is added to {user.Name}---");
                                }

                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                            }

                            break;
                        case 0:
                            {
                            Environment.Exit(0);
                            }

                            break;
                        default:
                            {
                                Console.WriteLine("Such option is absent");
                            }

                            break;
                    }

                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("--------");
                Console.WriteLine($"Error has occured: {e.Message}");
                throw;
            }
        }
    }
}
