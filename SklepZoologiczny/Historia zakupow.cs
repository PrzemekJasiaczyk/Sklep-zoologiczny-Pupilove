using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SklepZoologiczny
{
    public partial class Historia_zakupow : Form
    {
        private int userId;

        public Historia_zakupow(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            FillDataGridView();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_wyjście_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            this.Hide();
            homeForm.ShowDialog();
        }

        private void FillDataGridView()
        {
            string konfiguracja = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
            MySqlConnection polaczenie = new MySqlConnection(konfiguracja);
            try
            {
              
                string zapytanieSQL = "SELECT Orders.OrderId, Orders.OrderEmail, Orders.OrderPrice, OrderStatus.StatusName, COUNT(OrderItem.ProductId) AS ProductCount " +
                                      "FROM Orders " +
                                      "INNER JOIN OrderStatus ON Orders.StatusId = OrderStatus.StatusId " +
                                      "LEFT JOIN OrderItem ON Orders.OrderId = OrderItem.OrderId " +
                                      "WHERE Orders.UserId = @UserId " +
                                      "GROUP BY Orders.OrderId";

                MySqlCommand zapytanie = new MySqlCommand(zapytanieSQL, polaczenie);


                zapytanie.Parameters.AddWithValue("@UserId", userId);

                
                MySqlDataAdapter adapter = new MySqlDataAdapter(zapytanie);
                DataTable tabelaZamowien = new DataTable();
                adapter.Fill(tabelaZamowien);

   
                dataGridView1.DataSource = tabelaZamowien;
                dataGridView1.Columns[0].Visible = false; //krywanie 1 kolumny z id
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas komunikacji z bazą danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void FillDetale()
        {
            // Sprawdź, czy wiersz został zaznaczony w dataGridView1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz identyfikator zamówienia zaznaczonego wiersza
                int orderId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OrderId"].Value);

                // Utwórz nowe połączenie do bazy danych
                MySqlConnection polaczenieDetale = new MySqlConnection("datasource=localhost; port=3306; username=root; password=1234; database=pupilove");

                try
                {
                    polaczenieDetale.Open();

                    // Utwórz zapytanie SQL do pobrania nazw, cen i liczby produktów w danym zamówieniu
                    string zapytanieDetaleSQL = "SELECT Products.ProductName, Products.ProductPriceSell, COUNT(OrderItem.ProductId) AS ProductCount " +
                                                 "FROM OrderItem " +
                                                 "INNER JOIN Products ON OrderItem.ProductId = Products.id " +
                                                 "WHERE OrderItem.OrderId = @OrderId " +
                                                 "GROUP BY Products.ProductName, Products.ProductPriceSell";

                    MySqlCommand zapytanieDetale = new MySqlCommand(zapytanieDetaleSQL, polaczenieDetale);

                    // Dodaj parametr do zapytania
                    zapytanieDetale.Parameters.AddWithValue("@OrderId", orderId);

                    // Wykonaj zapytanie
                    MySqlDataAdapter adapterDetale = new MySqlDataAdapter(zapytanieDetale);
                    DataTable tabelaDetale = new DataTable();
                    adapterDetale.Fill(tabelaDetale);

                    // Przypisz dane do dataGridView_detale
                    dataGridView_detale.DataSource = tabelaDetale;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas komunikacji z bazą danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenieDetale.Close();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć zamówienie przed przejściem do szczegółów.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillAdres()
        {
            // Sprawdź, czy wiersz został zaznaczony w dataGridView1
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz identyfikator zamówienia zaznaczonego wiersza
                int orderId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["OrderId"].Value);

                // Utwórz nowe połączenie do bazy danych
                MySqlConnection polaczenieDetale = new MySqlConnection("datasource=localhost; port=3306; username=root; password=1234; database=pupilove");

                try
                {
                    polaczenieDetale.Open();

                    // Utwórz zapytanie SQL do pobrania informacji o zamówieniu
                    string zapytanieAdresSQL = "SELECT OrderAddressCity, OrderAddressPostalCode, OrderAddressStreet, OrderAddressApartmentNo " +
                                                "FROM Orders " +
                                                "WHERE OrderId = @OrderId";

                    MySqlCommand zapytanieAdres = new MySqlCommand(zapytanieAdresSQL, polaczenieDetale);

                    // Dodaj parametr do zapytania
                    zapytanieAdres.Parameters.AddWithValue("@OrderId", orderId);

                    // Wykonaj zapytanie
                    MySqlDataReader czytnikAdres = zapytanieAdres.ExecuteReader();

                    // Sprawdź, czy znaleziono rekord
                    if (czytnikAdres.Read())
                    {
                        // Utwórz adres na podstawie elementów
                        string adres = $"{czytnikAdres["OrderAddressCity"]} {czytnikAdres["OrderAddressPostalCode"]} {czytnikAdres["OrderAddressStreet"]} {czytnikAdres["OrderAddressApartmentNo"]}";

                        // Ustaw etykietę na utworzony adres
                        label_adres.Text = adres;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd podczas komunikacji z bazą danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenieDetale.Close();
                }
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć zamówienie przed przejściem do szczegółów.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FillComboBox()
        {
            string konfiguracja = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
            MySqlConnection polaczenie = new MySqlConnection(konfiguracja);
            try
            {
                polaczenie.Open();

                // Utwórz zapytanie SQL do pobrania statusów z tabeli OrderStatus
                string zapytanieStatusySQL = "SELECT StatusName FROM OrderStatus";
                MySqlCommand zapytanieStatusy = new MySqlCommand(zapytanieStatusySQL, polaczenie);

                // Wykonaj zapytanie
                MySqlDataReader czytnikStatusy = zapytanieStatusy.ExecuteReader();

                // Wyczyść ComboBox przed dodaniem nowych elementów
                comboBox_status.Items.Clear();

                // Dodaj statusy do ComboBox
                while (czytnikStatusy.Read())
                {
                    comboBox_status.Items.Add(czytnikStatusy["StatusName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wystąpił błąd podczas pobierania statusów: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void button1_Detale_Click(object sender, EventArgs e)
        {
            FillDetale();
            FillAdres();
        }
    }
}
