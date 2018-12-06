using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._5_Employee
{
    class User
    {
        protected string name;
        protected string middleName;
        protected string lastName;
        protected DateTime dateOfBirdth;

        public User()
        {
            this.name = "Unknown";
            this.middleName = "Unknown";
            this.lastName = "Unknown";
            this.dateOfBirdth = new DateTime(1996, 2, 20);
        }

        public User(string name, string middleName, string lastName, string dateOfBirth)
            : this()
        {
            this.name = CheckName(name);
            this.middleName = CheckName(middleName);
            this.lastName = CheckName(lastName);
            this.dateOfBirdth = GetDate(dateOfBirth);
        }

        public static DateTime GetDate(string date)
        {
            string[] dateArr = date.Split('.');
            int year = int.Parse(dateArr[0]);
            int month = int.Parse(dateArr[1]);
            int day = int.Parse(dateArr[2]);
            return new DateTime(year, month, day);

        }

        protected string CheckName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (!char.IsLetter(name[i]) && name[i] != '-')
                {
                    throw new Exception("Name / Middle name / Last name must contain only letters or \'-\' sign");
                }
            }
            return name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = CheckName(value);
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = CheckName(value);
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = CheckName(value);
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
                return (DateTime.Now - DateOfBirth).TotalDays / 365;
            }
        }
    }
}
