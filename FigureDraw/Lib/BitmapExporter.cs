using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FigureDraw.Lib
{
    abstract class BitmapExporter: Exporter
    {
        protected Bitmap bitmap;
        protected Graphics g;

        public BitmapExporter(IDraw draw, List<Shape.Shape> list) : base(draw, list)
        {
            bitmap = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024),
                           System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            g = Graphics.FromImage(bitmap);
            drawer.setGraphics(g);
        }
    }
}
