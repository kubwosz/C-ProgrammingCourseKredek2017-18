using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace JakubWoszczynaZad7
{
    public partial class Scores : Form
    {

        DataJakubWoszczynaZad7DataContext context = new DataJakubWoszczynaZad7DataContext();


        public Scores()
        {
            InitializeComponent();
            
            FillDataGridView();
        }

        private IQueryable GetUser()
        {
            var scores = from score in context.JakubWoszczyna_Scores select new { score.PlayerName, score.PointsNumber};

            return scores;
        }

        void FillDataGridView()
        {
            dataGridViewMain.DataSource = GetUser();
        }

    }
}
