namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            player = new PictureBox();
            obstacle1 = new PictureBox();
            obstacle2 = new PictureBox();
            txtScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 418);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(838, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.BackgroundImageLayout = ImageLayout.Stretch;
            player.Image = Properties.Resources.running;
            player.Location = new Point(67, 337);
            player.Name = "player";
            player.Size = new Size(66, 75);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // obstacle1
            // 
            obstacle1.BackColor = Color.Transparent;
            obstacle1.BackgroundImage = (Image)resources.GetObject("obstacle1.BackgroundImage");
            obstacle1.BackgroundImageLayout = ImageLayout.Stretch;
            obstacle1.Location = new Point(566, 363);
            obstacle1.Name = "obstacle1";
            obstacle1.Size = new Size(54, 57);
            obstacle1.TabIndex = 2;
            obstacle1.TabStop = false;
            obstacle1.Tag = "obstacle";
            obstacle1.Click += obstacle1_Click;
            // 
            // obstacle2
            // 
            obstacle2.BackColor = Color.Transparent;
            obstacle2.BackgroundImage = (Image)resources.GetObject("obstacle2.BackgroundImage");
            obstacle2.BackgroundImageLayout = ImageLayout.Stretch;
            obstacle2.Location = new Point(658, 363);
            obstacle2.Name = "obstacle2";
            obstacle2.Size = new Size(29, 57);
            obstacle2.TabIndex = 3;
            obstacle2.TabStop = false;
            obstacle2.Tag = "obstacle";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.Location = new Point(0, -2);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(90, 22);
            txtScore.TabIndex = 4;
            txtScore.Text = "Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 466);
            Controls.Add(pictureBox1);
            Controls.Add(txtScore);
            Controls.Add(obstacle2);
            Controls.Add(obstacle1);
            Controls.Add(player);
            Name = "Form1";
            Text = " ";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox player;
        private PictureBox obstacle1;
        private PictureBox obstacle2;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}