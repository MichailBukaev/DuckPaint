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
        Bitmap bitMap;
        Bitmap bitMapTmp;
        FigureFactory figureFactory;
        Figure figure;
        Brush brush;
        Fill fill;

        bool flagDownMouse = false;
        string flagMethWorkMouse = " ";
        string flagTypeOfDraw = "borders";
        bool flagUsBitMapTmp = false;

        bool flagRewrieStartPoint = false;




        int startX, startY;

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
            startX = e.Location.X;
            startY = e.Location.Y;
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
        }

       

        private void Blue_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                fill.Color = Color.Blue;
            }
            else if(e.Button == MouseButtons.Left)
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

        private void Line_Click(object sender, EventArgs e)
        {
            figureFactory = new LineFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = true;
        }



    }
}
