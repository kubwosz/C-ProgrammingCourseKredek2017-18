using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubWoszczynaZad7
{
    public partial class FormMenu : Form
    {
        /// <summary>
        /// Zmienna potrzebna do wykorzystania LINQ, przechowuje informację o połączniu z bazą danych
        /// </summary>
        DataJakubWoszczynaZad7DataContext context = new DataJakubWoszczynaZad7DataContext();

        string playerName;
        int playerId;

        //int score;
        

        public FormMenu(string name)
        {
            InitializeComponent();
            playerName = name;           

            labelPlayerName.Text = "Hello " + playerName + " !";

            playerId = AddPlayer();
        }

        /// <summary>
        /// Dodanie nowego gracza do bazy danych, metoda zwraca ID tego gracza
        /// </summary>
        /// <returns></returns>
        private int AddPlayer()
        {
            var score = new JakubWoszczyna_Score
            {
                PlayerName = playerName,
                PointsNumber = 0
            };

            context.JakubWoszczyna_Scores.InsertOnSubmit(score);
            context.SubmitChanges();

            return score.ID;
        }

        /// <summary>
        /// Metoda obsługująca przycisk, włączający grę kółko i krzyżyk
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayTicTacToe_Click(object sender, EventArgs e)
        {
            FormTicTacToe ticTacToe = new FormTicTacToe();
            ticTacToe.Show();
        }

        private void buttonInvadersGame_Click(object sender, EventArgs e)
        {
            InvadersGame invadersGame = new InvadersGame(playerId, context);
            invadersGame.Show();
        }


        /// <summary>
        /// Metoda obsługująca przycisk, włączająca grę platformową
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlayPlatform_Click(object sender, EventArgs e)
        {
            PlatformGameForm platformGame = new PlatformGameForm(playerId, context);
            platformGame.Show();
        }
        /// <summary>
        /// Metoda obsługująca przycisk, włączający grę typu dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDropDown_Click(object sender, EventArgs e)
        {
            DropDown dropDown = new DropDown(playerId, context);
            dropDown.Show();
        }
        /// <summary>
        /// Metoda osbługująca przycisk, który pokazuje tablicę wyników graczy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonScores_Click(object sender, EventArgs e)
        {
            Scores scores = new Scores();
            scores.Show();
        }
        /// <summary>
        /// Metoda obsługująca przycis, który pokazuje informacje o pomocy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeśli masz problemy, lub znalazłeś błąd w grze, napisz proszę na multigamecenter@mail.com");
        }
        /// <summary>
        /// Metoda obsługuąca przycisk, który pokazuje zasady gier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Możesz zagrać w cztery różne gry. \n " +
               "1)Kółko i krzyżyk \n" +
               "Twoim zadaniem jest ułożenie 3 symboli w obok siebie lub na skos, zanim zrobi to Twój przeciwnik \n " +
               "2)Gra Invaders \n" +
               "Twoim zadaniem jest unikanie nadlatujących asteroid, za każdą unikniętą asteroidę dostajesz punkty. \n " +
               "3)Gra platformowa \n" +
               "Twoim zadaniem jest dojście do brązowych dzwi. Poruszanie: Strzałki - Lewo,Prawo, Spacja - skok.  \n" +
               "4)Gra Dropdown \n" +
               "Twoim zadaniem jest zejście na niższą platformę, zanim dotrzesz do końca ekranu. Poruszanie: Strzałki - Lewo,Prawo \n "

               );
        }
    }
}
