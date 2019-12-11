using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public static class ModeVector
    {
        public static VectorFigure MovePoint(VectorFigure vectorFigure, int indexPoint, Point currentPoint)
        {
            vectorFigure.Points[indexPoint] = currentPoint;
            return vectorFigure;
        }
        public static VectorFigure MoveFigure(VectorFigure vectorFigure, int indexPoint, Point currentPoint)
        {
            int removelX = currentPoint.X - vectorFigure.Points[indexPoint].X;
            int removelY = currentPoint.Y - vectorFigure.Points[indexPoint].Y;

            for (int i = 0; i<vectorFigure.Points.Count; i++)
            {
                Point tmp = vectorFigure.Points[i];
                tmp.Offset(removelX, removelY);
                vectorFigure.Points[i] = tmp;
            }
            return vectorFigure;
        }
    }
}
