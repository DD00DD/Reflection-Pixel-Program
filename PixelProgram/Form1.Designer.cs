namespace PixelProgram
{
    partial class PixelProgram
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
            this.picPixel = new System.Windows.Forms.PictureBox();
            this.grpColours = new System.Windows.Forms.GroupBox();
            this.rdbRandColour = new System.Windows.Forms.RadioButton();
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.rdbPink = new System.Windows.Forms.RadioButton();
            this.rdbPurple = new System.Windows.Forms.RadioButton();
            this.rdbYellow = new System.Windows.Forms.RadioButton();
            this.rdbGreen = new System.Windows.Forms.RadioButton();
            this.rdbBlue = new System.Windows.Forms.RadioButton();
            this.rdbRed = new System.Windows.Forms.RadioButton();
            this.grpShapes = new System.Windows.Forms.GroupBox();
            this.rdbRandShape = new System.Windows.Forms.RadioButton();
            this.rdbArrow = new System.Windows.Forms.RadioButton();
            this.rdbHexagon = new System.Windows.Forms.RadioButton();
            this.rdbTrapezoid = new System.Windows.Forms.RadioButton();
            this.rdbRhombus = new System.Windows.Forms.RadioButton();
            this.rdbParallelogram = new System.Windows.Forms.RadioButton();
            this.rdbTriangle = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbSquare = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpDrawingType = new System.Windows.Forms.GroupBox();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbLines = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPixel)).BeginInit();
            this.grpColours.SuspendLayout();
            this.grpShapes.SuspendLayout();
            this.grpDrawingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPixel
            // 
            this.picPixel.Location = new System.Drawing.Point(12, 12);
            this.picPixel.Name = "picPixel";
            this.picPixel.Size = new System.Drawing.Size(457, 480);
            this.picPixel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPixel.TabIndex = 0;
            this.picPixel.TabStop = false;
            // 
            // grpColours
            // 
            this.grpColours.Controls.Add(this.rdbRandColour);
            this.grpColours.Controls.Add(this.rdbWhite);
            this.grpColours.Controls.Add(this.rdbBlack);
            this.grpColours.Controls.Add(this.rdbPink);
            this.grpColours.Controls.Add(this.rdbPurple);
            this.grpColours.Controls.Add(this.rdbYellow);
            this.grpColours.Controls.Add(this.rdbGreen);
            this.grpColours.Controls.Add(this.rdbBlue);
            this.grpColours.Controls.Add(this.rdbRed);
            this.grpColours.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColours.Location = new System.Drawing.Point(488, 12);
            this.grpColours.Name = "grpColours";
            this.grpColours.Size = new System.Drawing.Size(157, 276);
            this.grpColours.TabIndex = 0;
            this.grpColours.TabStop = false;
            this.grpColours.Text = "Colours";
            // 
            // rdbRandColour
            // 
            this.rdbRandColour.AutoSize = true;
            this.rdbRandColour.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRandColour.Location = new System.Drawing.Point(19, 238);
            this.rdbRandColour.Name = "rdbRandColour";
            this.rdbRandColour.Size = new System.Drawing.Size(136, 20);
            this.rdbRandColour.TabIndex = 8;
            this.rdbRandColour.Text = "Random Colour";
            this.rdbRandColour.UseVisualStyleBackColor = true;
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWhite.Location = new System.Drawing.Point(19, 212);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(68, 20);
            this.rdbWhite.TabIndex = 7;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBlack.Location = new System.Drawing.Point(19, 186);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(65, 20);
            this.rdbBlack.TabIndex = 6;
            this.rdbBlack.TabStop = true;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            // 
            // rdbPink
            // 
            this.rdbPink.AutoSize = true;
            this.rdbPink.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPink.Location = new System.Drawing.Point(19, 160);
            this.rdbPink.Name = "rdbPink";
            this.rdbPink.Size = new System.Drawing.Size(56, 20);
            this.rdbPink.TabIndex = 5;
            this.rdbPink.TabStop = true;
            this.rdbPink.Text = "Pink";
            this.rdbPink.UseVisualStyleBackColor = true;
            // 
            // rdbPurple
            // 
            this.rdbPurple.AutoSize = true;
            this.rdbPurple.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPurple.Location = new System.Drawing.Point(19, 134);
            this.rdbPurple.Name = "rdbPurple";
            this.rdbPurple.Size = new System.Drawing.Size(72, 20);
            this.rdbPurple.TabIndex = 4;
            this.rdbPurple.TabStop = true;
            this.rdbPurple.Text = "Purple";
            this.rdbPurple.UseVisualStyleBackColor = true;
            // 
            // rdbYellow
            // 
            this.rdbYellow.AutoSize = true;
            this.rdbYellow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbYellow.Location = new System.Drawing.Point(19, 108);
            this.rdbYellow.Name = "rdbYellow";
            this.rdbYellow.Size = new System.Drawing.Size(74, 20);
            this.rdbYellow.TabIndex = 3;
            this.rdbYellow.TabStop = true;
            this.rdbYellow.Text = "Yellow";
            this.rdbYellow.UseVisualStyleBackColor = true;
            // 
            // rdbGreen
            // 
            this.rdbGreen.AutoSize = true;
            this.rdbGreen.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGreen.Location = new System.Drawing.Point(19, 82);
            this.rdbGreen.Name = "rdbGreen";
            this.rdbGreen.Size = new System.Drawing.Size(69, 20);
            this.rdbGreen.TabIndex = 2;
            this.rdbGreen.TabStop = true;
            this.rdbGreen.Text = "Green";
            this.rdbGreen.UseVisualStyleBackColor = true;
            // 
            // rdbBlue
            // 
            this.rdbBlue.AutoSize = true;
            this.rdbBlue.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBlue.Location = new System.Drawing.Point(19, 56);
            this.rdbBlue.Name = "rdbBlue";
            this.rdbBlue.Size = new System.Drawing.Size(58, 20);
            this.rdbBlue.TabIndex = 1;
            this.rdbBlue.TabStop = true;
            this.rdbBlue.Text = "Blue";
            this.rdbBlue.UseVisualStyleBackColor = true;
            // 
            // rdbRed
            // 
            this.rdbRed.AutoSize = true;
            this.rdbRed.Checked = true;
            this.rdbRed.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRed.Location = new System.Drawing.Point(19, 30);
            this.rdbRed.Name = "rdbRed";
            this.rdbRed.Size = new System.Drawing.Size(53, 20);
            this.rdbRed.TabIndex = 0;
            this.rdbRed.TabStop = true;
            this.rdbRed.Text = "Red";
            this.rdbRed.UseVisualStyleBackColor = true;
            // 
            // grpShapes
            // 
            this.grpShapes.Controls.Add(this.rdbRandShape);
            this.grpShapes.Controls.Add(this.rdbArrow);
            this.grpShapes.Controls.Add(this.rdbHexagon);
            this.grpShapes.Controls.Add(this.rdbTrapezoid);
            this.grpShapes.Controls.Add(this.rdbRhombus);
            this.grpShapes.Controls.Add(this.rdbParallelogram);
            this.grpShapes.Controls.Add(this.rdbTriangle);
            this.grpShapes.Controls.Add(this.rdbRectangle);
            this.grpShapes.Controls.Add(this.rdbSquare);
            this.grpShapes.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpShapes.Location = new System.Drawing.Point(651, 12);
            this.grpShapes.Name = "grpShapes";
            this.grpShapes.Size = new System.Drawing.Size(157, 276);
            this.grpShapes.TabIndex = 1;
            this.grpShapes.TabStop = false;
            this.grpShapes.Text = "Shapes";
            // 
            // rdbRandShape
            // 
            this.rdbRandShape.AutoSize = true;
            this.rdbRandShape.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRandShape.Location = new System.Drawing.Point(19, 238);
            this.rdbRandShape.Name = "rdbRandShape";
            this.rdbRandShape.Size = new System.Drawing.Size(134, 20);
            this.rdbRandShape.TabIndex = 8;
            this.rdbRandShape.Text = "Random Shape";
            this.rdbRandShape.UseVisualStyleBackColor = true;
            // 
            // rdbArrow
            // 
            this.rdbArrow.AutoSize = true;
            this.rdbArrow.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbArrow.Location = new System.Drawing.Point(19, 212);
            this.rdbArrow.Name = "rdbArrow";
            this.rdbArrow.Size = new System.Drawing.Size(69, 20);
            this.rdbArrow.TabIndex = 7;
            this.rdbArrow.TabStop = true;
            this.rdbArrow.Text = "Arrow";
            this.rdbArrow.UseVisualStyleBackColor = true;
            // 
            // rdbHexagon
            // 
            this.rdbHexagon.AutoSize = true;
            this.rdbHexagon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHexagon.Location = new System.Drawing.Point(19, 186);
            this.rdbHexagon.Name = "rdbHexagon";
            this.rdbHexagon.Size = new System.Drawing.Size(91, 20);
            this.rdbHexagon.TabIndex = 6;
            this.rdbHexagon.TabStop = true;
            this.rdbHexagon.Text = "Hexagon";
            this.rdbHexagon.UseVisualStyleBackColor = true;
            // 
            // rdbTrapezoid
            // 
            this.rdbTrapezoid.AutoSize = true;
            this.rdbTrapezoid.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTrapezoid.Location = new System.Drawing.Point(19, 160);
            this.rdbTrapezoid.Name = "rdbTrapezoid";
            this.rdbTrapezoid.Size = new System.Drawing.Size(97, 20);
            this.rdbTrapezoid.TabIndex = 5;
            this.rdbTrapezoid.TabStop = true;
            this.rdbTrapezoid.Text = "Trapezoid";
            this.rdbTrapezoid.UseVisualStyleBackColor = true;
            // 
            // rdbRhombus
            // 
            this.rdbRhombus.AutoSize = true;
            this.rdbRhombus.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRhombus.Location = new System.Drawing.Point(19, 134);
            this.rdbRhombus.Name = "rdbRhombus";
            this.rdbRhombus.Size = new System.Drawing.Size(93, 20);
            this.rdbRhombus.TabIndex = 4;
            this.rdbRhombus.TabStop = true;
            this.rdbRhombus.Text = "Rhombus";
            this.rdbRhombus.UseVisualStyleBackColor = true;
            // 
            // rdbParallelogram
            // 
            this.rdbParallelogram.AutoSize = true;
            this.rdbParallelogram.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbParallelogram.Location = new System.Drawing.Point(19, 108);
            this.rdbParallelogram.Name = "rdbParallelogram";
            this.rdbParallelogram.Size = new System.Drawing.Size(127, 20);
            this.rdbParallelogram.TabIndex = 3;
            this.rdbParallelogram.TabStop = true;
            this.rdbParallelogram.Text = "Parallelogram";
            this.rdbParallelogram.UseVisualStyleBackColor = true;
            // 
            // rdbTriangle
            // 
            this.rdbTriangle.AutoSize = true;
            this.rdbTriangle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriangle.Location = new System.Drawing.Point(19, 82);
            this.rdbTriangle.Name = "rdbTriangle";
            this.rdbTriangle.Size = new System.Drawing.Size(84, 20);
            this.rdbTriangle.TabIndex = 2;
            this.rdbTriangle.TabStop = true;
            this.rdbTriangle.Text = "Triangle";
            this.rdbTriangle.UseVisualStyleBackColor = true;
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectangle.Location = new System.Drawing.Point(19, 56);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(98, 20);
            this.rdbRectangle.TabIndex = 1;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = true;
            // 
            // rdbSquare
            // 
            this.rdbSquare.AutoSize = true;
            this.rdbSquare.Checked = true;
            this.rdbSquare.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSquare.Location = new System.Drawing.Point(19, 30);
            this.rdbSquare.Name = "rdbSquare";
            this.rdbSquare.Size = new System.Drawing.Size(77, 20);
            this.rdbSquare.TabIndex = 0;
            this.rdbSquare.TabStop = true;
            this.rdbSquare.Text = "Square";
            this.rdbSquare.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoad.Font = new System.Drawing.Font("Verdana", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(488, 371);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(319, 120);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load Reflection";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // grpDrawingType
            // 
            this.grpDrawingType.Controls.Add(this.rdbLines);
            this.grpDrawingType.Controls.Add(this.rdbNormal);
            this.grpDrawingType.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDrawingType.Location = new System.Drawing.Point(488, 294);
            this.grpDrawingType.Name = "grpDrawingType";
            this.grpDrawingType.Size = new System.Drawing.Size(316, 71);
            this.grpDrawingType.TabIndex = 3;
            this.grpDrawingType.TabStop = false;
            this.grpDrawingType.Text = "Drawing Type";
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Checked = true;
            this.rdbNormal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNormal.Location = new System.Drawing.Point(50, 30);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(78, 20);
            this.rdbNormal.TabIndex = 9;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbLines
            // 
            this.rdbLines.AutoSize = true;
            this.rdbLines.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLines.Location = new System.Drawing.Point(195, 30);
            this.rdbLines.Name = "rdbLines";
            this.rdbLines.Size = new System.Drawing.Size(64, 20);
            this.rdbLines.TabIndex = 10;
            this.rdbLines.Text = "Lines";
            this.rdbLines.UseVisualStyleBackColor = true;
            // 
            // PixelProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(823, 504);
            this.Controls.Add(this.grpDrawingType);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpShapes);
            this.Controls.Add(this.grpColours);
            this.Controls.Add(this.picPixel);
            this.Name = "PixelProgram";
            this.Text = "Pixel Reflection";
            this.Load += new System.EventHandler(this.PixelProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPixel)).EndInit();
            this.grpColours.ResumeLayout(false);
            this.grpColours.PerformLayout();
            this.grpShapes.ResumeLayout(false);
            this.grpShapes.PerformLayout();
            this.grpDrawingType.ResumeLayout(false);
            this.grpDrawingType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPixel;
        private System.Windows.Forms.GroupBox grpColours;
        private System.Windows.Forms.RadioButton rdbGreen;
        private System.Windows.Forms.RadioButton rdbBlue;
        private System.Windows.Forms.RadioButton rdbRed;
        private System.Windows.Forms.RadioButton rdbWhite;
        private System.Windows.Forms.RadioButton rdbBlack;
        private System.Windows.Forms.RadioButton rdbPink;
        private System.Windows.Forms.RadioButton rdbPurple;
        private System.Windows.Forms.RadioButton rdbYellow;
        private System.Windows.Forms.GroupBox grpShapes;
        private System.Windows.Forms.RadioButton rdbArrow;
        private System.Windows.Forms.RadioButton rdbHexagon;
        private System.Windows.Forms.RadioButton rdbTrapezoid;
        private System.Windows.Forms.RadioButton rdbRhombus;
        private System.Windows.Forms.RadioButton rdbParallelogram;
        private System.Windows.Forms.RadioButton rdbTriangle;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbSquare;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RadioButton rdbRandColour;
        private System.Windows.Forms.RadioButton rdbRandShape;
        private System.Windows.Forms.GroupBox grpDrawingType;
        private System.Windows.Forms.RadioButton rdbLines;
        private System.Windows.Forms.RadioButton rdbNormal;
    }
}

