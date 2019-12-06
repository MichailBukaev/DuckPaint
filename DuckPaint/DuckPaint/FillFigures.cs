using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public interface FillFigures
    {
        Bitmap DrawFill(int x1, int y1, int x2, int y2, Bitmap bitmap);
    }
}
