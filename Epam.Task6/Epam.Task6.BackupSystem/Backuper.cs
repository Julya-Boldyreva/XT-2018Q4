using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Epam.Task6.BackupSystem
{
    class Backuper
    {
        public static void ToBackup()
        {
            Console.Clear();
            string tmp;
            Console.WriteLine("Enter the number for rollback or press 0 to escape");
            Console.WriteLine("------");
            Data.ShowList();
            tmp = Console.ReadLine();
            
            if (tmp != "0")
            {
                Data.Delete(int.Parse(tmp));
            }

            Console.WriteLine("Rollback is applied. Press any key to return in main menu...");
            Console.ReadKey();
        }
    }
}
