using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        Bitmap bitMap;
        Bitmap bitMaptmp;

        bool flagDownMouse = false;
        Char flagTool = '0';

        Brush brush;
        Rictangle rectangle;
        Ellipse ellipse;

        int size=1;
        Color color = Color.Black;

        int startX, startY;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            switch (flagTool)
            {
                case 'B':
                    {
                        if (flagDownMouse && e.Location.X < pictureBox1.Width && e.Location.Y < pictureBox1.Height
                        && e.Location.X >= 0 && e.Location.Y >= 0)
                        {
                            brush = new Brush(bitMap, color, size);
                            bitMap = brush.DrawLine(startX, startY, e.Location.X, e.Location.Y);
                            pictureBox1.Image = bitMap;
                            startX = e.Location.X;
                            startY = e.Location.Y;
                        }
                        break;
                    }
                case 'R':
                    {
                        if (flagDownMouse && e.Location.X < pictureBox1.Width && e.Location.Y < pictureBox1.Height
                        && e.Location.X >= 0 && e.Location.Y >= 0)
                        {
                            if (Control.ModifierKeys == Keys.Shift)
                            {
                                rectangle = new Rictangle(bitMap, color, size);
                                int y = e.Location.Y < startY? startY - Math.Abs(e.Location.X - startX): startY + Math.Abs(e.Location.X - startX);
                                if (y < pictureBox1.Height && y >= 0)
                                {
                                    bitMaptmp = rectangle.DrawRectagle(startX, startY, e.Location.X, y);
                                    pictureBox1.Image = bitMaptmp;
                                }
                            }
                            else
                            {
                                rectangle = new Rictangle(bitMap, color, size);
                                bitMaptmp = rectangle.DrawRectagle(startX, startY, e.Location.X, e.Location.Y);
                                pictureBox1.Image = bitMaptmp;
                            }
                        }
                        break;
                    }
                case 'E':
                    {
                        if (flagDownMouse && e.Location.X < pictureBox1.Width && e.Location.Y < pictureBox1.Height
                        && e.Location.X >= 0 && e.Location.Y >= 0)
                        {
                            ellipse = new Ellipse(bitMap, color, size);
                            bitMaptmp = ellipse.Draw(startX, startY, e.Location.X, e.Location.Y);
                            pictureBox1.Image = bitMaptmp;
                        }
                        break;
                    }
                default:
                    break;
                    

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bitMap;
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            flagDownMouse = true;
            startX = e.Location.X;
            startY = e.Location.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            flagDownMouse = false;
            if (flagTool == 'R' || flagTool == 'E')
            {
                bitMap = bitMaptmp;
                pictureBox1.Image = bitMap;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0:
                    size = 1;
                    break;
                case 1:
                    size = 2;
                    break;
                case 2:
                    size = 3;
                    break;
                case 3:
                    size = 4;
                    break;
                case 4:
                    size = 5;
                    break;
                case 5:
                    size = 6;
                    break;
                case 6:
                    size = 7;
                    break;
                case 7:
                    size = 8;
                    break;
                case 8:
                    size = 9;
                    break;
                case 9:
                    size = 10;
                    break;
                
            }
        }

        private void Black_Click(object sender, EventArgs e)
        {
           color = Color.Black;
        }

        private void Orange_Click(object sender, EventArgs e)
        {
            color = Color.Orange;
        }

        private void Yellow_Click(object sender, EventArgs e)
        {
            color = Color.Yellow;
        }

        private void Green_Click(object sender, EventArgs e)
        {
            color = Color.Green;
        }

        private void Aqua_Click(object sender, EventArgs e)
        {
            color = Color.Aqua;
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void Violet_Click(object sender, EventArgs e)
        {
            color = Color.Violet;
        }

        private void Red_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void brushes_Click(object sender, EventArgs e)
        {
            if(flagTool == 'B')
            {
                flagTool = '0';
            }
            else
            {
                flagTool = 'B';
            }
        }
        private void Rictangle_Click(object sender, EventArgs e)
        {
            if (flagTool == 'R')
            {
                flagTool = '0';
            }
            else
            {
                flagTool = 'R';
            }
        }


        private void Ellipse_Click(object sender, EventArgs e)
        {
            if (flagTool == 'E')
            {
                flagTool = '0';
            }
            else
            {
                flagTool = 'E';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitMap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            trackBar1.Value = 0;
            pictureBox1.Image = bitMap;
        }
    }
}
