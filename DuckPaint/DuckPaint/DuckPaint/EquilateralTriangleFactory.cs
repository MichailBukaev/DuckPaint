using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    class EquilateralTriangleFactory : FigureFactory
    {
        public Figure Create(string TypeOfDraw)
        {
            EquilateralTriangle figure = new EquilateralTriangle(TypeOfDraw);
            return figure;
        }
    }
}
