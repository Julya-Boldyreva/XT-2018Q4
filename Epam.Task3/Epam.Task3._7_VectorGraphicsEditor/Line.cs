using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    class Line : Figure
    {
        protected double x2;
        protected double y2;

        public Line()
        {
            name = "LINE";
            this.x2 = 0;
            this.y2 = 0;
            this.x2 = 1;
            this.y2 = 1;
        }

        public Line(double x1, double y1, double x2, double y2)
        {
            name = "LINE";
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public override void PrintFigure()
        {
            Console.WriteLine("Line drawn");
        }

        public override Figure EnterFigure()
        {
            Console.WriteLine("Enter first x-coordinate");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter first y-coordinate");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second x-coordinate");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second y-coordinate");
            double y2 = double.Parse(Console.ReadLine());
            Line myLine = new Line(x1, y1, x2, x2);
            return myLine;
        }
    }
}
