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
        #region Rastr
        Bitmap bitMap, bitmap_copy;
        Bitmap bitMapTmp;
        FigureFactory figureFactory;
        Figure figure;
        Brush brush;
        Fill fill;
        FigureOption angl;
        #endregion

        #region Vector
        Bitmap Vbitmap;
        Canvas Vcanvas;
        VectorFigure Vfigure;
        VectorFigureFactory VfigureFactory;
        Point VpointForChange;
        int indexPoint;
        #endregion


        #region Flags Rastr
        bool flagDownMouse = false;
        string flagMethWorkMouse = " ";
        string flagTypeOfDraw = "borders";
        bool flagUsBitMapTmp = false;
        bool flagRewrieStartPoint = false;
        bool flagPolygonNum = false;
        #endregion


        bool VflagMode = true;
        bool VflagDownMouse = false;



        int startX, startY;
        int firstPointX = 0, firstPointY = 0;

        Color Vcolor = Color.Black;
        int Vsize = 1;
        

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
            angl = FigureOption.SetAngles();
            Vcanvas = Canvas.CreateCanvas();
            //VfigureFactory = new VectorLineFactory();
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

        #region Color rastr
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

        #endregion

        #region Button Rastr
        private void Ellipse_Click(object sender, EventArgs e)
        {
            figureFactory = new EllipseFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = true;
        }

        private void button_Fill_Click(object sender, EventArgs e)
        {
            flagMethWorkMouse = "MouseClick";
            OnlyBordres.Enabled = false;
            FillAndBorders.Enabled = false;
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
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = true;
        }

        private void eTriangle_Click(object sender, EventArgs e)
        {
            figureFactory = new EquilateralTriangleFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = true;
        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            figureFactory = new RectFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = true;
        }

        private void Polygon_Click(object sender, EventArgs e)
        {

            NumericForPolygon.Enabled = true;
            flagPolygonNum = true;
            figureFactory = new PolygonFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = false;
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.bitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitMap;
        }
        #endregion

        private void button5_Click(object sender, EventArgs e)
        {
            Raster.Visible = false;
            Vector.Visible = true;
        }

        private void button_Raster_Click(object sender, EventArgs e)
        {
            Raster.Visible = true;
            Vector.Visible = false;

        }

        private void button_Draw_Click(object sender, EventArgs e)
        {
            VflagMode = true;
        }

        private void button_Change_Click(object sender, EventArgs e)
        {
            VflagMode = false;
        }

        private void pictureBoxVector_MouseDown(object sender, MouseEventArgs e)
        {
            VflagDownMouse = true;
            if (VflagMode)
            {
               
                Vfigure = VfigureFactory.Creator(e.Location, Vsize, Vcolor);
                Vcanvas.Add(Vfigure);
            }
            else
            {
                Vfigure = Vcanvas.FindPoint(e.Location, ref VpointForChange);
                if (Vfigure != null)
                {
                    for (int i = 0; i < Vfigure.Points.Count; i++)
                    {
                        if (Vfigure.Points[i] == VpointForChange)
                        {
                            indexPoint = i;
                        }
                    }
                }
            }
            
        }

        private void pictureBoxVector_MouseMove(object sender, MouseEventArgs e)
        {
            if (VflagDownMouse)
            {
                if (VflagMode)
                {
                    Vfigure.MouseMoveTillCreation(e.Location);
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
                else
                {
                    if (Vfigure != null)
                    {
                        if (Control.ModifierKeys == Keys.Shift)
                        {
                            Vfigure = ModeVector.MoveFigure(Vfigure, indexPoint, e.Location);
                            Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                            Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                            pictureBoxVector.Image = Vbitmap;
                        }
                        else
                        {
                            Vfigure = ModeVector.MovePoint(Vfigure, indexPoint, e.Location);
                            Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                            Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                            pictureBoxVector.Image = Vbitmap;
                        }
                    }
                }
            }
        }

        private void pictureBoxVector_MouseUp(object sender, MouseEventArgs e)
        {
            VflagDownMouse = false;
        }

        private void BlackVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Black;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Black;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void AquaVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Aqua;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Aqua;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    pictureBoxVector.Image = Vcanvas.UpDateAll(Vbitmap);
                }
            }
        }

        private void OrangeVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Orange;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Orange;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void BlueVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Blue;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Blue;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void YellowVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Yellow;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Yellow;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void VioletVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Violet;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Violet;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void GreenVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Green;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Green;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void RedVector_Click(object sender, EventArgs e)
        {
            if (VflagMode)
            {
                Vcolor = Color.Red;
            }
            else
            {
                if (Vfigure != null)
                {
                    Vfigure.Color = Color.Red;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
        }

        private void trackBarVector_ValueChanged(object sender, EventArgs e)
        {
            if(VflagMode)
            {
                Vsize = trackBarSizBrush.Value;
            }
            else
            {
                if(Vfigure != null)
                {
                    Vsize = trackBarSizBrush.Value;
                    Vbitmap = new Bitmap(pictureBoxVector.Width, pictureBoxVector.Height);
                    Vbitmap = Vcanvas.UpDateAll(Vbitmap);
                    pictureBoxVector.Image = Vbitmap;
                }
            }
            
        }

        private void NumericForPolygon_ValueChanged(object sender, EventArgs e)
        { 
            angl.Angl = (int)NumericForPolygon.Value;
        }

       

        private void PolygonByPoint_Click(object sender, EventArgs e)
        {
            figureFactory = new PolygonByPointFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseClickByPoint";
            flagRewrieStartPoint = false;
            firstPointX = 0;
            firstPointY = 0;
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = false;
        }

        private void Line_Click(object sender, EventArgs e)
        {
            figureFactory = new LineFactory();
            figure = figureFactory.Create(flagTypeOfDraw);
            flagMethWorkMouse = "MouseMove";
            flagRewrieStartPoint = true;
            OnlyBordres.Enabled = true;
            FillAndBorders.Enabled = false;
        }



    }
}
