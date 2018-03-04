using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Pole
    {
        //nazwa.numer.cena.czynsz1.czynsz2.czynsz3.czynsz4.czynsz5.czynsz6.cenaBudynku.właściciel
        public string nazwa { get; set; }
        public int numer{ get; set; }
        public int cenaZakupu{ get; set; }
        public int[] czynsz { get; set; }
        public int cenaBudynku{ get; set; }
        public Gracz wlasciciel{ get; set; }
        public int iloscBlokow{ get; set; }
        public int iloscHoteli { get; set; }
        public int pozycjaX;
        public int pozycjaY;
        public bool czyZastawione;
        public bool czyDoZastawiania;

        public Pole()
        {
            czynsz = new int[6];
            nazwa = null; 
            numer = 0; 
            cenaZakupu = 0;
            czynsz[0] = 0; 
            czynsz[1] = 0; 
            czynsz[2] = 0; 
            czynsz[3] = 0; 
            czynsz[4] = 0; 
            czynsz[5] = 0;    
            cenaBudynku = 0; 
            wlasciciel = new Gracz();
            iloscBlokow = 0;
            iloscHoteli = 0;
            pozycjaX = -1;
            pozycjaY = -1;
            czyZastawione = false;
            czyDoZastawiania = false;
        }

        public int liczCzynsz()
        {
            return czynsz[iloscBlokow + iloscHoteli];
        }

        public int liczPostujNaPeronach()
        {
            return czynsz[wlasciciel.liczbaPeronow];
        }
    }
}
