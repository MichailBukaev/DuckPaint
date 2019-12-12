namespace DuckPaint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarSizBrush = new System.Windows.Forms.TrackBar();
            this.Black = new System.Windows.Forms.Button();
            this.Violet = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.button_Fill = new System.Windows.Forms.Button();
            this.OnlyBordres = new System.Windows.Forms.Button();
            this.FillAndBorders = new System.Windows.Forms.Button();
            this.rTriangle = new System.Windows.Forms.Button();
            this.eTriangle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.PolygonByPoint = new System.Windows.Forms.Button();
            this.Polygon = new System.Windows.Forms.Button();
            this.NumericForPolygon = new System.Windows.Forms.NumericUpDown();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Raster = new System.Windows.Forms.Panel();
            this.button_Raster = new System.Windows.Forms.Button();
            this.Vector = new System.Windows.Forms.Panel();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Draw = new System.Windows.Forms.Button();
            this.trackBarVector = new System.Windows.Forms.TrackBar();
            this.RedVector = new System.Windows.Forms.Button();
            this.ClearVector = new System.Windows.Forms.Button();
            this.pictureBoxVector = new System.Windows.Forms.PictureBox();
            this.OrangeVector = new System.Windows.Forms.Button();
            this.YellowVector = new System.Windows.Forms.Button();
            this.GreenVector = new System.Windows.Forms.Button();
            this.AquaVector = new System.Windows.Forms.Button();
            this.BlueVector = new System.Windows.Forms.Button();
            this.VioletVector = new System.Windows.Forms.Button();
            this.BlackVector = new System.Windows.Forms.Button();
            this.button_Vector = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericForPolygon)).BeginInit();
            this.Raster.SuspendLayout();
            this.Vector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVector)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // trackBarSizBrush
            // 
            this.trackBarSizBrush.Location = new System.Drawing.Point(10, 11);
            this.trackBarSizBrush.Maximum = 5;
            this.trackBarSizBrush.Minimum = 1;
            this.trackBarSizBrush.Name = "trackBarSizBrush";
            this.trackBarSizBrush.Size = new System.Drawing.Size(104, 45);
            this.trackBarSizBrush.TabIndex = 1;
            this.trackBarSizBrush.Value = 1;
            this.trackBarSizBrush.ValueChanged += new System.EventHandler(this.trackBarSizBrush_ValueChanged);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(124, 4);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 26);
            this.Black.TabIndex = 18;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Black_MouseDown);
            // 
            // Violet
            // 
            this.Violet.BackColor = System.Drawing.Color.Violet;
            this.Violet.Location = new System.Drawing.Point(186, 34);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(25, 26);
            this.Violet.TabIndex = 17;
            this.Violet.UseVisualStyleBackColor = false;
            this.Violet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Violet_MouseDown);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(155, 34);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 26);
            this.Blue.TabIndex = 16;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseDown);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(124, 34);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(25, 26);
            this.Aqua.TabIndex = 15;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aqua_MouseDown);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(217, 4);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 26);
            this.Green.TabIndex = 14;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Green_MouseDown);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(186, 4);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 26);
            this.Yellow.TabIndex = 13;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseDown);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(155, 4);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(25, 26);
            this.Orange.TabIndex = 12;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseDown);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(217, 34);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 26);
            this.Red.TabIndex = 11;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Red_MouseDown);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(249, 4);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(60, 26);
            this.Line.TabIndex = 19;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(249, 33);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(60, 26);
            this.Ellipse.TabIndex = 20;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // button_Fill
            // 
            this.button_Fill.Location = new System.Drawing.Point(692, 4);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(37, 56);
            this.button_Fill.TabIndex = 21;
            this.button_Fill.Text = "Fill";
            this.button_Fill.UseVisualStyleBackColor = true;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // OnlyBordres
            // 
            this.OnlyBordres.Enabled = false;
            this.OnlyBordres.Location = new System.Drawing.Point(599, 4);
            this.OnlyBordres.Name = "OnlyBordres";
            this.OnlyBordres.Size = new System.Drawing.Size(87, 27);
            this.OnlyBordres.TabIndex = 22;
            this.OnlyBordres.Text = "OnlyBordres";
            this.OnlyBordres.UseVisualStyleBackColor = true;
            this.OnlyBordres.Click += new System.EventHandler(this.OnlyBordres_Click);
            // 
            // FillAndBorders
            // 
            this.FillAndBorders.Enabled = false;
            this.FillAndBorders.Location = new System.Drawing.Point(599, 33);
            this.FillAndBorders.Name = "FillAndBorders";
            this.FillAndBorders.Size = new System.Drawing.Size(87, 27);
            this.FillAndBorders.TabIndex = 23;
            this.FillAndBorders.Text = "FillAndBorders";
            this.FillAndBorders.UseVisualStyleBackColor = true;
            this.FillAndBorders.Click += new System.EventHandler(this.FillAndBorders_Click);
            // 
            // rTriangle
            // 
            this.rTriangle.Location = new System.Drawing.Point(447, 2);
            this.rTriangle.Name = "rTriangle";
            this.rTriangle.Size = new System.Drawing.Size(75, 26);
            this.rTriangle.TabIndex = 24;
            this.rTriangle.Text = "rTriangle";
            this.rTriangle.UseVisualStyleBackColor = true;
            this.rTriangle.Click += new System.EventHandler(this.rTriangle_Click);
            // 
            // eTriangle
            // 
            this.eTriangle.Location = new System.Drawing.Point(447, 33);
            this.eTriangle.Name = "eTriangle";
            this.eTriangle.Size = new System.Drawing.Size(75, 27);
            this.eTriangle.TabIndex = 25;
            this.eTriangle.Text = "eTriangle";
            this.eTriangle.UseVisualStyleBackColor = true;
            this.eTriangle.Click += new System.EventHandler(this.eTriangle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(528, 4);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(65, 56);
            this.Rectangle.TabIndex = 26;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // PolygonByPoint
            // 
            this.PolygonByPoint.Location = new System.Drawing.Point(381, 4);
            this.PolygonByPoint.Name = "PolygonByPoint";
            this.PolygonByPoint.Size = new System.Drawing.Size(60, 56);
            this.PolygonByPoint.TabIndex = 27;
            this.PolygonByPoint.Text = "Polygon By Point";
            this.PolygonByPoint.UseVisualStyleBackColor = true;
            this.PolygonByPoint.Click += new System.EventHandler(this.PolygonByPoint_Click);
            // 
            // Polygon
            // 
            this.Polygon.Location = new System.Drawing.Point(315, 4);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(60, 26);
            this.Polygon.TabIndex = 28;
            this.Polygon.Text = "Polygon";
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // NumericForPolygon
            // 
            this.NumericForPolygon.Location = new System.Drawing.Point(315, 36);
            this.NumericForPolygon.Name = "NumericForPolygon";
            this.NumericForPolygon.Size = new System.Drawing.Size(60, 20);
            this.NumericForPolygon.TabIndex = 29;
            this.NumericForPolygon.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericForPolygon.ValueChanged += new System.EventHandler(this.NumericForPolygon_ValueChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(755, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(41, 55);
            this.Clear.TabIndex = 30;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1049, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(106, -77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 58);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Raster
            // 
            this.Raster.Controls.Add(this.trackBarSizBrush);
            this.Raster.Controls.Add(this.Red);
            this.Raster.Controls.Add(this.Clear);
            this.Raster.Controls.Add(this.pictureBox1);
            this.Raster.Controls.Add(this.Orange);
            this.Raster.Controls.Add(this.NumericForPolygon);
            this.Raster.Controls.Add(this.Yellow);
            this.Raster.Controls.Add(this.Polygon);
            this.Raster.Controls.Add(this.Green);
            this.Raster.Controls.Add(this.PolygonByPoint);
            this.Raster.Controls.Add(this.Aqua);
            this.Raster.Controls.Add(this.Rectangle);
            this.Raster.Controls.Add(this.Blue);
            this.Raster.Controls.Add(this.eTriangle);
            this.Raster.Controls.Add(this.Violet);
            this.Raster.Controls.Add(this.rTriangle);
            this.Raster.Controls.Add(this.Black);
            this.Raster.Controls.Add(this.FillAndBorders);
            this.Raster.Controls.Add(this.Line);
            this.Raster.Controls.Add(this.OnlyBordres);
            this.Raster.Controls.Add(this.Ellipse);
            this.Raster.Controls.Add(this.button_Fill);
            this.Raster.Location = new System.Drawing.Point(2, 46);
            this.Raster.Name = "Raster";
            this.Raster.Size = new System.Drawing.Size(819, 448);
            this.Raster.TabIndex = 33;
            // 
            // button_Raster
            // 
            this.button_Raster.Location = new System.Drawing.Point(2, 12);
            this.button_Raster.Name = "button_Raster";
            this.button_Raster.Size = new System.Drawing.Size(89, 28);
            this.button_Raster.TabIndex = 34;
            this.button_Raster.Text = "Raster";
            this.button_Raster.UseVisualStyleBackColor = true;
            this.button_Raster.Click += new System.EventHandler(this.button_Raster_Click);
            // 
            // Vector
            // 
            this.Vector.Controls.Add(this.button_Change);
            this.Vector.Controls.Add(this.button_Draw);
            this.Vector.Controls.Add(this.trackBarVector);
            this.Vector.Controls.Add(this.RedVector);
            this.Vector.Controls.Add(this.ClearVector);
            this.Vector.Controls.Add(this.pictureBoxVector);
            this.Vector.Controls.Add(this.OrangeVector);
            this.Vector.Controls.Add(this.YellowVector);
            this.Vector.Controls.Add(this.GreenVector);
            this.Vector.Controls.Add(this.AquaVector);
            this.Vector.Controls.Add(this.BlueVector);
            this.Vector.Controls.Add(this.VioletVector);
            this.Vector.Controls.Add(this.BlackVector);
            this.Vector.Location = new System.Drawing.Point(2, 46);
            this.Vector.Name = "Vector";
            this.Vector.Size = new System.Drawing.Size(825, 485);
            this.Vector.TabIndex = 34;
            this.Vector.Visible = false;
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(249, 34);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(83, 27);
            this.button_Change.TabIndex = 32;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(249, 4);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(83, 27);
            this.button_Draw.TabIndex = 31;
            this.button_Draw.Text = "Draw";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // trackBarVector
            // 
            this.trackBarVector.Location = new System.Drawing.Point(10, 10);
            this.trackBarVector.Maximum = 5;
            this.trackBarVector.Minimum = 1;
            this.trackBarVector.Name = "trackBarVector";
            this.trackBarVector.Size = new System.Drawing.Size(104, 45);
            this.trackBarVector.TabIndex = 1;
            this.trackBarVector.Value = 1;
            this.trackBarVector.ValueChanged += new System.EventHandler(this.trackBarVector_ValueChanged);
            // 
            // RedVector
            // 
            this.RedVector.BackColor = System.Drawing.Color.Red;
            this.RedVector.Location = new System.Drawing.Point(217, 34);
            this.RedVector.Name = "RedVector";
            this.RedVector.Size = new System.Drawing.Size(25, 26);
            this.RedVector.TabIndex = 11;
            this.RedVector.UseVisualStyleBackColor = false;
            this.RedVector.Click += new System.EventHandler(this.RedVector_Click);
            // 
            // ClearVector
            // 
            this.ClearVector.Location = new System.Drawing.Point(755, 4);
            this.ClearVector.Name = "ClearVector";
            this.ClearVector.Size = new System.Drawing.Size(41, 55);
            this.ClearVector.TabIndex = 30;
            this.ClearVector.Text = "Clear";
            this.ClearVector.UseVisualStyleBackColor = true;
            // 
            // pictureBoxVector
            // 
            this.pictureBoxVector.BackColor = System.Drawing.Color.White;
            this.pictureBoxVector.Location = new System.Drawing.Point(3, 66);
            this.pictureBoxVector.Name = "pictureBoxVector";
            this.pictureBoxVector.Size = new System.Drawing.Size(803, 380);
            this.pictureBoxVector.TabIndex = 0;
            this.pictureBoxVector.TabStop = false;
            this.pictureBoxVector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVector_MouseDown);
            this.pictureBoxVector.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVector_MouseMove);
            this.pictureBoxVector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVector_MouseUp);
            // 
            // OrangeVector
            // 
            this.OrangeVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeVector.Location = new System.Drawing.Point(155, 4);
            this.OrangeVector.Name = "OrangeVector";
            this.OrangeVector.Size = new System.Drawing.Size(25, 26);
            this.OrangeVector.TabIndex = 12;
            this.OrangeVector.UseVisualStyleBackColor = false;
            this.OrangeVector.Click += new System.EventHandler(this.OrangeVector_Click);
            // 
            // YellowVector
            // 
            this.YellowVector.BackColor = System.Drawing.Color.Yellow;
            this.YellowVector.Location = new System.Drawing.Point(186, 4);
            this.YellowVector.Name = "YellowVector";
            this.YellowVector.Size = new System.Drawing.Size(25, 26);
            this.YellowVector.TabIndex = 13;
            this.YellowVector.UseVisualStyleBackColor = false;
            this.YellowVector.Click += new System.EventHandler(this.YellowVector_Click);
            // 
            // GreenVector
            // 
            this.GreenVector.BackColor = System.Drawing.Color.Green;
            this.GreenVector.Location = new System.Drawing.Point(217, 4);
            this.GreenVector.Name = "GreenVector";
            this.GreenVector.Size = new System.Drawing.Size(25, 26);
            this.GreenVector.TabIndex = 14;
            this.GreenVector.UseVisualStyleBackColor = false;
            this.GreenVector.Click += new System.EventHandler(this.GreenVector_Click);
            // 
            // AquaVector
            // 
            this.AquaVector.BackColor = System.Drawing.Color.Aqua;
            this.AquaVector.Location = new System.Drawing.Point(124, 34);
            this.AquaVector.Name = "AquaVector";
            this.AquaVector.Size = new System.Drawing.Size(25, 26);
            this.AquaVector.TabIndex = 15;
            this.AquaVector.UseVisualStyleBackColor = false;
            this.AquaVector.Click += new System.EventHandler(this.AquaVector_Click);
            // 
            // BlueVector
            // 
            this.BlueVector.BackColor = System.Drawing.Color.Blue;
            this.BlueVector.Location = new System.Drawing.Point(155, 34);
            this.BlueVector.Name = "BlueVector";
            this.BlueVector.Size = new System.Drawing.Size(25, 26);
            this.BlueVector.TabIndex = 16;
            this.BlueVector.UseVisualStyleBackColor = false;
            this.BlueVector.Click += new System.EventHandler(this.BlueVector_Click);
            // 
            // VioletVector
            // 
            this.VioletVector.BackColor = System.Drawing.Color.Violet;
            this.VioletVector.Location = new System.Drawing.Point(186, 34);
            this.VioletVector.Name = "VioletVector";
            this.VioletVector.Size = new System.Drawing.Size(25, 26);
            this.VioletVector.TabIndex = 17;
            this.VioletVector.UseVisualStyleBackColor = false;
            this.VioletVector.Click += new System.EventHandler(this.VioletVector_Click);
            // 
            // BlackVector
            // 
            this.BlackVector.BackColor = System.Drawing.Color.Black;
            this.BlackVector.Location = new System.Drawing.Point(124, 4);
            this.BlackVector.Name = "BlackVector";
            this.BlackVector.Size = new System.Drawing.Size(25, 26);
            this.BlackVector.TabIndex = 18;
            this.BlackVector.UseVisualStyleBackColor = false;
            this.BlackVector.Click += new System.EventHandler(this.BlackVector_Click);
            // 
            // button_Vector
            // 
            this.button_Vector.Location = new System.Drawing.Point(97, 12);
            this.button_Vector.Name = "button_Vector";
            this.button_Vector.Size = new System.Drawing.Size(89, 28);
            this.button_Vector.TabIndex = 35;
            this.button_Vector.Text = "Vector";
            this.button_Vector.UseVisualStyleBackColor = true;
            this.button_Vector.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 569);
            this.Controls.Add(this.Vector);
            this.Controls.Add(this.button_Vector);
            this.Controls.Add(this.button_Raster);
            this.Controls.Add(this.Raster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericForPolygon)).EndInit();
            this.Raster.ResumeLayout(false);
            this.Raster.PerformLayout();
            this.Vector.ResumeLayout(false);
            this.Vector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarSizBrush;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Violet;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Aqua;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.Button OnlyBordres;
        private System.Windows.Forms.Button FillAndBorders;
        private System.Windows.Forms.Button rTriangle;
        private System.Windows.Forms.Button eTriangle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button PolygonByPoint;
        private System.Windows.Forms.Button Polygon;
        private System.Windows.Forms.NumericUpDown NumericForPolygon;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Raster;
        private System.Windows.Forms.Button button_Raster;
        private System.Windows.Forms.Panel Vector;
        private System.Windows.Forms.TrackBar trackBarVector;
        private System.Windows.Forms.Button RedVector;
        private System.Windows.Forms.Button ClearVector;
        private System.Windows.Forms.PictureBox pictureBoxVector;
        private System.Windows.Forms.Button OrangeVector;
        private System.Windows.Forms.Button YellowVector;
        private System.Windows.Forms.Button GreenVector;
        private System.Windows.Forms.Button AquaVector;
        private System.Windows.Forms.Button BlueVector;
        private System.Windows.Forms.Button VioletVector;
        private System.Windows.Forms.Button BlackVector;
        private System.Windows.Forms.Button button_Vector;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Draw;
    }
}

