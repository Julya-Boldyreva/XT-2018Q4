using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;

namespace Epam.Task7.DAL
{
    public class LoginDBDao : ILoginDao
    {
        private string _connectionString;
        public static List<Login> usersList = new List<Login>();

        public LoginDBDao()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            this.Read();
            if (!this.IsUser("admin", "admin"))
            {
                Login usr = new Login("admin", "admin", "admin");
                this.AddToFileNewUser(usr);
            }
        }

        public void AddToFileAll()
        {
        }

        public void AddToFileNewUser(Login user)
        {
            usersList.Add(user);

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "INSERT INTO logins (login, pasword, role) VALUES (\'" + user.Name+ "\',\'" + user.Password + "\', \'" + user.Role + "\')";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }
        }

        public void Read()
        {
            usersList.Clear();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM logins";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usersList.Add(new Login(reader["login"]+"", reader["pasword"] == DBNull.Value ? "" : reader["pasword"] + "", reader["role"] + ""));
                }

                sqlConnection.Close();
            }
        }

        public bool IsUser(string name, string password)
        {
            this.Read();
            bool res = false;
            Login tmp = usersList.Find(a => a.Name == name);
            if (tmp != null)
            {
                if (tmp.Name == name && tmp.Password == password)
                {
                    res = true;
                }
            }

            return res;
        }

        public Login ReturnUser(string name)
        {
            this.Read();
            Login res = usersList.Find(a => a.Name == name);
            return res;
        }

        public void Delete(Login user)
        {
            usersList.Clear();
            this.Read();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DELETE FROM logins WHERE login = \'" + user.Name + "\'";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            usersList.Clear();
            this.Read();
        }

        public void Change(int no, string newname, string newpass, string newrole)
        {
            usersList.Clear();
            this.Read();
            Login login = this.GetByNo(no);

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "UPDATE logins SET login = \'" + newname + "\', pasword = \'" + newpass + "\', role = \'" + newrole + "\'  WHERE login = \'" + login.Name + "\'";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            usersList.Clear();
            this.Read();
        }

        public Login GetByNo(int no)
        {
            usersList.Clear();
            this.Read();

            int count = 0;

            foreach (var item in usersList)
            {
                if (count == no - 1)
                {
                    return item;
                }

                count++;
            }

            return null;
        }
    }
}
