using Horror_Game.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Horror_Game
{
    public partial class MainScreen : Form
    {
        Game _greetScreen;
        Game _proba;
        public MainScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _greetScreen = new Game(this);
            Controls.Add(_greetScreen);
            _greetScreen.BringToFront();
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                _proba.Proba();
            }
        }
    }
}
