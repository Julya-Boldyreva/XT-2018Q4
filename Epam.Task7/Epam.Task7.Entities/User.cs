using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task7.Entities
{
    public class User
    {
        private string id;
        private string name;
        private DateTime dateOfBirdth;
        private List<Award> awards = new List<Award>();

        public User(string name, string dateOfBirth)
        {
            this.id = $"U{DateTime.Now:ddMMyyyyHHmmssffff}";
            this.name = name;
            this.dateOfBirdth = GetDate(dateOfBirth);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirdth;
            }

            set
            {
                this.dateOfBirdth = value;
            }
        }

        public double Age
        {
            get
            {
                return (DateTime.Now - this.DateOfBirth).TotalDays / 365;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public List<Award> Awards
        {
            get
            {
                return this.awards;
            }

            set
            {
                this.awards = value;
            }
        }

        public static DateTime GetDate(string date)
        {
            string[] dateArr = date.Split('.');
            int year = int.Parse(dateArr[2]);
            int month = int.Parse(dateArr[1]);
            int day = int.Parse(dateArr[0]);
            return new DateTime(year, month, day);
        }
    }
}
