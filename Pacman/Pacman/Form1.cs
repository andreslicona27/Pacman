using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        // Game Properties 
        int score;
        PictureBox coin = new PictureBox();
        List<Enemy> ghosts = new List<Enemy>();
        Random rand = new Random();
        Image[] ghostImages =
            {
                Properties.Resources.red_guy,
                Properties.Resources.yellow_guy,
                Properties.Resources.pink_guy
            };

        // Pacman Properties
        bool goUp;
        bool goDown;
        bool goRight;
        bool goLeft;
        int pacmanSpeed = 8;


        public Form1()
        {
            InitializeComponent();

            // Coin creation
            coin.Tag = "coin";
            coin.Name = "Coin";
            coin.Size = new Size(20, 20);
            coin.Image = Properties.Resources.coin;
            coin.SizeMode = PictureBoxSizeMode.StretchImage;
            coin.Location = new Point(rand.Next(30, 671), rand.Next(50, 470));
            Controls.Add(coin);

            ResetGame();
        }

        /// <summary>
        /// Get the keycode and sets the corresponding variable to true 
        /// </summary>
        /// <param name="sender">the component that sends the event</param>
        /// <param name="e">information of the key that has been pressed</param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    goUp = true;
                    break;
                case Keys.Down:
                    goDown = true;
                    break;
                case Keys.Right:
                    goRight = true;
                    break;
                case Keys.Left:
                    goLeft = true;
                    break;
            }
        }

        /// <summary>
        /// Get the keycode and sets the corresponding variable to false 
        /// </summary>
        /// <param name="sender">the component that sends the event</param>
        /// <param name="e">information of the key that has been pressed</param>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    goUp = false;
                    break;
                case Keys.Down:
                    goDown = false;
                    break;
                case Keys.Right:
                    goRight = false;
                    break;
                case Keys.Left:
                    goLeft = false;
                    break;
                case Keys.Enter:
                    ResetGame();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGameTimer(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;

            PacmanMovement();
            PacmanTouchManagement();
            GhostMovement();
        }

        /// <summary>
        /// Manage what happens when the pacman touch other element 
        /// </summary>
        private void PacmanTouchManagement()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if ((string)control.Tag == "coin" && control.Visible == true)
                    {
                        if (pbPacman.Bounds.IntersectsWith(control.Bounds))
                        {
                            score += 10;
                            coin.Location = new Point(rand.Next(30, 671), rand.Next(50, 470));
                            GhostCreation();
                        }
                    }

                    if ((string)control.Tag == "wall")
                    {
                        if (pbPacman.Bounds.IntersectsWith(control.Bounds))
                        {
                            GameOver("You Lose! You crash against the the wall");
                        }
                    }

                    if ((string)control.Tag == "ghost")
                    {
                        if (pbPacman.Bounds.IntersectsWith(control.Bounds))
                        {
                            GameOver("You Lose! You get touch by the ghost!");
                        }

                    }
                }
            }
        }

        /// <summary>
        /// Manage the movement of the pacman
        /// </summary>
        private void PacmanMovement()
        {
            if (goUp)
            {
                pbPacman.Top -= pacmanSpeed;
                pbPacman.Image = Properties.Resources.Up;
            }
            if (goDown)
            {
                pbPacman.Top += pacmanSpeed;
                pbPacman.Image = Properties.Resources.down;
            }
            if (goRight)
            {
                pbPacman.Left += pacmanSpeed;
                pbPacman.Image = Properties.Resources.right;
            }
            if (goLeft)
            {
                pbPacman.Left -= pacmanSpeed;
                pbPacman.Image = Properties.Resources.left;
            }
        }

        /// <summary>
        /// Manage the movement of the ghosts
        /// </summary>
        private void GhostMovement()
        {
            int positionX;
            int positionY;
            foreach (Enemy ghost in ghosts)
            {
                positionX = ghost.Ghost.Location.X + (ghost.Speed * ghost.DirectionX);
                positionY = ghost.Ghost.Location.Y + (ghost.Speed * ghost.DirectionY);
                ghost.Ghost.Location = new Point(positionX, positionY);

                if (ghost.Ghost.Bounds.IntersectsWith(pbWall2.Bounds) ||
                    ghost.Ghost.Bounds.IntersectsWith(pbWall4.Bounds))
                {
                    ghost.DirectionX *= -1;
                }
                if (ghost.Ghost.Bounds.IntersectsWith(pbWall1.Bounds) ||
                    ghost.Ghost.Bounds.IntersectsWith(pbWall3.Bounds))
                {
                    ghost.DirectionY *= -1;
                }
            }
        }

        int i = 0;
        /// <summary>
        /// Basic code for the creation of each ghost and the addition of that ghost to the colection
        /// </summary>
        private void GhostCreation()
        {
            PictureBox newGhost = new PictureBox();
            newGhost.Tag = "ghost";
            newGhost.Name = "G" + i;
            newGhost.Size = new Size(25, 40);
            newGhost.SizeMode = PictureBoxSizeMode.StretchImage;
            newGhost.Image = ghostImages[rand.Next(0, ghostImages.Length)];
            newGhost.Location = new Point(rand.Next(30, 671), rand.Next(50, 470));

            this.Controls.Add(newGhost);
            Enemy ghost = new Enemy(newGhost, newGhost.Name);
            ghosts.Add(ghost);
            i++;
        }

        /// <summary>
        /// Restarts the game 
        /// </summary>
        private void ResetGame()
        {
            score = 0;
            lblScore.Text = "Score: " + score;

            pbPacman.Image = Properties.Resources.right;
            pbPacman.Left = this.Width / 2;
            pbPacman.Top = this.Height / 2;

            foreach (Enemy ghost in ghosts)
            {
                this.Controls.Remove(ghost.Ghost);
            }
            ghosts.Clear();

            GhostCreation();
            gameTimer.Start();
        }

        /// <summary>
        /// Ends the game and shows you a final message 
        /// </summary>
        /// <param name="message">the message you show to the player when he losses</param>
        private void GameOver(string message)
        {
            gameTimer.Stop();
            lblScore.Text = String.Format($"Score: {score} \t {message}");
        }
    }
}
