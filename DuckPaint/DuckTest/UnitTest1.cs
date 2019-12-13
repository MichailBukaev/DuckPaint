using NUnit.Framework;
using System.Drawing;
using System.Collections.Generic;

namespace DuckPaint
{
    [TestFixture]
    public class Tests
    {

        [TestCase(0, 0, 100, 500, new int[] { 0, 100 }, new int[] { 0, 500 })]
        [TestCase(0, 0, -100, -500, new int[] { 0, -100 }, new int[] { 0, -500 })]
        [TestCase(100, 100, 100, 500, new int[] { 100, 100 }, new int[] { 100, 500 })]
        [TestCase(-100, -500, 0, 0, new int[] { -100, 0 }, new int[] { -500, 0 })]
        public void TestVectorLine(int oneX, int oneY, int twoX, int twoY, int[] arrAllResultX, int[] arrAllResultY)
        {
            Point pointOne = new Point(oneX, oneY);
            Point pointTwo = new Point(twoX, twoY);
            VectorLine vectorLine = new VectorLine(pointOne, Color.Red, 1);
            vectorLine.MouseMoveTillCreation(pointTwo);
            List<Point> pointsResult = new List<Point>();
            for (int i = 0; i < arrAllResultX.Length; i++)
            {
                pointsResult.Add(new Point(arrAllResultX[i], arrAllResultY[i]));
            }
            CollectionAssert.AreEqual(pointsResult, vectorLine.Points);
        }
        [TestCase(0, 0, 5, 0, new int[] { 5, 4, 3, 2, 1, 0, 0, -1, -2, -3, -4, -5, -5, -4, -3, -2, -1, 0, 0, 1, 2, 3, 4, 5 }, new int[] { 0, 3, 4, 5, 5, 5, 5, 5, 5, 4, 3, 0, 0, -3, -4, -5, -5, -5, -5, -5, -5, -4, -3, 0 })]
        public void TestVectorCircle(int oneX, int oneY, int twoX, int twoY, int[] arrAllResultX, int[] arrAllResultY)
        {
            Point pointOne = new Point(oneX, oneY);
            Point pointTwo = new Point(twoX, twoY);
            VectorCircle vectorCircle = new VectorCircle(pointOne, Color.Red, 1);
            vectorCircle.MouseMoveTillCreation(pointTwo);
            List<Point> pointsResult = new List<Point>();
            for (int i = 0; i < arrAllResultX.Length; i++)
            {
                pointsResult.Add(new Point(arrAllResultX[i], arrAllResultY[i]));
            }
            CollectionAssert.AreEqual(pointsResult, vectorCircle.Points);
        }

        [TestCase(0, 0, 20, 0, new int[] { 0, 20, 10 }, new int[] { 0, 0, -17 })]
        
        
        public void TestVectorTriangle(int oneX, int oneY, int twoX, int twoY, int[] arrAllResultX, int[] arrAllResultY)
        {
            Point pointOne = new Point(oneX, oneY);
            Point pointTwo = new Point(twoX, twoY);
            VectorTriangle vectorTriange = new VectorTriangle(pointOne, Color.Red, 1);
            vectorTriange.MouseMoveTillCreation(pointTwo);
            List<Point> pointsResult = new List<Point>();

            for (int i = 0; i < arrAllResultX.Length; i++)
            {
                pointsResult.Add(new Point(arrAllResultX[i], arrAllResultY[i]));
            }
            CollectionAssert.AreEqual(pointsResult, vectorTriange.Points);

        }

    }
}