using System.Drawing;
namespace DuckPaint
{
    public class BordersLine : BordersFigures
    {
        public void DrawBorders(int x1, int y1, int x2, int y2, Bitmap bitMap)
        {
            Brush brush = Brush.NewBrash();
            brush.DrawLine(x1, y1, x2, y2, bitMap);
            
        }   
    }
}