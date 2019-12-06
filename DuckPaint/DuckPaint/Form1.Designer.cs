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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizBrush)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // trackBarSizBrush
            // 
            this.trackBarSizBrush.Location = new System.Drawing.Point(-1, 12);
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
            this.Black.Location = new System.Drawing.Point(123, 5);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 26);
            this.Black.TabIndex = 18;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Black_MouseDown);
            // 
            // Violet
            // 
            this.Violet.BackColor = System.Drawing.Color.Violet;
            this.Violet.Location = new System.Drawing.Point(185, 35);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(25, 26);
            this.Violet.TabIndex = 17;
            this.Violet.UseVisualStyleBackColor = false;
            this.Violet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Violet_MouseDown);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(154, 35);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 26);
            this.Blue.TabIndex = 16;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Blue_MouseDown);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(123, 35);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(25, 26);
            this.Aqua.TabIndex = 15;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Aqua_MouseDown);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(216, 5);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 26);
            this.Green.TabIndex = 14;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Green_MouseDown);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(185, 5);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 26);
            this.Yellow.TabIndex = 13;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yellow_MouseDown);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(154, 5);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(25, 26);
            this.Orange.TabIndex = 12;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Orange_MouseDown);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(216, 35);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 26);
            this.Red.TabIndex = 11;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Red_MouseDown);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(248, 5);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(60, 56);
            this.Line.TabIndex = 19;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.Location = new System.Drawing.Point(314, 5);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(60, 56);
            this.Ellipse.TabIndex = 20;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // button_Fill
            // 
            this.button_Fill.Location = new System.Drawing.Point(380, 5);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(60, 56);
            this.button_Fill.TabIndex = 21;
            this.button_Fill.Text = "Fill";
            this.button_Fill.UseVisualStyleBackColor = true;
            this.button_Fill.Click += new System.EventHandler(this.button_Fill_Click);
            // 
            // OnlyBordres
            // 
            this.OnlyBordres.Location = new System.Drawing.Point(690, 7);
            this.OnlyBordres.Name = "OnlyBordres";
            this.OnlyBordres.Size = new System.Drawing.Size(92, 23);
            this.OnlyBordres.TabIndex = 22;
            this.OnlyBordres.Text = "OnlyBordres";
            this.OnlyBordres.UseVisualStyleBackColor = true;
            this.OnlyBordres.Click += new System.EventHandler(this.OnlyBordres_Click);
            // 
            // FillAndBorders
            // 
            this.FillAndBorders.Location = new System.Drawing.Point(690, 36);
            this.FillAndBorders.Name = "FillAndBorders";
            this.FillAndBorders.Size = new System.Drawing.Size(92, 23);
            this.FillAndBorders.TabIndex = 23;
            this.FillAndBorders.Text = "FillAndBorders";
            this.FillAndBorders.UseVisualStyleBackColor = true;
            this.FillAndBorders.Click += new System.EventHandler(this.FillAndBorders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FillAndBorders);
            this.Controls.Add(this.OnlyBordres);
            this.Controls.Add(this.button_Fill);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Violet);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.trackBarSizBrush);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSizBrush)).EndInit();
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
    }
}

