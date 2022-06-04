using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKP_V1
{
    public partial class Form1 : Form
    {
        const double b = 1;
        private Pen axisPen = new Pen(Color.Black);
        private Pen borderPen = new Pen(Color.Black);
        private Pen gridPen = new Pen(Color.LightGray);
        private Pen tickPen = new Pen(Color.Black);
        private Pen linePen = new Pen(Color.Teal);
        private Brush textBrush = Brushes.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int axisOffset = 20;
            int h = pictureBox1.Height - axisOffset;
            int w = pictureBox1.Width - axisOffset;
            int tick = 5;
            Font tickFont = Font;
            int scale = trackBar1.Value * 5;
            Graphics g = e.Graphics;

            g.Clear(pictureBox1.BackColor);

            g.TranslateTransform(axisOffset, 0);
            int xt = 0;
            for (int x = w / 2; x < w; x += scale) {
                g.DrawLine(gridPen, x, 0, x, h);
                g.DrawLine(gridPen, w - x, 0, w - x, h);

                g.DrawLine(tickPen, x, 0, x, tick);
                g.DrawLine(tickPen, w - x, 0, w - x, tick);

                g.DrawLine(tickPen, x, h, x, h - tick);
                g.DrawLine(tickPen, w - x, h, w - x, h - tick);

                float tw = g.MeasureString(xt.ToString(), tickFont).Width;
                g.DrawString(xt.ToString(), tickFont, textBrush, x - tw / 2, h);
                tw = g.MeasureString((-xt).ToString(), tickFont).Width;
                g.DrawString((-xt).ToString(), tickFont, textBrush, w - x - tw / 2, h);
                xt++;
            }
            int yt = 0;
            for (int y = h / 2; y < h; y += scale)
            {
                g.DrawLine(gridPen, 0, y, w, y);
                g.DrawLine(gridPen, 0, h - y, w, h - y);

                g.DrawLine(tickPen, 0, y, tick, y);
                g.DrawLine(tickPen, 0, h - y, tick, h - y);

                g.DrawLine(tickPen, w, y, w - tick, y);
                g.DrawLine(tickPen, w, h - y, w - tick, h - y);

                g.DrawString((-yt).ToString(), tickFont, textBrush, -axisOffset, y - tickFont.Height / 2);
                g.DrawString(yt.ToString(), tickFont, textBrush, -axisOffset, h - y - tickFont.Height / 2);
                yt++;
            }
            g.ResetTransform();

            g.TranslateTransform(axisOffset + w / 2, h / 2);
            g.SetClip(new Rectangle(-w / 2, -h / 2, w, h));
            var points = new List<PointF>();
            for (double t = 0; t < 2 * Math.PI; t += Math.PI / 720)
            {
                points.Add(new PointF((float)getX(t) * scale, (float)getY(t) * scale));
            }
            g.DrawLines(linePen, points.ToArray());
            g.ResetTransform();
            g.ResetClip();

            g.DrawRectangle(borderPen, axisOffset, 0, w - borderPen.Width, h);
        }

        private double getX(double t)
        {
            return 2 * (double)numericUpDown1.Value * Math.Pow(Math.Cos(t), 2) + b * Math.Cos(t);
        }

        private double getY(double t)
        {
            return 2 * (double)numericUpDown1.Value * Math.Sin(t) * Math.Cos(t) + b * Math.Sin(t);
        }
    }
}
