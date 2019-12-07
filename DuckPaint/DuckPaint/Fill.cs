using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DuckPaint
{
    public class Fill
    {
        private static Fill fill = null;
        private Bitmap bitmap;
        private Color color = Color.Black;
        public Color Color { set { color = value; } }

        private Fill()
        {

        }

        public static Fill NewFill()
        {
            if(fill == null)
            {
                fill = new Fill();
            }
            return fill;
        }

        private void HelpFilling(int x, int y)
        {
            

            int x_start = x, x_end = x;
            

            Color curColor = bitmap.GetPixel(x, y);

            
                while (x_start - 1 >= 0 && curColor == bitmap.GetPixel(x_start - 1, y))
                {
                    x_start--;
                }
                while (x_end + 1 < bitmap.Width - 1 && curColor == bitmap.GetPixel(x_end + 1, y))
                {
                    x_end++;
                }

                for (int i = x_start; i <= x_end; i++)
                {
                    bitmap.SetPixel(i, y, color);
                }

                for (int i = x_start; i <= x_end; i++)
                {
                    if (y - 1 >= 0 && curColor == bitmap.GetPixel(i, y - 1))
                    {
                        HelpFilling(i, y - 1);
                    }
                    if (y + 1 < bitmap.Height && curColor == bitmap.GetPixel(i, y + 1))
                    {
                        HelpFilling(i, y + 1);
                    }

                }
            
            
               
        }

        public void Filling(int x, int y, Bitmap bitmap)
        {
            this.bitmap = bitmap;
            if (y < 0)
                y = 0;
            else if (y >= bitmap.Height)
                y = bitmap.Height - 1;


            else if (x < 0)
                x = 0;
            else if (x >= bitmap.Width)
                x = bitmap.Width - 1;
            Color curColor = bitmap.GetPixel(x, y);
            int color1 = curColor.ToArgb();
            int color2 = this.color.ToArgb();

            if (color1!=color2 )
            {
                HelpFilling(x, y);
            }

                
        }
    }
}
