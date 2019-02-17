using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Task7.DAL.Interface;
using Epam.Task7.Entities;

namespace Epam.Task7.DAL
{
    public class AwardDBDao : IAwardDao
    {
        private string _connectionString;
        private static List<Award> repoAwards = new List<Award>();

        public AwardDBDao()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            repoAwards = this.GetAll().ToList<Award>();
        }

        public void Add(User user, Award award)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DELETE FROM useraward WHERE id_award IS NULL AND id_user = " + user.Id + ";INSERT INTO useraward (id_user, id_award) VALUES (" + user.Id + "," + award.Id + ")";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
        }

        public void AddAward(Award award)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "INSERT INTO award (title) VALUES (\'" + award.Title + "\')";
                command.CommandType = CommandType.Text;
                
                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
        }

        public void DeleteFromAwards(int no)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
            Award award = this.GetByNo(no);

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "DELETE FROM useraward WHERE useraward.id_award = " + award.Id + ";DELETE FROM award WHERE id_award = " + award.Id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
        }

        public void Delete(User user, string id)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "UPDATE useraward SET id_award = NULL WHERE id_user = " + user.Id + "AND id_award = " + id;
                //// + "; DELETE FROM useraward WHERE id_award IS NULL AND id_user = " + user.Id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
        }

        public void Change(int no, string newname)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
            Award award = this.GetByNo(no);

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "UPDATE award SET title = \'" + newname + "\' WHERE id_award = " + award.Id;
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                command.ExecuteReader();
                sqlConnection.Close();
            }

            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
        }

        public Award GetById(string id)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();
            foreach (var item in repoAwards)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public Award GetByNo(int no)
        {
            repoAwards.Clear();
            repoAwards = this.GetAll().ToList<Award>();

            int count = 0;

            foreach (var item in repoAwards)
            {
                if (count == no - 1)
                {
                    return item;
                }

                count++;
            }

            return null;
        }

        public IEnumerable<Award> GetAll()
        {
            repoAwards.Clear();
            var result = new List<Award>();

            using (var sqlConnection = new SqlConnection(this._connectionString))
            {
                var command = sqlConnection.CreateCommand();
                command.CommandText = "SELECT * FROM award";
                command.CommandType = CommandType.Text;

                sqlConnection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    result.Add(new Award((int)reader["id_award"], (string)reader["title"]));
                }

                sqlConnection.Close();
            }

            return result;
        }
    }
}
