using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace DuckPaint
{
    public abstract class VectorFigure
    {
        protected List<Point> points;
       
        protected int size;
        protected Color color;

        public List<Point> Points
        {
            get
            {
                return points;
            }
        }

       
        public int Size { get; set; }

        public Color Color { get; set; }
        

        public abstract void MouseMoveTillCreation(Point p);
        


    }
}