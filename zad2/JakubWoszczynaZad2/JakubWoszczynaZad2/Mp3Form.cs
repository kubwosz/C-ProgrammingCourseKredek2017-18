using System.Windows.Forms;

namespace JakubWoszczynaZad2
{
    public partial class Mp3Form : Form
    {
        public Mp3Form()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        /// <param name="diskSize"></param>
        /// <param name="formatsNumber"></param>
        /// <param name="fm"></param>
        /// <param name="miniJack"></param>
        /// <param name="timeOfPlaying"></param>
        public void FillDataGridView(/*int weight, int screenSize, bool bluetooth, */int diskSize, int formatsNumber, bool fm, bool miniJack, int timeOfPlaying)
        {
            int rowsNumber = dataGridViewMp3.Rows.Add();
            dataGridViewMp3.Rows[rowsNumber].Cells[0].Value = "Ilość formatów odtwarzanej muzyki";
            dataGridViewMp3.Rows[rowsNumber].Cells[1].Value = formatsNumber;

            rowsNumber = dataGridViewMp3.Rows.Add();
            dataGridViewMp3.Rows[rowsNumber].Cells[0].Value = "Radio fm";
            dataGridViewMp3.Rows[rowsNumber].Cells[1].Value = fm;

            rowsNumber = dataGridViewMp3.Rows.Add();
            dataGridViewMp3.Rows[rowsNumber].Cells[0].Value = "Mini jack";
            dataGridViewMp3.Rows[rowsNumber].Cells[1].Value = miniJack;

            rowsNumber = dataGridViewMp3.Rows.Add();
            dataGridViewMp3.Rows[rowsNumber].Cells[0].Value = "Rozmiar dysku";
            dataGridViewMp3.Rows[rowsNumber].Cells[1].Value = diskSize;

            rowsNumber = dataGridViewMp3.Rows.Add();
            dataGridViewMp3.Rows[rowsNumber].Cells[0].Value = "Czas grania muzyki";
            dataGridViewMp3.Rows[rowsNumber].Cells[1].Value = timeOfPlaying;
        }
    }
}
