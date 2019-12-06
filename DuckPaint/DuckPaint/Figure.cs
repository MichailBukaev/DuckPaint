using System.Drawing;
namespace DuckPaint
{
    public abstract class Figure
    {
        protected BordersFigures formBorders;
        protected FillFigures fillFigures;
        
        public virtual Bitmap Draw(int x1, int y1, int x2, int y2, bool key, Bitmap bitMap) { return bitMap; }

    }
}
