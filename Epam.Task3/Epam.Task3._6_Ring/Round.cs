﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._6_Ring
{
    class Round
    {
        protected double x;
        protected double y;
        protected double radius;

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
            set
            {
                this.x = value;
            }
            get
            {
                return this.x;
            }
        }

        public double Y
        {
            set
            {
                this.y = value;
            }
            get
            {
                return this.y;
            }
        }

        public double Radius
        {
            set
            {
                this.radius = value;
            }
            get
            {
                return this.radius;
            }
        }

        public virtual double Circumference()
        {
            return 2 * Math.PI * this.radius;
        }

        public virtual double Area()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
    }
}