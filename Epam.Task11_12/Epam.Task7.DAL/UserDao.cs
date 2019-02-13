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
    public class UserDao : IUserDao
    {
        private static Dictionary<string, User> repoUsers = new Dictionary<string, User>();

        static UserDao()
        {
            repoUsers = FilesDao.Read();
        }

        public void Add(User user)
        {
            repoUsers.Add(user.Id, user);
            FilesDao.Add(repoUsers);
        }

        public void Delete(string id)
        {
            repoUsers.Remove(id);
            FilesDao.Add(repoUsers);
        }

        public void DeleteByNo(int no)
        {
            int count = 0;
            string id = string.Empty;
            foreach (var item in repoUsers)
            {
                if (count == no)
                {
                    id = item.Key;
                }

                count++;
            }

            repoUsers.Remove(id);
            FilesDao.Add(repoUsers);
        }

        public void Change(int no, string newname, string newdate)
        {
            int count = 0;
            string id = string.Empty;
            foreach (var item in repoUsers)
            {
                if (count == no)
                {
                    id = item.Key;
                }

                count++;
            }

            repoUsers[id].Name = newname;
            repoUsers[id].DateOfBirth = DateTime.Parse(newdate);
            FilesDao.Add(repoUsers);
        }

        public User GetById(string id)
        {
            if (repoUsers.TryGetValue(id, out var user))
            {
                return user;
            }

            return null;
        }

        public User GetByNo(int no)
        {
            int count = 0;
            string id = string.Empty;
            foreach (var item in repoUsers)
            {
                if (count == no)
                {
                    id = item.Key;
                }

                count++;
            }

            return repoUsers[id];
        }

        public IEnumerable<User> GetAll()
        {
            return repoUsers.Values;
        }
    }
}
