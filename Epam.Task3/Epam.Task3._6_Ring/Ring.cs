using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._6_Ring
{
    class Ring : Round
    {
        protected double radiusOther;

        public Ring() 
            : base()
        {
            this.radiusOther = 2;
        }

        public Ring(double x, double y, double radius, double radiusOther)
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

            if (radiusOther > 0)
            {
                this.radiusOther = radiusOther;
            }
            else
            {
                throw new Exception("Radius must be more than zero!");
            }
        }

        public double RadiusOther
        {
            get
            {
                return this.radiusOther;
            }
        }

        public override double Area()
        {
            return Math.Abs(base.Area() - Math.PI * Math.Pow(this.RadiusOther, 2));
        }

        public override double Circumference()
        {
            return base.Circumference() + 2 * Math.PI * this.RadiusOther;
        }
    }
}
