using System.Data;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    class TV : ElectronicDeviceWithScreen
    {
        public bool SmartTv { get; set; }
        public int HdmiNumber { get; set; }
        public bool Technology3d { get; set; }
        public char EnergyClass { get; set; }

        public TV() { }
        public TV(int weightGrams, int screenSizeInches, bool bluetooth)
        {

        }
        /// <summary>
        /// Metoda pokazująca urządzenie oraz specyfikację w nowym oknie
        /// </summary>
        /// <param name="tv"></param>
        public void ShowDevice(TV tv)
        {
            TvForm tvForm = new TvForm();
            tvForm.Show();
            tvForm.FillDataGridView(tv.HdmiNumber, tv.EnergyClass, tv.Technology3d, tv.SmartTv);
        }
        /// <summary>
        /// Metoda wykorzystująca polimorfizm, nadpisujaca metodę w wirtualnej klasie ElectrocDeviceWitScreen
        /// </summary>
        /// <returns></returns>
        public override string ShowInformation()
        {
            return "Telewizor to  urządzenie elektroniczne przeznaczone do zdalnego odbioru ruchomego obrazu, który jest nadawany przez telewizję i składa się z wyświetlanych jeden po drugim nieruchomych obrazów, z częstotliwością 25 lub 30 obrazów na sekundę lub inną. ";
        }
        
        public static DataTable TakeChosen(SqlConnection connection, int hdmiNumber, char energyClass,
            bool tech3d, bool smartTv)
        {
            //Zmienne pomocnicze, ponieważ sql nie działa z wartościami bool
            int t = 0, s = 0;
            if (tech3d)
                t = 1;
            if (smartTv)
                s = 1;
            SqlDataAdapter adapter = new SqlDataAdapter($"Select * from Tv where HdmiNumber like '%{hdmiNumber}%'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            return table;
        }
    }
}
