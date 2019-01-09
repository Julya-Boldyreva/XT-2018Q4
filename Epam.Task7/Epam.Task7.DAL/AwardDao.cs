using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class AwardDao : IAwardDao
    {
        private static Dictionary<string, Award> repoAwards = new Dictionary<string, Award>();

        static AwardDao()
        {
            repoAwards = FilesDao.ReadAward();
        }

        public void Add(User user, Award award)
        {
            user.Awards.Add(award);
        }

        public void AddAward(Award award)
        {
            repoAwards.Add(award.Id, award);
            FilesDao.AddAward(repoAwards);
        }

        public void Delete(User user, string awardId)
        {
            for (int i = 0; i < user.Awards.Count; i++)
            {
                if (user.Awards[i].Id.Equals(awardId))
                {
                    user.Awards.RemoveAt(i);
                }
            }
        }

        public Award GetById(string id)
        {
            if (repoAwards.TryGetValue(id, out var award))
            {
                return award;
            }

            return null;
        }

        public Award GetByNo(int no)
        {
            int count = 0;
            string id = string.Empty;
            foreach (var item in repoAwards)
            {
                if (count == no)
                {
                    id = item.Key;
                }

                count++;
            }

            return repoAwards[id];
        }

        public IEnumerable<Award> GetAll()
        {
            return repoAwards.Values;
        }
    }
}
