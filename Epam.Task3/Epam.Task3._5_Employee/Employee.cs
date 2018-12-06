using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._5_Employee
{
    public class Employee : User
    {
        private string appointment;
        private DateTime startWorking;

        public Employee()
           : base()
        {
        }

        public string Appointment
        {
            get
            {
                return this.appointment;
            }

            set
            {
                this.appointment = this.CheckName(value);
            }
        }

        public DateTime StartWorking
        {
            get
            {
                return this.startWorking;
            }

            set
            {
                if (value <= this.DateOfBirth)
                {
                    throw new Exception("You not work before your birth");
                }
                else
                {
                    this.startWorking = value;
                }
            }
        }

        public double PeriodOfWorking
        {
            get
            {
                return (DateTime.Now - this.StartWorking).TotalDays / 365;
            }
        }
    }
}
