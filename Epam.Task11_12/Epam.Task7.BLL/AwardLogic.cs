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
    public class AwardLogic : IAwardLogic
    {
        private IAwardDao awardDao;

        public AwardLogic(IAwardDao awardDao)
        {
            this.awardDao = awardDao;
        }

        public void AddToUser(User user, Award award)
        {
            this.awardDao.Add(user, award);
        }

        public void AddToAwards(Award award)
        {
            this.awardDao.AddAward(award);
        }

       /*public void AddAwardWithImg(Award award)
        {
            this.awardDao.AddAwardWithImg(award);
        }*/

        public void DeleteFromAwards(int no)
        {
            this.awardDao.DeleteFromAwards(no);
        }

        public void Delete(User user, string id)
        {
            this.awardDao.Delete(user, id);
        }

        public void Change(int id, string newname)
        {
            this.awardDao.Change(id, newname);
        }

        public Award GetById(string id)
        {
            return this.awardDao.GetById(id);
        }

        public Award GetByNo(int no)
        {
            return this.awardDao.GetByNo(no);
        }

        public IEnumerable<Award> GetAll()
        {
            return this.awardDao.GetAll();
        }
    }
}
