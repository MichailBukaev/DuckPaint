using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class VectorCircleFactory : VectorFigureFactory
    {
        public VectorFigure Creator(Point point, Color color, int size)
        {
            VectorCircle vectorCircle = new VectorCircle(point, color, size);
            return vectorCircle;
        }
    }
}
