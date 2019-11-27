using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Drawing
{
    class Rictangle
    {
        Bitmap bitMap;
        Brush line;

        Color color;
        int size;

        public Rictangle(Bitmap bitMap, Color color, int size)
        {
            Rectangle rec = new Rectangle(0, 0, bitMap.Width, bitMap.Height);

            this.bitMap = bitMap.Clone(rec, System.Drawing.Imaging.PixelFormat.DontCare);
            this.color = color;
            this.size = size;
        }

        public Bitmap DrawRectagle(int x1, int y1, int x2, int y2)
        {
            line = new Brush(bitMap, color, size);
            line.DrawLine(x1, y1, x1, y2);
            line.DrawLine(x1, y1, x2, y1);
            line.DrawLine(x1, y2, x2, y2);
            line.DrawLine(x2, y1, x2, y2);

            return bitMap;
        }

    }
}
