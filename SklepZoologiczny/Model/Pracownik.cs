using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZoologiczny.Model
{
    internal class Pracownik :Uzytkownik
    {
        private string stanowisko;
        private static List<Pracownik> lista_pracownikow = new List<Pracownik>();

        internal static List<Pracownik> Lista_pracownikow { get => lista_pracownikow; set => lista_pracownikow = value; }
        public string Stanowisko { get => stanowisko; set => stanowisko = value; }

    }
}
