using MySql.Data.MySqlClient;
using SklepZoologiczny.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string connectionString = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
            Produkt.PobierzProduktyZBazyDanych(connectionString);
        }

        private void button2_Wyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Zaloguj_Click(object sender, EventArgs e)
        {
            String konfiguracja = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
            MySqlConnection polaczenie = new MySqlConnection(konfiguracja);

            string username = textBox_Login.Text;
            string password = textBox_pass.Text;
            MySqlCommand zapytanie = new MySqlCommand("SELECT UserId FROM pupilove.users WHERE UserName = @username and PasswordHash = @password;", polaczenie);
            zapytanie.Parameters.AddWithValue("@username", username);
            zapytanie.Parameters.AddWithValue("@password", password);

            MySqlDataReader czytnik;

            try
            {
                polaczenie.Open();
                czytnik = zapytanie.ExecuteReader();

                if (czytnik.Read())
                {
                    int userId = czytnik.GetInt32(0); 
                    czytnik.Close();
                    polaczenie.Close();

                    // Przechodzimy do nowego formularza (Home) i przekazujemy ID użytkownika
                    Home homeForm = new Home(userId);
                    this.Hide();
                    homeForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nie ma takiego użytkownika.", "Informacja");
                }

                czytnik.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd połączenia z bazą danych: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void button1_Rejestracja_Click(object sender, EventArgs e)
        {
            Rejestracja rejestracjaForm = new Rejestracja();
            rejestracjaForm.ShowDialog();
        }

        private void label1_Tytul_Click(object sender, EventArgs e)
        {

        }

    }
}
