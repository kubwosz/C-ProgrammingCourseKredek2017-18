using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace JakubWoszczynaZad7
{
    class Board : FormTicTacToe
    {
        public int moves = 0;


        private Holder[,] holders = new Holder[3, 3];

        /// <summary>
        /// Zmienne odpowiadające za kółko i krzyżyk
        /// </summary>
        public const int X = 0;
        public const int O = 1;
        public const int b = 2;

        /// <summary>
        /// Zmienna typu boolean przechowująca tablicę pól, które zostały już uzyte w grze
        /// </summary>
        bool[,] isClicked = new bool[3, 3];

        /// <summary>
        /// Zmienna boolean mówiąca o wygranej, skonczonej grze.
        /// </summary>
        bool isWin = false;



/// <summary>
/// Metoda inicjująca, rysyjąca tablicę do gry
/// </summary>
        public void InitBoard()
        {
            for(int x = 0; x < 3; x++)
            {
                for(int y = 0; y < 3; y++)
                {
                    //slots[x, y] = new Rectangle(x*167,y*167,167,167);
                    holders[x, y] = new Holder();
                    holders[x, y].setValue(b);
                    holders[x, y].setLocation(new Point(x, y));

                    isClicked[x, y] = false;
                }
            }

        }
        /// <summary>
        /// Metoda wykrywająca uderzenie, oraz przypasowująca je do odpowiedniego pola
        /// </summary>
        /// <param name="loc"></param>
        /// <returns></returns>
        public bool DetectHit(Point loc)
        {
            //Sprawdza, czy kliknięte zotało w tablicę
            if (loc.Y <= 500)
            {
                int x = 0;
                int y = 0;

                if (loc.X < 167)
                {
                    x = 0;

                    if (loc.Y < 167)
                    {
                        y = 0;
                    }
                    else if (loc.Y > 167 && loc.Y < 334)
                    {
                        y = 1;
                    }
                    else if (loc.Y > 334 && loc.Y < 500)
                    {
                        y = 2;
                    }
                }
                else if (loc.X > 167 && loc.X < 334)
                {
                    x = 1;

                    if (loc.Y < 167)
                    {
                        y = 0;
                    }
                    else if (loc.Y > 167 && loc.Y < 334)
                    {
                        y = 1;
                    }
                    else if (loc.Y > 334 && loc.Y < 500)
                    {
                        y = 2;
                    }
                }
                else if (loc.X > 334)
                {
                    x = 2;

                    if (loc.Y < 167)
                    {
                        y = 0;
                    }
                    else if (loc.Y > 167 && loc.Y < 334)
                    {
                        y = 1;
                    }
                    else if (loc.Y > 334 && loc.Y < 500)
                    {
                        y = 2;
                    }
                }

                //Jeśli pole nie jest kliknięta,a gra nie została skoczona
                if (!isClicked[x, y] && isWin==false) { 
                moves++;

                    if (moves % 2 == 0)
                    {
                        Graph.drawX(new Point(x, y));
                        holders[x, y].setValue(X);

                        if (checkWinner(X))
                        {
                            MessageBox.Show("Gracz X wygrywa!");
                            isWin = true;
                        }
                    }
                    else
                    {
                        Graph.drawO(new Point(x, y));
                        holders[x, y].setValue(O);

                        if (checkWinner(O))
                        {
                            MessageBox.Show("Gracz O wygyrwa!");
                            isWin = true;
                        }
                    }
                    isClicked[x, y] = true;
            }
            }
            return isWin;
        }

        /// <summary>
        /// Metoda sprawdzająca, który gracz zostaje zwyciezcą
        /// </summary>
        /// <param name="sign"></param>
        /// <returns></returns>
        public bool checkWinner(int sign)
        {
            bool isWon = false;

            for (int x = 0; x < 3; x++)
            {
                if (holders[x, 0].getValue() == sign && holders[x, 1].getValue() == sign && holders[x, 2].getValue() == sign)
                {
                    isWon = true;
                }

                if (holders[0, x].getValue() == sign && holders[1, x].getValue() == sign && holders[2, x].getValue() == sign)
                {
                   isWon = true;
                }

                switch (x)
                {
                    case 0:
                        if (holders[x, 0].getValue() == sign && holders[x + 1, 1].getValue() == sign && holders[x + 2, 2].getValue() == sign)
                        {
                            isWon = true;
                        }
                        break;

                    case 2:
                        if (holders[x, 0].getValue() == sign && holders[x - 1, 1].getValue() == sign && holders[x - 2, 2].getValue() == sign)
                        {
                            isWon = true;
                        }
                        break;
                }

            }
            return isWon;
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxO)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxO
            // 
            this.pictureBoxO.Location = new System.Drawing.Point(506, 88);
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(664, 500);
            this.Name = "Board";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }


    /// <summary>
    /// Klasa Holder, przechowuje informacje o lokacji oraz początkowe wartości tablicy = b
    /// </summary>
    class Holder
    {
        private Point location;
        public int value = Board.b;

        public void setLocation(Point p)
        {
            location = p;
        }

    public Point getLocation()
        {
            return location;
        }

        public void setValue(int i)
        {
            value = i;
        }

        public int getValue()
        {
            return value;
        }
    }
}


