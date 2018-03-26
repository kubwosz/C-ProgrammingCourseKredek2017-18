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
    public partial class DropDown : Form
    {
        /// <summary>
        /// Zmienna potrzebna do technologii LINQ
        /// </summary>
        DataJakubWoszczynaZad7DataContext context;

        /// <summary>
        /// zmienna z ID gracza
        /// </summary>
        int playerId;
        
        //Zmienne potrzebne do funkcjonowania gry
        Random rnd = new Random();
        int gravity = 8;
        int score = 0;
        int speed = 12;

        bool moveLeft = false;
        bool moveRight = false;


        public DropDown(int id, DataJakubWoszczynaZad7DataContext c)
        {
            InitializeComponent();

            playerId = id;
            context = c;
        }

        /// <summary>
        /// Metoda obsługująca timer, polecenia wykonują się z każdym taktem timera.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playTimer_Tick(object sender, EventArgs e)
        {
            pictureBoxPlayer.Top += gravity;
            //pictureBoxPlayer.Top += 20;
            labelScore.Text = "Score: " + score;

            if(moveLeft && pictureBoxPlayer.Left > 1) { pictureBoxPlayer.Left -= speed; }

            if (moveRight && pictureBoxPlayer.Left + pictureBoxPlayer.Width < panelScreen.Width) { pictureBoxPlayer.Left += speed; }

            foreach(Control x in panelScreen.Controls)
            {
                if(x is PictureBox && x.Tag == "platform")
                {
                    x.Top -= 2;

                    if(x.Top < panelScreen.Top - x.Height)
                    {
                        x.Top = panelScreen.Height + x.Height;

                        x.Width = rnd.Next(100, 400);

                        score++;
                    }

                    if (pictureBoxPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        gravity = 0;

                        pictureBoxPlayer.Top = x.Top - pictureBoxPlayer.Height;
                    }
                    else
                    {
                        gravity = 8;
                    }
                }
            }

            if(pictureBoxPlayer.Top + pictureBoxPlayer.Height<0 || pictureBoxPlayer.Top > panelScreen.Height)
            {
                timerMain.Stop();
            }
        }

        /// <summary>
        /// Metoda obslugująca zdarzenie, gdy przycisk na klawiaturze jest wciśnięty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { moveLeft = true; }
            if (e.KeyCode == Keys.Right) { moveRight = true; }
        }
        /// <summary>
        /// Metoda obslugująca zdarzenie, gdy przycisk na klawiaturze został puszczony
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) { moveLeft = false; }
            if (e.KeyCode == Keys.Right) { moveRight = false; }
        }

        private void DropDown_FormClosed(object sender, FormClosedEventArgs e)
        {
            JakubWoszczyna_Score sc = (from element in context.JakubWoszczyna_Scores
                                       where element.ID == playerId
                                       select element).FirstOrDefault();

            sc.PointsNumber += score;

            context.SubmitChanges();
        }
    }
}
