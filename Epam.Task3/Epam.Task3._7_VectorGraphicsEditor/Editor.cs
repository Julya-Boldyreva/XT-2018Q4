using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    class Editor : IEditorable
    {
        public List<Figure> figures;

        public void CreateFigure(Figure f)
        {
            figures.Add(f);
        }

        public void PrintFigure(Figure f)
        {
            f.PrintFigure();
        }

        public void PrintFigures()
        {
            Console.WriteLine("Your figures: ");
            int i = 0;
            foreach (var item in figures)
            {
                Console.WriteLine($"{i}) {item.name}");
            }
        }

        public List<Figure> Figures
        {
            get
            {
                return this.figures;
            }
        }

    }
}
