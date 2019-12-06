using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class EllipseFactory : FigureFactory
    {
        public Figure Create(string TypeOfDraw)
        {
            Ellipse figure = new Ellipse (TypeOfDraw);
            return figure;
        }
    }
}
