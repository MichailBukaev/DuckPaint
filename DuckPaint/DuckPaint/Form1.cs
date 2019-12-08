using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuckPaint
{
    public partial class Form1 : Form
    {
        Bitmap bitMap, bitmap_copy;
        Bitmap bitMapTmp;
        FigureFactory figureFactory;
        Figure figure;
        Brush brush;
        Fill fill;
        Angles angl;

        // char flag_button = '0';

        bool flagDownMouse = false;
        string flagMethWorkMouse = " ";
        string flagTypeOfDraw = "borders";
        bool flagUsBitMapTmp = false;
        bool flagRewrieStartPoint = false;
        bool flagPolygonNum = false;



        int startX, startY;
        int firstPointX = 0, firstPointY = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarSizBrush_ValueChanged(object sender, EventArgs e)
        {
            brush.Size = trackBarSizBrush.Value;
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            bitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bitMapTmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            brush = Brush.NewBrash();
            fill = Fill.NewFill();
            pictureBox1.Image = bitMap;
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {

            flagDownMouse = false;
            if (flagUsBitMapTmp)
            {
                bitMap = bitMapTmp;
                flagUsBitMapTmp = false;
            }
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            flagDownMouse = true;
            if (flagMethWorkMouse != "MouseClickByPoint")
            {
                startX = e.Location.X;
                startY = e.Location.Y;
            }


        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (flagMethWorkMouse == "MouseMove" && flagDownMouse)
            {
                flagUsBitMapTmp = true;
                if (Control.ModifierKeys == Keys.Shift)
                {
                    bitMapTmp = figure.Draw(startX, startY, e.Location.X, e.Location.Y, true, bitMap);
                }
                else
                {
                    bitMapTmp = figure.Draw(startX, startY, e.Location.X, e.Location.Y, false, bitMap);
                }

                if (flagRewrieStartPoint)
                {
                    startX = e.Location.X;
                    startY = e.Location.Y;
                }
                pictureBox1.Image = bitMapTmp;
            }
        }

        private void Ellipse_Click(object sender, EventArgs e)
        {
            figureFactory = new EllipseFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
        }

        private void button_Fill_Click(object sender, EventArgs e)
        {
            flagMethWorkMouse = "MouseClick";
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (flagMethWorkMouse == "MouseClick")
            {
                fill.Filling(e.X, e.Y, this.bitMap);
                pictureBox1.Image = bitMap;
            }
            else if (flagMethWorkMouse == "MouseClickByPoint")
            {
                if (firstPointX == 0 && firstPointY == 0)
                {
                    firstPointX = e.Location.X;
                    firstPointY = e.Location.Y;
                    startX = e.Location.X;
                    startY = e.Location.Y;
                }
                figure.Draw(startX, startY, e.Location.X, e.Location.Y, false, bitMap);
                startX = e.Location.X;
                startY = e.Location.Y;
                pictureBox1.Image = bitMap;
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (flagMethWorkMouse == "MouseClickByPoint")
            {
                figure.Draw(startX, startY, firstPointX, firstPointY, false, bitMap);
                firstPointX = 0;
                firstPointY = 0;
                pictureBox1.Image = bitMap;
            }
        }

        private void Blue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Blue;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Blue;
            }
        }

        private void Black_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Black;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Black;
            }
        }

        private void Orange_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Orange;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Orange;
            }
        }

        private void Aqua_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Aqua;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Aqua;
            }
        }

        private void Yellow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Yellow;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Yellow;
            }
        }

        private void Violet_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Violet;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Violet;
            }
        }

        private void Green_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Green;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Green;
            }
        }

        private void Red_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Red;
            }
            else if (e.Button == MouseButtons.Left)
            {
                brush.Color = Color.Red;
            }
        }

        private void OnlyBordres_Click(object sender, EventArgs e)
        {
            flagTypeOfDraw = "borders";
            figure = figureFactory.Create(flagTypeOfDraw);

        }

        private void FillAndBorders_Click(object sender, EventArgs e)
        {
            flagTypeOfDraw = "fill";
            figure = figureFactory.Create(flagTypeOfDraw);
        }

        private void rTriangle_Click(object sender, EventArgs e)
        {
            figureFactory = new RightTriangleFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
        }

        private void eTriangle_Click(object sender, EventArgs e)
        {
            figureFactory = new EquilateralTriangleFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            figureFactory = new RectFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {

            NumericForPolygon.Visible = true;
            flagPolygonNum = true;
            figureFactory = new PolygonFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
        }

        private void NumericForPolygon_ValueChanged(object sender, EventArgs e)
        { 
            angl.Angl = (int)NumericForPolygon.Value;
        }

        private void NumericForPolygon_Click(object sender, EventArgs e)
        {
            

        }

        private void PolygonByPoint_Click(object sender, EventArgs e)
        {
            figureFactory = new PolygonByPointFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseClickByPoint";
            flagRewrieStartPoint = false;
            firstPointX = 0;
            firstPointY = 0;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            figureFactory = new LineFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = true;
        }



    }
}
