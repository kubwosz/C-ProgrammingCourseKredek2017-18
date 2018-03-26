

namespace JakubWoszczynaZad2
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
    }
}
