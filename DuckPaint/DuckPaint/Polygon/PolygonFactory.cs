using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class PolygonFactory : FigureFactory
    {
        public Figure Create(string TypeOfDraw)
        {

            Polygon figure = new Polygon(TypeOfDraw);
            return figure;
        }
    }
}
