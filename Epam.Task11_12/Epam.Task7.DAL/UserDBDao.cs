using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Epam.Task7.Entities;
using Epam.Task7.DAL.Interface;

namespace Epam.Task7.DAL
{
    public class UserDBDao : IUserDao
    {
        private string _connectionString;
        private static Dictionary<string, User> repoUsers = new Dictionary<string, User>();

        public UserDBDao()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            this.GetAll();
        }

        public void Add(User user)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "INSERT INTO users (name, birth) VALUES (\'" + user.Name + "\', \'" + user.DateOfBirth + "\'); INSERT INTO useraward (id_user) VALUES (IDENT_CURRENT(\'users\'))";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoUsers.Clear();
            this.GetAll();
        }

        public void Change(int no, string newname, string newdate)
        {
            repoUsers.Clear();
            this.GetAll();

            User user = this.GetByNo(no);

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "UPDATE users SET name = \'" + newname + "\', birth = \'" + newdate + "\' WHERE id_user = " + user.Id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoUsers.Clear();
            this.GetAll();
        }

        public void Delete(string id)
        {
            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DELETE FROM useraward WHERE useraward.id_user = " + id + ";DELETE FROM users WHERE id_user = " + id; 
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();      
            }
        }

        public void DeleteByNo(int no)
        {
            repoUsers.Clear();
            this.GetAll();
            int count = 0;

            foreach (var item in repoUsers)
            {
                if (count == no - 1)
                {
                    this.Delete(item.Value.Id);
                }

                count++;
            }

            repoUsers.Clear();
            this.GetAll();
        }

        public IEnumerable<User> GetAll()
        {
            repoUsers.Clear();
            var result = new List<User>();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT users.id_user, users.name, users.birth, award.id_award, award.title FROM award, users, useraward WHERE useraward.id_award = award.id_award AND useraward.id_user = users.id_user UNION SELECT users.id_user, users.name, users.birth, null, null FROM useraward, users WHERE useraward.id_user = users.id_user AND useraward.id_award IS NULL";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    User u = new User(reader["id_user"] + "", reader["name"] + "", ((DateTime)reader["birth"]).ToString("d"));
                    Award a = new Award(reader["id_award"] == DBNull.Value ? "" : reader["id_award"] + "", reader["title"] + "");
                    if (!repoUsers.ContainsKey(u.Id))
                    {
                        repoUsers.Add(u.Id, u);
                        repoUsers[u.Id].Awards.Add(a);
                    }
                    else
                    {
                        repoUsers[u.Id].Awards.Add(a);
                    }
                }

                sqlConnection.Close();
            }

            foreach (var item in repoUsers)
            {
                result.Add(item.Value);
            }

            return result;
        }

        public User GetById(string id)
        {
            repoUsers.Clear();
            this.GetAll();

            foreach (var item in repoUsers)
            {
                if (item.Value.Id == id)
                {
                    return item.Value;
                }
            }

            return null;
        }

        public User GetByNo(int no)
        {
            repoUsers.Clear();
            this.GetAll();

            int count = 0;

            foreach (var item in repoUsers)
            {
                if (count == no - 1)
                {
                    return item.Value;
                }

                count++;
            }

            return null;
        }
    }
}
