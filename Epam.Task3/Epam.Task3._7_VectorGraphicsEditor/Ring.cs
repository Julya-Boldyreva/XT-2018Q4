﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    class Ring : Round
    {
        protected double radiusOther;

        public Ring()
            : base()
        {
            name = "RING";
            this.radiusOther = 2;
        }

        public Ring(double x1, double y1, double radius, double radiusOther)
        {
            name = "RING";
            this.x1 = x1;
            this.y1 = y1;
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

        public override Figure EnterFigure()
        {
            Console.WriteLine("Enter x-coordinate for center");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate for center");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter round 1st radius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter round 2nd radius");
            double radiusOther = double.Parse(Console.ReadLine());
            Ring myRing = new Ring(x, y, radius, radiusOther);
            return myRing;
        }

        public override void PrintFigure()
        {
            Console.WriteLine("Ring drawn");
        }
    }
}