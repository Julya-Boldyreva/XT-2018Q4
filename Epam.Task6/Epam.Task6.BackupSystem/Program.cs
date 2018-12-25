using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task6.BackupSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // Data.CheckFolder(Data.currentDir);
           // Data.CheckFolder(Data.backupDir);
           // Data.DeleteFilesFromFolder(Data.backupDir);

            int choose;
            try
            {
                while (true)
                {
                    Console.WriteLine("This is backup system program");
                    Console.WriteLine("------------");
                    Console.WriteLine($"Welcome back, {Environment.UserName}! {Environment.NewLine}Please, choose the option below:");
                    Console.WriteLine("1. See aftwer the directory");
                    Console.WriteLine("2. Rollback changes");
                    Console.WriteLine("(enter number: 1 or 2)");
                    choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1:
                            {
                                Watcher.ToWatch();
                            }
                            break;
                        case 2:
                            {

                                Backuper.ToBackup();
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Default");
                            }
                            break;
                    }
                    Console.Clear();
                }
                //Console.WriteLine("Environment.MachineName  = " + Environment.MachineName);

            }
            catch (Exception e)
            {
                Console.WriteLine($"------{Environment.NewLine}The error has occured: {e.Message}");
            }
        }
    }
}
