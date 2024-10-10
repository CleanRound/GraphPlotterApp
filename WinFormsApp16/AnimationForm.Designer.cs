namespace WinFormsApp16
{ 
    partial class AnimationForm
    {
        private Button startButton;

        private void InitializeComponent()
        {
            this.startButton = new Button();
            this.SuspendLayout();

            // 
            // startButton
            // 
            this.startButton.Location = new Point(350, 500);
            this.startButton.Name = "startButton";
            this.startButton.Size = new Size(100, 30);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start Animation";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new EventHandler(this.startButton_Click);

            // 
            // AnimationForm
            // 
            this.ClientSize = new Size(800, 600);
            this.Controls.Add(this.startButton);
            this.Name = "AnimationForm";
            this.Text = "Graph Animation";
            this.Paint += new PaintEventHandler(this.AnimationForm_Paint);
            this.ResumeLayout(false);
        }
    }
}
