using System;
using System.Collections.Generic;
using System.Configuration;
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
        private static string key = ConfigurationManager.AppSettings["UserAwardDaoKey"];

        private static IUserDao userDao;

        private static IUserLogic userLogic;

        private static IAwardDao awardDao;

        private static IAwardLogic awardLogic;

        private static ILoginDao loginDao;

        private static ILoginLogic loginLogic;


        public static IUserDao UserDao
        {
            get
            {
                if (userDao == null)
                {
                    switch (key.ToLower())
                    {
                        case "file":
                            {
                                userDao = new UserDao();
                                break;
                            }
                        case "db":
                            {
                                userDao = new UserDBDao();
                                break;
                            }

                        default:
                            throw new Exception("Invalid app data source configuration");
                    }
                }

                return userDao;
            }
        }

        public static IAwardDao AwardDao
        {
            get
            {
                if (awardDao == null)
                {
                    switch (key.ToLower())
                    {
                        case "file":
                            {
                                awardDao = new AwardDao();
                                break;
                            }
                        case "db":
                            {
                                awardDao = new AwardDBDao();
                                break;
                            }

                        default:
                            throw new Exception("Invalid app data source configuration");
                    }
                }

                return awardDao;
            }
        }

        public static ILoginDao LoginDao
        {
            get
            {
                if (loginDao == null)
                {
                    switch (key.ToLower())
                    {
                        case "file":
                            {
                                loginDao = new LoginDao();
                                break;
                            }
                        case "db":
                            {
                                loginDao = new LoginDBDao();
                                break;
                            }

                        default:
                            throw new Exception("Invalid app data source configuration");
                    }
                }

                return loginDao;
            }
        }


        public static IUserLogic UserLogic => userLogic ?? (userLogic = new UserLogic(UserDao));

        public static IAwardLogic AwardLogic => awardLogic ?? (awardLogic = new AwardLogic(AwardDao));

        public static ILoginLogic LoginLogic => loginLogic ?? (loginLogic = new LoginLogic(LoginDao));
    }
}
