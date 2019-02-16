using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL;
using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;

namespace Epam.Task7.BLL
{
    public class LoginLogic : ILoginLogic
    {
        private ILoginDao logicDao;

        public LoginLogic(ILoginDao logicDao)
        {
            this.logicDao = logicDao;
        }

        public void AddToFileAll()
        {
            this.logicDao.AddToFileAll();
        }

        public void AddToFileNewUser(Login user)
        {
            this.logicDao.AddToFileNewUser(user);
        }

        public void Change(int no, string newname, string newpass, string newrole)
        {
            this.logicDao.Change(no, newname, newpass, newrole);
        }

        public void Delete(Login user)
        {
            this.logicDao.Delete(user);
        }

        public Login GetByNo(int no)
        {
            return this.logicDao.GetByNo(no);
        }

        public bool IsUser(string name, string password)
        {
            return this.logicDao.IsUser(name, password);
        }

        public void Read()
        {
            this.logicDao.Read();
        }

        public Login ReturnUser(string name)
        {
            return this.logicDao.ReturnUser(name);
        }
    }
}
