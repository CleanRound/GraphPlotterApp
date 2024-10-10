namespace WinFormsApp16
{
    partial class Form1
    {
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openAnimationForm;
        private ToolStripMenuItem openPrimitivesForm;

        private void InitializeComponent()
        {
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.openAnimationForm = new ToolStripMenuItem();
            this.openPrimitivesForm = new ToolStripMenuItem();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";

            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.openAnimationForm,
            this.openPrimitivesForm});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";

            // 
            // openAnimationForm
            // 
            this.openAnimationForm.Name = "openAnimationForm";
            this.openAnimationForm.Size = new Size(180, 22);
            this.openAnimationForm.Text = "Open Animation";
            this.openAnimationForm.Click += new EventHandler(this.openAnimationForm_Click);

            // 
            // openPrimitivesForm
            // 
            this.openPrimitivesForm.Name = "openPrimitivesForm";
            this.openPrimitivesForm.Size = new Size(180, 22);
            this.openPrimitivesForm.Text = "Open Primitives";
            this.openPrimitivesForm.Click += new EventHandler(this.openPrimitivesForm_Click);

            // 
            // Form1
            // 
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graph Plotter";
            this.Paint += new PaintEventHandler(this.Form1_Paint);
        }
    }
}
