using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SklepZoologiczny.Model
{
    internal class Klient:Uzytkownik 
    {

        public string login;
        private string opisProfilu, adres, miasto;
        private int nrDomu; 


        public string Adres { get => adres; set => adres = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string OpisProfilu { get => opisProfilu; set => opisProfilu = value; }
        public int NrDomu { get => nrDomu; set => nrDomu = value; }


        public Klient() { }


        public Klient(string login, string mail,string adres, string miasto, int nrDomu)
        {
            Login = login;
            Mail = mail;
            Adres = adres;
            Miasto = miasto;
            NrDomu = nrDomu;
        }

    }
}
