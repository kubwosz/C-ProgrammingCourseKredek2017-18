using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace JakubWoszczynaZad7
{
    class Graph
    {
        private static Graphics gObj;
       

        public Graph(Graphics g)
        {,
            gObj = g;
            setUpCanvas();
        }

        /// <summary>
        /// Metoda rysująca linie, pole do gry wg podanych lokalizacji
        /// </summary>
        public void setUpCanvas()
        {
            Brush bg = new SolidBrush(Color.WhiteSmoke);
            Pen lines = new Pen(Color.Black);

            gObj.FillRectangle(bg, new Rectangle(0, 0, 500, 600));

            gObj.DrawLine(lines, new Point(167, 0), new Point(167, 600));
            gObj.DrawLine(lines, new Point(334, 0), new Point(334, 600));

            gObj.DrawLine(lines, new Point(0, 167), new Point(500, 167));
            gObj.DrawLine(lines, new Point(0, 334), new Point(500, 334));

            gObj.DrawLine(lines, new Point(0, 500), new Point(500, 500));
        }

        /// <summary>
        /// Metoda ryzująca X
        /// </summary>
        /// <param name="loc"></param>
        public static void drawX(Point loc)
        {
            Image imageX = JakubWoszczynaZad7.Properties.Resources.x;
            Rectangle rect = new Rectangle(loc.X * 167, loc.Y * 167, 147, 147);

            gObj.DrawImage(imageX, rect);

        }
        /// <summary>
        /// Metoda ryzująca O
        /// </summary>
        /// <param name="loc"></param>
        public static void drawO(Point loc)
        {
            Image imageO = JakubWoszczynaZad7.Properties.Resources.o;
            Rectangle rect = new Rectangle(loc.X * 167, loc.Y * 167, 147, 147);

            gObj.DrawImage(imageO, rect);

        }
    }
}
