using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    public class Round : Circle
    {
        protected string color = "black";

        public Round()
        {
            this.Name = "ROUND";
            this.x1 = 0;
            this.y1 = 0;
            this.radius = 1;
        }

        public Round(double x1, double y1, double radius, string color)
            : base(x1, y1, radius)
        {
            this.Name = "ROUND";
            this.color = color;
        }

        public override void PrintFigure()
        {
            Console.WriteLine("Round drawn");
        }

        public override Figure EnterFigure()
        {
            Console.WriteLine("Enter x-coordinate for center");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter y-coordinate for center");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter round radius");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter color");
            string color = Console.ReadLine();
            return new Round(x, y, radius, color);
        }

        public override string ToString()
        {
            return this.Name + " (coords: [" + this.x1 + ", " + this.y1 + "] radius: " + this.radius + ", color: " + this.color + ")";
        }
    }
}
