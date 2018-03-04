using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public class Gracz
    {
        public string nazwa;
        public int numer;
        public List<Pole> pola;
        public int gotowka;
        public Color kolor;
        public int numerAktualnegoPola;
        public PictureBox obrazek;
        public int liczbaPeronow;
        public int liczbaMediow;
        public int czyWWiezieniu;

        public Gracz(int i)
        {
            nazwa = null;
            numer = -1;
            pola = new List<Pole>();
            gotowka = -1;
            numerAktualnegoPola = -1;
            kolor = Color.Black;
            obrazek = new PictureBox();
            obrazek.Size = new Size(20, 20);
            obrazek.Left = 15 + 20 ;
            obrazek.Top = 15 + (20 + 5) * i;
            liczbaPeronow = 0;
            liczbaMediow = 0;
            czyWWiezieniu = 0;
        }
        public Gracz()
        {
            nazwa = "brak";
        }

        public void Ruch(int x, int y)
        {
            obrazek.Left = x;
            obrazek.Top = y;
        }
    }
}
