using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class VectorTriangle :VectorFigure
    {
        

        public VectorTriangle(Point p, Color c, int s)
        {
            this.points = new List<Point>();
            this.color = c;
            this.size = s;
            points.Add(p);
            points.Add(p);
            points.Add(p);

        }
        public override void MouseMoveTillCreation(Point p)
        {
            points[1] = new Point(p.X, points[0].Y);

            int x = (p.X + points[0].X) / 2;
            int y = (points[0].Y + x);
            
            points[2] = new Point(x, y);
        }

    }
}
