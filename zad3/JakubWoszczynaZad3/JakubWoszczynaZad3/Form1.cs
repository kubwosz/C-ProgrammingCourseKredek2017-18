using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JakubWoszczynaZad3
{
    public partial class Technology : Form
    {
        SqlConnection connection;
        public Technology()
        {
            InitializeComponent();
           connection = new SqlConnection(@"Data Source=JAKUBW\SQLEXPRESS; database=JakubWoszczynaZad3;Trusted_Connection = yes");
        }
        /// <summary>
        /// Zmienna opisująca maskymalny poziom procentowy paska progresywnego
        /// </summary>
        int progressBarBaseMaximum = 99;
        /// <summary>
        /// Zmienna opisujące skok o wartość w pasku progresywnym
        /// </summary>
        int progressBarBaseStep = 17;

        //Zadeklarowanie zmiennych potrzebnych do decydowania czy użytkownik wprowadził dane, oraz 
        //odpowiednie zarządzanie paskiem progresywnym, a także ustawienie ich wartości początkowych.
        bool comboBoxIncremented = false;
        bool textBoxWeightMinIncremented = false;
        bool textBoxWeightMaxIncremented = false;
        bool textBoxScreenMinIncremented = false;
        bool textBoxScreenMaxIncremented = false;

        //Utworzenie list na obiekty klas dziedziczących 
        private List<Mp3> listOfMp3 = new List<Mp3>();
        private List<Tablet> listOfTablet = new List<Tablet>();
        private List<TV> listOfTv = new List<TV>();
        private List<Smartphone> listOfSmartphone = new List<Smartphone>();
        private List<Laptop> listOfLaptop = new List<Laptop>();
        private List<Client> listOfClient = new List<Client>();

        /// <summary>
        /// Utworzenie tablicy wirtualnej klasy bazowej, potrzebnej do wypisania informacji o urządzeniach przy użyciu metody o takiej samej nazwie w każdej klasie
        /// </summary>
        private ElectronicDeviceWithScreen[] device = new ElectronicDeviceWithScreen[5];

      /// <summary>
      /// Metoda opisująca pokazywanie groupboxów w zależności od wybranej opcji. Najpier wszystkie sa niewidoczne, a zależności od 
      /// wybranego urządzenia pojawia się jeden z nich
      /// </summary>
        private void ShowGroupBox()
        {
            groupBoxMp3.Visible = false;
            groupBoxTablet.Visible = false;
            groupBoxTv.Visible = false;
            groupBoxSmartphone.Visible = false;
            groupBoxLaptop.Visible = false;
            if (GetBaseInformation() == true)
            {
                switch (comboBoxLookingFor.Text)
                {
                    case "Mp3":
                        groupBoxMp3.Visible = true;
                        break;
                    case "Tablet":
                        groupBoxTablet.Visible = true;
                        break;
                    case "Telewizor":
                        groupBoxTv.Visible = true;
                        break;
                    case "Smartfon":
                        groupBoxSmartphone.Visible = true;
                        break;
                    case "Laptop":
                        groupBoxLaptop.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }

 /////////////////////////PRZYKŁAD POLIMORFIZMU/////////////////////////
 //Tutaj pokazany został przykład polimorfizmu, dzieki któremu można wywołać metodę o tej samej nazwie z wielu klas
                device[0] = new Mp3();
                device[1] = new Tablet();
                device[2] = new Laptop();
                device[3] = new TV();
                device[4] = new Smartphone();
               
                foreach (var dev in device)
                {
                   // MessageBox.Show(dev.ShowInformation());
                }
            }
        }
/// <summary>
/// Metoda losująca wartość z przedziału dwóch podanych parametrów.
/// </summary>
/// <param name="value1"></param>
/// <param name="value2"></param>
/// <returns></returns>
        public int RandomNumber(int value1, int value2)
        {
            try
            {
                Random rand = new Random();
                return rand.Next(value1, value2);
            }
            catch (Exception)
            {
                MessageBox.Show("Liczba po lewej nie może być większa niż ta po prawej", "Błąd");
                return -1;
            }
        }


        /////////////////ZARZĄDZANIE PASKIEM PROGRESYWNYM///////////////////////////////////
        /// <summary>
        /// Metoda inkremetująca lub dekrementujaća pasek w zależności od wpisania czegoś w pole lub nie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLookingFor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxIncremented) {
                progressBarBase.Increment(progressBarBaseStep);
                comboBoxIncremented = true;
            }

            ProgressBarBaseProgressChanged();
        }
        /// <summary>
        /// Metoda inkremetująca lub dekrementujaća pasek w zależności od wpisania czegoś w pole lub usunięcia czegoś
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWeightMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWeightMin.Text) && textBoxWeightMinIncremented == true)
            {
                progressBarBase.Increment((-1)*progressBarBaseStep);
                textBoxWeightMinIncremented = false;
            }
            else if (!(String.IsNullOrEmpty(textBoxWeightMin.Text)) && textBoxWeightMinIncremented == false)
            {
                progressBarBase.Increment(progressBarBaseStep);
                textBoxWeightMinIncremented = true;
            }

            ProgressBarBaseProgressChanged();
        }
        /// <summary>
        ///  Metoda inkremetująca lub dekrementujaća pasek w zależności od wpisania czegoś w pole lub usunięcia czegoś
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWeightMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxWeightMax.Text) && textBoxWeightMaxIncremented == true)
            {
                progressBarBase.Increment((-1) * progressBarBaseStep);
                textBoxWeightMaxIncremented = false;
            }
            else if (!(String.IsNullOrEmpty(textBoxWeightMin.Text)) && textBoxWeightMaxIncremented == false)
            {
                progressBarBase.Increment(progressBarBaseStep);
                textBoxWeightMaxIncremented = true;
            }
            ProgressBarBaseProgressChanged();
        }
        /// <summary>
        ///  Metoda inkremetująca lub dekrementujaća pasek w zależności od wpisania czegoś w pole lub usunięcia czegoś
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScreenMin_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxScreenMin.Text) && textBoxScreenMinIncremented == true)
            {
                progressBarBase.Increment((-1) * progressBarBaseStep);
                textBoxScreenMinIncremented = false;
            }
            else if (!(String.IsNullOrEmpty(textBoxWeightMin.Text)) && textBoxScreenMinIncremented == false)
            {
                progressBarBase.Increment(progressBarBaseStep);
                textBoxScreenMinIncremented = true;
            }
            ProgressBarBaseProgressChanged();
        }
        /// <summary>
        ///  Metoda inkremetująca lub dekrementujaća pasek w zależności od wpisania czegoś w pole lub usunięcia czegoś
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxScreenMax_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxScreenMax.Text) && textBoxScreenMaxIncremented == true)
            {
                progressBarBase.Increment((-1) * progressBarBaseStep);
                textBoxScreenMaxIncremented = false;
            }
            else if (!(String.IsNullOrEmpty(textBoxWeightMin.Text)) && textBoxScreenMaxIncremented == false)
            {
                progressBarBase.Increment(progressBarBaseStep);
                textBoxScreenMaxIncremented = true;
            }
            ProgressBarBaseProgressChanged();
        }
        /// <summary>
        ///  Metoda inkremetująca lub dekrementujaća pasek w zależności od wpisania czegoś w pole lub usunięcia czegoś
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxBluetooth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBluetooth.Checked)
            {
                progressBarBase.Increment(progressBarBaseStep);
            }
            else
            {
                progressBarBase.Increment((-1) * progressBarBaseStep);
            }
            ProgressBarBaseProgressChanged();
        }
        /////////////////KONIEC ZARZĄDZANIA PASKIEM PROGRESYWNYM///////////////////////////////////

        /// <summary>
        /// Metoda sprawdzająca czy pasek został wypełniony, jesli tak to można pokazać kolejne opcje urządzeń.
        /// </summary>
        private void ProgressBarBaseProgressChanged()
        {
            if(progressBarBase.Value > progressBarBaseMaximum)
            {
                ShowGroupBox();
            }
        }
        /// <summary>
        /// Metoda sprawdzająca czy użytkownik poprawnie wypełnił wszystkie pola, jeśli nie, zostaje wyrzucony error oraz 
        /// zwrócona wartośc metody false
        /// </summary>
        /// <returns></returns>
        private bool GetBaseInformation()
        { 
            try
            {

                    var emPeTrzy = new Mp3(RandomNumber(Int32.Parse(textBoxWeightMin.Text), Int32.Parse(textBoxWeightMax.Text)),
    RandomNumber(Int32.Parse(textBoxScreenMin.Text), Int32.Parse(textBoxScreenMax.Text)), checkBoxBluetooth.Checked);

                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }


        /// <summary>
        /// MP3 - Metoda tworząca obiekt klasy Mp3 i wypełniająca go odpowiedznimi wartościami. Metoda
        /// sprawdza także, czy pola zostały wpełnione poprawnie. Obiekt zostaje dodany do listy.
        /// </summary>
        private bool GetMp3Information()
        {
            try
            {
                var mp3 = new Mp3(RandomNumber(Int32.Parse(textBoxWeightMin.Text), Int32.Parse(textBoxWeightMax.Text)),
RandomNumber(Int32.Parse(textBoxScreenMin.Text), Int32.Parse(textBoxScreenMax.Text)), checkBoxBluetooth.Checked)
                {
                    DiskSizeGb = Int32.Parse(comboBoxDiskSizeMp3.Text),
                    NumberOfFormats = checkedListBoxMusicFormatMp3.Items.Count,
                    FmRadio = checkBoxFmMp3.Checked,
                    HeadphoneJack = checkBoxHeadphoneJackMp3.Checked,
                    TimeOfPlayingMusic = Int32.Parse(textBoxTimeOfPlayingMusicMp3.Text)
                };
                listOfMp3.Add(mp3);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }

        /// <summary>
        /// Tablet - metoda tworząca obiekt klasy Tablet oraz wypełniająca go odpowiednimi wartościami z pól. Metoda
        /// sprawdza także, czy pola zostały wpełnione poprawnie. Obiekt zostaje dodany do listy.
        /// </summary>
        private bool GetTabletInformation()
        {
            try
            {
                var tablet = new Tablet(RandomNumber(Int32.Parse(textBoxWeightMin.Text), Int32.Parse(textBoxWeightMax.Text)),
RandomNumber(Int32.Parse(textBoxScreenMin.Text), Int32.Parse(textBoxScreenMax.Text)), checkBoxBluetooth.Checked)
                {
                    DiskSizeGb = Int32.Parse(comboBoxDiskSizeTablet.Text),
                    SimCard = checkBoxSimTablet.Checked,
                    OperatingSystem = comboBoxOperatingSystemTablet.Text,
                    RamNumber= Int32.Parse(comboBoxRamTablet.Text),
                    CameraMpix = Int32.Parse(comboBoxCameraTablet.Text)
                };
                listOfTablet.Add(tablet);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }
        /// <summary>
        /// Laptop - metoda tworząca obiekt klasy Laptop oraz wypełniająca go odpowiednimi wartościami z pól. Metoda
        /// sprawdza także, czy pola zostały wpełnione poprawnie. Obiekt zostaje dodany do listy.
        /// </summary>
        private bool GetLaptopInformation()
        {
            try
            {
                var laptop = new Laptop(RandomNumber(Int32.Parse(textBoxWeightMin.Text), Int32.Parse(textBoxWeightMax.Text)),
RandomNumber(Int32.Parse(textBoxScreenMin.Text), Int32.Parse(textBoxScreenMax.Text)), checkBoxBluetooth.Checked)
                {
                    DiskSizeGb = Int32.Parse(comboBoxDiskSizeLaptop.Text),
                    RamNumber = Int32.Parse(comboBoxRamLaptop.Text),
                    CameraMpix = Int32.Parse(comboBoxCameraLaptop.Text),
                    ProcessorModel = comboBoxProcessorLaptop.Text
                };
                listOfLaptop.Add(laptop);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }
        /// <summary>
        /// TV - metoda tworząca obiekt klasy TV oraz wypełniająca go odpowiednimi wartościami z pól. Metoda
        /// sprawdza także, czy pola zostały wpełnione poprawnie. Obiekt zostaje dodany do listy.
        /// </summary>
        private bool GetTvInformation()
        {
            try
            {
                var tv = new TV(RandomNumber(Int32.Parse(textBoxWeightMin.Text), Int32.Parse(textBoxWeightMax.Text)),
RandomNumber(Int32.Parse(textBoxScreenMin.Text), Int32.Parse(textBoxScreenMax.Text)), checkBoxBluetooth.Checked)
                {
                    HdmiNumber = Int32.Parse(textBoxHdmiTv.Text),
                    EnergyClass = Char.Parse(comboBoxEnergyClassTv.Text),
                    Technology3d = checkBox3dTv.Checked,
                    SmartTv = checkBoxSmartTv.Checked
                };
                listOfTv.Add(tv);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }
        /// <summary>
        /// Smartphone- metoda tworząca obiekt klasy Smartphone oraz wypełniająca go odpowiednimi wartościami z pól. Metoda
        /// sprawdza także, czy pola zostały wpełnione poprawnie. Obiekt zostaje dodany do listy.
        /// </summary>
        private bool GetSmartphoneInformation()
        {
            try
            {
                var smartphone = new Smartphone(RandomNumber(Int32.Parse(textBoxWeightMin.Text), Int32.Parse(textBoxWeightMax.Text)),
RandomNumber(Int32.Parse(textBoxScreenMin.Text), Int32.Parse(textBoxScreenMax.Text)), checkBoxBluetooth.Checked)
                {
                    RamNumber = Int32.Parse(comboBoxRamSmartphone.Text),
                    CameraMpix = Char.Parse(comboBoxCameraSmartphone.Text),
                    TechnologyNFC = checkBoxNfcSmartphone.Checked,
                    HeadphoneJack = checkBoxHeadphoneJackSmarthone.Checked,
                    DualSim = checkBoxDualSimSmartphone.Checked,
                    OperatingSystem = comboBoxOperatingSystemSmartphone.Text
                };
                listOfSmartphone.Add(smartphone);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }
        /// <summary>
        /// Metoda tworząca obiekt clasy klient, zczytująca wartości do obiektu z textboxów, a następnie dodawanie obiektu do listy.
        /// Dodatkowo łapanie wyjątków oraz zwracanie true w razie powodznia, false w razie niepowodzenia.
        /// </summary>
        /// <returns></returns>
        private bool GetClientInformation()
        {
            try
            {
                var client = new Client()
                {
                    City = textBoxCity.Text,
                    Street = textBoxStreet.Text,
                    HouseNumber = textBoxHouseNumber.Text,
                    PhoneNumber = Int32.Parse(textBoxPhoneNumber.Text),
                    Mail = textBoxMail.Text,
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text
                };
                listOfClient.Add(client);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Podaj wszystkie potrzebne informacje lub we właściwym formacie", "Błąd podawania informacji");
                return false;
            }
        }

        /// <summary>
        /// Metoda wywołująca metodę pozyskującą i tworzącą obiekt klasy, a następnie
        /// metodę pokazującą dane urządznie oraz jego specyfikację.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowMp3_Click(object sender, EventArgs e)
        {
            if(GetMp3Information())
                listOfMp3[0].ShowDevice(listOfMp3[0]);

        }
        /// <summary>
        /// Metoda wywołująca metodę pozyskującą i tworzącą obiekt klasy, a następnie
        /// metodę pokazującą dane urządznie oraz jego specyfikację.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowTablet_Click(object sender, EventArgs e)
        {
            if (GetTabletInformation())
                listOfTablet[0].ShowDevice(listOfTablet[0]);
        }
        /// <summary>
        /// Metoda wywołująca metodę pozyskującą i tworzącą obiekt klasy, a następnie
        /// metodę pokazującą dane urządznie oraz jego specyfikację.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowTv_Click(object sender, EventArgs e)
        {
            if (GetTvInformation())
                listOfTv[0].ShowDevice(listOfTv[0]);
        }
        /// <summary>
        /// Metoda wywołująca metodę pozyskującą i tworzącą obiekt klasy, a następnie
        /// metodę pokazującą dane urządznie oraz jego specyfikację.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowSmartphone_Click(object sender, EventArgs e)
        {
            if (GetSmartphoneInformation())
                listOfSmartphone[0].ShowDevice(listOfSmartphone[0]);
        }
        /// <summary>
        /// Metoda wywołująca metodę pozyskującą i tworzącą obiekt klasy, a następnie
        /// metodę pokazującą dane urządznie oraz jego specyfikację.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowLaptop_Click(object sender, EventArgs e)
        {
            if (GetLaptopInformation())
            listOfLaptop[0].ShowDevice(listOfLaptop[0]);
        }
        /// <summary>
        /// Metoda obsługująca przycisk i dodająca klienta do listy po przyciśnieciu, po wczesniejszym sprawdzeniu
        /// czy metoda GetClientInformation() wykonała sie poprawnie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (GetClientInformation())
            {
                listOfClient[0].ShowClient(connection,listOfClient[0]);
            }
        }
    }
}
