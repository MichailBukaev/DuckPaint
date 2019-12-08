using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
     class BordersPolygon : BordersFigures
    {
        public int n = 6;

        public void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();
            int X = x1, Y = y1, angles = n,
            r = Convert.ToInt32(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));

            if (angles < 3)
            {
                angles = 3;
            }

            double angl;
            double pointX1 = r * Math.Cos(0) + X,
                   pointY1 = r * Math.Sin(0) + Y;
            double pointX1m = pointX1,
                   pointY1m = pointY1;
            double pointX2, pointY2;

            for (int i = 1; i <= angles; i++)
            {
                angl = 2 * Math.PI * i / angles;

                pointX2 = r * Math.Cos(angl) + X;
                pointY2 = r * Math.Sin(angl) + Y;

                if (i == angles)
                {
                    brush.DrawLine(Convert.ToInt32(pointX1), Convert.ToInt32(pointY1), Convert.ToInt32(pointX1m), Convert.ToInt32(pointY1m), bitMap);
                }
                else
                {
                    brush.DrawLine(Convert.ToInt32(pointX1), Convert.ToInt32(pointY1), Convert.ToInt32(pointX2), Convert.ToInt32(pointY2), bitMap);
                }
                pointX1 = pointX2;
                pointY1 = pointY2;

            }
        }

      









        //сюда пишеш математику, здесь вызываешь кисть, здесь все делаешь,
        //короче, тот метод который ты описала вверху, должен быть здесь и называться именно так.
    }

   }
