using System.Data;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    class Smartphone : ElectronicDeviceWithScreen
    {
        public bool DualSim { get; set; }
        public bool TechnologyNFC { get; set; }
        public int RamNumber { get; set; }
        public string OperatingSystem { get; set; }
        public bool HeadphoneJack { get; set; }
        public int CameraMpix { get; set; }

        public Smartphone() { }
        public Smartphone(int weightGrams, int screenSizeInches, bool bluetooth)
        {

        }
        /// <summary>
        /// Metoda pokazująca urządzenie oraz specyfikację w nowym oknie
        /// </summary>
        /// <param name="smartphone"></param>
        public void ShowDevice(Smartphone smartphone)
        {
            SmartphoneForm smartphoneForm = new SmartphoneForm();
            smartphoneForm.Show();
            smartphoneForm.FillDataGridView(smartphone.TechnologyNFC, smartphone.DualSim, smartphone.HeadphoneJack, smartphone.CameraMpix, smartphone.RamNumber, smartphone.OperatingSystem);
        }
        /// <summary>
        /// Metoda wykorzystująca polimorfizm, nadpisujaca metodę w wirtualnej klasie ElectrocDeviceWitScreen
        /// </summary>
        /// <returns></returns>
        public override string ShowInformation()
        {
            return "Smartfon to przenośne urządzenie telefoniczne łączące w sobie funkcje telefonu komórkowego i komputera kieszonkowego (PDA – Personal Digital Assistant). Pierwsze smartfony powstały pod koniec lat 90., a obecnie łączą funkcje telefonu komórkowego, poczty elektronicznej, przeglądarki sieciowej, pagera, GPS, jak również cyfrowego aparatu fotograficznego i kamery wideo.";
        }

        public static DataTable TakeChosen(SqlConnection connection, bool nfc, bool dualSim, bool miniJack,
            int cameraMpix, int ramSize, string operatingSystem)
        {
            //Zmienne pomocnicze, ponieważ sql nie działa z wartościami bool
            int n = 0, d = 0, m = 0;
            if (nfc)
                n = 1;
            if (dualSim)
                d = 1;
            if (miniJack)
                m = 1;
            SqlDataAdapter adapter = new SqlDataAdapter($"Select * from Smartphone where CameraMpix like '%{cameraMpix}%' and OperatingSystem like '%{operatingSystem}%'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
