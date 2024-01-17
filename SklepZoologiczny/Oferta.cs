using MySql.Data.MySqlClient;
using SklepZoologiczny.Model;
using System;
using System.Collections;
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
    public partial class Oferta : Form
    {
        private int userId;
        private string connectionString = "datasource=localhost; port=3306; username=root; password=1234; database=pupilove";

        public Oferta(int userId)
        {
            InitializeComponent();
            this.userId = userId;

            // W konstruktorze lub metodzie inicjalizacji
            dataGridView1_Oferta.CellFormatting += dataGridView1_Oferta_CellFormatting;

            FillComboBoxWithAnimals();
            FillComboBoxWithProductCategories();
            FillDataGridView2();


        }

        private void button10_Home_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            this.Hide();
            homeForm.ShowDialog();
        }

        private void FillDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT ProductName, ProductPriceBuy, ProductBrand, ProductQuantity FROM Products";

                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // Sprawdź, czy istnieją kolumny w DataGridView
                    if (dataGridView1_Oferta.Columns.Count >= 3)
                    {
                        dataGridView1_Oferta.Columns[0].DataPropertyName = "ProductName";
                        dataGridView1_Oferta.Columns[1].DataPropertyName = "ProductPriceBuy";
                        dataGridView1_Oferta.Columns[2].DataPropertyName = "ProductBrand";
                        dataGridView1_Oferta.Columns[3].DataPropertyName = "ProductQuantity";
                    }
                    else
                    {
                        MessageBox.Show("Nie ma wystarczającej liczby kolumn w DataGridView.");
                    }

                    // Przypisanie danych z DataTable do kontrolki DataGridView
                    dataGridView1_Oferta.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }

        private void FillDataGridView2()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT p.id, p.ProductName, p.ProductPriceBuy, p.ProductPriceSell, p.ProductImage, p.ProductBrand, p.ProductDescription, p.ProductQuantity, p.ProductDiscountId, pc.ProductCategoryName AS ProductCategory, a.AnimalName AS Animal FROM Products p LEFT JOIN ProductCategory pc ON p.ProductCategoryId = pc.ProductCategoryId LEFT JOIN Animals a ON p.AnimalsId = a.AnimalsId";

                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // Przypisanie danych z DataTable do kontrolki DataGridView
                    dataGridView1_Oferta.DataSource = dataTable;

                    dataGridView1_Oferta.Columns["id"].Visible = false;
                    dataGridView1_Oferta.Columns["ProductPriceBuy"].Visible = false;
                    dataGridView1_Oferta.Columns["ProductDescription"].Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }


        private void FillComboBoxWithAnimals()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT AnimalName FROM Animals";

                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox_Pupil.Items.Add(reader["AnimalName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }

        private void FillComboBoxWithProductCategories()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT ProductCategoryName FROM ProductCategory";

                MySqlCommand command = new MySqlCommand(query, connection);
                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox_Rodzaj.Items.Add(reader["ProductCategoryName"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }


        private void dataGridView1_Oferta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1_Oferta.Columns.Contains("ProductQuantity") && e.ColumnIndex == dataGridView1_Oferta.Columns["ProductQuantity"].Index && e.Value != null)
            {
                int quantity;
                if (int.TryParse(e.Value.ToString(), out quantity))
                {
                    e.Value = quantity > 0 ? "Tak" : "Nie";
                    e.FormattingApplied = true;
                }
            }
        }

        private void button_Filtruj_Click(object sender, EventArgs e)
        {
            string selectedAnimal = comboBox_Pupil.SelectedItem != null ? comboBox_Pupil.SelectedItem.ToString() : null;
            string selectedCategory = comboBox_Rodzaj.SelectedItem != null ? comboBox_Rodzaj.SelectedItem.ToString() : null;
            decimal minPrice = numericUpDown_CenaMin.Value;
            decimal maxPrice = numericUpDown_CenaMax.Value;
            bool showPromotionsOnly = checkBox_Promocja.Checked;
            bool showAvailableOnly = checkBox_dostepny.Checked;

            string query = "SELECT p.id, p.ProductName, p.ProductPriceBuy, p.ProductPriceSell, p.ProductImage, p.ProductBrand, p.ProductDescription, p.ProductQuantity, p.ProductDiscountId, pc.ProductCategoryName AS ProductCategory, a.AnimalName AS Animal FROM Products p LEFT JOIN ProductCategory pc ON p.ProductCategoryId = pc.ProductCategoryId LEFT JOIN Animals a ON p.AnimalsId = a.AnimalsId WHERE 1 = 1";

            if (!string.IsNullOrEmpty(selectedAnimal))
            {
                query += " AND a.AnimalName = @selectedAnimal";
            }

            if (!string.IsNullOrEmpty(selectedCategory))
            {
                query += " AND pc.ProductCategoryName = @selectedCategory";
            }

            query += " AND p.ProductPriceSell >= @minPrice AND p.ProductPriceSell <= @maxPrice";

            if (showPromotionsOnly)
            {
                query += " AND p.ProductDiscountId IS NOT NULL";
            }

            if (showAvailableOnly)
            {
                query += " AND p.ProductQuantity > 0";
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);

                if (!string.IsNullOrEmpty(selectedAnimal))
                {
                    command.Parameters.AddWithValue("@selectedAnimal", selectedAnimal);
                }

                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    command.Parameters.AddWithValue("@selectedCategory", selectedCategory);
                }

                command.Parameters.AddWithValue("@minPrice", minPrice);
                command.Parameters.AddWithValue("@maxPrice", maxPrice);

                try
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    // Przypisanie danych z DataTable do kontrolki DataGridView
                    dataGridView1_Oferta.DataSource = dataTable;

                    // Ukrywanie odpowiednich kolumn
                    dataGridView1_Oferta.Columns["id"].Visible = false;
                    dataGridView1_Oferta.Columns["ProductPriceBuy"].Visible = false;
                    dataGridView1_Oferta.Columns["ProductDescription"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
            }
        }


        private void button_Koszyk_Click(object sender, EventArgs e)
        {
            if (dataGridView1_Oferta.CurrentRow != null)
            {
                int productId = Convert.ToInt32(dataGridView1_Oferta.CurrentRow.Cells["id"].Value);

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string checkIfExistsQuery = "SELECT COUNT(*) FROM CART_ITEM WHERE UserId = @userId AND ProductId = @productId";

                    MySqlCommand checkIfExistsCommand = new MySqlCommand(checkIfExistsQuery, connection);
                    checkIfExistsCommand.Parameters.AddWithValue("@userId", userId);
                    checkIfExistsCommand.Parameters.AddWithValue("@productId", productId);
                    string productQuantity = dataGridView1_Oferta.CurrentRow.Cells["ProductQuantity"].Value.ToString();

                    try
                    {
                        connection.Open();
                        int productCount = Convert.ToInt32(checkIfExistsCommand.ExecuteScalar());

                        if (productCount > 0)
                        {
                            // Produkt jest już w koszyku, zwiększ ilość
                            string increaseQuantityQuery = "UPDATE CART_ITEM SET ProductQuantity = ProductQuantity + 1 WHERE UserId = @userId AND ProductId = @productId";

                            MySqlCommand increaseQuantityCommand = new MySqlCommand(increaseQuantityQuery, connection);
                            increaseQuantityCommand.Parameters.AddWithValue("@userId", userId);
                            increaseQuantityCommand.Parameters.AddWithValue("@productId", productId);

                            int rowsAffected = increaseQuantityCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                string productName = dataGridView1_Oferta.CurrentRow.Cells["ProductName"].Value.ToString();
                                MessageBox.Show($"Zwiększono ilość produktu {productName} w koszyku.");
                            }
                        }
                        else
                        {
                            // Produkt nie jest jeszcze w koszyku, dodaj nowy rekord
                            string addNewProductQuery = "INSERT INTO CART_ITEM (UserId, ProductId, ProductQuantity) VALUES (@userId, @productId, 1)";

                            MySqlCommand addNewProductCommand = new MySqlCommand(addNewProductQuery, connection);
                            addNewProductCommand.Parameters.AddWithValue("@userId", userId);
                            addNewProductCommand.Parameters.AddWithValue("@productId", productId);

                            int rowsAffected = addNewProductCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                string productName = dataGridView1_Oferta.CurrentRow.Cells["ProductName"].Value.ToString();
                                MessageBox.Show($"Dodano produkt {productName} do koszyka.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd: " + ex.Message);
                    }
                }
            }
        }

      


        private void button_anuluj_Click(object sender, EventArgs e)
        {
            comboBox_Pupil.SelectedIndex = -1;
            comboBox_Rodzaj.SelectedIndex = -1; 
            numericUpDown_CenaMin.Value = 0;
            numericUpDown_CenaMax.Value = 1000; 
            checkBox_Promocja.Checked = false; 
            checkBox_dostepny.Checked = false; 
        }

    }
}
