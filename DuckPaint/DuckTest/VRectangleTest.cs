using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using NUnit.Framework;

namespace DuckPaint
{
    [TestFixture]
   public class VRectangleTest
    {
        [TestCase (0, 0, 10, 50, new int[] { 0, 10, 10, 0}, new int[]  {0, 0, 50, 50 }  ) ]

        public void TestVectorRectangle(int oneX, int oneY, int twoX, int twoY, int[] arrAllResultX, int[] arrAllResultY)
        {
            Point pointOne = new Point(oneX, oneY);
            Point pointTwo = new Point(twoX,twoY);
            //Point pointThree = new Point(twoX, twoY);
            //Point pointFour = new Point(oneX, twoY);

            VectorRectangle vectorRectangle = new VectorRectangle(pointOne, Color.Red, 1);
            vectorRectangle.MouseMoveTillCreation(pointTwo);
            List<Point> pointsResult = new List<Point>();
            for (int i = 0; i < arrAllResultX.Length; i++)
            {
                pointsResult.Add(new Point(arrAllResultX[i], arrAllResultY[i]));
            }
            CollectionAssert.AreEqual(pointsResult, vectorRectangle.Points);
        }

    }
}
