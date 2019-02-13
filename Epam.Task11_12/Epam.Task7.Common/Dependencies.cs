using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.BLL;
using Epam.Task7.BLL.Interface;
using Epam.Task7.DAL;
using Epam.Task7.DAL.Interface;

namespace Epam.Task7.Common
{
    public static class Dependencies
    {
        private static IUserDao userDao;

        private static IUserLogic userLogic;

        private static IAwardDao awardDao;

        private static IAwardLogic awardLogic;

        public static IUserDao UserDao => userDao ?? (userDao = new UserDao());

        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));       

        public static IAwardDao AwardDao => awardDao ?? (awardDao = new AwardDao());       

        public static IAwardLogic AwardLogic => awardLogic ?? (awardLogic = new AwardLogic(AwardDao));
    }
}
