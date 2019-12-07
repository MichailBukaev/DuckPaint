using System.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    internal class BordersPolygon : BordersFigures
    {
        private Bitmap bitMap;
        Brush brush;
        private Bitmap Draw(int x1, int y1, int endX, int endY, int angles, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();
            int X = x1, Y = y1,
            r = Convert.ToInt32(Math.Sqrt(Math.Pow(endX - x1, 2) + Math.Pow(endY - y1, 2)));

            if (angles < 3)
            {
                angles = 3;
            }

            double angl = (double)(360.0 / (double)angles);
            double pointX1 = r * Math.Cos(0) + X,
                   pointY1 = r * Math.Sin(0) + Y;
            double pointX1m = pointX1,
                   pointY1m = pointY1;
            double pointX2, pointY2;

            for (int i = 1; i <= angles; i++)
            {
                angl = 2 * Math.Cos(angl) + X;

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
            return bitMap;
        }

        int n;

        public void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();


            int r = (y1 - y2), B_x = x1, B_y = y2, C_x, C_y, start_x, start_y;

            double a = (double)(360.0 / (double)n), z = 0;

            start_x = (int)(r * Math.Cos(0) + x1);

            start_y = (int)(y1 + r * Math.Sin(0));

            B_x = start_x;
            B_y = start_y;

            for (int i = 1; i < n; i++)
            {
                C_x = (int)(r * Math.Cos(a * i) + x1);
                C_y = (int)(y1 + r * Math.Sin(a * i));
                if (B_x < bitMap.Width && B_y < bitMap.Height && B_x >= 0 && B_y >= 0 && C_x < bitMap.Width && C_y < bitMap.Height && C_x >= 0 && C_y >= 0)
                {
                    brush.DrawLine(B_x, B_y, C_x, C_y, bitMap);

                }
                B_x = C_x;
                B_y = C_y;
            }

            //сюда пишеш математику, здесь вызываешь кисть, здесь все делаешь,
            //короче, тот метод который ты описала вверху, должен быть здесь и называться именно так.
        }

    }
}
