namespace WinFormsApp16
{
    partial class PrimitivesForm
    {
        private Button loadImage;
        private Button saveImage;

        private void InitializeComponent()
        {
            this.loadImage = new Button();
            this.saveImage = new Button();
            this.SuspendLayout();

            // 
            // loadImage
            // 
            this.loadImage.Location = new Point(50, 400);
            this.loadImage.Name = "loadImage";
            this.loadImage.Size = new Size(100, 30);
            this.loadImage.TabIndex = 0;
            this.loadImage.Text = "Load Image";
            this.loadImage.UseVisualStyleBackColor = true;
            this.loadImage.Click += new EventHandler(this.loadImage_Click);

            // 
            // saveImage
            // 
            this.saveImage.Location = new Point(200, 400);
            this.saveImage.Name = "saveImage";
            this.saveImage.Size = new Size(100, 30);
            this.saveImage.TabIndex = 1;
            this.saveImage.Text = "Save Image";
            this.saveImage.UseVisualStyleBackColor = true;
            this.saveImage.Click += new EventHandler(this.saveImage_Click);

            // 
            // PrimitivesForm
            // 
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.loadImage);
            this.Controls.Add(this.saveImage);
            this.Name = "PrimitivesForm";
            this.Text = "Primitives Drawing";
            this.Paint += new PaintEventHandler(this.PrimitivesForm_Paint);
            this.ResumeLayout(false);
        }
    }
}
