namespace SklepZoologiczny
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1_Zaloguj = new System.Windows.Forms.Button();
            this.button2_Wyjscie = new System.Windows.Forms.Button();
            this.label1_Tytul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label1_podpis = new System.Windows.Forms.Label();
            this.label2_podpis = new System.Windows.Forms.Label();
            this.button1_Rejestracja = new System.Windows.Forms.Button();
            this.label1_podpisRejestracja = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1_Zaloguj
            // 
            this.button1_Zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Zaloguj.Location = new System.Drawing.Point(134, 316);
            this.button1_Zaloguj.Name = "button1_Zaloguj";
            this.button1_Zaloguj.Size = new System.Drawing.Size(189, 39);
            this.button1_Zaloguj.TabIndex = 0;
            this.button1_Zaloguj.Text = "Zaloguj";
            this.button1_Zaloguj.UseVisualStyleBackColor = true;
            this.button1_Zaloguj.Click += new System.EventHandler(this.button1_Zaloguj_Click);
            // 
            // button2_Wyjscie
            // 
            this.button2_Wyjscie.BackColor = System.Drawing.Color.Red;
            this.button2_Wyjscie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2_Wyjscie.ForeColor = System.Drawing.Color.White;
            this.button2_Wyjscie.Location = new System.Drawing.Point(242, 438);
            this.button2_Wyjscie.Name = "button2_Wyjscie";
            this.button2_Wyjscie.Size = new System.Drawing.Size(180, 41);
            this.button2_Wyjscie.TabIndex = 1;
            this.button2_Wyjscie.Text = "Wyjście";
            this.button2_Wyjscie.UseVisualStyleBackColor = false;
            this.button2_Wyjscie.Click += new System.EventHandler(this.button2_Wyjscie_Click);
            // 
            // label1_Tytul
            // 
            this.label1_Tytul.AutoSize = true;
            this.label1_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tytul.ForeColor = System.Drawing.Color.White;
            this.label1_Tytul.Location = new System.Drawing.Point(32, 33);
            this.label1_Tytul.Name = "label1_Tytul";
            this.label1_Tytul.Size = new System.Drawing.Size(419, 108);
            this.label1_Tytul.TabIndex = 2;
            this.label1_Tytul.Text = "Pupilove";
            this.label1_Tytul.Click += new System.EventHandler(this.label1_Tytul_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1_Tytul);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 175);
            this.panel1.TabIndex = 3;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(134, 213);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(189, 20);
            this.textBox_Login.TabIndex = 4;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(134, 277);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(189, 20);
            this.textBox_pass.TabIndex = 5;
            // 
            // label1_podpis
            // 
            this.label1_podpis.AutoSize = true;
            this.label1_podpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_podpis.Location = new System.Drawing.Point(135, 186);
            this.label1_podpis.Name = "label1_podpis";
            this.label1_podpis.Size = new System.Drawing.Size(188, 24);
            this.label1_podpis.TabIndex = 6;
            this.label1_podpis.Text = "Nazwa użytkownika : ";
            // 
            // label2_podpis
            // 
            this.label2_podpis.AutoSize = true;
            this.label2_podpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2_podpis.Location = new System.Drawing.Point(191, 250);
            this.label2_podpis.Name = "label2_podpis";
            this.label2_podpis.Size = new System.Drawing.Size(72, 24);
            this.label2_podpis.TabIndex = 7;
            this.label2_podpis.Text = "Hasło :";
            // 
            // button1_Rejestracja
            // 
            this.button1_Rejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1_Rejestracja.Location = new System.Drawing.Point(35, 438);
            this.button1_Rejestracja.Name = "button1_Rejestracja";
            this.button1_Rejestracja.Size = new System.Drawing.Size(180, 41);
            this.button1_Rejestracja.TabIndex = 10;
            this.button1_Rejestracja.Text = "Zarejestruj";
            this.button1_Rejestracja.Click += new System.EventHandler(this.button1_Rejestracja_Click);
            // 
            // label1_podpisRejestracja
            // 
            this.label1_podpisRejestracja.AutoSize = true;
            this.label1_podpisRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_podpisRejestracja.Location = new System.Drawing.Point(153, 400);
            this.label1_podpisRejestracja.Name = "label1_podpisRejestracja";
            this.label1_podpisRejestracja.Size = new System.Drawing.Size(153, 24);
            this.label1_podpisRejestracja.TabIndex = 9;
            this.label1_podpisRejestracja.Text = "Nie masz konta ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 511);
            this.Controls.Add(this.label1_podpisRejestracja);
            this.Controls.Add(this.button1_Rejestracja);
            this.Controls.Add(this.label2_podpis);
            this.Controls.Add(this.label1_podpis);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2_Wyjscie);
            this.Controls.Add(this.button1_Zaloguj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_Zaloguj;
        private System.Windows.Forms.Button button2_Wyjscie;
        private System.Windows.Forms.Label label1_Tytul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label1_podpis;
        private System.Windows.Forms.Label label2_podpis;
        private System.Windows.Forms.Button button1_Rejestracja;
        private System.Windows.Forms.Label label1_podpisRejestracja;
    }
}

