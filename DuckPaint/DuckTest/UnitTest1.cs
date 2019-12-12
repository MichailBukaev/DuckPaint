using NUnit.Framework;
using System.Drawing;
using System.Collections.Generic;

namespace DuckPaint
{
    [TestFixture]
    public class Tests
    {

        [TestCase(0, 0, 100, 500, new int[] { 0,100}, new int[] { 0, 500 })]
        [TestCase(0, 0, -100, -500, new int[] { 0, -100 }, new int[] { 0, -500 })]
        [TestCase(100, 100, 100, 500, new int[] { 100, 100 }, new int[] { 100, 500 })]
        [TestCase(-100, -500, 0, 0, new int[] { -100, 0 }, new int[] { -500, 0 })]
        public void TestVectorLine(int oneX, int oneY, int twoX, int twoY, int [] arrAllResultX, int[]arrAllResultY)
        {
            Point pointOne = new Point(oneX, oneY); 
            Point pointTwo = new Point(twoX, twoY); 
            VectorLine vectorLine = new VectorLine(pointOne, Color.Red, 1);
            vectorLine.MouseMoveTillCreation(pointTwo);
            List<Point> pointsResult = new List<Point>();
            for (int i = 0; i<arrAllResultX.Length; i++)
            {
                pointsResult.Add(new Point(arrAllResultX[i], arrAllResultY[i]));
            }
            CollectionAssert.AreEqual(pointsResult, vectorLine.Points);
        }
    }
}