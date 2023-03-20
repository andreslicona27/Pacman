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
        bool group;
        bool goUp;
        bool goDown;
        bool goRigth;
        bool goLeft;
        bool gameOver;
        int score;
        int playerSpeed;
        int redGhostSpeed;
        int yellowGhostSpeed;
        int pinkGhost1;
        int pinkGhost2;
        public Form1()
        {
            InitializeComponent();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            
        }

        

    }
}
