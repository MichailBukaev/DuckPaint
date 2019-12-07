using System.Drawing;
    namespace DuckPaint
{
    internal class PlygonByPoint:Figure
    {
        
        public PlygonByPoint(string typeOfDraw)
        {
            this.formBorders = new BordersPlygonByPoint();
            this.fillFigures = new NonFill();
        }

        public override Bitmap Draw(int x1, int y1, int x2, int y2, bool key, Bitmap bitMap) 
        {
            formBorders.DrawBorders(x1, y1, x2, y2, bitMap);
            return bitMap; 
        }

    }
}