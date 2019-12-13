using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
        class VectorTriangleFactory : VectorFigureFactory
        {
            public VectorFigure Creator(Point point, Color color, int size)
            {
                VectorTriangle vectorLine = new VectorTriangle(point, color, size);

                return vectorLine;
            }
        }
    }
