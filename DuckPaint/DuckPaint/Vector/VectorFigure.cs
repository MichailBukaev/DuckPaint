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

       
        public int Size { get { return size; } set { size = value; } }

        public Color Color { get { return color; } set {color = value; } }


        public abstract void MouseMoveTillCreation(Point p);

        


    }
}