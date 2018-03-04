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
    public partial class BudujForma : Form 
    {
        private Pole budujNaPolu;
        private Gracz obecnyGracz;
        private Gra gra;
        public bool czyAktywna;
        public BudujForma(Pole budujNaPolu, Gracz obecnyGracz, Gra gra)
        {
            InitializeComponent();
            czyAktywna = true;
            this.budujNaPolu = budujNaPolu;
            this.obecnyGracz = obecnyGracz;
            this.gra = gra;
            zastawione();
                
            aktualizujTekst();
        }

        private void zastawione()
        {
            if (budujNaPolu.czyZastawione == true)
            {
                buttonWykup.Text = "Wykup za " + budujNaPolu.liczCzynsz().ToString();
                buttonWykup.Enabled = true;
                buttonBudujBlok.Enabled = false;
                buttonBudujHotel.Enabled = false;
                buttonZastaw.Enabled = false;
            }
        }

        private void buttonBudujBlok_Click(object sender, EventArgs e)
        {
            if(obecnyGracz.gotowka >= budujNaPolu.cenaBudynku)
            {
                if(budujNaPolu.iloscBlokow<4)
                {
                    budujNaPolu.iloscBlokow++;
                    obecnyGracz.gotowka -= budujNaPolu.cenaBudynku;
                    aktualizujTekst();
                }
                else
                {
                    MessageBox.Show("Możesz postawić maksymalnie 4 bloki");
                }
               
            }
            else
            {
                MessageBox.Show("Nie stać cię !");
            }
            
        }

        private void aktualizujTekst()
        {
            label1.Text = "Nazwa: " + budujNaPolu.nazwa +"\nCena za blok: "+budujNaPolu.cenaBudynku.ToString()+ "\nLiczba budynkow: " + budujNaPolu.iloscBlokow + "\nLiczba hoteli: " + budujNaPolu.iloscHoteli + "\nCzynsz: " + budujNaPolu.czynsz[budujNaPolu.iloscBlokow + budujNaPolu.iloscHoteli];
            gra.aktualizujTekst();
        }

        private void BudujForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            czyAktywna = false;
        }

        private void buttonBudujHotel_Click(object sender, EventArgs e)
        {
            if(budujNaPolu.iloscBlokow==4)
            {
                if (obecnyGracz.gotowka >= budujNaPolu.cenaBudynku)
                {
                    if (budujNaPolu.iloscHoteli < 1)
                    {
                        budujNaPolu.iloscHoteli++;
                        obecnyGracz.gotowka -= budujNaPolu.cenaBudynku;
                        aktualizujTekst();
                    }
                    else
                    {
                        MessageBox.Show("Możesz postawić maksymalnie 1 hotel");
                    }

                }
                else
                {
                    MessageBox.Show("Nie stać cię !");
                }
            }
            else
            {
                MessageBox.Show("Masz za mało bloków");
            }
            
        }

        private void buttonWykup_Click(object sender, EventArgs e)
        {
            if (obecnyGracz.gotowka >= budujNaPolu.liczCzynsz())
            {
                obecnyGracz.gotowka -= budujNaPolu.liczCzynsz();
                buttonWykup.Text = "Wykup";
                buttonWykup.Enabled = false;
                buttonBudujBlok.Enabled  = true;
                buttonBudujHotel.Enabled = true;
                buttonZastaw.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nie stać cię !");
            }
            gra.aktualizujTekst();
        }

        private void buttonZastaw_Click(object sender, EventArgs e)
        {
            if(budujNaPolu.czyDoZastawiania == true)
            {
                obecnyGracz.gotowka += budujNaPolu.liczCzynsz();
                budujNaPolu.czyZastawione = true;
                zastawione();
                gra.aktualizujTekst();
            }
            else
            {
                MessageBox.Show("Tego pola nie można zastawiać");
            }
            
        }
    }
}
