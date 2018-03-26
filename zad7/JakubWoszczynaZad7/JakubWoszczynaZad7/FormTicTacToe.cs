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
    public partial class FormTicTacToe : Form
    {
        //Zmienne potrzebne do gry
        Graph engine;
        Board theBoard;
        int count = 0;
        int moves = 0;

        /// <summary>
        /// Zmienna mówiąca czy gra została skonczona
        /// </summary>
        bool isWin = false;

        public FormTicTacToe()
        {
            InitializeComponent();
            timerMain.Start();
        }
        
        /// <summary>
        /// Metda rysująca, za pomocą narzędzi grafinczych, tabelę wykorzystaną do gry w kółko i krzyżyk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTicTacToe_Paint(object sender, PaintEventArgs e)
        {
            Graphics toPass = panelTicTacToe.CreateGraphics();
            engine = new Graph(toPass);
           
            theBoard = new Board();
            theBoard.InitBoard();
    }
        /// <summary>
        /// Metoda obsługująca klikanie na tabelę z kółkiem i krzyżykiem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelTicTacToe_Click(object sender, EventArgs e)
        {
            Point mouse = Cursor.Position;
            mouse = panelTicTacToe.PointToClient(mouse);

            theBoard.DetectHit(mouse);
            if (theBoard.DetectHit(mouse) == true)
            {
                isWin = true;
                pictureBoxX.Visible = false;
                pictureBoxO.Visible = false;
            }

            if (moves < 8 && isWin == false)
            {
                if (moves % 2 == 0)
                {
                    pictureBoxO.Visible = false;
                    pictureBoxX.Visible = true;
                }
                else
                {
                    pictureBoxX.Visible = false;
                    pictureBoxO.Visible = true;
                }
                moves++;
            }
            else
            {
                pictureBoxX.Visible = false;
                pictureBoxO.Visible = false;
                if (isWin == false)
                {
                    MessageBox.Show("Remis!");
                }
            }

        }
        /// <summary>
        /// Metoda obsługująca timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            labelCountTime.Text = (count++).ToString();
        }

        /// <summary>
        /// Metoda włączająca od nowa grę w kólko i krzyżyk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRestart_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTicTacToe ticTacToe = new FormTicTacToe();
            ticTacToe.Show();
        }
    }
}
