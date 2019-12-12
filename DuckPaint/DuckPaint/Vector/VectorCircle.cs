using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class VectorCircle : VectorFigure
    {
        private Point centre;
        private Point radiusPoint;

        public Point Centre { get { return centre; } }
        public Point RadiusPoint { get { return radiusPoint; } }

        public VectorCircle(Point p, Color c, int s)
        {
            this.points = new List<Point>();
            this.color = c;
            this.size = s;
            this.centre = p;
            this.radiusPoint = p;
        }
        public override void MouseMoveTillCreation(Point p)
        {

            points = new List<Point>();
            List<Point> firstQ = new List<Point>();
            List<Point> secondQ = new List<Point>();
            List<Point> thirdQ = new List<Point>();
            List<Point> fourthQ = new List<Point>();

            double x = Math.Abs(centre.X - p.X);
            double y = Math.Abs(centre.Y - p.Y);
            double nan = Double.NaN;

            double r = Math.Sqrt(x * x + y * y);
            int radius;
            if (r.Equals(nan))
            {
                radius = 0;
            }
            else
            {
                radius = Convert.ToInt32(r);
            }


            Point tmp = new Point(centre.X, centre.Y + radius);
            //firstQ.Add(tmp);
            //secondQ.Add(tmp);

            //tmp = new Point(centre.X, centre.Y - radius);
            //thirdQ.Add(tmp);
            //fourthQ.Add(tmp);

            for (int i = 0; i <= radius; i++)
            {
                double a = Math.Sqrt(radius * radius - i * i);

                tmp = new Point(centre.X + i, Convert.ToInt32(a) + centre.Y);
                firstQ.Add(tmp);
                tmp = new Point(centre.X - i, Convert.ToInt32(a) + centre.Y);
                secondQ.Add(tmp);
                tmp = new Point(centre.X - i, centre.Y - Convert.ToInt32(a));
                thirdQ.Add(tmp);
                tmp = new Point(centre.X + i, centre.Y - Convert.ToInt32(a));
                fourthQ.Add(tmp);

            }
            firstQ.Reverse();
            thirdQ.Reverse();

            points.AddRange(firstQ);
            points.AddRange(secondQ);
            points.AddRange(thirdQ);
            points.AddRange(fourthQ);
        }
    }       
}
