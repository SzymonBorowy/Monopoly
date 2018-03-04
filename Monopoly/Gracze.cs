using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Gracze : Form
    {
        private List<Pole> listaPol;
        private List<Gracz> listaGraczy;
        public Gracze()
        {
            InitializeComponent();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            buttonKolor1.Enabled = false;
            buttonKolor2.Enabled = false;
            buttonKolor3.Enabled = false;
            buttonKolor4.Enabled = false;
            buttonKolor1.Click += ustawKolor;
            buttonKolor2.Click += ustawKolor;
            buttonKolor3.Click += ustawKolor;
            buttonKolor4.Click += ustawKolor;

            listaPol = new List<Pole>();
            listaGraczy = new List<Gracz>();
            pobierzPolaZPliku();
        }
        private void pobierzPolaZPliku()
        {
            string[] linie = File.ReadAllLines("Pola_wartosci.txt");
            foreach (var item in linie)
            {
                string[] linia = item.Split('.');
                Pole pole = new Pole();
                try
                {
                    pole.nazwa = linia[0];
                    pole.numer = Convert.ToInt32(linia[1]);
                    pole.cenaZakupu = Convert.ToInt32(linia[2]);
                    pole.czynsz[0] = Convert.ToInt32(linia[3]);
                    pole.czynsz[1] = Convert.ToInt32(linia[4]);
                    pole.czynsz[2] = Convert.ToInt32(linia[5]);
                    pole.czynsz[3] = Convert.ToInt32(linia[6]);
                    pole.czynsz[4] = Convert.ToInt32(linia[7]);
                    pole.czynsz[5] = Convert.ToInt32(linia[8]);
                    pole.cenaBudynku = Convert.ToInt32(linia[9]);
                    pole.wlasciciel.nazwa = linia[10];
                    pole.pozycjaX = Convert.ToInt32(linia[11]);
                    pole.pozycjaY = Convert.ToInt32(linia[12]);
                }
                catch
                { }
                listaPol.Add(pole);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            buttonKolor1.Enabled = true;
            buttonKolor2.Enabled = true;
            buttonKolor3.Enabled = false;
            buttonKolor4.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            buttonKolor1.Enabled = true;
            buttonKolor2.Enabled = true;
            buttonKolor3.Enabled = true;
            buttonKolor4.Enabled = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            buttonKolor1.Enabled = true;
            buttonKolor2.Enabled = true;
            buttonKolor3.Enabled = true;
            buttonKolor4.Enabled = true;
        }

        private void buttonGraj_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                dodajGracza(textBox1.Text, buttonKolor1.BackColor);
                dodajGracza(textBox2.Text, buttonKolor2.BackColor);
            }
            else if (radioButton2.Checked)
            {
                dodajGracza(textBox1.Text, buttonKolor1.BackColor);
                dodajGracza(textBox2.Text, buttonKolor2.BackColor);
                dodajGracza(textBox3.Text, buttonKolor3.BackColor);
            }
            else if (radioButton3.Checked)
            {
                dodajGracza(textBox1.Text, buttonKolor1.BackColor);
                dodajGracza(textBox2.Text, buttonKolor2.BackColor);
                dodajGracza(textBox3.Text, buttonKolor3.BackColor);
                dodajGracza(textBox4.Text, buttonKolor4.BackColor);
            }
            if(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked)
            {
                Gra gra = new Gra(listaPol, listaGraczy);
                gra.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Błąd","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private int i = 1;
        private void dodajGracza(string nazwa, Color kolor)
        {
            Gracz gracz = new Gracz(i);
            gracz.nazwa = nazwa;
            gracz.numer = i;
            gracz.gotowka = 300;
            gracz.numerAktualnegoPola = 0;
            gracz.kolor = kolor;
            gracz.obrazek.BackColor = kolor;
            listaGraczy.Add(gracz);
            i++;
        }

        private void ustawKolor(object sender, EventArgs e)
        {
            var button = (Button)sender;
            ColorDialog colorDialog1 = new ColorDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button.BackColor = colorDialog1.Color;
            }
        }
    }
}
