using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class VectorRectangleFactory : VectorFigureFactory
    {
        public VectorFigure Creator(Point point, Color color, int size)
        {
            VectorRectangle vectorRectangle = new VectorRectangle(point, color, size);

            return vectorRectangle;

        }
    }
}
