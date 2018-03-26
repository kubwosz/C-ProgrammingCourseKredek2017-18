

namespace JakubWoszczynaZad2
{
    class Mp3 : ElectronicDeviceWithScreen
    {
        public int DiskSizeGb { get; set; }
        public int NumberOfFormats { get; set; } //Formaty które mp3 moze odtworzyc, WMA, AAC, WAV
        public bool HeadphoneJack { get; set; }
        public int TimeOfPlayingMusic { get; set; }
        public bool FmRadio { get; set; }

        public Mp3() { }
        public Mp3(int weightGrams, int screenSizeInches, bool bluetooth)
        {

        }
        /// <summary>
        /// Metoda pokazująca urządzenie oraz specyfikację w nowym oknie
        /// </summary>
        /// <param name="mp3"></param>
        public void ShowDevice(Mp3 mp3)
        {
            Mp3Form mp3Form = new Mp3Form();
            mp3Form.Show();
            mp3Form.FillDataGridView(mp3.DiskSizeGb, mp3.NumberOfFormats, mp3.FmRadio, mp3.HeadphoneJack, mp3.TimeOfPlayingMusic);
        }
        /// <summary>
        /// Metoda wykorzystująca polimorfizm, nadpisujaca metodę w wirtualnej klasie ElectrocDeviceWitScreen
        /// </summary>
        /// <returns></returns>
        public override string ShowInformation()
        {
            return "Mp3 to przenośne urządzenie służące do katalogowania i odsłuchiwania plików dźwiękowych.Część odtwarzaczy MP3 zaopatrzonych jest dodatkowo w radio lub możliwość nagrania dźwięku (dyktafon) z możliwością kodowania zapisywanego dźwięku do formatu MP3 czy ADPCM WAV.";
        }
    }
}
