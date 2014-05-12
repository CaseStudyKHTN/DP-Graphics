using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureDraw.Shape
{
    class MyEllipse: Shape
    {
        public MyEllipse(float x, float y, float width, float height) : base(x, y, width, height) { }

        public override void Draw(Lib.IDraw drawer)
        {
            drawer.DrawEllipse(info[0], info[1], info[2], info[3]);
        }
    }
}
