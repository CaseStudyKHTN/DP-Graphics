using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;
namespace FigureDraw.Lib
{
    public class CairoAdapter : IDraw
    {
        Context context;
        public CairoAdapter(System.Drawing.Graphics graphic)
        {
            Surface surface = new Win32Surface(graphic.GetHdc());
            this.context = new Context(surface);
            context.LineWidth = 2;
            context.Color = new Color(1, 0, 0);
        }

        public void setGraphics(System.Drawing.Graphics g)
        {
            Surface surface = new Win32Surface(g.GetHdc());
            this.context = new Context(surface);
        }

        public void DrawRectangle(float x, float y, float width, float height)
        {
            this.context.Rectangle(x, y, width, height);
            this.context.Stroke();
        }

        public void DrawLine(float x1, float y1, float x2, float y2)
        {
            context.MoveTo(x1, y1);
            context.LineTo(x2, y2);
            context.Stroke();
        }

        public void DrawEllipse(float x, float y, float width, float height)
        {
            context.Scale(width / height, height / height);
            context.Arc(x - width / 8, y + height / 2, (width < height ? width : height) / 2, 0, 2 * Math.PI);
            context.Stroke();
        }
    }
}
