using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            _connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            GetAll();
        }

        public void Add(User user)
        {
            repoUsers.Clear();
            GetAll();

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "INSERT INTO users (name, birth) VALUES (\'" + user.Name + "\',\'" + user.DateOfBirth + "\')";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoUsers.Clear();
            GetAll();
        }

        public void Change(int no, string newname, string newdate)
        {
            repoUsers.Clear();
            GetAll();

            User user = GetByNo(no);

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "UPDATE users SET name = \'" + user.Name + "\', birth = \'" + user.DateOfBirth + "\' WHERE id_user = " + user.Id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoUsers.Clear();
            GetAll();
        }

        public void Delete(string id)
        {
            repoUsers.Clear();
            GetAll();
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
               command.CommandText = "DELETE FROM userawards WHERE userawards.id_user = " + id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();

                command.CommandText = "DELETE FROM users WHERE users.id_user = " + id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();                
            }

            repoUsers.Clear();
            GetAll();
        }

        public void DeleteByNo(int no)
        {
            repoUsers.Clear();
            GetAll();
            int count = 0;

            foreach (var item in repoUsers)
            {
                if (count == no)
                {
                    Delete(item.Value.Id);
                }

                count++;
            }
            repoUsers.Clear();
            GetAll();
        }

        public IEnumerable<User> GetAll()
        {
            repoUsers.Clear();
            var result = new List<User>();

            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM users";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    repoUsers.Add(reader["id_user"]+"", new User(reader["id_user"]+"", reader["name"]+"", ((DateTime)reader["birth"]).ToString("d")));
                }
                sqlConnection.Close();

                sqlConnection.Open();
                command.CommandText = "SELECT  award.id_award, award.title FROM award, useraward WHERE award.id_award = useraward.id_award";
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < repoUsers.Count(); i++)
                    {
                        if (GetByNo(i).Id == (string)reader["id_user"])
                        {
                            repoUsers[i.ToString()].Awards.Add(new Award((string)reader["id_award"], (string)reader["title"]));
                        }
                    }
                }

                sqlConnection.Close();
            }

            return result;
        }

        public User GetById(string id)
        {
            repoUsers.Clear();
            GetAll();
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
            GetAll();
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
