

namespace JakubWoszczynaZad2
{
    class Tablet : ElectronicDeviceWithScreen
    {
        public bool SimCard { get; set; }
        public int RamNumber { get; set; }
        public int DiskSizeGb { get; set; }
        public string OperatingSystem { get; set; }
        public int CameraMpix { get; set; }

        public Tablet() { }
        public Tablet(int weightGrams, int screenSizeInches, bool bluetooth)
        {

        }
        /// <summary>
        /// Metoda pokazująca urządzenie oraz specyfikację w nowym oknie
        /// </summary>
        /// <param name="tablet"></param>
        public void ShowDevice(Tablet tablet)
        {
            TabletForm tabletForm = new TabletForm();
            tabletForm.Show();
            tabletForm.FillDataGridView(tablet.DiskSizeGb, tablet.CameraMpix, tablet.RamNumber, tablet.OperatingSystem, tablet.SimCard);
        }
        /// <summary>
        /// Metoda wykorzystująca polimorfizm, nadpisujaca metodę w wirtualnej klasie ElectrocDeviceWitScreen
        /// </summary>
        /// <returns></returns>
        public override string ShowInformation()
        {
            return "Tablet to przenośny komputer o rozmiarach większych niż telefon komórkowy lub smartfon, którego główną właściwością jest posiadanie dużego ekranu z zastosowaną technologią Multi-Touch";
        }
    }
}
