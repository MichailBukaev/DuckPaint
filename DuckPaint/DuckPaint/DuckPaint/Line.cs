using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class Line: Figure
    {

        public Line (string TypeOfDraw)
        {
            this.formBorders = new BordersLine();
            this.fillFigures = new NonFill();
        }
       
        public override Bitmap Draw(int x1, int y1, int x2, int y2, bool key, Bitmap bitMap)
        {
            formBorders.DrawBorders(x1, y1, x2, y2, bitMap);
            return bitMap;
        }
    }
}
