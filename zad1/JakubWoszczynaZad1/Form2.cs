using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JakubWoszczynaZad1
{
    public partial class FormStart : Form
    {
        /// <summary>
        /// Metoda rozpoczynająca pracę nowego okna startowego gry
        /// </summary>
        public FormStart()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda opisująca działanie przycisku startu gry. Trzeba wpisać jakąś nazwę użytkownika, następnie otwierane jest nowe okno, 
        /// do którego przekazywana jest ta nazwa. W przypadku nie wpisania zostaje wyswietlona informacja
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text.Length > 0)
            {
                string username = textBoxLogin.Text;
                FormMain formMain = new FormMain(username);
                formMain.Show();
            }
            else
            {
                MessageBox.Show("Type youe user name!", "User name error");
            }
        }
        /// <summary>
        /// Metoda zamykająca okno w przypadku naciśnięcia przycisku zamykającego grę
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
