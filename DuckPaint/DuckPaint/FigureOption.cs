using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class FigureOption
    {
        private static FigureOption angl = null;
        private int angles = 6;

        public int Angl
        { 
            set 
            { 
                if(value < 3)
                {
                    angles = 3;
                }
                else
                {
                    angles = value;
                }
            }
            get
            {
                return angles;
            }
        }

        private FigureOption()
        { }

        public static FigureOption SetAngles()
        {
            if (angl == null)
            {
                angl = new FigureOption();
            }
            return angl;
        }
    }
}
