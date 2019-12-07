using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class BordersEllipse : BordersFigures
    {
        private void Draw(int x1, int y1, double big, double small, bool flagVertical, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();
            int tmpX = 0, tmpY = 0;
            for (int i = 0; i <= big; i++)
            {
                double x; double y;
                double nan = Double.NaN;

                if (flagVertical)
                {
                    y = i;
                    x = Math.Sqrt((Math.Pow(small, 2) / Math.Pow(big, 2)) * (Math.Pow(big, 2) - Math.Pow(y, 2)));
                }
                else
                {
                    x = i;
                    y = Math.Sqrt((Math.Pow(small, 2) / Math.Pow(big, 2)) * (Math.Pow(big, 2) - Math.Pow(x, 2)));
                }
                if (y.Equals(nan) || x.Equals(nan))
                {
                    break;
                }
                else
                {
                    if (i == 0)
                    {
                        tmpX = Convert.ToInt32(x);
                        tmpY = Convert.ToInt32(y);
                    }
                    else
                    {
                        brush.DrawLine((x1 + tmpX), (y1 + tmpY), Convert.ToInt32(x1 + x), Convert.ToInt32(y1 + y), bitMap);
                        brush.DrawLine((x1 + tmpX), (y1 - tmpY), Convert.ToInt32(x1 + x), Convert.ToInt32(y1 - y), bitMap);
                        brush.DrawLine((x1 - tmpX), (y1 - tmpY), Convert.ToInt32(x1 - x), Convert.ToInt32(y1 - y), bitMap);
                        brush.DrawLine((x1 - tmpX), (y1 + tmpY), Convert.ToInt32(x1 - x), Convert.ToInt32(y1 + y), bitMap);
                        tmpX = Convert.ToInt32(x);
                        tmpY = Convert.ToInt32(y);
                    }

                }
            }
        }
        public void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            double w = Math.Abs(x2 - x1);
            double h = Math.Abs(y2 - y1);
            double big, small;
            bool flagVertical = false;
            if (w >= h)
            {
                big = w;
                small = h;
            }
            else
            {
                big = h;
                small = w;
                flagVertical = true;
            }
            Draw(x1, y1, big, small, flagVertical, bitMap);
        }

    }
}