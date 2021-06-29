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
        Game game;
        
        
        public MainScreen()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game = new Game(this);
            Controls.Add(game);
            game.BringToFront();
        }

       
        
    }
}
