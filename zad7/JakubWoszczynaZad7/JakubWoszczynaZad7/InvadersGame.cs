using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;


namespace JakubWoszczynaZad7
{
    public partial class InvadersGame : Form
    {
        /// <summary>
        /// Zmienna potrzebna do połączenia z bazą dnayhc przy pomocy LINQ
        /// </summary>
        DataJakubWoszczynaZad7DataContext context;

        int playerId;

        bool isLost = false;
        Random rnd = new Random();

        int speed = 1;
        int frequencyOfObstacles = 15;
        int temp = 0;
        int score = 0;


        public InvadersGame(int id, DataJakubWoszczynaZad7DataContext c)
        {
            InitializeComponent();
            timerMain.Interval = speed;
            //SetCursorPos(100, 100);
            Cursor.Position = new Point(500,730);
            playerId = id;
            context = c;
        }

        /// <summary>
        /// Zmienna ustawiająca pictureBoxPlayer(statek kosmczny) względem myszy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelScreen_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBoxPlayer.Top = e.Y;
            pictureBoxPlayer.Left = e.X;
        }

        /// <summary>
        /// Metoda obsługująca taktowanie timera, reagowanie na kolizje oraz sprawdzanie przegranej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            temp++;
            if (temp % frequencyOfObstacles == 0)
            {
                GenerateObstacle();

                ++score;
                labelScore.Text = "Score: " + score;
            }

            foreach (Control x in panelScreen.Controls)
            {
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Top+=1;

                    if (pictureBoxPlayer.Bounds.IntersectsWith(x.Bounds))
                    {
                        isLost = true;
                    }

                    //if (x.Top >= panelScreen.Height)
                    //{
                    //    x.Top = 0;
                    //    x.Location = new Point(rnd.Next(0, panelScreen.Width), 0);
                    //}

                }
            }

            if (isLost)
            {
                timerMain.Stop();

                MessageBox.Show("Game over");
                //isLost = false;
            }


        }

        /// <summary>
        /// Metoda generująca nowe przeszkody(asteroidy)
        /// </summary>
        void GenerateObstacle()
        {

            PictureBox pic1 = new PictureBox();


            pic1.Image = global::JakubWoszczynaZad7.Properties.Resources.asteroid;
            pic1.BackColor = Color.Transparent;
            pic1.Location = new Point(rnd.Next(0, panelScreen.Width), 0);
            //pic1.Name = "pic1";
            pic1.Size = new Size(44, 36);
            pic1.TabIndex = 120;
            pic1.TabStop = false;
            pic1.Tag = "obstacle";

            panelScreen.Controls.Add(pic1);
        }

        /// <summary>
        /// Metoda dodająca punkty gracza do bazy danych po zakonczeniu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InvadersGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            JakubWoszczyna_Score sc = (from element in context.JakubWoszczyna_Scores
                                       where element.ID == playerId
                                       select element).FirstOrDefault();

            sc.PointsNumber += score;

            context.SubmitChanges();
        }
    }
}
