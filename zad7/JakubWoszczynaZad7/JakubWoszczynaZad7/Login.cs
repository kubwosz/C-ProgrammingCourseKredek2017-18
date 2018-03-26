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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda obsługująca przycisk, który po kliknieciu prowadzi do Menu gry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu(textBoxPlayerName.Text);
            formMenu.Show();

            this.Hide();
        }
    }
}
