using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System;

namespace JakubWoszczynaZad3
{
    public partial class LaptopForm : Form
    {
        SqlConnection connection;
        public LaptopForm()
        {
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
        }


        /// <summary>
        /// Metoda uzupełniająca DataGridView w otwartym oknie, wartościami obiektu danymi do funckji
        /// </summary>
        public void FillDataGridView(int diskSize, int cameraMpix, int ramSize, string processorModel)
        {
            dataGridViewLaptop.DataSource = Laptop.TakeChosen(connection, diskSize, cameraMpix, ramSize, processorModel);
            //dataGridViewLaptop.DataSource = Laptop.GetAll(connection);
        }
    }
}
