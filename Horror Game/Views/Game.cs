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
        bool goLeft, goRight, goUp, goDown;

        int playerSpeed = 12;

        MainScreen menu;

        private void MainTimeEvent(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score;
            if(goLeft==true && Player.Left > -15)
            {
                Player.Left -= playerSpeed;
            }
            if(goRight==true && Player.Left + Player.Width-15 < this.ClientSize.Width)
            {
                Player.Left += playerSpeed;
            }
            if(goDown==true && Player.Top + Player.Height  < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }
            if (goUp == true && Player.Top-10>0)
            {
                Player.Top -= playerSpeed;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Ghost")
                {
                    if(Player.Bounds.IntersectsWith(x.Bounds)&&x.Visible ==true)
                    {
                        x.Visible = false;
                        score += 1;
                    }
                }
                x.BringToFront();
                                        
            }
            if(score==10)
            {
                score = 0;
                restartGame();
            }

        }

        int score = 0;
        public Game(MainScreen gamescreen)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        

       private void KeyIsDown(object sender, KeyEventArgs e)
        {
            
            
            if(e.KeyCode == Keys.A && e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.D && e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if(e.KeyCode == Keys.W && e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.S && e.KeyCode == Keys.Down)
            {
                goDown = true;
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
        /*private void MoveGameElements(string direction)
        {
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag=="Ghost")
                {
                    
                }
            }
        } Do późniejszego rozważenia w kwestii poruszania elementów*/
        private void restartGame()
        {
            MessageBox.Show("Gratulacje Udało ci się ukończyć grę!"+Environment.NewLine+"Kliknij OK aby zagrać ponownie");
            this.Hide();

        }
    }
}
