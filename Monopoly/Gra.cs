using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{

    public partial class Gra : Form
    {
        private List<Pole> listaPol;
        private List<Gracz> listaGraczy;
        public Gracz obecnyGracz;
        public Pole obecnePole;
        private int[] tablicaPozycjiGraczy;
        public int wartoscZastawiana;
        public Gra(List<Pole> listaPol, List<Gracz> listaGraczy)
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Red;
            this.listaPol = listaPol;
            this.listaGraczy = listaGraczy;
            tablicaPozycjiGraczy = new int[listaGraczy.Count];
            aktualizujTablicePozycjiGraczy();
            panel1.BackgroundImage = Image.FromFile("plansza.jpg");
            foreach (var item in listaGraczy)
            {
                panel1.Controls.Add(item.obrazek);
            }
            obecnyGracz = listaGraczy[0];
            buttonRzucKostka.Enabled = false;
            buttonKoniecTury.Enabled = false;
            //int i = 0;
            //foreach (var item in listaPol)
            //{
            //    if(i%3==0)
            //    {
            //        item.wlasciciel = listaGraczy[0];
            //        listaGraczy[0].pola.Add(item);
            //        item.iloscBlokow = 4;
            //    }
            //    if (i % 3 == 1)
            //    {
            //        item.wlasciciel = listaGraczy[1];
            //        item.iloscBlokow = 4;
            //        listaGraczy[1].pola.Add(item);
            //    }
            //    if (i % 3 == 2)
            //    {
            //        item.wlasciciel = listaGraczy[2];
            //        item.iloscBlokow = 4;
            //        listaGraczy[2].pola.Add(item);
            //    }
            //    i++;


            //}

            start();
        }

        private void aktualizujTablicePozycjiGraczy()
        {
            int i = 0;
            foreach (var item in listaGraczy)
            {
                tablicaPozycjiGraczy[i] = item.numerAktualnegoPola;
                i++;
            }
            
        }

        public void aktualizujTekst()
        {
            labelNazwaGracza.Text = "Ruch gracza: " + obecnyGracz.nazwa;
            labelGotowka.Text = "Gotówka: "+obecnyGracz.gotowka.ToString();

            pictureBox1.BackColor = obecnyGracz.kolor;
            listBoxWlasnosci.Items.Clear();
            foreach (var item in obecnyGracz.pola)
            {
                listBoxWlasnosci.Items.Add(item.nazwa);
            }
            wyswietlWszystkieInformacje();
        }

        private void start()
        {
            wyswietlWszystkieInformacje();
            buttonRzucKostka.Enabled = true;
            aktualizujTekst();
            if(obecnyGracz.czyWWiezieniu>0)
            {
                MessageBox.Show("Jesteś w wiezieniu");
                buttonKoniecTury.Enabled = true;
                buttonRzucKostka.Enabled = false;
                buttonKupPole.Enabled = false;
                obecnyGracz.czyWWiezieniu--;
            }
            
        }
        private void buttonRzucKostka_Click(object sender, EventArgs e)
        {
            //bot();

            buttonRzucKostka.Enabled = false;
            buttonKoniecTury.Enabled = true;
            rzucKostami();
            
        }

        private void rzucKostami()
        {
            Random rand = new Random();
            int kostka1 = rand.Next(1,7);
            int kostka2 = rand.Next(1,7);
            //MessageBox.Show(kostka1.ToString()+"\n"+kostka2.ToString());
            wynik(kostka1 +kostka2);
        }

        private void wynik(int sumaOczek)
        {
            int ktorePole = sumaOczek + obecnyGracz.numerAktualnegoPola;
            ktorePole = okrazenie(ktorePole);
            obecnyGracz.numerAktualnegoPola = ktorePole;
            obecnePole = listaPol[ktorePole];
            sprawdzCzyPoleJestZajete(ktorePole);
            MessageBox.Show(obecnePole.nazwa);
            if (obecnePole.nazwa == "szansa")
            {
                MessageBox.Show("szansa");
            }
            else if(obecnePole.nazwa =="ryzyko")
            {
                MessageBox.Show("ryzyko");
            }
            else if (obecnePole.nazwa == "wiezienie")
            {
                MessageBox.Show("wiezienie");
            }
            else if (obecnePole.nazwa == "podatek")
            {
                MessageBox.Show("podatek");
                if (obecnyGracz.gotowka < obecnePole.liczCzynsz())
                {
                    zastaw();
                }
                obecnyGracz.gotowka -= obecnePole.liczCzynsz();
            }
            //else if (obecnePole.nazwa.Contains("peron"))
            //{
            //    MessageBox.Show("peron");
            //}
            //else if (obecnePole.nazwa == "elektrownia")
            //{
            //    MessageBox.Show("elektrownia");
            //}
            //else if (obecnePole.nazwa == "wodociagi")
            //{
            //    MessageBox.Show("wodociagi");
            //}
            else if (obecnePole.nazwa == "wolny parking")
            {
                MessageBox.Show("wolny parking");
            }
            else if (obecnePole.nazwa == "idzDoWiezienia")
            {
                MessageBox.Show("idzDoWiezienia");
                obecnyGracz.numerAktualnegoPola = 10;
                //Refresh();
                aktualizujTablicePozycjiGraczy();
                obecnyGracz.czyWWiezieniu = 3;

            }
            else
            {
                sprawdzCZyPoleJestCzyjasWlasnoscia(ktorePole);
            }

            aktualizujTablicePozycjiGraczy();

        }

        private void sprawdzCZyPoleJestCzyjasWlasnoscia(int ktorePole)
        {
            int oplata = 0;
            if(obecnePole.wlasciciel.nazwa != "brak" && obecnePole.wlasciciel.nazwa != obecnyGracz.nazwa)
            {
                if(obecnePole.wlasciciel.czyWWiezieniu==0)
                {
                    if (obecnePole.nazwa.Contains("peron"))
                    {
                        oplata = obecnePole.liczPostujNaPeronach();
                    }

                    else if (obecnePole.czyZastawione == false)
                    {
                        oplata = obecnePole.liczCzynsz();
                    }
                    else if (obecnePole.nazwa == "elektrownia" || obecnePole.nazwa == "wodociagi")
                    {
                        oplata = obecnyGracz.liczbaMediow * obecnePole.liczCzynsz();
                    }
                    MessageBox.Show("Musisz zapłaci " + oplata + " graczowi: " + obecnePole.wlasciciel.nazwa);
                    if (obecnyGracz.gotowka < oplata)
                    {
                        zastaw();
                    }
                    obecnyGracz.gotowka -= oplata;
                    obecnePole.wlasciciel.gotowka += oplata;
                    aktualizujTekst();
                }
                else
                {
                    MessageBox.Show("Właścieciel pola jest w więzieniu nie płacisz czynszu");
                }
            }
            
        }

        private void zastaw()
        {
            ZastawPolaForm zastaw = new ZastawPolaForm(obecnyGracz.pola, this);
            var dialogResult = zastaw.ShowDialog();


            obecnyGracz.gotowka += wartoscZastawiana;
        }

        private void sprawdzCzyPoleJestZajete(int ktorePole)
        {
            if(tablicaPozycjiGraczy.Contains(obecnyGracz.numerAktualnegoPola))
            {
                obecnyGracz.Ruch(listaPol[ktorePole].pozycjaX+15, listaPol[ktorePole].pozycjaY+15);
            }
            else
                obecnyGracz.Ruch(listaPol[ktorePole].pozycjaX, listaPol[ktorePole].pozycjaY);

        }

        private int okrazenie(int ktorePole)
        {
            if (ktorePole >= 40)
            {
                ktorePole -= 40;
                obecnyGracz.gotowka += 250; // gotówka za przejscie przez start
                aktualizujTekst();
            }
                
            return ktorePole;
        }

        private Gracz nastepnyGracz(Gracz obecnyGracz)
        {
            if (obecnyGracz.numer  == listaGraczy.Count)
                obecnyGracz = listaGraczy[0];
            else
                obecnyGracz = listaGraczy[obecnyGracz.numer];
            return obecnyGracz;
        }

        private void koniec()
        {
            obecnyGracz = nastepnyGracz(obecnyGracz);
            obecnePole = null;
            MessageBox.Show("Ruch gracza: " + obecnyGracz.nazwa,"Ruch",MessageBoxButtons.OK);
            start();
        }

        private void buttonKupPole_Click(object sender, EventArgs e)
        {
            kupPole();
        }

        private void kupPole()
        {
            if (obecnePole.wlasciciel.nazwa == "brak")
            {
                if (obecnyGracz.gotowka >= obecnePole.cenaZakupu)
                {
                    if(obecnePole.nazwa.Contains("peron"))
                    {
                        obecnyGracz.liczbaPeronow++;
                    }
                    else if (obecnePole.nazwa == "elektrownia")
                    {
                        obecnyGracz.liczbaMediow++;
                    }
                    else if (obecnePole.nazwa == "wodociagi")
                    {
                        obecnyGracz.liczbaMediow++;
                    }
                    else
                    {
                        obecnePole.czyDoZastawiania = true;
                    }


                    obecnyGracz.pola.Add(obecnePole);
                    obecnyGracz.gotowka -= obecnePole.cenaZakupu;
                    obecnePole.wlasciciel = obecnyGracz;
                    //obecnyGracz.pola.Sort();
                    aktualizujTekst();
                }
                else
                {
                    MessageBox.Show("Nie stać cię !");
                }
            }
            else
            {
                MessageBox.Show("To pole ma właściciela!");

            }
        }

        private void buttonKoniecTury_Click(object sender, EventArgs e)
        {
            buttonRzucKostka.Enabled = true;
            buttonKoniecTury.Enabled = false;
            koniec();
        }

        private void bot()
        {
            int i = 0;
            do
            {
                i++;
                start();
                rzucKostami();
                panel1.Refresh();
                koniec();
            }
            while (czyRowne() == 1);
            
           
        }

        private int czyRowne()
        {
            if (tablicaPozycjiGraczy[0] == tablicaPozycjiGraczy[1] && tablicaPozycjiGraczy[0] == tablicaPozycjiGraczy[2] && tablicaPozycjiGraczy[0] == tablicaPozycjiGraczy[3])
                return 0;
            else
                return 1;
        }

        private void listBoxWlasnosci_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pole budujNaPolu = new Pole();
            foreach (var item in obecnyGracz.pola)
            {
                if(item.nazwa == listBoxWlasnosci.SelectedItem.ToString())
                {
                    budujNaPolu = item;
                }
            }

            BudujForma buduj = new BudujForma(budujNaPolu, obecnyGracz, this);
            buduj.Show();
            //while(buduj.czyAktywna == true)
            //{
            //    aktualizujTekst();
            //}
            
            //MessageBox.Show("Nazwa: "+ listBoxWlasnosci.SelectedItem +"\nLiczba budynkow: "+obecnyGracz.pola[listBoxWlasnosci.SelectedIndex].iloscBlokow+"\nLiczba hoteli: "+ obecnyGracz.pola[listBoxWlasnosci.SelectedIndex].iloscHoteli+"\nCzynsz: "+ obecnyGracz.pola[listBoxWlasnosci.SelectedIndex].czynsz[obecnyGracz.pola[listBoxWlasnosci.SelectedIndex].iloscBlokow + obecnyGracz.pola[listBoxWlasnosci.SelectedIndex].iloscHoteli]);
        }

        void wyswietlWszystkieInformacje()
        {
            textBox1.Text = "";
            string text = null;
            foreach(var item in listaGraczy)
            {
                text += "nazwa: " + item.nazwa + "\ngotowka: " + item.gotowka+"\n ";
            }
            textBox1.Text = text;
        }
    }
}
