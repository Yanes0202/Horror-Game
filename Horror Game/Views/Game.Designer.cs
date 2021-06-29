
namespace Horror_Game.Views
{
    partial class Game
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
       
        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblScore = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Ghost3 = new System.Windows.Forms.PictureBox();
            this.Ghost4 = new System.Windows.Forms.PictureBox();
            this.Ghost9 = new System.Windows.Forms.PictureBox();
            this.Ghost2 = new System.Windows.Forms.PictureBox();
            this.Ghost6 = new System.Windows.Forms.PictureBox();
            this.Ghost5 = new System.Windows.Forms.PictureBox();
            this.Ghost8 = new System.Windows.Forms.PictureBox();
            this.Ghost1 = new System.Windows.Forms.PictureBox();
            this.Ghost10 = new System.Windows.Forms.PictureBox();
            this.Ghost7 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.DimGray;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(0, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(57, 16);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: ";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimeEvent);
            // 
            // Ghost3
            // 
            this.Ghost3.Image = global::Horror_Game.Properties.Resources.ghost;
            this.Ghost3.InitialImage = global::Horror_Game.Properties.Resources.ghost1;
            this.Ghost3.Location = new System.Drawing.Point(0, 38);
            this.Ghost3.Name = "Ghost3";
            this.Ghost3.Size = new System.Drawing.Size(35, 38);
            this.Ghost3.TabIndex = 11;
            this.Ghost3.TabStop = false;
            this.Ghost3.Tag = "Ghost";
            // 
            // Ghost4
            // 
            this.Ghost4.Image = global::Horror_Game.Properties.Resources.ghost;
            this.Ghost4.Location = new System.Drawing.Point(337, 3);
            this.Ghost4.Name = "Ghost4";
            this.Ghost4.Size = new System.Drawing.Size(41, 37);
            this.Ghost4.TabIndex = 10;
            this.Ghost4.TabStop = false;
            this.Ghost4.Tag = "Ghost";
            // 
            // Ghost9
            // 
            this.Ghost9.Image = global::Horror_Game.Properties.Resources.ghost11;
            this.Ghost9.Location = new System.Drawing.Point(443, 405);
            this.Ghost9.Name = "Ghost9";
            this.Ghost9.Size = new System.Drawing.Size(40, 43);
            this.Ghost9.TabIndex = 9;
            this.Ghost9.TabStop = false;
            this.Ghost9.Tag = "Ghost";
            // 
            // Ghost2
            // 
            this.Ghost2.Image = global::Horror_Game.Properties.Resources.ghost;
            this.Ghost2.Location = new System.Drawing.Point(267, 180);
            this.Ghost2.Name = "Ghost2";
            this.Ghost2.Size = new System.Drawing.Size(39, 38);
            this.Ghost2.TabIndex = 8;
            this.Ghost2.TabStop = false;
            this.Ghost2.Tag = "Ghost";
            // 
            // Ghost6
            // 
            this.Ghost6.Image = global::Horror_Game.Properties.Resources.ghost11;
            this.Ghost6.Location = new System.Drawing.Point(651, 259);
            this.Ghost6.Name = "Ghost6";
            this.Ghost6.Size = new System.Drawing.Size(37, 37);
            this.Ghost6.TabIndex = 7;
            this.Ghost6.TabStop = false;
            this.Ghost6.Tag = "Ghost";
            // 
            // Ghost5
            // 
            this.Ghost5.Image = global::Horror_Game.Properties.Resources.ghost11;
            this.Ghost5.Location = new System.Drawing.Point(650, 0);
            this.Ghost5.Name = "Ghost5";
            this.Ghost5.Size = new System.Drawing.Size(38, 38);
            this.Ghost5.TabIndex = 6;
            this.Ghost5.TabStop = false;
            this.Ghost5.Tag = "Ghost";
            // 
            // Ghost8
            // 
            this.Ghost8.Image = global::Horror_Game.Properties.Resources.ghost;
            this.Ghost8.Location = new System.Drawing.Point(288, 382);
            this.Ghost8.Name = "Ghost8";
            this.Ghost8.Size = new System.Drawing.Size(37, 42);
            this.Ghost8.TabIndex = 5;
            this.Ghost8.TabStop = false;
            this.Ghost8.Tag = "Ghost";
            // 
            // Ghost1
            // 
            this.Ghost1.Image = global::Horror_Game.Properties.Resources.ghost;
            this.Ghost1.Location = new System.Drawing.Point(-1, 232);
            this.Ghost1.Name = "Ghost1";
            this.Ghost1.Size = new System.Drawing.Size(36, 34);
            this.Ghost1.TabIndex = 4;
            this.Ghost1.TabStop = false;
            this.Ghost1.Tag = "Ghost";
            // 
            // Ghost10
            // 
            this.Ghost10.Image = global::Horror_Game.Properties.Resources.ghost11;
            this.Ghost10.Location = new System.Drawing.Point(624, 394);
            this.Ghost10.Name = "Ghost10";
            this.Ghost10.Size = new System.Drawing.Size(41, 38);
            this.Ghost10.TabIndex = 3;
            this.Ghost10.TabStop = false;
            this.Ghost10.Tag = "Ghost";
            // 
            // Ghost7
            // 
            this.Ghost7.Image = global::Horror_Game.Properties.Resources.ghost11;
            this.Ghost7.Location = new System.Drawing.Point(488, 232);
            this.Ghost7.Name = "Ghost7";
            this.Ghost7.Size = new System.Drawing.Size(37, 44);
            this.Ghost7.TabIndex = 2;
            this.Ghost7.TabStop = false;
            this.Ghost7.Tag = "Ghost";
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.ErrorImage = null;
            this.Player.Image = global::Horror_Game.Properties.Resources.jason_horror_human_icon_156895;
            this.Player.InitialImage = null;
            this.Player.Location = new System.Drawing.Point(22, 394);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(69, 54);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.Ghost3);
            this.Controls.Add(this.Ghost4);
            this.Controls.Add(this.Ghost9);
            this.Controls.Add(this.Ghost2);
            this.Controls.Add(this.Ghost6);
            this.Controls.Add(this.Ghost5);
            this.Controls.Add(this.Ghost8);
            this.Controls.Add(this.Ghost1);
            this.Controls.Add(this.Ghost10);
            this.Controls.Add(this.Ghost7);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.Player);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(688, 483);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ghost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ghost7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Ghost7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox Ghost10;
        private System.Windows.Forms.PictureBox Ghost1;
        private System.Windows.Forms.PictureBox Ghost8;
        private System.Windows.Forms.PictureBox Ghost5;
        private System.Windows.Forms.PictureBox Ghost6;
        private System.Windows.Forms.PictureBox Ghost2;
        private System.Windows.Forms.PictureBox Ghost9;
        private System.Windows.Forms.PictureBox Ghost4;
        private System.Windows.Forms.PictureBox Ghost3;
    }
}
