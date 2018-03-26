using System.Windows.Forms;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    public partial class TabletForm : Form
    {
        SqlConnection connection;
        public TabletForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
        }
        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        /// <param name="diskSize"></param>
        /// <param name="cameraMpix"></param>
        /// <param name="ramSize"></param>
        /// <param name="operatingSystem"></param>
        /// <param name="simCard"></param>
        public void FillDataGridView(/*int weight, int screenSize, bool bluetooth, */int diskSize, int cameraMpix,
            int ramSize, string operatingSystem, bool simCard)
        {
            dataGridViewTablet.DataSource = Tablet.TakeChosen(connection, diskSize, 
                cameraMpix, ramSize, operatingSystem, simCard);
        }
    }
}
