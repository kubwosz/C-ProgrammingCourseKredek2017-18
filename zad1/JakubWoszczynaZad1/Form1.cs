using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JakubWoszczynaZad1
{
    


    public partial class FormMain : Form
    {
        /// <summary>
        /// Klasa określająca atrybuty surowców, liczba materiałów, kopalń oraz zmienna odpowiadająca za miejsce w tabeli
        /// </summary>
        class Material
        {
            public int numberOfMaterial;
            public int numberOfMines;
            public int rowsNumber;
            /// <summary>
            /// Kontruktor klasy Material, ustala wartości początkowe atrybutów
            /// </summary>
            /// <param name="material"></param>
            /// <param name="mines"></param>
            public Material(int material, int mines)
            {
                numberOfMaterial = material;
                numberOfMines = mines;
            }
        }

        /// <summary>
        /// Obiekt klasy Castle, tworzenie, potrzebne będzie do otwierania okna wyboru przy kupnie zamku
        /// </summary>
        Castle formCastle = new Castle();
        /// <summary>
        /// Obiekt klasy Hero, potrzebny będzie do otwierania okna wyboru przy zakupie bohatera
        /// </summary>
        Hero formHero = new Hero();

        /// <summary>
        /// Zmienna pomocnicza do kupowania bohaterów
        /// </summary>
        int tmpBuyHero;
        /// <summary>
        /// Zmienna pomocnicza do kuowania zamków
        /// </summary>
        int tmpBuyCastle;
       

        /// <summary>
        /// Zmienna słuząca za licznik sekund, używana przy timerze
        /// </summary>
        int counterSeconds = 0;

        /// <summary>
        /// Zmienna słuząca za licznik minut, używana przy timerze
        /// </summary>
        int counterMinutes = 0;

        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o drewnie
        /// </summary>
        Material wood = new Material(30,0);
        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o rtęci
        /// </summary>
        Material mercury = new Material(20,0);
        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o kamieniu
        /// </summary>
        Material stone = new Material(30,0);
        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o siarce
        /// </summary>
        Material sulfur = new Material(20,0);
        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o krysztale
        /// </summary>
        Material crystal = new Material(20,0);
        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o klejnotach
        /// </summary>
        Material jewels = new Material(20,0);
        /// <summary>
        /// Obiekt klasy Material, przechowujący informacje o złocie
        /// </summary>
        Material gold = new Material(2500,0);

        /// <summary>
        /// Metoda główna, rozpoczyna pracę timera oraz wpisuje nazwę użytkownika do labelUserName
        /// </summary>
        public FormMain(string username)
        {
            InitializeComponent();
            timerCounter.Start();
            labelUserName.Text = "Hello " + username + " !";
        }


        /// <summary>
        /// Metoda odpowiadająca za wypisywanie czasu oraz formatowanie go to minut oraz sekund, za iterowanie wartości surowców w zależności od 
        /// ilości posiadanych kopalń a także wpisywanie wartości materiałów na bieżąco.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerCounter_Tick(object sender, EventArgs e)
        {


            counterSeconds++;

            labelTimer.Text = counterMinutes.ToString() + " : " + counterSeconds.ToString();
            if (counterSeconds == 60)
            {
                counterSeconds = 0;
                counterMinutes++;
            }

            if (counterSeconds % 5 == 0 && wood.numberOfMines > 0)
                wood.numberOfMaterial += wood.numberOfMines;

            if (counterSeconds % 5 == 0 && mercury.numberOfMines > 0)
                mercury.numberOfMaterial += mercury.numberOfMines;

            if (counterSeconds % 5 == 0 && stone.numberOfMines > 0)
                stone.numberOfMaterial += stone.numberOfMines;

            if (counterSeconds % 5 == 0 && sulfur.numberOfMines > 0)
                sulfur.numberOfMaterial += sulfur.numberOfMines;

            if (counterSeconds % 8 == 0 && crystal.numberOfMines > 0)
                crystal.numberOfMaterial += crystal.numberOfMines;

            if (counterSeconds % 8 == 0 && jewels.numberOfMines > 0)
                jewels.numberOfMaterial += jewels.numberOfMines;

            if (counterSeconds % 10 == 0 && gold.numberOfMines > 0)
                gold.numberOfMaterial += (gold.numberOfMines * 100);

            labelWood.Text = "Wood: " + wood.numberOfMaterial;
            labelMercury.Text = "Mercury: " + mercury.numberOfMaterial;
            labelStone.Text = "Stone: " + stone.numberOfMaterial;
            labelSulfur.Text = "Sulfur: " + sulfur.numberOfMaterial;
            labelCrystal.Text = "Crystal: " + crystal.numberOfMaterial;
            labelJewels.Text = "Jewels: " + jewels.numberOfMaterial;
            labelGold.Text = "Gold: " + gold.numberOfMaterial;
        }

        /// <summary>
        /// Metoda odpowiadająca za wyświetlanie czasu w etykeicie labelTimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelTimer_Click(object sender, EventArgs e)
        {
         
        }
      
        /// <summary>
        /// MEtoda definująca pracę programu po naciśniędziu przycisku buttonWood. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWood_Click(object sender, EventArgs e)
        {
            
            if (wood.numberOfMaterial < 30)
            {
                MessageBox.Show("You have too little wood!", "You can't buy it.");
            }
            else
            {
                wood.numberOfMines++;
                wood.numberOfMaterial -= 30;
                    
                if (wood.numberOfMines == 1)
                {
                    wood.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[wood.rowsNumber].Cells[0].Value = "Wood";
                    dataGridViewMines.Rows[wood.rowsNumber].Cells[1].Value = wood.numberOfMines;
                    dataGridViewMines.Rows[wood.rowsNumber].Cells[2].Value = 5;
                    dataGridViewMines.Rows[wood.rowsNumber].Cells[3].Value = "30 wood";
                }
                dataGridViewMines.Rows[wood.rowsNumber].Cells[1].Value = wood.numberOfMines;

                buttonWood.Text = "Buy lumbermill lvl " + (wood.numberOfMines + 1);
            }

        }
        /// <summary>
        /// Metoda definująca pracę programu po naciśniędziu przycisku buttonMercury. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMercury_Click(object sender, EventArgs e)
        {
            if (mercury.numberOfMaterial < 20)
            {
                MessageBox.Show("You have too little mercury!", "You can't buy it.");
            }
            else
            {
                mercury.numberOfMines++;
                mercury.numberOfMaterial -= 20;

                if (mercury.numberOfMines == 1)
                {
                    mercury.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[mercury.rowsNumber].Cells[0].Value = "Mercury";
                    dataGridViewMines.Rows[mercury.rowsNumber].Cells[1].Value = mercury.numberOfMines;
                    dataGridViewMines.Rows[mercury.rowsNumber].Cells[2].Value = 5;
                    dataGridViewMines.Rows[mercury.rowsNumber].Cells[3].Value = "20 mercury";
                }
                dataGridViewMines.Rows[mercury.rowsNumber].Cells[1].Value = mercury.numberOfMines;

                buttonMercury.Text = "Buy mercury mine lvl " + (mercury.numberOfMines + 1);
            }
        }
        /// <summary>
        /// Metoda definująca pracę programu po naciśniędziu przycisku buttonStone. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStone_Click(object sender, EventArgs e)
        {
            if (stone.numberOfMaterial < 30)
            {
                MessageBox.Show("You have too little stone!", "You can't buy it.");
            }
            else
            {
                stone.numberOfMines++;
                stone.numberOfMaterial -= 30;

                if (stone.numberOfMines == 1)
                {
                    stone.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[stone.rowsNumber].Cells[0].Value = "Stone";
                    dataGridViewMines.Rows[stone.rowsNumber].Cells[1].Value = stone.numberOfMines;
                    dataGridViewMines.Rows[stone.rowsNumber].Cells[2].Value = 5;
                    dataGridViewMines.Rows[stone.rowsNumber].Cells[3].Value = "30 stone";
                }
                dataGridViewMines.Rows[stone.rowsNumber].Cells[1].Value = stone.numberOfMines;

                buttonStone.Text = "Buy stone mine lvl " + (stone.numberOfMines + 1);
            }

        }
        /// <summary>
        /// Metoda definująca pracę programu po naciśniędziu przycisku buttonSulfur. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSulfur_Click(object sender, EventArgs e)
        {
            if (sulfur.numberOfMaterial < 20)
            {
                MessageBox.Show("You have too little sulfur!", "You can't buy it.");
            }
            else
            {
                sulfur.numberOfMines++;
                sulfur.numberOfMaterial -= 20;

                if (sulfur.numberOfMines == 1)
                {
                    sulfur.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[sulfur.rowsNumber].Cells[0].Value = "Sulfur";
                    dataGridViewMines.Rows[sulfur.rowsNumber].Cells[1].Value = sulfur.numberOfMines;
                    dataGridViewMines.Rows[sulfur.rowsNumber].Cells[2].Value = 5;
                    dataGridViewMines.Rows[sulfur.rowsNumber].Cells[3].Value = "20 sulfur";
                }
                dataGridViewMines.Rows[sulfur.rowsNumber].Cells[1].Value = sulfur.numberOfMines;

                buttonSulfur.Text = "Buy sulfur mine lvl " + (sulfur.numberOfMines + 1);
            }
        }
        /// <summary>
        /// Metoda definująca pracę programu po naciśniędziu przycisku buttonCrystal. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCrystal_Click(object sender, EventArgs e)
        {
            if (crystal.numberOfMaterial < 20)
            {
                MessageBox.Show("You have too little crystal!", "You can't buy it.");
            }
            else
            {
                crystal.numberOfMines++;
                crystal.numberOfMaterial -= 20;

                if (crystal.numberOfMines == 1)
                {
                    crystal.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[crystal.rowsNumber].Cells[0].Value = "Crystal";
                    dataGridViewMines.Rows[crystal.rowsNumber].Cells[1].Value = crystal.numberOfMines;
                    dataGridViewMines.Rows[crystal.rowsNumber].Cells[2].Value = 8;
                    dataGridViewMines.Rows[crystal.rowsNumber].Cells[3].Value = "20 crystal";
                }
                dataGridViewMines.Rows[crystal.rowsNumber].Cells[1].Value = crystal.numberOfMines;

                buttonCrystal.Text = "Buy crystal mine lvl " + (crystal.numberOfMines + 1);
            }
        }
        /// <summary>
        /// Metoda definująca pracę programu po naciśniędziu przycisku buttonJewels. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonJewels_Click(object sender, EventArgs e)
        {
            if (jewels.numberOfMaterial < 20)
            {
                MessageBox.Show("You have too little jewels!", "You can't buy it.");
            }
            else
            {
                jewels.numberOfMines++;
                jewels.numberOfMaterial -= 20;

                if (jewels.numberOfMines == 1)
                {
                    jewels.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[jewels.rowsNumber].Cells[0].Value = "Jewels";
                    dataGridViewMines.Rows[jewels.rowsNumber].Cells[1].Value = jewels.numberOfMines;
                    dataGridViewMines.Rows[jewels.rowsNumber].Cells[2].Value = 8;
                    dataGridViewMines.Rows[jewels.rowsNumber].Cells[3].Value = "20 jewels";
                }
                dataGridViewMines.Rows[jewels.rowsNumber].Cells[1].Value = jewels.numberOfMines;

                buttonJewels.Text = "Buy jewels mine lvl " + (jewels.numberOfMines + 1);
            }
        }
        /// <summary>
        /// Metoda definująca pracę programu po naciśniędziu przycisku buttonGold. Zmniejszanie ilości materiałów po kupnie kopalni, wypełnianie 
        /// tabeli wartościami dotyczącymi danych surowców, a także zwiększanie kolejnych poziomów kopalń w przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGold_Click(object sender, EventArgs e)
        {
            if (gold.numberOfMaterial < 2500)
            {
                MessageBox.Show("You have too little gold!", "You can't buy it.");
            }
            else
            {
                gold.numberOfMines++;
                gold.numberOfMaterial -= 2500;

                if (gold.numberOfMines == 1)
                {
                    gold.rowsNumber = dataGridViewMines.Rows.Add();
                    dataGridViewMines.Rows[gold.rowsNumber].Cells[0].Value = "Gold";
                    dataGridViewMines.Rows[gold.rowsNumber].Cells[1].Value = gold.numberOfMines;
                    dataGridViewMines.Rows[gold.rowsNumber].Cells[2].Value = 10;
                    dataGridViewMines.Rows[gold.rowsNumber].Cells[3].Value = "2500 gold";
                }
                dataGridViewMines.Rows[gold.rowsNumber].Cells[1].Value = gold.numberOfMines;

                buttonGold.Text = "Buy gold mine lvl " + (gold.numberOfMines + 1);
            }
        }

        /// <summary>
        /// Metody określające podświetlenie przycisku po najechaniu na przycisk. Kolejno, wszystkie funkcje wykonują tę samą operację
        /// zmiany koloru po najechaniu oraz zjechaniu z przycisku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWood_MouseHover(object sender, EventArgs e)
        {
            buttonWood.BackColor = Color.Maroon;
        }

        private void buttonWood_MouseLeave(object sender, EventArgs e)
        {
            buttonWood.BackColor = Color.Firebrick;
        }

        private void buttonMercury_MouseHover(object sender, EventArgs e)
        {
            buttonMercury.BackColor = Color.Maroon;
        }

        private void buttonMercury_MouseLeave(object sender, EventArgs e)
        {
            buttonMercury.BackColor = Color.Firebrick;
        }

        private void buttonStone_MouseHover(object sender, EventArgs e)
        {
            buttonStone.BackColor = Color.Maroon;
        }

        private void buttonStone_MouseLeave(object sender, EventArgs e)
        {
            buttonStone.BackColor = Color.Firebrick;

        }

        private void buttonSulfur_MouseHover(object sender, EventArgs e)
        {
            buttonSulfur.BackColor = Color.Maroon;
        }

        private void buttonSulfur_MouseLeave(object sender, EventArgs e)
        {
            buttonSulfur.BackColor = Color.Firebrick;
        }

        private void buttonCrystal_MouseHover(object sender, EventArgs e)
        {
            buttonCrystal.BackColor = Color.Maroon;
        }

        private void buttonCrystal_MouseLeave(object sender, EventArgs e)
        {
            buttonCrystal.BackColor = Color.Firebrick;
        }

        private void buttonJewels_MouseHover(object sender, EventArgs e)
        {
            buttonJewels.BackColor = Color.Maroon;
        }

        private void buttonJewels_MouseLeave(object sender, EventArgs e)
        {
            buttonJewels.BackColor = Color.Firebrick;
        }

        private void buttonGold_MouseHover(object sender, EventArgs e)
        {
            buttonGold.BackColor = Color.Maroon;
        }

        private void buttonGold_MouseLeave(object sender, EventArgs e)
        {
            buttonGold.BackColor = Color.Firebrick;
        }
        ///////////////////Koniec metod opisujących zmianę koloru przycisku po najechaniu.//////////////////////////


        /// <summary>
        /// Metoda definiująca pracę programu po kliknięciu przycisku buttonHero, do kupienia nowego bohatera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHero_Click(object sender, EventArgs e)
        {
            
            //formHero.ShowDialog();

            var result = formHero.ShowDialog();
            if (result == DialogResult.OK)
            {
                if(jewels.numberOfMaterial >=2 && gold.numberOfMaterial >= 1500)
                {
                    jewels.numberOfMaterial -= 2;
                    gold.numberOfMaterial -= 1500;

                    if (tmpBuyCastle == 0)
                        tmpBuyHero = dataGridViewHeroes.Rows.Add();

                    dataGridViewHeroes.Rows[tmpBuyHero].Cells[0].Value = "Bohater " + (tmpBuyHero + 1);
                    tmpBuyHero++;
                }
                else
                {
                    MessageBox.Show("You have too little material!", "You can't buy it.");
                }
            }
        }
        /// <summary>
        /// Metoda definiująca pracę programu po kliknięciu przycisku buttonCastle, do kupienia nowego zamku. Zmniejszanie zasobów po zakupie,
        /// wyświetlanie informacji w wyniku braku surowców do zakupu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCastle_Click(object sender, EventArgs e)
        {
            var result = formCastle.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (wood.numberOfMaterial >= 15 && wood.numberOfMaterial >= 20 && crystal.numberOfMaterial >= 2 && gold.numberOfMaterial >= 4000)
                {
                    jewels.numberOfMaterial -= 2;
                    gold.numberOfMaterial -= 4000;

                    if (tmpBuyHero == 0)
                        tmpBuyCastle = dataGridViewHeroes.Rows.Add();

                    dataGridViewHeroes.Rows[tmpBuyCastle].Cells[1].Value = "Zamek " + (tmpBuyCastle + 1);
                    tmpBuyCastle++;
                }
                else
                {
                    MessageBox.Show("You have too little material!", "You can't buy it.");
                }
            }
        }

        /// <summary>
        /// Przyciski dające graczowi surowce po naciśnięciu. Przyciski symulują uproszczone rozwiązanie, zamiast tworzenia mapy, po której gracz
        /// mógłby chodzić i znajdować oraz zdobywać takie surowce. Bardzo przydatne i konieczne również przy testach programu. Wszystkie metody 
        /// robią tę samą prostą czynnośc, iterują wartość surowców o
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGainWood_Click(object sender, EventArgs e)
        {
            wood.numberOfMaterial++;
        }

        private void buttonGainMercury_Click(object sender, EventArgs e)
        {
            mercury.numberOfMaterial++;
        }

        private void buttonGainStone_Click(object sender, EventArgs e)
        {
            stone.numberOfMaterial++;
        }

        private void buttonGainSulfur_Click(object sender, EventArgs e)
        {
            sulfur.numberOfMaterial++;
        }

        private void buttonGainCrystal_Click(object sender, EventArgs e)
        {
            crystal.numberOfMaterial++;
        }

        private void buttonGainJewels_Click(object sender, EventArgs e)
        {
            jewels.numberOfMaterial++;
        }

        private void buttonGainGold_Click(object sender, EventArgs e)
        {
            gold.numberOfMaterial += 100;
        }
        ///////////////////Koniec metod iterujących wartości surowców po naciśnięciu.///////////////////////
    }
}
