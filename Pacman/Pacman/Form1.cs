using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        // Game Properties 
        int score;
        bool gameOver;

        // Pacman Properties
        bool goUp;
        bool goDown;
        bool goRight;
        bool goLeft;
        int pacmanSpeed;

        int redGhostSpeed;
        int yellowGhostSpeed;
        int pinkGhost1;
        int pinkGhost2;

        public Form1()
        {
            InitializeComponent();
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
                            score += 1;
                            control.Visible = false;
                        }
                    }

                    if ((string)control.Tag == "wall")
                    {
                        if (pbPacman.Bounds.IntersectsWith(control.Bounds))
                        {
                            GameOver("You Lose!");
                        }
                    }

                    if ((string)control.Tag == "ghost")
                    {
                        if (pbPacman.Bounds.IntersectsWith(control.Bounds))
                        {
                            GameOver("You Lose! You get touch by the enemy!");
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
            //redGhost.Left += redGhostSpeed;

            //if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds) || redGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            //{
            //    redGhostSpeed = -redGhostSpeed;
            //}

            //yellowGhost.Left -= yellowGhostSpeed;

            //if (yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds) || yellowGhost.Bounds.IntersectsWith(pictureBox4.Bounds))
            //{
            //    yellowGhostSpeed = -yellowGhostSpeed;
            //}


            //pinkGhost.Left -= pinkGhostX;
            //pinkGhost.Top -= pinkGhostY;


            //if (pinkGhost.Top < 0 || pinkGhost.Top > 520)
            //{
            //    pinkGhostY = -pinkGhostY;
            //}

            //if (pinkGhost.Left < 0 || pinkGhost.Left > 620)
            //{
            //    pinkGhostX = -pinkGhostX;
            //}
        }

        /// <summary>
        /// Restarts the game 
        /// </summary>
        private void ResetGame()
        {
            gameOver = false;
            score = 0;
            lblScore.Text = "Score: " + score;

            redGhostSpeed = 5;
            yellowGhostSpeed = 5;
            pinkGhost1 = 5;
            pinkGhost2 = 5;
            pacmanSpeed = 8;

            pbPacman.Left = this.Width / 2;
            pbPacman.Top = this.Height / 2;


            // We add all the components to the game 
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    control.Visible = true;
                }
            }
            gameTimer.Start();
        }

        /// <summary>
        /// Ends the game and shows you a final message 
        /// </summary>
        /// <param name="message">the message you show to the player when he losses</param>
        private void GameOver(string message)
        {
            gameOver = true;
            gameTimer.Stop();
            lblScore.Text = String.Format($"Score: {score} \t {message}");
        }
    }
}
