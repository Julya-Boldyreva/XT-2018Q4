using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Epam.Task6.BackupSystem
{
    class Watcher
    {
        public static void ToWatch()
        {
            Console.Clear();

            Console.WriteLine($"Your current directory is {Data.currentDir}");
            Console.WriteLine("Do you want change watched directory? (y/n)");
            char choose = char.Parse(Console.ReadLine());
            Console.WriteLine("------------");
            if (choose.Equals('y'))
            {
                Console.WriteLine("Enter new directory: ");
                string s = Console.ReadLine();
                Data.currentDir = s;
                Console.WriteLine($"[Changed to {Data.currentDir}]");
            }
            Console.WriteLine("------------");
            Console.WriteLine($"Start of watching...{Environment.NewLine}If you don\'t want see after, press 0");
            while (Console.ReadLine() != "0")
            {
            }

            FileSystemWatcher watcher = new FileSystemWatcher();

            watcher.Path = Data.currentDir;
            watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
            watcher.Changed += new FileSystemEventHandler(OnChanged);
            watcher.Created += new FileSystemEventHandler(OnChanged);
            watcher.Deleted += new FileSystemEventHandler(OnChanged);
            watcher.Renamed += new RenamedEventHandler(OnRenamed);
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            // watcher.Dispose();

            Console.WriteLine("End of watching. Press any key to return in main menu...");
            Console.ReadKey();
        }

        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("changed " + e.FullPath);
            Data.PushToHistory(e.FullPath);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("renamed " + e.FullPath);
            Data.PushToHistory(e.FullPath);
        }
    }
}
