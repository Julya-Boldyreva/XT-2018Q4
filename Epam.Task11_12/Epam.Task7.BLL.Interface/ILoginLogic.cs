using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL;

namespace Epam.Task7.BLL.Interface
{
    public interface ILoginLogic
    {
        void AddToFileAll();

        void AddToFileNewUser(Login user);

        void Read();

        bool IsUser(string name, string password);

        Login ReturnUser(string name);

        void Delete(Login user);

        void Change(int no, string newname, string newpass, string newrole);

        Login GetByNo(int no);
    }
}
