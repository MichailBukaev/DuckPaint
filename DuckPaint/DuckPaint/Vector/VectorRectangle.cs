using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class VectorRectangle : VectorFigure
    {
      

        public override void MouseMoveTillCreation(Point p)
        {
            Point tmp ;
            tmp = points[0];
            tmp.X = p.X;
            points[1] = tmp;

            points[2] = p;
            tmp = points[0];
            tmp.Y = p.Y;

            points[3] = tmp;
           
        }

        public VectorRectangle(Point p, Color c, int s )
        {
        
            this.points = new List<Point>();
            this.Color = c;
            this.size = s;
            this.points.Add(p);
            this.points.Add(p);
            this.points.Add(p);
            this.points.Add(p);
        }
    }
}
