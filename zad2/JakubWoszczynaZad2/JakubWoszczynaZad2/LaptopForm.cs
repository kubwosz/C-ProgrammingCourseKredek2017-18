using System.Windows.Forms;

namespace JakubWoszczynaZad2
{
    public partial class LaptopForm : Form
    {
        public LaptopForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        /// <param name="diskSize"></param>
        /// <param name="cameraMpix"></param>
        /// <param name="ramSize"></param>
        /// <param name="processorModel"></param>
        public void FillDataGridView(/*int weight, int screenSize, bool bluetooth, */int diskSize, int cameraMpix, int ramSize, string processorModel )
        {
            int rowsNumber = dataGridViewLaptop.Rows.Add();
            dataGridViewLaptop.Rows[rowsNumber].Cells[0].Value = "Ilośc megapikseli w aparcie";
            dataGridViewLaptop.Rows[rowsNumber].Cells[1].Value = cameraMpix;

            rowsNumber = dataGridViewLaptop.Rows.Add();
            dataGridViewLaptop.Rows[rowsNumber].Cells[0].Value = "Model procesora";
            dataGridViewLaptop.Rows[rowsNumber].Cells[1].Value = ramSize;

            rowsNumber = dataGridViewLaptop.Rows.Add();
            dataGridViewLaptop.Rows[rowsNumber].Cells[0].Value = "Ilość pamieci RAM";
            dataGridViewLaptop.Rows[rowsNumber].Cells[1].Value = processorModel;

            rowsNumber = dataGridViewLaptop.Rows.Add();
            dataGridViewLaptop.Rows[rowsNumber].Cells[0].Value = "Rozmiar dysku";
            dataGridViewLaptop.Rows[rowsNumber].Cells[1].Value = diskSize;
        }
    }
}
