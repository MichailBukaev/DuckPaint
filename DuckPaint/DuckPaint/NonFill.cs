﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class NonFill : FillFigures
    {
        public Bitmap DrawFill(int x1, int y1, int x2, int y2, Bitmap bitmap)
        {
            return bitmap;
        }
    }
}
