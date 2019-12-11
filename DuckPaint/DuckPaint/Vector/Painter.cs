using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public static class Painter
    {
        public static void DrawFigure(VectorFigure figure, Bitmap bitmap)
        {
            Pen pen = new Pen(figure.Color, figure.Size);
            Graphics graphics = Graphics.FromImage(bitmap);
            for (int i = 0; i < figure.Points.Count - 1; i++)
            {
                graphics.DrawLine(pen, figure.Points[i], figure.Points[i + 1]);
            }
            graphics.DrawLine(pen, figure.Points[0], figure.Points[figure.Points.Count - 1]);
        }

    }
}
