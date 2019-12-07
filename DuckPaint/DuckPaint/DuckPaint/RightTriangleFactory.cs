using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    class RightTriangleFactory : FigureFactory
    {
        public Figure Create (string TypeOfDraw)
        {
            RightTriangle figure = new RightTriangle (TypeOfDraw);
            return figure;
        }
    }
}
