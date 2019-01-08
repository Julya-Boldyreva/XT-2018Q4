using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL.Interface
{
    public interface IAwardLogic
    {
        void AddToUser(User user, Award award);

        void AddToAwards(Award award);

        void Delete(User user, string id);

        Award GetById(string id);

        Award GetByNo(int no);

        IEnumerable<Award> GetAll();
    }
}
