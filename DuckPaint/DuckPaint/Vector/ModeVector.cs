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
            if (vectorFigure is VectorCircle)
            {
                vectorFigure.MouseMoveTillCreation(currentPoint);
            }
            else
            {
                vectorFigure.Points[indexPoint] = currentPoint;
            }
            return vectorFigure;
        }
        public static VectorFigure MoveFigure(VectorFigure vectorFigure, int indexPoint, Point currentPoint)
        {
            int removelX = currentPoint.X - vectorFigure.Points[indexPoint].X;
            int removelY = currentPoint.Y - vectorFigure.Points[indexPoint].Y;
           
            
            for (int i = 0; i < vectorFigure.Points.Count; i++)
            {
                Point tmp = vectorFigure.Points[i];
                tmp.Offset(removelX, removelY);
                vectorFigure.Points[i] = tmp;
            }
            if (vectorFigure is VectorCircle)
            {
                VectorCircle vectorCircle = (VectorCircle)vectorFigure;
                Point tmp = vectorCircle.Centre;
                tmp.Offset(removelX, removelY);
                vectorCircle.Centre = tmp;
            }

                return vectorFigure;
        }

       
        
    }
}
