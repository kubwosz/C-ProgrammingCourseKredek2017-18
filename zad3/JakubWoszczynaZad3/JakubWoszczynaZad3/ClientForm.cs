using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JakubWoszczynaZad3
{
    public partial class ClientForm : Form
    {
        SqlConnection connection;
        public ClientForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
        }
        /// <summary>
        /// Medota wypełniająca w tym oknie dataGridView z informacjami o klientach
        /// </summary>
        public void FillDataGridView()
        {
            dataGridViewClient.DataSource = Client.GetAll(connection);
            dataGridViewOrder.DataSource = Order.GetAll(connection);
        }

        //public void SetCategory()
        //{

        //}

    }
}
