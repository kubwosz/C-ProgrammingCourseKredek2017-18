using System.Windows.Forms;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    public partial class Mp3Form : Form
    {
        SqlConnection connection;
        public Mp3Form()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
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
            dataGridViewMp3.DataSource = Mp3.TakeChosen(connection, diskSize, formatsNumber, fm, miniJack, timeOfPlaying);
        }
    }
}
