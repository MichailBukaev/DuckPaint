using System.Drawing;
namespace DuckPaint
{
    public interface BordersFigures
    {
        void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap);
    }
}