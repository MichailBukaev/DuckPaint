using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    class BordersRect : BordersFigures
    {
        public void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();

            brush.DrawLine(x1, y1, x2, y1, bitMap);
            brush.DrawLine(x1, y2, x2, y2, bitMap);
            brush.DrawLine(x1, y1, x1, y2, bitMap);
            brush.DrawLine(x2, y1, x2, y2, bitMap);

        }
    }
}
