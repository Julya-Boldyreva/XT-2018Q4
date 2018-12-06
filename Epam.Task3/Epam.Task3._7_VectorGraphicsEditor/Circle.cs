using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    class Circle: Figure
    {
        protected double radius;

        public Circle()
        {
            name = "CIRCLE";
            this.x1 = 0;
            this.y1 = 0;
            this.radius = 1;
        }

        public Circle (double x1, double y1, double radius)
            : this()
        {
            name = "CIRCLE";
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
        }

        public override void PrintFigure()
        {
            Console.WriteLine("Circle drawn");
        }

        public override Figure EnterFigure()
        {
            Console.WriteLine("Enter x-coordinate for center");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate for center");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter round radius");
            double radius = double.Parse(Console.ReadLine());
            Circle myCircle = new Circle(x, y, radius);
            return myCircle;
        }
    }
}
