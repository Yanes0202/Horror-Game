using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horror_Game.Views
{
    public partial class Game : UserControl
    {
        bool goLeft, goRight, goUp, goDown, hasKey;

        int playerSpeed = 8;
        int score = 0;
        public Game(MainScreen gamescreen)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public void Proba()
        {
            lblCheck.Text = "W";
        }

       private void KeyIsDown(object sender, KeyEventArgs e)
        {
            
            
            if(e.KeyCode == Keys.A)
            {
                goLeft = true;
                lblCheck.Text = "A";
            }
            if(e.KeyCode == Keys.D)
            {
                goRight = true;
                lblCheck.Text = "D";
            }
            if(e.KeyCode == Keys.W)
            {
                goUp = true;
                lblCheck.Text = "W";
            }
            if(e.KeyCode == Keys.S)
            {
                goDown = true;
                lblCheck.Text = "W";
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

        }
    }
}
