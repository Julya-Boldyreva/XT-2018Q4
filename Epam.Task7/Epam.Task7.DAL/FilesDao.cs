using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class FilesDao
    {
        private static string path = "UsersData.txt";
        private static string pathA = "AwardsData.txt";

        public static void Add(Dictionary<string, User> list)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Value.Id}{Environment.NewLine}{item.Value.Name}{Environment.NewLine}{item.Value.DateOfBirth:dd.MM.yyyy}");
                }
            }
        }

        public static void AddAward(Dictionary<string, Award> list)
        {
            using (StreamWriter sw = new StreamWriter(pathA))
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Key}{Environment.NewLine}{item.Value.Title}");
                }
            }
        }

        public static Dictionary<string, User> Read()
        {
            Dictionary<string, User> res = new Dictionary<string, User>();

            if (!File.Exists(path))
            {
                return res;
            }

            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string id = sr.ReadLine();
                    string name = sr.ReadLine();
                    string dob = sr.ReadLine();

                    User user = new User(id, name, dob);

                    res.Add(id, user);
                }
            }

            return res;
        }

        public static Dictionary<string, Award> ReadAward()
        {
            Dictionary<string, Award> res = new Dictionary<string, Award>();

            if (!File.Exists(pathA))
            {
                return res;
            }

            using (StreamReader sr = new StreamReader(pathA))
            {
                while (!sr.EndOfStream)
                {
                    string id = sr.ReadLine();
                    string title = sr.ReadLine();

                    Award award = new Award(id, title);

                    res.Add(id, award);
                }
            }

            return res;
        }
    }
}
