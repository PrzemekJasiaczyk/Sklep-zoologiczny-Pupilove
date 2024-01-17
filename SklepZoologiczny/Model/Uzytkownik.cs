using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SklepZoologiczny.Model
{
    internal class Uzytkownik
    {
        private string login, haslo, mail, ulica, miasto, kod_pocztowy, mieszkanie;
        private byte[] UserAvatar;

        private Klient klient;
        private Pracownik stanowisko;


        private static List<Uzytkownik> Lista_Uzytkownikow = new List<Uzytkownik>();

        public string Login { get => login; set => login = value; }
        public string Haslo { get => haslo; set => haslo = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Ulica { get => ulica; set => ulica = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string Kod_pocztowy { get => kod_pocztowy; set => kod_pocztowy = value; }
        public string Mieszkanie { get => mieszkanie; set => mieszkanie = value; }
        public byte[] UserAvatar1 { get => UserAvatar; set => UserAvatar = value; }
    }
}
