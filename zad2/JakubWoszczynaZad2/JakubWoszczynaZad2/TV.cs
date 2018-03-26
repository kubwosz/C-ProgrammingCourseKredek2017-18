using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakubWoszczynaZad2
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
    }
}
