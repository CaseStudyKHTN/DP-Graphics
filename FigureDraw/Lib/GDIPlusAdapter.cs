using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Lib
{
    public class GDIPlusAdapter : IDraw
    {
        System.Drawing.Graphics graphics;
        Pen pen;
        Color color = Color.Black;
        float penWidth = 2;

        public GDIPlusAdapter(Graphics g)
        {
            this.graphics = g;
            pen = new Pen(color);
            pen.Width = penWidth;
        }

        public void setGraphics(Graphics g)
        {
            this.graphics = g;
        }

        public void DrawRectangle(float x, float y, float width, float height)
        {
            Rectangle rec = new Rectangle((int)x, (int)y, (int)width, (int)height);
            this.graphics.DrawRectangle(pen, rec);
        }

        public void DrawLine(float x1, float y1, float x2, float y2)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }

        public void DrawEllipse(float x, float y, float width, float height)
        {
            Rectangle rec = new Rectangle((int)x, (int)y, (int)width, (int)height);
            graphics.DrawEllipse(pen, rec);
        }
    }
}
