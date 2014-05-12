using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureDraw.Lib
{
    abstract class Exporter
    {
        protected IDraw drawer;
        protected List<Shape.Shape> listShape;

        public Exporter(IDraw draw, List<Shape.Shape> list)
        {
            drawer = draw;
            listShape = list;
        }

        public abstract void Save(String filename);
    }
}
