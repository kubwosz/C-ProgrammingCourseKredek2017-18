using System.Windows.Forms;

namespace JakubWoszczynaZad2
{
    public partial class TvForm : Form
    {
        public TvForm()
        {
            InitializeComponent();
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
            int rowsNumber = dataGridViewTv.Rows.Add();
            dataGridViewTv.Rows[rowsNumber].Cells[0].Value = "Ilość portów HDMI";
            dataGridViewTv.Rows[rowsNumber].Cells[1].Value = hdmiNumber;

            rowsNumber = dataGridViewTv.Rows.Add();
            dataGridViewTv.Rows[rowsNumber].Cells[0].Value = "Klasa energetyczna";
            dataGridViewTv.Rows[rowsNumber].Cells[1].Value = energyClass;

            rowsNumber = dataGridViewTv.Rows.Add();
            dataGridViewTv.Rows[rowsNumber].Cells[0].Value = "Technologia 3D";
            dataGridViewTv.Rows[rowsNumber].Cells[1].Value = tech3d;

            rowsNumber = dataGridViewTv.Rows.Add();
            dataGridViewTv.Rows[rowsNumber].Cells[0].Value = "Smart TV";
            dataGridViewTv.Rows[rowsNumber].Cells[1].Value = smartTv;
        }
    }
}
