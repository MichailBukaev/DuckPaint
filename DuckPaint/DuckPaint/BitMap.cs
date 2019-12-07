using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class BitMap
    {
        private static Bitmap bitMap;
        private static BitMap map = null;

        private BitMap(int width, int height)
        {
            bitMap = new Bitmap(width, height);
        }

        public static Bitmap NewBitMap (int width, int height)
        {
            if (bitMap == null)
            {
                map = new BitMap(width, height);
            }
            return bitMap;
        }
    }
}
