using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Drawing
{
    public class Brush
    {
        Color color = Color.Black;
        Bitmap bitMap;


        int size;

        public Color COlor { set { color = value; } }
        public int Size { set { size = value; } }
        public Brush(Bitmap bitMap, Color color, int size)
        {
            this.bitMap = bitMap;
            this.color = color;
            this.size = size;
        }
        private void DrawLine(int x1, int y1, double w, double h, int start, double end, double speed)
        {
           
           
            for (int i = start; i <= end; i++)
            {
                int x, y;
                if (Math.Abs(h) >= Math.Abs(w))
                {
                        x = Convert.ToInt32(i * speed);
                        y = i;
                }
                else
                {
                        y = Convert.ToInt32(i * speed);
                        x = i;
                }
                DrawSize((x + x1), (y + y1));

            }

        }
        private void DrawSize(int x, int y)
        {

            int radius = size;
            for (int i = 0; i<size; i++)
            {
                int currentX = i;
                int currentY_x = Convert.ToInt32(Math.Sqrt(Math.Pow(radius, 2) - Math.Pow(currentX, 2)));

                for (int j = 0; j<currentY_x; j++)
                {
                    if (x + currentX < bitMap.Width && y + j < bitMap.Height && x + currentX > 0 && y + j > 0)
                        bitMap.SetPixel(x + currentX, y + j, color);
                    if (x - currentX < bitMap.Width && y + j < bitMap.Height && x - currentX > 0 && y + j > 0)
                        bitMap.SetPixel(x - currentX, y + j, color);
                    if (x - currentX < bitMap.Width && y - j < bitMap.Height && x - currentX > 0 && y - j > 0)
                        bitMap.SetPixel(x - currentX, y - j, color);
                    if (x + currentX < bitMap.Width && y - j < bitMap.Height && x + currentX > 0 && y - j > 0)
                        bitMap.SetPixel(x + currentX, y - j, color);
                }
            }
        }
        
        public Bitmap DrawLine(int x1, int y1, int x2, int y2)
        {
            double w = x2 - x1;
            double h = y2 - y1;
            int start = 0;
            double end = 0;
            double big = (Math.Abs(h) >= Math.Abs(w)) ? h : w;
            double small = (Math.Abs(h) >= Math.Abs(w)) ? w : h;
            double speed = big != 0 ? small / big : 1;

            if (big >= 0)
            {
                end = big;
            }
            else
            {
                start = Convert.ToInt32(big);
            }

            DrawLine(x1, y1, w, h, start, end, speed);

            return bitMap;
        }

    }
}
