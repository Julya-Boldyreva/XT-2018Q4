﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    public class Rectangle : Figure
    {
        protected double a;
        protected double b;

        public Rectangle()
        {
            this.Name = "RECTANGLE";
            this.x1 = 0;
            this.y1 = 0;
            this.a = 1;
            this.b = 2;
        }

        public Rectangle(double x1, double y1, double a, double b)
        {
            this.Name = "RECTANGLE";
            this.x1 = x1;
            this.y1 = y1;
            this.a = a;
            this.b = b;
        }

        public override void PrintFigure()
        {
            Console.WriteLine("Rectangle drawn");
        }

        public override Figure EnterFigure()
        {
            Console.WriteLine("Enter x-coordinate for center");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate for center");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle width");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter rectangle height");
            double b = double.Parse(Console.ReadLine());
            return new Rectangle(x, y, a, b);
        }

        public override string ToString()
        {
            return this.Name + " (coords: [" + this.x1 + ", " + this.y1 + "] width: " + this.a + ", height " + this.b + ")";
        }
    }
}
