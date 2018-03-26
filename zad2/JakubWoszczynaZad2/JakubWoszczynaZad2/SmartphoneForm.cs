using System.Windows.Forms;

namespace JakubWoszczynaZad2
{
    public partial class SmartphoneForm : Form
    {
        public SmartphoneForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        /// <param name="nfc"></param>
        /// <param name="dualSim"></param>
        /// <param name="miniJack"></param>
        /// <param name="cameraMpix"></param>
        /// <param name="ramSize"></param>
        /// <param name="operatingSystem"></param>
        public void FillDataGridView(/*int weight, int screenSize, bool bluetooth, */bool nfc, bool dualSim, bool miniJack, 
            int cameraMpix, int ramSize, string operatingSystem)
        {
            int rowsNumber = dataGridViewSmartphone.Rows.Add();
            dataGridViewSmartphone.Rows[rowsNumber].Cells[0].Value = "Ilość megapikseli w aparcie";
            dataGridViewSmartphone.Rows[rowsNumber].Cells[1].Value = cameraMpix;

            rowsNumber = dataGridViewSmartphone.Rows.Add();
            dataGridViewSmartphone.Rows[rowsNumber].Cells[0].Value = "NFC";
            dataGridViewSmartphone.Rows[rowsNumber].Cells[1].Value = nfc;

            rowsNumber = dataGridViewSmartphone.Rows.Add();
            dataGridViewSmartphone.Rows[rowsNumber].Cells[0].Value = "Mini jack";
            dataGridViewSmartphone.Rows[rowsNumber].Cells[1].Value = miniJack;

            rowsNumber = dataGridViewSmartphone.Rows.Add();
            dataGridViewSmartphone.Rows[rowsNumber].Cells[0].Value = "Ilość pamieci RAM";
            dataGridViewSmartphone.Rows[rowsNumber].Cells[1].Value = ramSize;

            rowsNumber = dataGridViewSmartphone.Rows.Add();
            dataGridViewSmartphone.Rows[rowsNumber].Cells[0].Value = "Dual Sim";
            dataGridViewSmartphone.Rows[rowsNumber].Cells[1].Value = dualSim;

            rowsNumber = dataGridViewSmartphone.Rows.Add();
            dataGridViewSmartphone.Rows[rowsNumber].Cells[0].Value = "System operacyjny";
            dataGridViewSmartphone.Rows[rowsNumber].Cells[1].Value = operatingSystem;
        }
    }
}
