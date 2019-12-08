using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckPaint
{
    public class Angles
    {
        private static Angles angl = null;
        private static int angles;

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
        }

        private Angles()
        { }

        public static Angles SetAngles()
        {
            if (angl == null)
            {
                angl = new Angles();
            }
            return angl;
        }
    }
}
