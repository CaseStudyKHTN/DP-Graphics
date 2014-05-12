using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FigureDraw.Lib;

namespace FigureDraw.Shape
{
    abstract class Shape
    {
        protected List<float> info = new List<float>();

        public Shape(float x1, float y1, float width, float height)
        {
            info.Add(x1);
            info.Add(y1);
            info.Add(width);
            info.Add(height);
        }

        public abstract void Draw(FigureDraw.Lib.IDraw drawer);

    }
}
