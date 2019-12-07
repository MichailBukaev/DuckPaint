using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    class RectFactory : FigureFactory
    {
        public Figure Create(string TypeOfDraw)
        {
            Rect figure = new Rect(TypeOfDraw);
            return figure;
        }
    }
}
