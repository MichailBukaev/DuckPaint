using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    [Serializable]
    public  class VectorLine : VectorFigure
    {
       
        public VectorLine(Point p, Color c, int s)
        {
            this.points = new List<Point>();
            this.Color = c;
            this.size = s;
        }

       
        public override void MouseMoveTillCreation(Point p)
        {
            points[1] = p;
        }



    }
}
