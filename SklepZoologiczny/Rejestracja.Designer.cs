namespace SklepZoologiczny
{
    partial class Rejestracja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Exit = new System.Windows.Forms.Button();
            this.button1_Rejestruj = new System.Windows.Forms.Button();
            this.textBox_haslopwt = new System.Windows.Forms.MaskedTextBox();
            this.textBox_haslo = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_plec = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_dataUrodzenia = new System.Windows.Forms.DateTimePicker();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.label7_Data_Urodzenia = new System.Windows.Forms.Label();
            this.label6_Plec = new System.Windows.Forms.Label();
            this.label5_Powtorz_Haslo = new System.Windows.Forms.Label();
            this.label4_Haslo = new System.Windows.Forms.Label();
            this.label3_Login = new System.Windows.Forms.Label();
            this.label2_Nazwisko = new System.Windows.Forms.Label();
            this.label1_Imie = new System.Windows.Forms.Label();
            this.label1_Tytul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1_Ulica = new System.Windows.Forms.Label();
            this.textBox_ulica = new System.Windows.Forms.TextBox();
            this.textBox_miasto = new System.Windows.Forms.TextBox();
            this.textBox_kodPocztowy = new System.Windows.Forms.TextBox();
            this.label1_Miasto = new System.Windows.Forms.Label();
            this.label2_Kod_Pocztowy = new System.Windows.Forms.Label();
            this.label3_NrDomu = new System.Windows.Forms.Label();
            this.label1_Tel = new System.Windows.Forms.Label();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_mieszkanie = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_Exit
            // 
            this.button1_Exit.BackColor = System.Drawing.Color.Red;
            this.button1_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_Exit.Location = new System.Drawing.Point(398, 537);
            this.button1_Exit.Name = "button1_Exit";
            this.button1_Exit.Size = new System.Drawing.Size(228, 54);
            this.button1_Exit.TabIndex = 41;
            this.button1_Exit.Text = "Wyjście";
            this.button1_Exit.UseVisualStyleBackColor = false;
            this.button1_Exit.Click += new System.EventHandler(this.button1_Exit_Click);
            // 
            // button1_Rejestruj
            // 
            this.button1_Rejestruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Rejestruj.Location = new System.Drawing.Point(164, 537);
            this.button1_Rejestruj.Name = "button1_Rejestruj";
            this.button1_Rejestruj.Size = new System.Drawing.Size(228, 54);
            this.button1_Rejestruj.TabIndex = 40;
            this.button1_Rejestruj.Text = "Zarejstruj się ";
            this.button1_Rejestruj.UseVisualStyleBackColor = true;
            this.button1_Rejestruj.Click += new System.EventHandler(this.button1_Rejestruj_Click);
            // 
            // textBox_haslopwt
            // 
            this.textBox_haslopwt.Location = new System.Drawing.Point(164, 285);
            this.textBox_haslopwt.Name = "textBox_haslopwt";
            this.textBox_haslopwt.Size = new System.Drawing.Size(200, 20);
            this.textBox_haslopwt.TabIndex = 39;
            // 
            // textBox_haslo
            // 
            this.textBox_haslo.Location = new System.Drawing.Point(164, 246);
            this.textBox_haslo.Name = "textBox_haslo";
            this.textBox_haslo.Size = new System.Drawing.Size(200, 20);
            this.textBox_haslo.TabIndex = 38;
            // 
            // comboBox_plec
            // 
            this.comboBox_plec.FormattingEnabled = true;
            this.comboBox_plec.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna",
            "Niebinarny "});
            this.comboBox_plec.Location = new System.Drawing.Point(164, 402);
            this.comboBox_plec.Name = "comboBox_plec";
            this.comboBox_plec.Size = new System.Drawing.Size(200, 21);
            this.comboBox_plec.TabIndex = 37;
            // 
            // dateTimePicker_dataUrodzenia
            // 
            this.dateTimePicker_dataUrodzenia.Location = new System.Drawing.Point(164, 451);
            this.dateTimePicker_dataUrodzenia.MaxDate = new System.DateTime(2024, 1, 17, 0, 0, 0, 0);
            this.dateTimePicker_dataUrodzenia.MinDate = new System.DateTime(1918, 11, 11, 0, 0, 0, 0);
            this.dateTimePicker_dataUrodzenia.Name = "dateTimePicker_dataUrodzenia";
            this.dateTimePicker_dataUrodzenia.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_dataUrodzenia.TabIndex = 36;
            this.dateTimePicker_dataUrodzenia.Value = new System.DateTime(2024, 1, 17, 0, 0, 0, 0);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(164, 205);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(200, 20);
            this.textBox_login.TabIndex = 35;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(164, 361);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(200, 20);
            this.textBox_nazwisko.TabIndex = 34;
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(164, 325);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(200, 20);
            this.textBox_imie.TabIndex = 33;
            // 
            // label7_Data_Urodzenia
            // 
            this.label7_Data_Urodzenia.AutoSize = true;
            this.label7_Data_Urodzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7_Data_Urodzenia.Location = new System.Drawing.Point(23, 452);
            this.label7_Data_Urodzenia.Name = "label7_Data_Urodzenia";
            this.label7_Data_Urodzenia.Size = new System.Drawing.Size(130, 20);
            this.label7_Data_Urodzenia.TabIndex = 32;
            this.label7_Data_Urodzenia.Text = "Data urodzenia : ";
            // 
            // label6_Plec
            // 
            this.label6_Plec.AutoSize = true;
            this.label6_Plec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6_Plec.Location = new System.Drawing.Point(24, 403);
            this.label6_Plec.Name = "label6_Plec";
            this.label6_Plec.Size = new System.Drawing.Size(52, 20);
            this.label6_Plec.TabIndex = 31;
            this.label6_Plec.Text = "Płeć : ";
            // 
            // label5_Powtorz_Haslo
            // 
            this.label5_Powtorz_Haslo.AutoSize = true;
            this.label5_Powtorz_Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5_Powtorz_Haslo.Location = new System.Drawing.Point(23, 282);
            this.label5_Powtorz_Haslo.Name = "label5_Powtorz_Haslo";
            this.label5_Powtorz_Haslo.Size = new System.Drawing.Size(121, 20);
            this.label5_Powtorz_Haslo.TabIndex = 30;
            this.label5_Powtorz_Haslo.Text = "Powtórz hasło : ";
            // 
            // label4_Haslo
            // 
            this.label4_Haslo.AutoSize = true;
            this.label4_Haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4_Haslo.Location = new System.Drawing.Point(23, 242);
            this.label4_Haslo.Name = "label4_Haslo";
            this.label4_Haslo.Size = new System.Drawing.Size(63, 20);
            this.label4_Haslo.TabIndex = 29;
            this.label4_Haslo.Text = "Hasło : ";
            // 
            // label3_Login
            // 
            this.label3_Login.AutoSize = true;
            this.label3_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3_Login.Location = new System.Drawing.Point(23, 203);
            this.label3_Login.Name = "label3_Login";
            this.label3_Login.Size = new System.Drawing.Size(60, 20);
            this.label3_Login.TabIndex = 28;
            this.label3_Login.Text = "Login : ";
            // 
            // label2_Nazwisko
            // 
            this.label2_Nazwisko.AutoSize = true;
            this.label2_Nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_Nazwisko.Location = new System.Drawing.Point(24, 364);
            this.label2_Nazwisko.Name = "label2_Nazwisko";
            this.label2_Nazwisko.Size = new System.Drawing.Size(88, 20);
            this.label2_Nazwisko.TabIndex = 27;
            this.label2_Nazwisko.Text = "Nazwisko : ";
            // 
            // label1_Imie
            // 
            this.label1_Imie.AutoSize = true;
            this.label1_Imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Imie.Location = new System.Drawing.Point(24, 325);
            this.label1_Imie.Name = "label1_Imie";
            this.label1_Imie.Size = new System.Drawing.Size(51, 20);
            this.label1_Imie.TabIndex = 26;
            this.label1_Imie.Text = "Imię : ";
            // 
            // label1_Tytul
            // 
            this.label1_Tytul.AutoSize = true;
            this.label1_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tytul.ForeColor = System.Drawing.Color.White;
            this.label1_Tytul.Location = new System.Drawing.Point(186, 9);
            this.label1_Tytul.Name = "label1_Tytul";
            this.label1_Tytul.Size = new System.Drawing.Size(419, 108);
            this.label1_Tytul.TabIndex = 25;
            this.label1_Tytul.Text = "Pupilove";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1_Tytul);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 175);
            this.panel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(329, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Rejestracja";
            // 
            // label1_Ulica
            // 
            this.label1_Ulica.AutoSize = true;
            this.label1_Ulica.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Ulica.Location = new System.Drawing.Point(9, 25);
            this.label1_Ulica.Name = "label1_Ulica";
            this.label1_Ulica.Size = new System.Drawing.Size(52, 20);
            this.label1_Ulica.TabIndex = 43;
            this.label1_Ulica.Text = "Ulica :";
            // 
            // textBox_ulica
            // 
            this.textBox_ulica.Location = new System.Drawing.Point(156, 25);
            this.textBox_ulica.Name = "textBox_ulica";
            this.textBox_ulica.Size = new System.Drawing.Size(200, 20);
            this.textBox_ulica.TabIndex = 44;
            // 
            // textBox_miasto
            // 
            this.textBox_miasto.Location = new System.Drawing.Point(156, 66);
            this.textBox_miasto.Name = "textBox_miasto";
            this.textBox_miasto.Size = new System.Drawing.Size(200, 20);
            this.textBox_miasto.TabIndex = 45;
            // 
            // textBox_kodPocztowy
            // 
            this.textBox_kodPocztowy.Location = new System.Drawing.Point(156, 107);
            this.textBox_kodPocztowy.Name = "textBox_kodPocztowy";
            this.textBox_kodPocztowy.Size = new System.Drawing.Size(200, 20);
            this.textBox_kodPocztowy.TabIndex = 46;
            // 
            // label1_Miasto
            // 
            this.label1_Miasto.AutoSize = true;
            this.label1_Miasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Miasto.Location = new System.Drawing.Point(9, 66);
            this.label1_Miasto.Name = "label1_Miasto";
            this.label1_Miasto.Size = new System.Drawing.Size(64, 20);
            this.label1_Miasto.TabIndex = 48;
            this.label1_Miasto.Text = "Miasto :";
            // 
            // label2_Kod_Pocztowy
            // 
            this.label2_Kod_Pocztowy.AutoSize = true;
            this.label2_Kod_Pocztowy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_Kod_Pocztowy.Location = new System.Drawing.Point(9, 102);
            this.label2_Kod_Pocztowy.Name = "label2_Kod_Pocztowy";
            this.label2_Kod_Pocztowy.Size = new System.Drawing.Size(116, 20);
            this.label2_Kod_Pocztowy.TabIndex = 49;
            this.label2_Kod_Pocztowy.Text = "Kod Pocztowy :";
            // 
            // label3_NrDomu
            // 
            this.label3_NrDomu.AutoSize = true;
            this.label3_NrDomu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3_NrDomu.Location = new System.Drawing.Point(9, 147);
            this.label3_NrDomu.Name = "label3_NrDomu";
            this.label3_NrDomu.Size = new System.Drawing.Size(147, 20);
            this.label3_NrDomu.TabIndex = 50;
            this.label3_NrDomu.Text = "Numer mieszkania :";
            // 
            // label1_Tel
            // 
            this.label1_Tel.AutoSize = true;
            this.label1_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tel.Location = new System.Drawing.Point(9, 229);
            this.label1_Tel.Name = "label1_Tel";
            this.label1_Tel.Size = new System.Drawing.Size(130, 20);
            this.label1_Tel.TabIndex = 51;
            this.label1_Tel.Text = "Numer Telefonu :";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(156, 231);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(200, 20);
            this.textBox_telefon.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(9, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Adres email : ";
            // 
            // textBox_mieszkanie
            // 
            this.textBox_mieszkanie.Location = new System.Drawing.Point(156, 149);
            this.textBox_mieszkanie.Name = "textBox_mieszkanie";
            this.textBox_mieszkanie.Size = new System.Drawing.Size(200, 20);
            this.textBox_mieszkanie.TabIndex = 54;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(156, 190);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(200, 20);
            this.textBox_email.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_telefon);
            this.groupBox1.Controls.Add(this.textBox_email);
            this.groupBox1.Controls.Add(this.label1_Ulica);
            this.groupBox1.Controls.Add(this.textBox_mieszkanie);
            this.groupBox1.Controls.Add(this.textBox_ulica);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_miasto);
            this.groupBox1.Controls.Add(this.textBox_kodPocztowy);
            this.groupBox1.Controls.Add(this.label1_Tel);
            this.groupBox1.Controls.Add(this.label1_Miasto);
            this.groupBox1.Controls.Add(this.label3_NrDomu);
            this.groupBox1.Controls.Add(this.label2_Kod_Pocztowy);
            this.groupBox1.Location = new System.Drawing.Point(398, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 271);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adres";
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 603);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1_Exit);
            this.Controls.Add(this.button1_Rejestruj);
            this.Controls.Add(this.textBox_haslopwt);
            this.Controls.Add(this.textBox_haslo);
            this.Controls.Add(this.comboBox_plec);
            this.Controls.Add(this.dateTimePicker_dataUrodzenia);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_nazwisko);
            this.Controls.Add(this.textBox_imie);
            this.Controls.Add(this.label7_Data_Urodzenia);
            this.Controls.Add(this.label6_Plec);
            this.Controls.Add(this.label5_Powtorz_Haslo);
            this.Controls.Add(this.label4_Haslo);
            this.Controls.Add(this.label3_Login);
            this.Controls.Add(this.label2_Nazwisko);
            this.Controls.Add(this.label1_Imie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Exit;
        private System.Windows.Forms.Button button1_Rejestruj;
        private System.Windows.Forms.MaskedTextBox textBox_haslopwt;
        private System.Windows.Forms.MaskedTextBox textBox_haslo;
        private System.Windows.Forms.ComboBox comboBox_plec;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataUrodzenia;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.Label label7_Data_Urodzenia;
        private System.Windows.Forms.Label label6_Plec;
        private System.Windows.Forms.Label label5_Powtorz_Haslo;
        private System.Windows.Forms.Label label4_Haslo;
        private System.Windows.Forms.Label label3_Login;
        private System.Windows.Forms.Label label2_Nazwisko;
        private System.Windows.Forms.Label label1_Imie;
        private System.Windows.Forms.Label label1_Tytul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1_Ulica;
        private System.Windows.Forms.TextBox textBox_ulica;
        private System.Windows.Forms.TextBox textBox_miasto;
        private System.Windows.Forms.TextBox textBox_kodPocztowy;
        private System.Windows.Forms.Label label1_Miasto;
        private System.Windows.Forms.Label label2_Kod_Pocztowy;
        private System.Windows.Forms.Label label3_NrDomu;
        private System.Windows.Forms.Label label1_Tel;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_mieszkanie;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}