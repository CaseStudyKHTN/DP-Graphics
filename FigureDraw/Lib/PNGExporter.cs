using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FigureDraw.Lib
{
    class PNGExporter: BitmapExporter
    {
        public PNGExporter(IDraw draw, List<Shape.Shape> list) : base(draw, list) { }

        public override void Save(String filename)
        {
            foreach (Shape.Shape shape in listShape)
            {
                shape.Draw(drawer);
            }

            bitmap.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
        }
    }
}
