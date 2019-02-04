using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    public abstract class Figure : IFigure
    {
        public string Name = "-FIGURE-";

        protected double x1;
        protected double y1;

        public virtual void PrintFigure()
        {
            Console.WriteLine("Class Figure");
        }

        public virtual Figure EnterFigure()
        {
            return this; 
        }
    }
}
