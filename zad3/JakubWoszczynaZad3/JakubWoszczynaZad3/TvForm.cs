using System.Windows.Forms;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    public partial class TvForm : Form
    {
        SqlConnection connection;
        public TvForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
        }
        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        /// <param name="hdmiNumber"></param>
        /// <param name="energyClass"></param>
        /// <param name="tech3d"></param>
        /// <param name="smartTv"></param>
        public void FillDataGridView(/*int weight, int screenSize, bool bluetooth, */int hdmiNumber, char energyClass, 
            bool tech3d, bool smartTv)
        {
            dataGridViewTv.DataSource = TV.TakeChosen(connection, hdmiNumber,
       energyClass, tech3d, smartTv);
        }
    }
}
