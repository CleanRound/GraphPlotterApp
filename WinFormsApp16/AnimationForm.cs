using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp16
{
    public partial class AnimationForm : Form
    {
        private System.Windows.Forms.Timer animationTimer;
        private int xCoord = -300;

        public AnimationForm()
        {
            InitializeComponent();
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 50;
            animationTimer.Tick += AnimationTick;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void AnimationTick(object sender, EventArgs e)
        {
            xCoord += 5;
            if (xCoord > this.ClientSize.Width / 2)
            {
                animationTimer.Stop();
                xCoord = -300;
            }
            this.Invalidate();
        }

        private void AnimationForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen graphPen = new Pen(Color.Red, 2);

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            g.TranslateTransform(centerX, centerY);

            g.DrawLine(Pens.Black, -centerX, 0, centerX, 0);
            g.DrawLine(Pens.Black, 0, -centerY, 0, centerY);

            for (int x = -300; x < xCoord - 1; x++)
            {
                float y1 = (float)Math.Sin(x / 20.0) * 50;
                float y2 = (float)Math.Sin((x + 1) / 20.0) * 50;
                g.DrawLine(graphPen, x, -y1, x + 1, -y2);
            }
        }
    }
}
