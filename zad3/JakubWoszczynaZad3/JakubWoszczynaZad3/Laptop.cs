using System.Data;
using System.Data.SqlClient;

namespace JakubWoszczynaZad3
{
    class Laptop : ElectronicDeviceWithScreen
    {
        public int CameraMpix { get; set; }
        public string ProcessorModel { get; set; }
        public int RamNumber { get; set; }
        public int DiskSizeGb { get; set; }

        public Laptop() { }
        public Laptop(int weightGrams, int screenSizeInches, bool bluetooth)
        {

        }

        /// <summary>
        /// Metoda pokazująca urządzenie oraz specyfikację w nowym oknie
        /// </summary>
        /// <param name="laptop"></param>
        public void ShowDevice(Laptop laptop)
        {
            LaptopForm laptopForm = new LaptopForm();
            laptopForm.Show();
            laptopForm.FillDataGridView(laptop.DiskSizeGb, laptop.CameraMpix, laptop.RamNumber, laptop.ProcessorModel);
        }
        /// <summary>
        /// Metoda wykorzystująca polimorfizm, nadpisujaca metodę w wirtualnej klasie ElectrocDeviceWitScreen
        /// </summary>
        /// <returns></returns>
        public override string ShowInformation()
        {
            return "Laptopy są zbudowane przeważnie jako pojedyncze niewielkie zamykane urządzenia, w których znajdują się wszystkie podzespoły wewnętrzne (procesor, pamięć, itd.), wybrane wejścia dla nośników (DVD-ROM, USB), złącza (HDMI, D-Sub, itd.) urządzenia komunikacji z użytkownikiem (klawiatura, ekran TFT oraz TrackPoint lub touchpad).";
        }

        public static DataTable GetAll(SqlConnection connection)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Laptop", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
        public static void SetCategory(SqlConnection connection)
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM Laptop", connection);

            connection.Open();
            SqlDataReader contact = cmd.ExecuteReader();
            contact.Read();
            id = contact.GetInt32(0);
            connection.Close();

            SqlCommand command3 = new SqlCommand($"INSERT INTO Laptop (IdLaptop) values ('{id}')", connection);
            connection.Open();
            command3.ExecuteNonQuery();
            connection.Close();
        }

        public static DataTable TakeChosen(SqlConnection connection, int diskSize, int cameraMpix, int ramSize, string processorModel)
        {
            SqlDataAdapter adapter = new SqlDataAdapter($"Select * from Laptop where CameraMpix like '%{cameraMpix}%' and DiskSizeGb like '%{diskSize}%'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }
    }
}
