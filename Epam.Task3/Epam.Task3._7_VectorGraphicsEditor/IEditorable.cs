using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._7_VectorGraphicsEditor
{
    public interface IEditorable
    {
        void CreateFigure(Figure f);

        void PrintFigure(Figure f);
    }
}
