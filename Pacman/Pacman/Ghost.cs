using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    internal class Enemy
    {
        private PictureBox ghost;
        public PictureBox Ghost
        {
            set { ghost = value; }
            get { return ghost; } 
        }

        private int directionX;
        public int DirectionX
        {
            set{ directionX = value;}
            get { return directionX; }
        }

        private int directionY;
        public int DirectionY
        {
            set { directionY = value; }
            get { return directionY; }
        }

        private int speed;
        public int Speed
        {
            set { speed = value; }
            get { return speed; }
        }

        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Enemy(PictureBox ghost, string name)
        {
            this.ghost = ghost;
            this.name = name;
            this.speed = 5;
            directionX = 1;
            directionY = 1;
        }

    }
}
