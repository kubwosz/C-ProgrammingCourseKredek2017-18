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
    public partial class Castle : Form
    {
        /// <summary>
        /// Metoda rozpoczynająca nowego okna otwieranego przy kupnie zamku
        /// </summary>
        public Castle()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda opisująca działanie w przypadku kupna zamku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// Metoda opisująca działanie programu w przypadku zaniechania kupna zamku
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
