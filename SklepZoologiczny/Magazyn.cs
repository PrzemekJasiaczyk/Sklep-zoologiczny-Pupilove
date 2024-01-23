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
    public partial class Magazyn : Form
    {
        private int userId;
        private string connectionString = "datasource=localhost; port = 3306; username=root; password=1234; database=pupilove";
        public Magazyn( int userId)
        {
            InitializeComponent();
            this.userId = userId;
            FillDataGridView();
        }

        private void Magazyn_Load(object sender, EventArgs e)
        {

        }

        private void FillDataGridView()
        {

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                string query = "SELECT ProductName, ProductPriceBuy, ProductQuantity FROM Products ";

                MySqlCommand command = new MySqlCommand(query, mySqlConnection);
                try
                {
                    mySqlConnection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    System.Data.DataTable dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);

                    if (dataGridView2_Magazyn.Columns.Count >= 2)
                    {
                        dataGridView2_Magazyn.Columns[0].DataPropertyName = "ProductName";
                        dataGridView2_Magazyn.Columns[1].DataPropertyName = "ProductPriceBuy";
                        dataGridView2_Magazyn.Columns[2].DataPropertyName = "ProductQuantity";
                    }
                    else
                    {
                        MessageBox.Show("Nie ma wystarczającej liczby kolumn w DataGridView.");
                    }

                    dataGridView2_Magazyn.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bład : " + ex.Message);
                }

            }


        }

        private void button1_Zloz_zamowienie_produkty_Click(object sender, EventArgs e)
        {
            decimal liczba = numericUpDown1_DodajArt.Value;
            string nazwaproduktu = label1_ProductName.Text;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Products SET ProductQuantity =@liczba WHERE Productname =@nazwaproduktu ";

                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@liczba", liczba);
                command.Parameters.AddWithValue("@nazwaproduktu", nazwaproduktu);
                try
                {

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Twoje zamówienie zostało zrealizowane.Zamówiełeś " + numericUpDown1_DodajArt.Value + " artykółów.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd: " + ex.Message);
                }
                finally
                { connection.Close(); }
            }


        }

        private void button1_Home_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home(userId);
            this.Hide();
            homeForm.ShowDialog();
        }

        private void textBox1_ProductName_TextChanged(object sender, EventArgs e)
        {
            if (numericUpDown1_DodajArt.Value > 0 && label1_ProductName != null)
            {
                button1_Zloz_zamowienie_produkty.Enabled = true;

            }
        }
    }
}
