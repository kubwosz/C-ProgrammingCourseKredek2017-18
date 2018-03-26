using System.Windows.Forms;

namespace JakubWoszczynaZad2
{
    public partial class TabletForm : Form
    {
        public TabletForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        /// <param name="diskSize"></param>
        /// <param name="cameraMpix"></param>
        /// <param name="ramSize"></param>
        /// <param name="operatingSystem"></param>
        /// <param name="simCard"></param>
        public void FillDataGridView(/*int weight, int screenSize, bool bluetooth, */int diskSize, int cameraMpix, int ramSize, 
            string operatingSystem, bool simCard)
        {
            int rowsNumber = dataGridViewTablet.Rows.Add();
            dataGridViewTablet.Rows[rowsNumber].Cells[0].Value = "Ilośc megapikseli w aparcie";
            dataGridViewTablet.Rows[rowsNumber].Cells[1].Value = cameraMpix;

            rowsNumber = dataGridViewTablet.Rows.Add();
            dataGridViewTablet.Rows[rowsNumber].Cells[0].Value = "System operacyjny";
            dataGridViewTablet.Rows[rowsNumber].Cells[1].Value = operatingSystem;

            rowsNumber = dataGridViewTablet.Rows.Add();
            dataGridViewTablet.Rows[rowsNumber].Cells[0].Value = "Ilość pamieci RAM";
            dataGridViewTablet.Rows[rowsNumber].Cells[1].Value = ramSize;

            rowsNumber = dataGridViewTablet.Rows.Add();
            dataGridViewTablet.Rows[rowsNumber].Cells[0].Value = "Rozmiar dysku";
            dataGridViewTablet.Rows[rowsNumber].Cells[1].Value = diskSize;

            rowsNumber = dataGridViewTablet.Rows.Add();
            dataGridViewTablet.Rows[rowsNumber].Cells[0].Value = "Karta sim";
            dataGridViewTablet.Rows[rowsNumber].Cells[1].Value = simCard;
        }
    }
}
