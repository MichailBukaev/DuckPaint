using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    class PolygonByPointFactory : FigureFactory
    {
        public Figure Create(string TypeOfDraw)
        {
            PlygonByPoint figure = new PlygonByPoint(TypeOfDraw);
            return figure;
        }
    }
}
