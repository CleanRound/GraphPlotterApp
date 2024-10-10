using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen redPen = new Pen(Color.Red, 2);
            Pen bluePen = new Pen(Color.Blue, 2);
            Pen greenPen = new Pen(Color.Green, 2);

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;

            g.TranslateTransform(centerX, centerY);

            g.DrawLine(Pens.Black, -centerX, 0, centerX, 0);
            g.DrawLine(Pens.Black, 0, -centerY, 0, centerY);

            for (int x = -300; x < 300; x++)
            {
                float y1 = (float)Math.Sin(x / 20.0) * 50;
                float y2 = (float)Math.Cos(x / 20.0) * 50;
                float y3 = (float)Math.Tan(x / 100.0) * 50;

                g.DrawLine(redPen, x, -y1, x + 1, -(float)Math.Sin((x + 1) / 20.0) * 50);
                g.DrawLine(bluePen, x, -y2, x + 1, -(float)Math.Cos((x + 1) / 20.0) * 50);
                g.DrawLine(greenPen, x, -y3, x + 1, -(float)Math.Tan((x + 1) / 100.0) * 50);
            }
        }

        private void DrawGraph(Graphics g, Pen pen, Func<float, float> func, int xMin, int xMax)
        {
            for (int x = xMin; x < xMax - 1; x++)
            {
                float y1 = func(x);
                float y2 = func(x + 1);
                g.DrawLine(pen, x, -y1, x + 1, -y2);
            }
        }

        private void openAnimationForm_Click(object sender, EventArgs e)
        {
            AnimationForm animationForm = new AnimationForm();
            animationForm.Show();
        }

        private void openPrimitivesForm_Click(object sender, EventArgs e)
        {
            PrimitivesForm primitivesForm = new PrimitivesForm();
            primitivesForm.Show();
        }
    }
}
