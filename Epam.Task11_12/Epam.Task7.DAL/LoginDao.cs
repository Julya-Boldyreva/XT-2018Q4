using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class LoginDao : ILoginDao
    {
        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Login.txt");
        public static List<Login> usersList = new List<Login>();

        public LoginDao()
        {
            this.Read();
            if (!this.IsUser("admin", "admin"))
            {
                Login usr = new Login("admin", "admin", "admin");
                this.AddToFileNewUser(usr);
            }
        }

        public void AddToFileAll()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in usersList)
                {
                    sw.WriteLine($"{item.Name}|{item.Password}|{item.Role}");
                }
            }
        }
            
        public void AddToFileNewUser(Login user)
        {
            usersList.Add(user);
            this.AddToFileAll();
        }

        public void Read()
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

        public bool IsUser(string name, string password)
        {
            this.Read();
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

        public Login ReturnUser(string name)
        {
            this.Read();
            Login res = usersList.Find(a => a.Name == name);
            return res;
        }

        public void Delete(Login user)
        {
        }

        public void Change(int no, string newname, string newpass, string newrole)
        {
        }

        public Login GetByNo(int no)
        {
            return null;
        }
    }
}
