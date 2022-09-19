using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawEllipse(pen, 0, 0, 100, 100);
        }

        private void pictureBoxRectagle_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawRectangle(pen, 0, 0, 100, 100);
            e.Graphics.DrawLine(pen, 0, 0, 100, 100);
        }

        private void pictureBoxSin_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);


            float x1 = 0;
            float y1 = 0;

            float y2 = 0;

            float yEx = 75;
            float eF = 15;

            for (float x = 0; x < Width; x += 0.00005F)
            {
                y2 = (float)(Math.Sin(x));
                y2 *= 1;

                e.Graphics.DrawLine(pen, x1 * eF, y1 * eF + yEx, x * eF, y2 * eF + yEx);
                x1 = x;
                y1 = y2;
            }
        }

        private void trackBarCircle_Scroll(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black);     
            pictureBoxCircle.CreateGraphics().Clear(Color.White);
            pictureBoxCircle.CreateGraphics().DrawEllipse(pen, 0, 0, 50, 50);
        }
    }
}
