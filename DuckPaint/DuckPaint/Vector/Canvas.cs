using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class Canvas
    {

        List<VectorFigure> figures;
        static Canvas canvas = null;

        private Canvas()
        {
            figures = new List<VectorFigure>();
        }

        public static Canvas CreateCanvas()
        {
            if(canvas ==null)
            {
                canvas = new Canvas();
            }
            return canvas;
        }

        public Bitmap UpDateAll(Bitmap bitmap)
        {
            foreach(VectorFigure i in figures)
            {
                Painter.DrawFigure(i, bitmap);
            }
            return bitmap;
        }

        public VectorFigure FindPoint(Point p, ref Point pointForChange)
        {
            int size = 3;
            Point q = new Point(p.X - size, p.Y - size);
            for (int i = 0; i < size * 4 + 1 ; i++)
            {

                for (int j  = 0; j  < size * 4 + 1 ; j++)
                {
                    pointForChange = new Point(q.X + i, q.Y + j);

                    foreach (VectorFigure f in figures)
                    {
                        if (f.Points.Contains(pointForChange))
                        {
                            return f;

                        }
                    }

                }
               
            }
              return null;
        }

    }

}
