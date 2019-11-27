namespace Drawing
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
            this.button1 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Red = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Aqua = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Violet = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.brushes = new System.Windows.Forms.Button();
            this.Rictangle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1346, 624);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(198, 13);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(145, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(522, 32);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(25, 26);
            this.Red.TabIndex = 3;
            this.Red.UseVisualStyleBackColor = false;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Orange.Location = new System.Drawing.Point(460, 2);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(25, 26);
            this.Orange.TabIndex = 4;
            this.Orange.UseVisualStyleBackColor = false;
            this.Orange.Click += new System.EventHandler(this.Orange_Click);
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(491, 2);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(25, 26);
            this.Yellow.TabIndex = 5;
            this.Yellow.UseVisualStyleBackColor = false;
            this.Yellow.Click += new System.EventHandler(this.Yellow_Click);
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(522, 2);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(25, 26);
            this.Green.TabIndex = 6;
            this.Green.UseVisualStyleBackColor = false;
            this.Green.Click += new System.EventHandler(this.Green_Click);
            // 
            // Aqua
            // 
            this.Aqua.BackColor = System.Drawing.Color.Aqua;
            this.Aqua.Location = new System.Drawing.Point(429, 32);
            this.Aqua.Name = "Aqua";
            this.Aqua.Size = new System.Drawing.Size(25, 26);
            this.Aqua.TabIndex = 7;
            this.Aqua.UseVisualStyleBackColor = false;
            this.Aqua.Click += new System.EventHandler(this.Aqua_Click);
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(460, 32);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(25, 26);
            this.Blue.TabIndex = 8;
            this.Blue.UseVisualStyleBackColor = false;
            this.Blue.Click += new System.EventHandler(this.Blue_Click);
            // 
            // Violet
            // 
            this.Violet.BackColor = System.Drawing.Color.Violet;
            this.Violet.Location = new System.Drawing.Point(491, 32);
            this.Violet.Name = "Violet";
            this.Violet.Size = new System.Drawing.Size(25, 26);
            this.Violet.TabIndex = 9;
            this.Violet.UseVisualStyleBackColor = false;
            this.Violet.Click += new System.EventHandler(this.Violet_Click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(429, 2);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(25, 26);
            this.Black.TabIndex = 10;
            this.Black.UseVisualStyleBackColor = false;
            this.Black.Click += new System.EventHandler(this.Black_Click);
            // 
            // brushes
            // 
            this.brushes.BackColor = System.Drawing.Color.Aqua;
            this.brushes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.brushes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.brushes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.brushes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.brushes.ImageKey = "(none)";
            this.brushes.Location = new System.Drawing.Point(360, 2);
            this.brushes.Name = "brushes";
            this.brushes.Size = new System.Drawing.Size(63, 56);
            this.brushes.TabIndex = 11;
            this.brushes.Text = "Brush";
            this.brushes.UseVisualStyleBackColor = false;
            this.brushes.Click += new System.EventHandler(this.brushes_Click);
            // 
            // Rictangle
            // 
            this.Rictangle.BackColor = System.Drawing.Color.Aqua;
            this.Rictangle.Location = new System.Drawing.Point(553, 5);
            this.Rictangle.Name = "Rictangle";
            this.Rictangle.Size = new System.Drawing.Size(75, 53);
            this.Rictangle.TabIndex = 12;
            this.Rictangle.Text = "Rictangle";
            this.Rictangle.UseVisualStyleBackColor = false;
            this.Rictangle.Click += new System.EventHandler(this.Rictangle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.BackColor = System.Drawing.Color.Aqua;
            this.Ellipse.Location = new System.Drawing.Point(634, 4);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(75, 53);
            this.Ellipse.TabIndex = 13;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = false;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 690);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Rictangle);
            this.Controls.Add(this.brushes);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.Violet);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Aqua);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Aqua;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Violet;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button brushes;
        private System.Windows.Forms.Button Rictangle;
        private System.Windows.Forms.Button Ellipse;
    }
}

