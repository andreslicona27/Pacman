namespace Pacman
{
    partial class Form1
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
            this.lblScore = new System.Windows.Forms.Label();
            this.pbWall1 = new System.Windows.Forms.PictureBox();
            this.pbWall4 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pbWall3 = new System.Windows.Forms.PictureBox();
            this.pbWall2 = new System.Windows.Forms.PictureBox();
            this.pbPacman = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(61, 20);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // pbWall1
            // 
            this.pbWall1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbWall1.Location = new System.Drawing.Point(12, 32);
            this.pbWall1.Name = "pbWall1";
            this.pbWall1.Size = new System.Drawing.Size(700, 10);
            this.pbWall1.TabIndex = 1;
            this.pbWall1.TabStop = false;
            this.pbWall1.Tag = "wall";
            // 
            // pbWall4
            // 
            this.pbWall4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbWall4.Location = new System.Drawing.Point(12, 32);
            this.pbWall4.Name = "pbWall4";
            this.pbWall4.Size = new System.Drawing.Size(10, 500);
            this.pbWall4.TabIndex = 4;
            this.pbWall4.TabStop = false;
            this.pbWall4.Tag = "wall";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // pbWall3
            // 
            this.pbWall3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbWall3.Location = new System.Drawing.Point(12, 522);
            this.pbWall3.Name = "pbWall3";
            this.pbWall3.Size = new System.Drawing.Size(700, 10);
            this.pbWall3.TabIndex = 6;
            this.pbWall3.TabStop = false;
            this.pbWall3.Tag = "wall";
            // 
            // pbWall2
            // 
            this.pbWall2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbWall2.Location = new System.Drawing.Point(704, 32);
            this.pbWall2.Name = "pbWall2";
            this.pbWall2.Size = new System.Drawing.Size(10, 500);
            this.pbWall2.TabIndex = 8;
            this.pbWall2.TabStop = false;
            this.pbWall2.Tag = "wall";
            // 
            // pbPacman
            // 
            this.pbPacman.Image = global::Pacman.Properties.Resources.right;
            this.pbPacman.Location = new System.Drawing.Point(312, 233);
            this.pbPacman.Name = "pbPacman";
            this.pbPacman.Size = new System.Drawing.Size(40, 40);
            this.pbPacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPacman.TabIndex = 10;
            this.pbPacman.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(731, 543);
            this.ControlBox = false;
            this.Controls.Add(this.pbPacman);
            this.Controls.Add(this.pbWall2);
            this.Controls.Add(this.pbWall3);
            this.Controls.Add(this.pbWall4);
            this.Controls.Add(this.pbWall1);
            this.Controls.Add(this.lblScore);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "wall";
            this.Text = "Pacman";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPacman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbWall1;
        private System.Windows.Forms.PictureBox pbWall4;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pbWall3;
        private System.Windows.Forms.PictureBox pbWall2;
        private System.Windows.Forms.PictureBox pbPacman;
    }
}

