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
    public partial class Koszyk : Form
    {
        private int userId;
        private string connectionString = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";
        public Koszyk(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            ShowCartItems();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowCartItems()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT p.ProductName, p.ProductPriceSell AS Price, ci.ProductQuantity, ci.ProductId " +
                                "FROM Products p " +
                                "JOIN CART_ITEM ci ON p.id = ci.ProductId " +
                                "WHERE ci.UserId = @userId";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    dataGridView_Koszyk.DataSource = dataTable;

                    // Ukrycie kolumny ProductId
                    dataGridView_Koszyk.Columns["ProductId"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }

            label_kwota.Text = CalculateTotalOrderPrice().ToString() + " zł";
        }


        private void button1_usun_Click(object sender, EventArgs e)
        {
            if (dataGridView_Koszyk.CurrentRow != null)
            {
                int rowIndex = dataGridView_Koszyk.CurrentRow.Index;

                string productName = dataGridView_Koszyk.Rows[rowIndex].Cells["ProductName"].Value.ToString();
                int productId = Convert.ToInt32(dataGridView_Koszyk.Rows[rowIndex].Cells["ProductId"].Value);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM CART_ITEM WHERE UserId = @userId AND ProductId = @productId";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@productId", productId);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Usunięto produkt {productName} z koszyka.");
                            ShowCartItems();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd: " + ex.Message);
                    }
                }
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy na pewno chcesz wyczyścić koszyk?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearCartItems();
                ShowCartItems();
                MessageBox.Show("Koszyk został wyczyszczony.");
            }
        }

        private void button1_wyjście_Click_1(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            this.Hide();
            homeForm.ShowDialog();
        }

        private void button2_platnosc_Click(object sender, EventArgs e)
        {
            decimal orderPrice = CalculateTotalOrderPrice();
            Uzytkownik userDetails = GetUserDetailsFromDatabase(userId);

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string insertOrderQuery = "INSERT INTO Orders (UserId, StatusId, OrderEmail, OrderAddressStreet, OrderAddressCity, OrderAddressPostalCode, OrderAddressApartmentNo, OrderPrice) " +
                                         "VALUES (@userId, @statusId, @orderEmail, @orderAddressStreet, @orderAddressCity, @orderAddressPostalCode, @orderAddressApartmentNo, @orderPrice);";

                MySqlCommand insertOrderCommand = new MySqlCommand(insertOrderQuery, connection);
                insertOrderCommand.Parameters.AddWithValue("@userId", userId);
                insertOrderCommand.Parameters.AddWithValue("@statusId", 1); // StatusId z bazy
                insertOrderCommand.Parameters.AddWithValue("@orderEmail", userDetails.Mail);
                insertOrderCommand.Parameters.AddWithValue("@orderAddressStreet", userDetails.Ulica);
                insertOrderCommand.Parameters.AddWithValue("@orderAddressCity", userDetails.Miasto);
                insertOrderCommand.Parameters.AddWithValue("@orderAddressPostalCode", userDetails.Kod_pocztowy);
                insertOrderCommand.Parameters.AddWithValue("@orderAddressApartmentNo", userDetails.Mieszkanie);
                insertOrderCommand.Parameters.AddWithValue("@orderPrice", orderPrice);

                //program przenosi dane
                try
                {
                    connection.Open();
                    insertOrderCommand.ExecuteNonQuery();

                    var lastInsertedId = insertOrderCommand.LastInsertedId;

                    
                    string moveItemsQuery = "INSERT INTO OrderItem (OrderId, ProductId, OrderItemQuantity) " +
                                    "SELECT @orderId, ProductId, ProductQuantity " +
                                    "FROM CART_ITEM " +
                                    "WHERE UserId = @userId;";

                    MySqlCommand moveItemsCommand = new MySqlCommand(moveItemsQuery, connection);
                    moveItemsCommand.Parameters.AddWithValue("@orderId", insertOrderCommand.LastInsertedId);
                    moveItemsCommand.Parameters.AddWithValue("@userId", userId);
                    moveItemsCommand.ExecuteNonQuery();

                    MessageBox.Show("Zamówienie zostało złożone.");
                    ClearCartItems();
                    ShowCartItems(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }


        private decimal CalculateTotalOrderPrice()
        {
            decimal total = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string cartItemsQuery = "SELECT p.ProductPriceSell AS Price, ci.ProductQuantity " +
                                        "FROM Products p " +
                                        "JOIN CART_ITEM ci ON p.id = ci.ProductId " +
                                        "WHERE ci.UserId = @userId;";

                MySqlCommand cartItemsCommand = new MySqlCommand(cartItemsQuery, connection);
                cartItemsCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    using (MySqlDataReader cartItemsReader = cartItemsCommand.ExecuteReader())
                    {
                        while (cartItemsReader.Read())
                        {
                            decimal price = cartItemsReader.GetDecimal("Price");
                            int quantity = cartItemsReader.GetInt32("ProductQuantity");
                            total += price * quantity;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                    return 0;
                }
            }

            return total;
        }

        private void ClearCartItems()
        {
            // Kod do usuwania przedmiotów z koszyka dla danego użytkownika
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string clearCartQuery = "DELETE FROM CART_ITEM WHERE UserId = @userId;";
                MySqlCommand clearCartCommand = new MySqlCommand(clearCartQuery, connection);
                clearCartCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    clearCartCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }

        private void Koszyk_Load(object sender, EventArgs e)
        {

        }

        private Uzytkownik GetUserDetailsFromDatabase(int userId)
        {
            Uzytkownik userDetails = new Uzytkownik();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string getUserQuery = "SELECT UserEmail, UserAddressStreet, UserAddressCity, UserAddressPostalCode, UserAddressApartmentNo " +
                                      "FROM Users " +
                                      "WHERE UserId = @userId;";

                MySqlCommand getUserCommand = new MySqlCommand(getUserQuery, connection);
                getUserCommand.Parameters.AddWithValue("@userId", userId);

                try
                {
                    connection.Open();
                    using (MySqlDataReader userReader = getUserCommand.ExecuteReader())
                    {
                        if (userReader.Read())
                        {
                            // Jeśli użytkownik został znaleziony, pobierz jego szczegóły
                            userDetails.Mail = userReader.GetString("UserEmail");
                            userDetails.Ulica = userReader.GetString("UserAddressStreet");
                            userDetails.Miasto = userReader.GetString("UserAddressCity");
                            userDetails.Kod_pocztowy = userReader.GetString("UserAddressPostalCode");
                            userDetails.Mieszkanie = userReader.GetString("UserAddressApartmentNo");
                        }
                        else
                        {
                            MessageBox.Show("Nie znaleziono użytkownika o podanym ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }

            return userDetails;
        }

    }
}
