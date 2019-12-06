using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    class LineFactory : FigureFactory
    {

        public Figure Create(string TypeOfDraw)
        {
            Line figure = new Line(TypeOfDraw);
            return figure;
        }
    }
}
