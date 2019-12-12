using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    class VectorLineFactory : VectorFigureFactory
    {
        public VectorFigure Creator(Point point, Color color, int size )
        {
            VectorLine vectorLine = new VectorLine(point,color, size );

            return vectorLine;
        }
    }
}
