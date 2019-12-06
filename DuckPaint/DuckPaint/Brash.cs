using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class Brush
    {
        private static Brush brush=null;
        private int size = 1;
        private Color color = Color.Black;
        private string typeOfBraush = "simpleBrush";
       

        public int Size { set { size = value; } }
        public Color Color { set { color = value; } }
        public string TypeOfBrush { set { typeOfBraush = value; } }


        private Brush()
        {

        }
        
        public static Brush NewBrash()
        {
            if (brush == null)
            {
                brush = new Brush();
            }
            return brush;
        }
        
        public void DrawLine(int x1, int y1, int x2, int y2, Bitmap bitMap) 
        {
            switch (typeOfBraush) 
            {
                case "simpleBrush":
                    {
                        new SimpleBrash(size, color).DrawLine(x1, y1, x2, y2, bitMap);
                        break;
                    }
            }

            
        }
    }
}
