using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Text.RegularExpressions;

namespace DuckPaint
{
    public class DiagramAVL
    {
        private List<VectorFigure> nodesEndRelations;
        private List<string> values;
        private AVLTree tree;
        public List<VectorFigure> NodesEndRelations {get { return nodesEndRelations; } }
        public DiagramAVL(string str)
        {
            int[] arr = StrToArr(str);
            tree = new AVLTree(arr);
            nodesEndRelations = new List<VectorFigure>();
            values = new List<string>();
        }

        private int [] StrToArr (string str)
        {
            int counter = 0;
            foreach (var item in Regex.Split(str, @"\s+"))
            {
                if (Int32.TryParse(item, out int itemNumber))
                {
                    counter++;
                }
            }
            int[] arr = new int[counter];
            int i=0;
            foreach (var item in Regex.Split(str, @"\s+"))
            {
                if (Int32.TryParse(item, out int itemNumber))
                {
                    arr[i] = Convert.ToInt32(itemNumber);
                    i++;
                }
            }

            return arr;
        }
        public void CreateDiagram(Bitmap bitmap)
        {
            int stepY = 80;
            int pointctnterX = bitmap.Width/2;
            int currentY = 0;

            if (tree.Root != null)
            {
                int lenght = bitmap.Width;
                AVLTreeNode current = tree.Root;
                CreateDiagram(current, lenght, stepY, pointctnterX, currentY);

            }
        }
        private void CreateDiagram(AVLTreeNode current, int lenght, int stepY, int pointctnterX,int currentY)
        {
            int radius = 20;
            Point centr = new Point(pointctnterX , currentY + stepY);

            nodesEndRelations.Add(new VectorCircle(centr, radius, Color.Black, 4));
            values.Add(Convert.ToString(current.Value));
            int stepX = lenght / 4;
            Point start = new Point(centr.X, currentY+stepY + radius);
            Point endL = new Point(centr.X - stepX, currentY+stepY + stepY-radius);
            Point endR = new Point(centr.X + stepX, currentY+stepY + stepY-radius);
            if (current.Left != null)
            {
                nodesEndRelations.Add(new VectorLine(start, endL, Color.Black, 2));
                CreateDiagram(current.Left, lenght / 2, stepY, pointctnterX -stepX, currentY + stepY);
            }
            if (current.Right != null)
            {
                nodesEndRelations.Add(new VectorLine(start, endR, Color.Black, 1));
                CreateDiagram(current.Right, lenght / 2, stepY, pointctnterX+stepX, currentY + stepY);
            }
        }
        public void DrawDiagram(Bitmap bitmap)
        {
            int counter = 0;
            Graphics graphics = Graphics.FromImage(bitmap);
            Font font = new Font("Arial", 16);
            System.Drawing.Brush brush = new SolidBrush(Color.Red);
            

            foreach (VectorFigure figure in nodesEndRelations)
            {
                Painter.DrawFigure(figure, bitmap);
                if (figure is VectorCircle)
                {

                    Point point = new Point( figure.Points[0].X-30, figure.Points[0].Y-10);
                    graphics.DrawString(values[counter], font, brush, point);
                    counter++;
                }
            }
        }
    }
}
