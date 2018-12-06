using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    public class Editor : IEditorable
    {
        public void CreateFigure(Figure f, List<Figure> figures)
        {
            figures.Add(f);
        }

        public void PrintFigure(Figure f)
        {
            f.PrintFigure();
        }

        public void PrintFigures(List<Figure> figures)
        {
            Console.WriteLine("Your figures: ");
            if (figures.Count() == 0)
            {
                Console.WriteLine("You\'ve not created figures yet");
            }
            else
            {
                foreach (var item in figures)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }
    }
}
