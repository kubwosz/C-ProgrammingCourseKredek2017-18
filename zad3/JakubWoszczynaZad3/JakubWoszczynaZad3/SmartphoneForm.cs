using System.Windows.Forms;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    public partial class SmartphoneForm : Form
    {
        SqlConnection connection;
        public SmartphoneForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
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
            dataGridViewSmartphone.DataSource = Smartphone.TakeChosen(connection, nfc, dualSim,
                miniJack, cameraMpix, ramSize, operatingSystem);
        }
    }
}
