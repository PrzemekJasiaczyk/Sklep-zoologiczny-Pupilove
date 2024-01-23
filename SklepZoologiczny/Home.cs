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
    public partial class Home : Form
    {
        private int userId; // Pole przechowujące ID użytkownika
        public Home(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Przypisanie otrzymanego ID do pola w klasie
        }

        private void button9_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_wyloguj_Click(object sender, EventArgs e)
        {
            Form1 logowanie = new Form1();
            this.Hide();
            logowanie.ShowDialog();
        }

        private void button2_Edytuj_Profil_Click(object sender, EventArgs e)
        {
            Edycja_profilu edycjaProfiluForm = new Edycja_profilu(this.userId);
            this.Hide();
            edycjaProfiluForm.ShowDialog();
        }

        private void button1_Oferta_Click(object sender, EventArgs e)
        {
            Oferta ofertaForm = new Oferta(this.userId);
            this.Hide();
            ofertaForm.ShowDialog();
        }

        private void button4_Koszyk_Click(object sender, EventArgs e)
        {
            Koszyk koszForm = new Koszyk(this.userId);
            this.Hide();
            koszForm.ShowDialog();
        }

        private void button8_Historia_zakupów_Click(object sender, EventArgs e)
        {
            Historia_zakupow historiaZakupowForm = new Historia_zakupow(this.userId);
            this.Hide();
            historiaZakupowForm.ShowDialog();
        }

        private void button3_Zostaw_Zwierzaka_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button7_Stan_Magazynowy_Click(object sender, EventArgs e)
        {
            Magazyn magazynForm = new Magazyn(this.userId);
            this.Hide();
            magazynForm.ShowDialog();
        }
    }
}
