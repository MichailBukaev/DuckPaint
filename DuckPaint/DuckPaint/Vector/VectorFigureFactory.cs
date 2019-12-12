using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public interface VectorFigureFactory
    {
        VectorFigure Creator(Point point, Color color, int size);
    }
}
