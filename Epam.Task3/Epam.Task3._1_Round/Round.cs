using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._1_Round
{
    public class Round
    {
        private double x;
        private double y;
        private double radius;

        public Round()
        {
            this.x = 0;
            this.y = 0;
            this.radius = 1;
        }

        public Round(double x, double y, double radius)
            : this()
        {
            this.x = x;
            this.y = y;
            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                throw new Exception("Radius must be more than zero!");
            }
        }

        public double X
        {
            get
            {
                return this.x;
            }
        }

        public double Y
        {
            get
            {
                return this.y;
            }
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }
        }

        public double Circumference()
        {
            return 2 * Math.PI * this.radius;
        } 

        public double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }
}
