using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Epam.Task7.Entities;


namespace Epam.Task7.DAL
{
    class DBDao
    {
        private string _connectionString;

        public DBDao()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }


    }
}
