
namespace WinFormsApp16
{
    public partial class PrimitivesForm : Form
    {
        public PrimitivesForm()
        {
            InitializeComponent();
        }

        private void PrimitivesForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Red, 50, 50, 100, 100);
            g.DrawEllipse(Pens.Blue, 200, 50, 150, 100);
            g.FillEllipse(Brushes.Green, 400, 50, 100, 100);
            g.DrawRectangle(Pens.Purple, 100, 200, 200, 150);
            g.FillPolygon(Brushes.Orange, new Point[]
            {
                new Point(500, 200),
                new Point(600, 300),
                new Point(400, 300)
            });
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                this.BackgroundImage = image;
            }
        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG Image|*.png|JPEG Image|*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(saveFileDialog.FileName);
            }
        }
    }
}

