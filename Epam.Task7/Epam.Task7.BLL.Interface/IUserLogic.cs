﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.Entities;

namespace Epam.Task7.BLL.Interface
{
    public interface IUserLogic
    {
        void Add(User user);

        void Delete(string id);

        void DeleteByNo(int no);

        User GetById(string id);

        User GetByNo(int no);

        IEnumerable<User> GetAll();
    }
}
