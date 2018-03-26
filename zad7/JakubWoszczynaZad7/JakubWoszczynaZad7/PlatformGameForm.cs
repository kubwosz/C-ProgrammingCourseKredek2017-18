using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubWoszczynaZad7
{
    public partial class PlatformGameForm : Form
    {
        /// <summary>
        /// zmienna potrzebna do połączenia z bazą danych w techn LINQ
        /// </summary>
        DataJakubWoszczynaZad7DataContext context;

        int playerId;
       // string playerName;

        bool goLeft = false;
        bool goRight = false;
        bool jump = false;
        bool obstacle = false;

        bool isWin=false;

        int force = 0;
        int jumpSpeed = 12;
        int g = 8;
        int score = 0;

        public PlatformGameForm(int id, DataJakubWoszczynaZad7DataContext c )
        {
            InitializeComponent();

            // playerName = name;
            playerId = id;
            context = c;
 
        }

        /// <summary>
        /// MEtoda obsługująca gdy przycisk na klawiaturze został wciśnięty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goLeft = true; }

            if (e.KeyCode == Keys.Right) { goRight = true; }

            if (e.KeyCode == Keys.Space && !jump && obstacle)
            {
                jump = true;
                force = g;
            }
        }
        /// <summary>
        /// MEtoda obsługująca gdy przycisk na klawiaturze został puszczony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { goLeft = false; }

            if (e.KeyCode == Keys.Right) { goRight = false; }

            if (jump)
            {
                //jump = false;
            }
        }

        /// <summary>
        /// Metoda obsługująca taktowanie timera, spadania gracza, skakanie itp., kolizje, zbieranie monet, koniec gry...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {

            pictureBoxPlayer.Top += 5;


            if (goLeft)
            {
                pictureBoxPlayer.Left -= 5;
            }

            if (goRight)
            {
                pictureBoxPlayer.Left += 5;
            }

            if (jump && force < 0 )
            {
                jump = false;
                obstacle = false;
            }

            if (jump && obstacle)
            {
                jumpSpeed = -12;
                pictureBoxPlayer.Top += jumpSpeed;
                //Opadanie
                pictureBoxPlayer.Top -= force;
                force -= 1;
            }
            else
            {
                
                jumpSpeed = 12;
                //obstacle = false;
            }



            if (pictureBoxPlayer.Left <= 0)
            {
                pictureBoxPlayer.Left = 0;
            }

            if (pictureBoxPlayer.Left >= panelScreen.Width - pictureBoxPlayer.Width)
            {
                pictureBoxPlayer.Left = panelScreen.Width - pictureBoxPlayer.Width;
            }


            foreach (Control x in panelScreen.Controls)
            {
                if (x is PictureBox && x.Tag == "platform")
                {
                    if (pictureBoxPlayer.Bounds.IntersectsWith(x.Bounds) && !jump)
                    {
                        force = g;
                        pictureBoxPlayer.Top = x.Top - pictureBoxPlayer.Height;
                        obstacle = true;
                        jump = false;
                    }

                }

                if (x is PictureBox && x.Tag == "coin")
                {
                    if (pictureBoxPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        x.Visible = false;
                            ++score;

                            labelScore.Text = "Score: " + score;
                    }

                }

                if (x is PictureBox && x.Tag == "door")
                {
                    if (pictureBoxPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        timerMain.Stop();
                        isWin = true;
                        MessageBox.Show("Gratulacje! \n Koniec gry!");
                    }
                }
            }
        }

        /// <summary>
        /// Metoda wykonująca sie po zamknięciu gry, uaktualniająca punkty gracza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlatformGameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isWin) {
            JakubWoszczyna_Score sc = (from element in context.JakubWoszczyna_Scores
                                       where element.ID == playerId
                                       select element).FirstOrDefault();

            sc.PointsNumber += score;

            context.SubmitChanges();
        }

        }
    }
}
