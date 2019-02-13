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
        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "UsersData.txt");
        private static string pathA = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "AwardsData.txt");

        public static void Add(Dictionary<string, User> list)
        {
            int co = 0;
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Value.Id}{Environment.NewLine}{item.Value.Name}{Environment.NewLine}{item.Value.DateOfBirth:dd.MM.yyyy}");
                    if (item.Value.Awards.Count > 0)
                    {
                        foreach (var i in item.Value.Awards)
                        {
                            if (co < item.Value.Awards.Count)
                            {
                                sw.Write($"{i.Id}|{i.Title}|");
                            }
                            else
                            {
                                sw.Write($"{i.Id}|{i.Title}");
                            }

                            co++;
                        }
                    }
                    else
                    {
                        sw.Write($"-|-");
                    }

                    sw.WriteLine();
                    co = 0;
                }
            }
        }

        public static void Add(IEnumerable<User> list)
        {
            int co = 0;
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Id}{Environment.NewLine}{item.Name}{Environment.NewLine}{item.DateOfBirth:dd.MM.yyyy}");
                    if (item.Awards.Count > 0)
                    {
                        foreach (var i in item.Awards)
                        {
                            if (co < item.Awards.Count)
                            {
                                sw.Write($"{i.Id}|{i.Title}|");
                            }
                            else
                            {
                                sw.Write($"{i.Id}|{i.Title}");
                            }

                            co++;
                        }
                    }
                    else
                    {
                        sw.Write($"-|-");
                    }

                    sw.WriteLine();
                    co = 0;
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
        
        /*
        public static void AddAwardWithImg(Dictionary<string, Award> list)
        {
            using (StreamWriter sw = new StreamWriter(pathA))
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Key}{Environment.NewLine}{item.Value.Title}{Environment.NewLine}{item.Value.StrImg}");
                }
            }
        }
        */
       /* public static Dictionary<string, Award> ReadAwardWithImg()
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
                    string img = sr.ReadLine();

                    Award award = new Award(id, title, img);

                    res.Add(id, award);
                }
            }

            return res;
        }*/

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
                    string str = sr.ReadLine();

                    string[] arr = str.Split('|');
                    List<Award> la = new List<Award>();

                    for (int i = 0; i < arr.Length - 1; i++)
                    {
                        la.Add(new Award(arr[i], arr[i + 1]));
                        i++;
                    }

                    res.Add(id, new User(id, name, dob, la));
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
