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
    public partial class ZastawPolaForm : Form
    {
        private List<Pole> pola;
        private Gra gra;
        private int suma;
        private int roznica;

        public ZastawPolaForm(List<Pole> pola, Gra gra)
        {
            InitializeComponent();
            this.pola = pola;
            this.gra = gra;
            foreach (var item in pola)
            {
                if (item.czyZastawione == false && item.czyDoZastawiania == true)//item.nazwa.Contains("peron")==false && item.nazwa != "wodociagi" && item.nazwa != "elektrownia")
                {
                    var tekst = item.nazwa + " czynsz: " + item.liczCzynsz();
                    listBoxPola.Items.Add(tekst);
                }
            }
            roznica = pola[0].wlasciciel.gotowka - gra.obecnePole.liczCzynsz();
            label1.Text = "+"+pola[0].wlasciciel.gotowka.ToString() + "\n-" + gra.obecnePole.liczCzynsz().ToString() + "\n______\n  " + roznica.ToString();
        }

        private void listBoxPola_SelectedIndexChanged(object sender, EventArgs e)
        {
            suma = roznica;
            label1.Text = "+"+pola[0].wlasciciel.gotowka.ToString() + "\n-" + gra.obecnePole.liczCzynsz().ToString()+"\n";
            foreach (var item in listBoxPola.SelectedItems)
            {
                var tekst = item.ToString();
                tekst = tekst.Remove(0,tekst.LastIndexOf(":") + 1);
                label1.Text +="+"+ tekst + "\n";
                suma = suma + Convert.ToInt32(tekst);
            }
            label1.Text += "______\n  " + suma.ToString();
        }

        private void buttonZastaw_Click(object sender, EventArgs e)
        {
            if(suma>=0)
            {
                gra.wartoscZastawiana = suma - roznica;
                foreach (var pole in pola)
                {
                    foreach (var item in listBoxPola.SelectedItems)
                    {
                        var tekst = pole.nazwa + " czynsz: " + pole.liczCzynsz();
                        if (tekst == item.ToString())
                        {
                            pole.czyZastawione = true;
                        }
                    }
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Musisz zastwić więcej");
            }
            
        }
    }
}
