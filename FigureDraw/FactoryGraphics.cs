using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigureDraw.Lib;

namespace FigureDraw
{
    class FactoryGraphics
    {
        private static List<Shape.Shape> listShape = new List<Shape.Shape>();

        Exporter export;
        // them phan tu
        public void addShape(Shape.Shape shape)
        {
            listShape.Add(shape);
        }

        // xoa phan tu cuoi
        public void removeLastShape()
        {
            listShape.Remove(listShape[listShape.Count - 1]);
        }

        public void SavePNG(IDraw draw, String filename)
        {
            export = new PNGExporter(draw, listShape);
            export.Save(filename);
        }

        public void SaveJPG(IDraw draw, String filename)
        {
            export = new JPGExporter(draw, listShape);
            export.Save(filename);
        }
    }
}
