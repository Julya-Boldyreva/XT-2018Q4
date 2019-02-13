using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class LoginDao
    {
        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Login.txt");
        public static List<Login> usersList = new List<Login>();

        public LoginDao()
        {
            Read();
            if (!IsUser("admin", "admin"))
            {
                Login usr = new Login("admin", "admin", "admin");
                AddToFileNewUser(usr);
            }
        }


        public static void AddToFileAll()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in usersList)
                {
                    sw.WriteLine($"{item.Name}|{item.Password}|{item.Role}");
                }
            }
        }
            
        public static void AddToFileNewUser(Login user)
        {
            usersList.Add(user);
            AddToFileAll();
        }

        public static void Read()
        {
            if (!File.Exists(path))
            {
                return;
            }
            else using (StreamReader sr = new StreamReader(path))
            {
                usersList.Clear();
                while (!sr.EndOfStream)
                {
                    string str = sr.ReadLine();
                    string[] arr = str.Split('|');
                    Login usr = new Login(arr[0], arr[1], arr[2]);
                    usersList.Add(usr);
                }
            }
        }

        public static bool IsUser(string name, string password)
        {
            Read();
            bool res = false;
            Login tmp = usersList.Find(a => a.Name == name);
            if (tmp != null)
            {
                if (tmp.Name == name && tmp.Password == password)
                {
                    res = true;
                }
            }

            return res;
        }

        public static Login ReturnUser(string name)
        {
            Read();
            Login res = usersList.Find(a => a.Name == name);
            return res;
        }

    }
}
