using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class ThereSFill : FillFigures
    {
        public Bitmap DrawFill(int x1, int y1, int x2, int y2, Bitmap bitmap)
        {
            int x = (x1 + x2) /2;
            int y = (y1 + y2) /2;
            Fill fill = Fill.NewFill();
            fill.Filling(x, y, bitmap);
            return bitmap;
        }
    }
}
