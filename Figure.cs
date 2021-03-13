using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    abstract class Figure
    {
        public Color penColor;
        public Color brushColor;
        public int penWidth;

        public void SetPenColor(Color color)
        {
            penColor = color;
        }
        public void SetBrushColor(Color color)
        {
            brushColor = color;
        }
        public void SetPenWidth(int value)
        {
            penWidth = value;
        }

        public abstract void Draw();
    }
}
