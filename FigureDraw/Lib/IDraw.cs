using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureDraw.Lib
{
    public interface IDraw
    {
        void DrawRectangle(float x, float y, float width, float height);
        void DrawLine(float x1, float y1, float x2, float y2);
        void DrawEllipse(float x, float y, float width, float height);
        void setGraphics(System.Drawing.Graphics g);
    }
}
