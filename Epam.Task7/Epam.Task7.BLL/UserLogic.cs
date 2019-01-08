using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL
{
    public class UserLogic : IUserLogic
    {
        private IUserDao userDao;

        public UserLogic(IUserDao userDao)
        {
            this.userDao = userDao;
        }

        public void Add(User user)
        {
            this.userDao.Add(user);
        }

        public void Delete(string id)
        {
            this.userDao.Delete(id);
        }

        public void DeleteByNo(int no)
        {
            this.userDao.DeleteByNo(no);
        }

        public User GetById(string id)
        {
            return this.userDao.GetById(id);
        }

        public User GetByNo(int no)
        {
            return this.userDao.GetByNo(no);
        }

        public IEnumerable<User> GetAll()
        {
            return this.userDao.GetAll();
        }
    }
}
