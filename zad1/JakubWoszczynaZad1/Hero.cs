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
    public partial class Hero : Form
    {
        /// <summary>
        /// Metoda rozpoczynająca pracę nowego okna w przypadku chęci kupna nowego bohatera
        /// </summary>
        public Hero()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda opisująca działanie programu w przypadku chęci zakupienia bohatera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        /// Metoda opisująca działanie programu w przypadku zaniechania kupna bohatera
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
