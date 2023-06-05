namespace T_Rex_Endless_Runner_Game
{
    partial class TRex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScoreLabel = new System.Windows.Forms.Label();
            this.trexPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScoreLabel
            // 
            this.txtScoreLabel.AutoSize = true;
            this.txtScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreLabel.Location = new System.Drawing.Point(12, 33);
            this.txtScoreLabel.Name = "txtScoreLabel";
            this.txtScoreLabel.Size = new System.Drawing.Size(104, 29);
            this.txtScoreLabel.TabIndex = 0;
            this.txtScoreLabel.Text = "Score- 0";
            // 
            // trexPictureBox
            // 
            this.trexPictureBox.BackColor = System.Drawing.Color.White;
            this.trexPictureBox.Image = global::T_Rex_Endless_Runner_Game.Properties.Resources.running;
            this.trexPictureBox.Location = new System.Drawing.Point(114, 461);
            this.trexPictureBox.Name = "trexPictureBox";
            this.trexPictureBox.Size = new System.Drawing.Size(40, 43);
            this.trexPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.trexPictureBox.TabIndex = 1;
            this.trexPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::T_Rex_Endless_Runner_Game.Properties.Resources.obstacle_2;
            this.pictureBox2.Location = new System.Drawing.Point(571, 471);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "obstacle";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = global::T_Rex_Endless_Runner_Game.Properties.Resources.obstacle_1;
            this.pictureBox3.Location = new System.Drawing.Point(376, 458);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "obstacle";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(-45, 500);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(776, 81);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimerEvent);
            // 
            // TRex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 531);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trexPictureBox);
            this.Controls.Add(this.txtScoreLabel);
            this.Name = "TRex";
            this.Text = "Trex Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.trexPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScoreLabel;
        private System.Windows.Forms.PictureBox trexPictureBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer gameTimer;
    }
}

