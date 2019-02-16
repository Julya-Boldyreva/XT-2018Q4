using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.DAL.Interface
{
    public interface ILoginDao
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
