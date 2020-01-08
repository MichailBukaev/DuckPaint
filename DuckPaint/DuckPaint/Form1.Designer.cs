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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_VectorCircle = new System.Windows.Forms.Button();
            this.button_Change = new System.Windows.Forms.Button();
            this.button_Draw = new System.Windows.Forms.Button();
            this.trackBarVector = new System.Windows.Forms.TrackBar();
            this.RedVector = new System.Windows.Forms.Button();
            this.pictureBoxVector = new System.Windows.Forms.PictureBox();
            this.OrangeVector = new System.Windows.Forms.Button();
            this.YellowVector = new System.Windows.Forms.Button();
            this.GreenVector = new System.Windows.Forms.Button();
            this.AquaVector = new System.Windows.Forms.Button();
            this.BlueVector = new System.Windows.Forms.Button();
            this.VioletVector = new System.Windows.Forms.Button();
            this.BlackVector = new System.Windows.Forms.Button();
            this.button_VectorLine = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.VectorClear = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_VectorRectengl = new System.Windows.Forms.Button();
            this.button_VectorTriangle = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveAs = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AVLtextBox = new System.Windows.Forms.TextBox();
            this.AVL = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizBrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericForPolygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVector)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(105, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(660, 552);
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
            this.trackBarSizBrush.Location = new System.Drawing.Point(6, 19);
            this.trackBarSizBrush.Maximum = 5;
            this.trackBarSizBrush.Minimum = 1;
            this.trackBarSizBrush.Name = "trackBarSizBrush";
            this.trackBarSizBrush.Size = new System.Drawing.Size(79, 45);
            this.trackBarSizBrush.TabIndex = 1;
            this.trackBarSizBrush.Value = 1;
            this.trackBarSizBrush.ValueChanged += new System.EventHandler(this.trackBarSizBrush_ValueChanged);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Black.Location = new System.Drawing.Point(6, 19);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 26);
            this.Black.TabIndex = 18;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Black_MouseDown);
            // 
            // Violet
            // 
            this.Violet.BackColor = System.Drawing.Color.Violet;
            this.Violet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Violet.Location = new System.Drawing.Point(6, 50);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(25, 26);
            this.Violet.TabIndex = 17;
            this.Violet.UseVisualStyleBackColor = false;
            this.Violet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Violet_MouseDown);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue.Location = new System.Drawing.Point(37, 19);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 26);
            this.Blue.TabIndex = 16;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseDown);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Aqua.Location = new System.Drawing.Point(37, 82);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(25, 26);
            this.Aqua.TabIndex = 15;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aqua_MouseDown);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Green.Location = new System.Drawing.Point(37, 51);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 26);
            this.Green.TabIndex = 14;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Green_MouseDown);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yellow.Location = new System.Drawing.Point(37, 114);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 26);
            this.Yellow.TabIndex = 13;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseDown);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orange.Location = new System.Drawing.Point(6, 114);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(25, 26);
            this.Orange.TabIndex = 12;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseDown);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red.Location = new System.Drawing.Point(6, 82);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 26);
            this.Red.TabIndex = 11;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Red_MouseDown);
            // 
            // Line
            // 
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.Location = new System.Drawing.Point(6, 20);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(20, 20);
            this.Line.TabIndex = 19;
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.Location = new System.Drawing.Point(32, 20);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(20, 20);
            this.Ellipse.TabIndex = 20;
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // button_Fill
            // 
            this.button_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fill.Location = new System.Drawing.Point(8, 9);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(79, 25);
            this.button_Fill.TabIndex = 21;
            this.button_Fill.Text = "Fill";
            this.button_Fill.UseVisualStyleBackColor = true;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // OnlyBordres
            // 
            this.OnlyBordres.Enabled = false;
            this.OnlyBordres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnlyBordres.Location = new System.Drawing.Point(8, 40);
            this.OnlyBordres.Name = "OnlyBordres";
            this.OnlyBordres.Size = new System.Drawing.Size(79, 27);
            this.OnlyBordres.TabIndex = 22;
            this.OnlyBordres.Text = "OnlyBordres";
            this.OnlyBordres.UseVisualStyleBackColor = true;
            this.OnlyBordres.Click += new System.EventHandler(this.OnlyBordres_Click);
            // 
            // FillAndBorders
            // 
            this.FillAndBorders.Enabled = false;
            this.FillAndBorders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillAndBorders.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FillAndBorders.Location = new System.Drawing.Point(8, 73);
            this.FillAndBorders.Name = "FillAndBorders";
            this.FillAndBorders.Size = new System.Drawing.Size(79, 25);
            this.FillAndBorders.TabIndex = 23;
            this.FillAndBorders.Text = "FillAndBorders";
            this.FillAndBorders.UseVisualStyleBackColor = true;
            this.FillAndBorders.Click += new System.EventHandler(this.FillAndBorders_Click);
            // 
            // rTriangle
            // 
            this.rTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rTriangle.Image = ((System.Drawing.Image)(resources.GetObject("rTriangle.Image")));
            this.rTriangle.Location = new System.Drawing.Point(32, 46);
            this.rTriangle.Name = "rTriangle";
            this.rTriangle.Size = new System.Drawing.Size(20, 20);
            this.rTriangle.TabIndex = 24;
            this.rTriangle.UseVisualStyleBackColor = true;
            this.rTriangle.Click += new System.EventHandler(this.rTriangle_Click);
            // 
            // eTriangle
            // 
            this.eTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eTriangle.Image = ((System.Drawing.Image)(resources.GetObject("eTriangle.Image")));
            this.eTriangle.Location = new System.Drawing.Point(6, 46);
            this.eTriangle.Name = "eTriangle";
            this.eTriangle.Size = new System.Drawing.Size(20, 20);
            this.eTriangle.TabIndex = 25;
            this.eTriangle.UseVisualStyleBackColor = true;
            this.eTriangle.Click += new System.EventHandler(this.eTriangle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.Location = new System.Drawing.Point(58, 20);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(20, 20);
            this.Rectangle.TabIndex = 26;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // PolygonByPoint
            // 
            this.PolygonByPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PolygonByPoint.Image = ((System.Drawing.Image)(resources.GetObject("PolygonByPoint.Image")));
            this.PolygonByPoint.Location = new System.Drawing.Point(58, 46);
            this.PolygonByPoint.Name = "PolygonByPoint";
            this.PolygonByPoint.Size = new System.Drawing.Size(20, 20);
            this.PolygonByPoint.TabIndex = 27;
            this.PolygonByPoint.UseVisualStyleBackColor = true;
            this.PolygonByPoint.Click += new System.EventHandler(this.PolygonByPoint_Click);
            // 
            // Polygon
            // 
            this.Polygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Polygon.Image = ((System.Drawing.Image)(resources.GetObject("Polygon.Image")));
            this.Polygon.Location = new System.Drawing.Point(6, 72);
            this.Polygon.Name = "Polygon";
            this.Polygon.Size = new System.Drawing.Size(20, 20);
            this.Polygon.TabIndex = 28;
            this.Polygon.UseVisualStyleBackColor = true;
            this.Polygon.Click += new System.EventHandler(this.Polygon_Click);
            // 
            // NumericForPolygon
            // 
            this.NumericForPolygon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumericForPolygon.Location = new System.Drawing.Point(32, 72);
            this.NumericForPolygon.Name = "NumericForPolygon";
            this.NumericForPolygon.Size = new System.Drawing.Size(46, 20);
            this.NumericForPolygon.TabIndex = 29;
            this.NumericForPolygon.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericForPolygon.ValueChanged += new System.EventHandler(this.NumericForPolygon_ValueChanged);
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
            // button_VectorCircle
            // 
            this.button_VectorCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VectorCircle.Image = ((System.Drawing.Image)(resources.GetObject("button_VectorCircle.Image")));
            this.button_VectorCircle.Location = new System.Drawing.Point(6, 19);
            this.button_VectorCircle.Name = "button_VectorCircle";
            this.button_VectorCircle.Size = new System.Drawing.Size(20, 20);
            this.button_VectorCircle.TabIndex = 33;
            this.button_VectorCircle.UseVisualStyleBackColor = true;
            this.button_VectorCircle.Click += new System.EventHandler(this.button_VectorCircle_Click);
            // 
            // button_Change
            // 
            this.button_Change.Location = new System.Drawing.Point(6, 53);
            this.button_Change.Name = "button_Change";
            this.button_Change.Size = new System.Drawing.Size(72, 25);
            this.button_Change.TabIndex = 32;
            this.button_Change.Text = "Change";
            this.button_Change.UseVisualStyleBackColor = true;
            this.button_Change.Click += new System.EventHandler(this.button_Change_Click);
            // 
            // button_Draw
            // 
            this.button_Draw.Location = new System.Drawing.Point(6, 19);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(72, 25);
            this.button_Draw.TabIndex = 31;
            this.button_Draw.Text = "DRAW";
            this.button_Draw.UseVisualStyleBackColor = true;
            this.button_Draw.Click += new System.EventHandler(this.button_Draw_Click);
            // 
            // trackBarVector
            // 
            this.trackBarVector.Location = new System.Drawing.Point(6, 13);
            this.trackBarVector.Maximum = 5;
            this.trackBarVector.Minimum = 1;
            this.trackBarVector.Name = "trackBarVector";
            this.trackBarVector.Size = new System.Drawing.Size(79, 45);
            this.trackBarVector.TabIndex = 1;
            this.trackBarVector.Value = 1;
            this.trackBarVector.ValueChanged += new System.EventHandler(this.trackBarVector_ValueChanged);
            // 
            // RedVector
            // 
            this.RedVector.BackColor = System.Drawing.Color.Red;
            this.RedVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RedVector.Location = new System.Drawing.Point(37, 83);
            this.RedVector.Name = "RedVector";
            this.RedVector.Size = new System.Drawing.Size(25, 26);
            this.RedVector.TabIndex = 11;
            this.RedVector.UseVisualStyleBackColor = false;
            this.RedVector.Click += new System.EventHandler(this.RedVector_Click);
            // 
            // pictureBoxVector
            // 
            this.pictureBoxVector.BackColor = System.Drawing.Color.White;
            this.pictureBoxVector.Location = new System.Drawing.Point(104, 6);
            this.pictureBoxVector.Name = "pictureBoxVector";
            this.pictureBoxVector.Size = new System.Drawing.Size(661, 552);
            this.pictureBoxVector.TabIndex = 0;
            this.pictureBoxVector.TabStop = false;
            this.pictureBoxVector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVector_MouseDown);
            this.pictureBoxVector.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVector_MouseMove);
            this.pictureBoxVector.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxVector_MouseUp);
            // 
            // OrangeVector
            // 
            this.OrangeVector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OrangeVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrangeVector.Location = new System.Drawing.Point(37, 19);
            this.OrangeVector.Name = "OrangeVector";
            this.OrangeVector.Size = new System.Drawing.Size(25, 26);
            this.OrangeVector.TabIndex = 12;
            this.OrangeVector.UseVisualStyleBackColor = false;
            this.OrangeVector.Click += new System.EventHandler(this.OrangeVector_Click);
            // 
            // YellowVector
            // 
            this.YellowVector.BackColor = System.Drawing.Color.Yellow;
            this.YellowVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YellowVector.Location = new System.Drawing.Point(6, 51);
            this.YellowVector.Name = "YellowVector";
            this.YellowVector.Size = new System.Drawing.Size(25, 26);
            this.YellowVector.TabIndex = 13;
            this.YellowVector.UseVisualStyleBackColor = false;
            this.YellowVector.Click += new System.EventHandler(this.YellowVector_Click);
            // 
            // GreenVector
            // 
            this.GreenVector.BackColor = System.Drawing.Color.Green;
            this.GreenVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GreenVector.Location = new System.Drawing.Point(6, 115);
            this.GreenVector.Name = "GreenVector";
            this.GreenVector.Size = new System.Drawing.Size(25, 26);
            this.GreenVector.TabIndex = 14;
            this.GreenVector.UseVisualStyleBackColor = false;
            this.GreenVector.Click += new System.EventHandler(this.GreenVector_Click);
            // 
            // AquaVector
            // 
            this.AquaVector.BackColor = System.Drawing.Color.Aqua;
            this.AquaVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AquaVector.Location = new System.Drawing.Point(37, 51);
            this.AquaVector.Name = "AquaVector";
            this.AquaVector.Size = new System.Drawing.Size(25, 26);
            this.AquaVector.TabIndex = 15;
            this.AquaVector.UseVisualStyleBackColor = false;
            this.AquaVector.Click += new System.EventHandler(this.AquaVector_Click);
            // 
            // BlueVector
            // 
            this.BlueVector.BackColor = System.Drawing.Color.Blue;
            this.BlueVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlueVector.Location = new System.Drawing.Point(6, 83);
            this.BlueVector.Name = "BlueVector";
            this.BlueVector.Size = new System.Drawing.Size(25, 26);
            this.BlueVector.TabIndex = 16;
            this.BlueVector.UseVisualStyleBackColor = false;
            this.BlueVector.Click += new System.EventHandler(this.BlueVector_Click);
            // 
            // VioletVector
            // 
            this.VioletVector.BackColor = System.Drawing.Color.Violet;
            this.VioletVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VioletVector.Location = new System.Drawing.Point(37, 115);
            this.VioletVector.Name = "VioletVector";
            this.VioletVector.Size = new System.Drawing.Size(25, 26);
            this.VioletVector.TabIndex = 17;
            this.VioletVector.UseVisualStyleBackColor = false;
            this.VioletVector.Click += new System.EventHandler(this.VioletVector_Click);
            // 
            // BlackVector
            // 
            this.BlackVector.BackColor = System.Drawing.Color.Black;
            this.BlackVector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BlackVector.Location = new System.Drawing.Point(6, 19);
            this.BlackVector.Name = "BlackVector";
            this.BlackVector.Size = new System.Drawing.Size(25, 26);
            this.BlackVector.TabIndex = 18;
            this.BlackVector.UseVisualStyleBackColor = false;
            this.BlackVector.Click += new System.EventHandler(this.BlackVector_Click);
            // 
            // button_VectorLine
            // 
            this.button_VectorLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VectorLine.Image = ((System.Drawing.Image)(resources.GetObject("button_VectorLine.Image")));
            this.button_VectorLine.Location = new System.Drawing.Point(32, 45);
            this.button_VectorLine.Name = "button_VectorLine";
            this.button_VectorLine.Size = new System.Drawing.Size(20, 20);
            this.button_VectorLine.TabIndex = 34;
            this.button_VectorLine.UseVisualStyleBackColor = true;
            this.button_VectorLine.Click += new System.EventHandler(this.button_VectorLine_Click_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 590);
            this.tabControl1.TabIndex = 36;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Raster";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonClear);
            this.groupBox5.Controls.Add(this.button_Fill);
            this.groupBox5.Controls.Add(this.OnlyBordres);
            this.groupBox5.Controls.Add(this.FillAndBorders);
            this.groupBox5.Location = new System.Drawing.Point(6, 368);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(93, 138);
            this.groupBox5.TabIndex = 33;
            this.groupBox5.TabStop = false;
            // 
            // buttonClear
            // 
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Location = new System.Drawing.Point(8, 106);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 23);
            this.buttonClear.TabIndex = 34;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Line);
            this.groupBox4.Controls.Add(this.Ellipse);
            this.groupBox4.Controls.Add(this.eTriangle);
            this.groupBox4.Controls.Add(this.rTriangle);
            this.groupBox4.Controls.Add(this.Rectangle);
            this.groupBox4.Controls.Add(this.PolygonByPoint);
            this.groupBox4.Controls.Add(this.NumericForPolygon);
            this.groupBox4.Controls.Add(this.Polygon);
            this.groupBox4.Location = new System.Drawing.Point(8, 256);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(91, 106);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Objects";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Black);
            this.groupBox3.Controls.Add(this.Blue);
            this.groupBox3.Controls.Add(this.Red);
            this.groupBox3.Controls.Add(this.Violet);
            this.groupBox3.Controls.Add(this.Green);
            this.groupBox3.Controls.Add(this.Aqua);
            this.groupBox3.Controls.Add(this.Orange);
            this.groupBox3.Controls.Add(this.Yellow);
            this.groupBox3.Location = new System.Drawing.Point(8, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(91, 151);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color Palette";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trackBarSizBrush);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(91, 87);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sizing";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.pictureBoxVector);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vector";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.VectorClear);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.button_Draw);
            this.groupBox8.Controls.Add(this.button_Change);
            this.groupBox8.Location = new System.Drawing.Point(6, 239);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(90, 220);
            this.groupBox8.TabIndex = 39;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Painting";
            // 
            // VectorClear
            // 
            this.VectorClear.Location = new System.Drawing.Point(6, 86);
            this.VectorClear.Name = "VectorClear";
            this.VectorClear.Size = new System.Drawing.Size(72, 25);
            this.VectorClear.TabIndex = 40;
            this.VectorClear.Text = "CLEAR";
            this.VectorClear.UseVisualStyleBackColor = true;
            this.VectorClear.Click += new System.EventHandler(this.VectorClear_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_VectorCircle);
            this.groupBox9.Controls.Add(this.button_VectorRectengl);
            this.groupBox9.Controls.Add(this.button_VectorTriangle);
            this.groupBox9.Controls.Add(this.button_VectorLine);
            this.groupBox9.Location = new System.Drawing.Point(6, 117);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(72, 86);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Objects";
            // 
            // button_VectorRectengl
            // 
            this.button_VectorRectengl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VectorRectengl.Image = ((System.Drawing.Image)(resources.GetObject("button_VectorRectengl.Image")));
            this.button_VectorRectengl.Location = new System.Drawing.Point(32, 19);
            this.button_VectorRectengl.Name = "button_VectorRectengl";
            this.button_VectorRectengl.Size = new System.Drawing.Size(20, 20);
            this.button_VectorRectengl.TabIndex = 35;
            this.button_VectorRectengl.UseVisualStyleBackColor = true;
            this.button_VectorRectengl.Click += new System.EventHandler(this.button_VectorRectengl_Click);
            // 
            // button_VectorTriangle
            // 
            this.button_VectorTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VectorTriangle.Image = ((System.Drawing.Image)(resources.GetObject("button_VectorTriangle.Image")));
            this.button_VectorTriangle.Location = new System.Drawing.Point(6, 45);
            this.button_VectorTriangle.Name = "button_VectorTriangle";
            this.button_VectorTriangle.Size = new System.Drawing.Size(20, 20);
            this.button_VectorTriangle.TabIndex = 36;
            this.button_VectorTriangle.UseVisualStyleBackColor = true;
            this.button_VectorTriangle.Click += new System.EventHandler(this.button_VectorTriangle_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.trackBarVector);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(92, 69);
            this.groupBox7.TabIndex = 38;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Sizing";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BlackVector);
            this.groupBox6.Controls.Add(this.OrangeVector);
            this.groupBox6.Controls.Add(this.YellowVector);
            this.groupBox6.Controls.Add(this.AquaVector);
            this.groupBox6.Controls.Add(this.BlueVector);
            this.groupBox6.Controls.Add(this.RedVector);
            this.groupBox6.Controls.Add(this.GreenVector);
            this.groupBox6.Controls.Add(this.VioletVector);
            this.groupBox6.Location = new System.Drawing.Point(6, 81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(90, 152);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Color Palette";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonSaveAs,
            this.toolStripButtonLoad,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(787, 25);
            this.toolStrip1.TabIndex = 37;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "toolStripButton1";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButtonSaveAs
            // 
            this.toolStripButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAs.Image")));
            this.toolStripButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveAs.Name = "toolStripButtonSaveAs";
            this.toolStripButtonSaveAs.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSaveAs.Text = "toolStripButton2";
            this.toolStripButtonSaveAs.Click += new System.EventHandler(this.toolStripButtonSaveAs_Click);
            // 
            // toolStripButtonLoad
            // 
            this.toolStripButtonLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLoad.Image")));
            this.toolStripButtonLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLoad.Name = "toolStripButtonLoad";
            this.toolStripButtonLoad.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLoad.Text = "toolStripButton3";
            this.toolStripButtonLoad.Click += new System.EventHandler(this.toolStripButtonLoad_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AVLtextBox
            // 
            this.AVLtextBox.Location = new System.Drawing.Point(152, 2);
            this.AVLtextBox.Name = "AVLtextBox";
            this.AVLtextBox.Size = new System.Drawing.Size(155, 20);
            this.AVLtextBox.TabIndex = 38;
            // 
            // AVL
            // 
            this.AVL.Location = new System.Drawing.Point(314, 2);
            this.AVL.Name = "AVL";
            this.AVL.Size = new System.Drawing.Size(75, 23);
            this.AVL.TabIndex = 39;
            this.AVL.Text = "button1";
            this.AVL.UseVisualStyleBackColor = true;
            this.AVL.Click += new System.EventHandler(this.AVL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 622);
            this.Controls.Add(this.AVL);
            this.Controls.Add(this.AVLtextBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "DuckPaint beta";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizBrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericForPolygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVector)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trackBarVector;
        private System.Windows.Forms.Button RedVector;
        private System.Windows.Forms.PictureBox pictureBoxVector;
        private System.Windows.Forms.Button OrangeVector;
        private System.Windows.Forms.Button YellowVector;
        private System.Windows.Forms.Button GreenVector;
        private System.Windows.Forms.Button AquaVector;
        private System.Windows.Forms.Button BlueVector;
        private System.Windows.Forms.Button VioletVector;
        private System.Windows.Forms.Button BlackVector;
        private System.Windows.Forms.Button button_Change;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.Button button_VectorCircle;
        private System.Windows.Forms.Button button_VectorLine;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button_VectorTriangle;
        private System.Windows.Forms.Button button_VectorRectengl;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button VectorClear;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveAs;
        private System.Windows.Forms.ToolStripButton toolStripButtonLoad;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox AVLtextBox;
        private System.Windows.Forms.Button AVL;
    }
}

