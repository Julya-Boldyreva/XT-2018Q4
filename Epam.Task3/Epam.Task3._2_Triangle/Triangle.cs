using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._2_Triangle
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;

        public Triangle()
        {
            this.a = 3;
            this.b = 4;
            this.c = 5;
        }

        public Triangle(double a, double b, double c)
            : this()
        {
            if (a > 0 && a < b + c)
            {
                this.a = a;
            }
            else
            {
                throw new Exception("First side must be less than sum of other sides and unequals zero");
            }

            if (b > 0 && b < a + c)
            {
                this.b = b;
            }
            else
            {
                throw new Exception("Second side must be less than sum of other sides and unequals zero");
            }

            if (c > 0 && c < a + b)
            {
                this.c = c;
            }
            else
            {
                throw new Exception("Third side must be less than sum of other sides and unequals zero");
            }
        }

        public double A
        {
            get
            {
                return this.a;
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
        }

        public double C
        {
            get
            {
                return this.c;
            }
        }

        public double Perimetr()
        {
            return this.a + this.b + this.c;
        }

        public double Area()
        {
            double halfPerimetr = this.Perimetr() / 2;
            double s = Math.Sqrt(halfPerimetr * (halfPerimetr - this.a) * (halfPerimetr - this.b) * (halfPerimetr - this.c));
            return s;
        }
    }
}
