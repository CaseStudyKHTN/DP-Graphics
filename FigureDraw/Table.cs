using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FigureDraw.Lib;
using FigureDraw.Shape;

namespace FigureDraw
{
    public partial class Table : Form
    {
        IDraw draw;
        FactoryGraphics listshapeGraphics = new FactoryGraphics();
        public Table()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);

            if(this.radioButton1.Checked)
                draw = new CairoAdapter(g);
            else
                draw = new GDIPlusAdapter(g);

            Random r = new Random();
            switch (r.Next(0, 5) % 3)
            { 
                case 0:
                    MyRectangle rect = new MyRectangle(100, 150, 50, 50);
                    listshapeGraphics.addShape(rect);
                    rect.Draw(draw);
                    break;
                case 1:
                    MyRectangle rect1 = new MyRectangle(300, 150, 150, 50);
                    rect1.Draw(draw);
                    listshapeGraphics.addShape(rect1);
                    break;
                case 2:
                    MyEllipse ellipse = new MyEllipse(150, 170, 200, 100);
                    listshapeGraphics.addShape(ellipse);
                    ellipse.Draw(draw);
                    break;
            }
        
            g.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "PNG Image|*.png|SVG Image|*.svg|JPeg Image|*.jpg|Bitmap Image|*.bmp";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listshapeGraphics.SavePNG(draw, saveFileDialog1.FileName);
            }

        }
    }
}
