using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace Paint
{
    class Pen : InkCanvas
    {
        public void SetCanvasAttributes(Color color, int value)
        {
            DefaultDrawingAttributes.Color = color;
            DefaultDrawingAttributes.Width = value + 1;
            DefaultDrawingAttributes.Height = value + 1;
        }
    }
}
