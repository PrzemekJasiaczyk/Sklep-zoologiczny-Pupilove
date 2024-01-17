using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SklepZoologiczny.Model
{
    internal class Produkt
    {
        private string nazwa, brand, description;
        private double cenaSprzedarzy, cenaKupna;
        private int discount;
        private bool czyWypozyczony;

        internal static List<Produkt> ListaProduktow = new List<Produkt>();

        public Produkt(string nazwa, string brand, string description, double cenaSprzedarzy, double cenaKupna, int discount, bool czyWypozyczony)
        {
            this.Nazwa = nazwa;
            this.Brand = brand;
            this.Description = description;
            this.CenaSprzedarzy = cenaSprzedarzy;
            this.CenaKupna = cenaKupna;
            this.Discount = discount;
            this.CzyWypozyczony = czyWypozyczony;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Description { get => description; set => description = value; }
        public double CenaSprzedarzy { get => cenaSprzedarzy; set => cenaSprzedarzy = value; }
        public double CenaKupna { get => cenaKupna; set => cenaKupna = value; }
        public int Discount { get => discount; set => discount = value; }
        public bool CzyWypozyczony { get => czyWypozyczony; set => czyWypozyczony = value; }

        private void DodajDoListy(Produkt produkt)
        {
            ListaProduktow.Add(produkt);
        }

        internal static void PobierzProduktyZBazyDanych(string connectionString)
        {
            ListaProduktow.Clear(); // Wyczyść listę przed pobraniem nowych danych

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT ProductName, ProductBrand, ProductDescription, ProductPriceSell, ProductPriceBuy, ProductDiscountId, ProductQuantity FROM Products";

                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Produkt produkt = new Produkt(
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetDouble(3),
                            reader.GetDouble(4),
                            reader.GetInt32(5),
                            reader.GetInt32(6) > 0
                        );
                    }
                }
                catch (Exception ex)
                {
                    // Obsługa błędów
                }
            }
        }
    }
}
