using MySql.Data.MySqlClient;
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
    public partial class Rejestracja : Form
    {
        public Rejestracja()
        {
            InitializeComponent();       
        }

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            //Form1 homeForm = new Form1();
            this.Hide();
            //homeForm.ShowDialog();
        }

        private void button1_Rejestruj_Click(object sender, EventArgs e)
        {
            string konfiguracja = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
            MySqlConnection polaczenie = new MySqlConnection(konfiguracja);

            // Pobierz dane z formularza
            string login = textBox_login.Text;
            string haslo = textBox_haslo.Text;
            string hasloPotwierdzenie = textBox_haslopwt.Text;
            string imie = textBox_imie.Text;
            string nazwisko = textBox_nazwisko.Text;
            string plec = comboBox_plec.Text;
            DateTime dataUrodzenia = dateTimePicker_dataUrodzenia.Value;
            string ulica = textBox_ulica.Text;
            string miasto = textBox_miasto.Text;
            string kodPocztowy = textBox_kodPocztowy.Text;
            string mieszkanie = textBox_mieszkanie.Text;
            string email = textBox_email.Text;
            string telefon = textBox_telefon.Text;

            // Możesz również dodać walidację danych wejściowych przed zapisaniem do bazy

            // Sprawdź, czy hasła są takie same
            if (haslo != hasloPotwierdzenie)
            {
                MessageBox.Show("Hasła nie są identyczne. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Otwórz połączenie z bazą danych
            try
            {
                polaczenie.Open();

                // Utwórz i wykonaj zapytanie SQL do wstawienia użytkownika do bazy danych
                string zapytanieSQL = "INSERT INTO Users (UserName, PasswordHash, UserEmail, UserAddressStreet, UserAddressCity, UserAddressPostalCode, UserAddressApartmentNo, " +
                                      "FirstName, LastName, Gender, DateOfBirth, PhoneNumber) " +
                                      "VALUES (@UserName, @PasswordHash, @UserEmail, @UserAddressStreet, @UserAddressCity, @UserAddressPostalCode, @UserAddressApartmentNo, " +
                                      "@UserFirstName, @UserLastName, @UserGender, @UserDateOfBirth, @UserPhoneNumber)";

                MySqlCommand zapytanie = new MySqlCommand(zapytanieSQL, polaczenie);

                // Dodaj parametry do zapytania
                zapytanie.Parameters.AddWithValue("@UserName", login);
                zapytanie.Parameters.AddWithValue("@PasswordHash", haslo);
                zapytanie.Parameters.AddWithValue("@UserEmail", email);
                zapytanie.Parameters.AddWithValue("@UserAddressStreet", ulica);
                zapytanie.Parameters.AddWithValue("@UserAddressCity", miasto);
                zapytanie.Parameters.AddWithValue("@UserAddressPostalCode", kodPocztowy);
                zapytanie.Parameters.AddWithValue("@UserAddressApartmentNo", mieszkanie);
                zapytanie.Parameters.AddWithValue("@UserFirstName", imie);
                zapytanie.Parameters.AddWithValue("@UserLastName", nazwisko);
                zapytanie.Parameters.AddWithValue("@UserGender", plec);
                zapytanie.Parameters.AddWithValue("@UserDateOfBirth", dataUrodzenia);
                zapytanie.Parameters.AddWithValue("@UserPhoneNumber", telefon);


                // Wykonaj zapytanie
                int result = zapytanie.ExecuteNonQuery();

                // Sprawdź, czy udało się dodać użytkownika
                if (result > 0)
                {
                    MessageBox.Show("Rejestracja zakończona sukcesem.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide(); // Ukryj formularz po pomyślnej rejestracji
                }
                else
                {
                    MessageBox.Show("Wystąpił problem podczas rejestracji. Spróbuj ponownie.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

    }
}
