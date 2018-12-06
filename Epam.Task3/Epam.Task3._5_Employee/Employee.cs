using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._5_Employee
{
    class Employee : User
    {
        string appointment;
        DateTime startWorking;

        public string Appointment
        {
            get
            {
                return this.appointment;
            }
            set
            {
                this.appointment = CheckName(value);
            }
        }

        public Employee()
            : base()
        {

        }

        public DateTime StartWorking
        {
            get
            {
                return this.startWorking;
            }
            set
            {
                if (value <= DateOfBirth)
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
                return (DateTime.Now - StartWorking).TotalDays / 365;
            }
        }
    }
}
