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
    public partial class Edycja_profilu : Form
    {
        private int userId;

        public Edycja_profilu(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserData();

        }

        private void button1_Exit_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            this.Hide();
            homeForm.ShowDialog();
        }

        private void LoadUserData()
        {
            string konfiguracja = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
            MySqlConnection polaczenie = new MySqlConnection(konfiguracja);

            try
            {
                polaczenie.Open();
                MySqlCommand zapytanie = new MySqlCommand("SELECT * FROM Users WHERE UserId = @userId", polaczenie);
                zapytanie.Parameters.AddWithValue("@userId", userId);

                MySqlDataReader czytnik = zapytanie.ExecuteReader();

                if (czytnik.Read())
                {
                    textBox1_Imie.Text = czytnik["FirstName"].ToString();
                    textBox_Nazwisko.Text = czytnik["LastName"].ToString();
                    textBox_Login.Text = czytnik["UserName"].ToString();
                    maskedTextBox1_Haslo.Text = czytnik["PasswordHash"].ToString();
                    // Przypisanie hasła do maskedTextBox1_Powtorz_Haslo jeśli takie pole w formularzu istnieje
                    // maskedTextBox1_Powtorz_Haslo.Text = czytnik["PasswordHash"].ToString();
                    comboBox_plec.Text = czytnik["Gender"].ToString();
                    textBox1_Ulica.Text = czytnik["UserAddressStreet"].ToString();
                    textBox4_Miasto.Text = czytnik["UserAddressCity"].ToString();
                    textBox5_KodPocztowy.Text = czytnik["UserAddressPostalCode"].ToString();
                    textBox_mieszkanie.Text = czytnik["UserAddressApartmentNo"].ToString();
                    textBox6_telefon.Text = czytnik["PhoneNumber"].ToString();

                    // Przypisanie daty urodzenia do dateTimePicker_urodzenie
                    if (czytnik["DateOfBirth"] != DBNull.Value)
                    {
                        DateTime dateOfBirth = (DateTime)czytnik["DateOfBirth"];
                        dateTimePicker_urodzenie.Value = dateOfBirth;
                    }
                }

                czytnik.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd podczas pobierania danych z bazy danych: " + ex.Message, "Błąd");
            }
            finally
            {
                polaczenie.Close();
            }
        }

        private void button1_Edytuj_Click(object sender, EventArgs e)
        {
            string firstName = textBox1_Imie.Text;
            string lastName = textBox_Nazwisko.Text;
            string userName = textBox_Login.Text;
            string password = maskedTextBox1_Haslo.Text;
            string gender = comboBox_plec.Text;
            string addressStreet = textBox1_Ulica.Text;
            string addressCity = textBox4_Miasto.Text;
            string postalCode = textBox5_KodPocztowy.Text;
            string apartmentNo = textBox_mieszkanie.Text;
            string phoneNumber = textBox6_telefon.Text;
            DateTime dateOfBirth = dateTimePicker_urodzenie.Value;

            string message = $"Czy na pewno chcesz zaktualizować dane użytkownika?\nImię: {firstName}\nNazwisko: {lastName}\nLogin: {userName}\nHasło: {password}\nPłeć: {gender}\nData urodzenia: {dateOfBirth}\nAdres: {addressStreet}, {addressCity}, {postalCode}, {apartmentNo}\nTelefon: {phoneNumber}";

            var result = MessageBox.Show(message, "Potwierdzenie zmian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Po potwierdzeniu aktualizuj rekord w bazie danych
                string konfiguracja = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
                MySqlConnection polaczenie = new MySqlConnection(konfiguracja);

                try
                {
                    polaczenie.Open();
                    MySqlCommand zapytanie = new MySqlCommand(@"UPDATE Users 
                                                        SET FirstName = @firstName, LastName = @lastName, 
                                                            UserName = @userName, PasswordHash = @password, 
                                                            Gender = @gender, DateOfBirth = @dateOfBirth, 
                                                            UserAddressStreet = @addressStreet, UserAddressCity = @addressCity, 
                                                            UserAddressPostalCode = @postalCode, UserAddressApartmentNo = @apartmentNo, 
                                                            PhoneNumber = @phoneNumber 
                                                        WHERE UserId = @userId", polaczenie);

                    zapytanie.Parameters.AddWithValue("@firstName", firstName);
                    zapytanie.Parameters.AddWithValue("@lastName", lastName);
                    zapytanie.Parameters.AddWithValue("@userName", userName);
                    zapytanie.Parameters.AddWithValue("@password", password);
                    zapytanie.Parameters.AddWithValue("@gender", gender);
                    zapytanie.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
                    zapytanie.Parameters.AddWithValue("@addressStreet", addressStreet);
                    zapytanie.Parameters.AddWithValue("@addressCity", addressCity);
                    zapytanie.Parameters.AddWithValue("@postalCode", postalCode);
                    zapytanie.Parameters.AddWithValue("@apartmentNo", apartmentNo);
                    zapytanie.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    zapytanie.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = zapytanie.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Dane użytkownika zostały zaktualizowane.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas aktualizacji danych: " + ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    polaczenie.Close();
                }
            }
        }

        private void label3_NrDomu_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_plec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
