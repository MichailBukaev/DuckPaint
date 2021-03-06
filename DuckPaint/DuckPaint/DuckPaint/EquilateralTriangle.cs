﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint 
{
    public class EquilateralTriangle : Figure
    {
        public EquilateralTriangle(string TypeOfDraw)
        {
            this.formBorders = new BordersEquilateralTriangle();
            switch (TypeOfDraw)
            {
                case "borders":
                    {
                        this.fillFigures = new NonFill();
                        break;
                    }
                case "fill":
                    {
                        this.fillFigures = new ThereSFill();
                        break;
                    }
                default:
                    break;
            }
        }


        public override Bitmap Draw(int x1, int y1, int x2, int y2, bool key, Bitmap bitMap)
        {
            Rectangle rec = new Rectangle(0, 0, bitMap.Width, bitMap.Height);
            bitMap = bitMap.Clone(rec, System.Drawing.Imaging.PixelFormat.DontCare);

            Bitmap blankBitmap = new Bitmap(bitMap.Width, bitMap.Height);
            blankBitmap.MakeTransparent();

            if (key)
            {
                y2 = y1 + Math.Abs(x2 - x1);
            }

            formBorders.DrawBorders(x1, y1, x2, y2, blankBitmap);

            fillFigures.DrawFill(x1, y1, x2, y2, blankBitmap);

            Graphics graphics = Graphics.FromImage(bitMap);
            graphics.DrawImage(blankBitmap, 0, 0);


            return bitMap;
        }
    }
}
