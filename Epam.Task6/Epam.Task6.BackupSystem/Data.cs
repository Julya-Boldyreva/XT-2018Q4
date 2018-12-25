using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Epam.Task6.BackupSystem
{
    public struct Uniq
    {
        public DateTime Time;
        public Guid Id;
    }

    public static class Data
    {
        public static string currentDir = Path.Combine(Environment.CurrentDirectory, "YOUR_DATA_HERE");
        public static string backupDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),"BACKUPS");
        public static List<Uniq> currentFiles = new List<Uniq>();

        static Data()
        {
            if (!Directory.Exists(backupDir))
            {
                DirectoryInfo di = Directory.CreateDirectory(backupDir);
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
        }

        public static void CheckFolder(string dir)
        {
            if (!File.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }

        public static void PushToHistory(string path)
        {
            var commit = new Uniq
            {
                Time = DateTime.Now,
                Id = Guid.NewGuid()
            };

            currentFiles.Add(commit);
            CopyFolder(currentDir, Path.Combine(backupDir, commit.Id.ToString()));
        }

        public static void Delete(int id)
        {
            DeleteFilesFromFolder(currentDir);
            CopyFolder(Path.Combine(backupDir, currentFiles[id].Id.ToString()), currentDir);
        }

        public static void DeleteFilesFromFolder(string dir)
        {
            Directory.Delete(dir, true);
            Directory.CreateDirectory(dir);
        }

        public static void CopyFolder(string fromDir, string toDir)
        {
            Directory.CreateDirectory(toDir);

            foreach (string s1 in Directory.GetFiles(fromDir))
            {
                string s2 = Path.Combine(toDir, Path.GetFileName(s1));
                File.Copy(s1, s2);
            }

            foreach (string s in Directory.GetDirectories(fromDir))
            {
                CopyFolder(s, Path.Combine(toDir, Path.GetFileName(s)));
            }
        }

        public static void ShowList()
        {
            int i = 1;
            foreach (var commit in currentFiles)
            {
                Console.WriteLine($"id - [{commit.Id}], time - [{commit.Time.ToString("G")}]");
                i++;
            }
        }
    }
}
