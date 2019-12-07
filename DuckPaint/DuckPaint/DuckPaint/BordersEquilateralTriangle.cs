using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    class BordersEquilateralTriangle : BordersFigures
    {
        private void Draw(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();

            int r = Math.Abs(x2 - x1);
            int x3;
            if (x1>x2)
            {
                x3 = x2 + r / 2;
            }
            else
            {
                x3 = x1 + r / 2;

            }
            int a = r / 2;
            int b = Convert.ToInt32(Math.Sqrt(r * r - a * a));
            int y3 = y1 - b;

            brush.DrawLine(x1, y1, x2, y1,bitMap);
            brush.DrawLine(x2, y1, x3, y3,bitMap);
            brush.DrawLine(x3, y3, x1, y1, bitMap);

        }

        public void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            //int r = Math.Abs(x2 - x1);
            //int x3;
            //if (x1 > x2)
            //{
            //    x3 = x2 + r / 2;
            //}
            //else
            //{
            //    x3 = x1 + r / 2;

            //}

            //int a = r / 2;
            //int b = Convert.ToInt32(Math.Sqrt(r * r - a * a));
            //int y3 = y1 - b;

            Draw(x1, y1, x2, y1, bitMap);
            //Draw(x2, y1, x3, y3, bitMap);
            //Draw(x3, y3, x1, y1, bitMap);

        }
    }
}
