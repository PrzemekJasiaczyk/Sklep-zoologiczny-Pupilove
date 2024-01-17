using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZoologiczny.Model
{
    internal class Zwierzak
    {
        private string imie, gatunek, imie_wlasciciela, wiek;
        private double czas_pozostawienia;



        public string Imie { get => imie; set => imie = value; }
        public string Gatunek { get => gatunek; set => gatunek = value; }
        public string Imie_wlascicela { get => imie_wlasciciela; set => imie_wlasciciela = value; }
        public string Wiek { get => wiek; set => wiek = value; }

        public double Czas_pozostawienia { get => czas_pozostawienia; set => czas_pozostawienia = value; }

        public Zwierzak( string imie, string wiek, string gatunek)
        {
            Imie = imie;
            Wiek = wiek;
            Gatunek = gatunek;
        }
    }
}
