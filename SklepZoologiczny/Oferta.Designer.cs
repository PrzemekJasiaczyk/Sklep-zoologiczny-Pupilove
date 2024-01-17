namespace SklepZoologiczny
{
    partial class Oferta
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
            this.dataGridView1_Oferta = new System.Windows.Forms.DataGridView();
            this.button10_Home = new System.Windows.Forms.Button();
            this.label1_Tytul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Filtruj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Pupil = new System.Windows.Forms.ComboBox();
            this.comboBox_Rodzaj = new System.Windows.Forms.ComboBox();
            this.numericUpDown_CenaMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_CenaMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Koszyk = new System.Windows.Forms.Button();
            this.checkBox_dostepny = new System.Windows.Forms.CheckBox();
            this.checkBox_Promocja = new System.Windows.Forms.CheckBox();
            this.button_anuluj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Oferta)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CenaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CenaMin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1_Oferta
            // 
            this.dataGridView1_Oferta.AllowUserToAddRows = false;
            this.dataGridView1_Oferta.AllowUserToDeleteRows = false;
            this.dataGridView1_Oferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Oferta.Location = new System.Drawing.Point(369, 215);
            this.dataGridView1_Oferta.MultiSelect = false;
            this.dataGridView1_Oferta.Name = "dataGridView1_Oferta";
            this.dataGridView1_Oferta.ReadOnly = true;
            this.dataGridView1_Oferta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1_Oferta.Size = new System.Drawing.Size(648, 448);
            this.dataGridView1_Oferta.TabIndex = 1;
            // 
            // button10_Home
            // 
            this.button10_Home.BackColor = System.Drawing.Color.White;
            this.button10_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10_Home.Location = new System.Drawing.Point(28, 603);
            this.button10_Home.Name = "button10_Home";
            this.button10_Home.Size = new System.Drawing.Size(292, 60);
            this.button10_Home.TabIndex = 32;
            this.button10_Home.Text = "Home";
            this.button10_Home.UseVisualStyleBackColor = false;
            this.button10_Home.Click += new System.EventHandler(this.button10_Home_Click);
            // 
            // label1_Tytul
            // 
            this.label1_Tytul.AutoSize = true;
            this.label1_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tytul.ForeColor = System.Drawing.Color.White;
            this.label1_Tytul.Location = new System.Drawing.Point(296, 11);
            this.label1_Tytul.Name = "label1_Tytul";
            this.label1_Tytul.Size = new System.Drawing.Size(419, 108);
            this.label1_Tytul.TabIndex = 3;
            this.label1_Tytul.Text = "Pupilove";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1_Tytul);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 156);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Oferta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_anuluj);
            this.groupBox1.Controls.Add(this.checkBox_Promocja);
            this.groupBox1.Controls.Add(this.checkBox_dostepny);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_Filtruj);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_Pupil);
            this.groupBox1.Controls.Add(this.comboBox_Rodzaj);
            this.groupBox1.Controls.Add(this.numericUpDown_CenaMax);
            this.groupBox1.Controls.Add(this.numericUpDown_CenaMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 426);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Produkt promocyjny : ";
            // 
            // button_Filtruj
            // 
            this.button_Filtruj.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Filtruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Filtruj.Location = new System.Drawing.Point(180, 354);
            this.button_Filtruj.Name = "button_Filtruj";
            this.button_Filtruj.Size = new System.Drawing.Size(120, 44);
            this.button_Filtruj.TabIndex = 15;
            this.button_Filtruj.Text = "Filtruj";
            this.button_Filtruj.UseVisualStyleBackColor = false;
            this.button_Filtruj.Click += new System.EventHandler(this.button_Filtruj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produkt dostępny : ";
            // 
            // comboBox_Pupil
            // 
            this.comboBox_Pupil.FormattingEnabled = true;
            this.comboBox_Pupil.Location = new System.Drawing.Point(180, 59);
            this.comboBox_Pupil.Name = "comboBox_Pupil";
            this.comboBox_Pupil.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Pupil.TabIndex = 10;
            // 
            // comboBox_Rodzaj
            // 
            this.comboBox_Rodzaj.FormattingEnabled = true;
            this.comboBox_Rodzaj.Location = new System.Drawing.Point(181, 19);
            this.comboBox_Rodzaj.Name = "comboBox_Rodzaj";
            this.comboBox_Rodzaj.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Rodzaj.TabIndex = 8;
            // 
            // numericUpDown_CenaMax
            // 
            this.numericUpDown_CenaMax.Location = new System.Drawing.Point(180, 140);
            this.numericUpDown_CenaMax.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_CenaMax.Name = "numericUpDown_CenaMax";
            this.numericUpDown_CenaMax.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_CenaMax.TabIndex = 7;
            this.numericUpDown_CenaMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_CenaMin
            // 
            this.numericUpDown_CenaMin.Location = new System.Drawing.Point(180, 105);
            this.numericUpDown_CenaMin.Name = "numericUpDown_CenaMin";
            this.numericUpDown_CenaMin.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_CenaMin.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(79, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jaki pupil ?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(33, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rodzaj artykółów : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(107, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Cena : ";
            // 
            // button_Koszyk
            // 
            this.button_Koszyk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Koszyk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Koszyk.Location = new System.Drawing.Point(829, 165);
            this.button_Koszyk.Name = "button_Koszyk";
            this.button_Koszyk.Size = new System.Drawing.Size(188, 44);
            this.button_Koszyk.TabIndex = 34;
            this.button_Koszyk.Text = "Dodaj Do Koszyka";
            this.button_Koszyk.UseVisualStyleBackColor = false;
            this.button_Koszyk.Click += new System.EventHandler(this.button_Koszyk_Click);
            // 
            // checkBox_dostepny
            // 
            this.checkBox_dostepny.AutoSize = true;
            this.checkBox_dostepny.Location = new System.Drawing.Point(217, 185);
            this.checkBox_dostepny.Name = "checkBox_dostepny";
            this.checkBox_dostepny.Size = new System.Drawing.Size(15, 14);
            this.checkBox_dostepny.TabIndex = 18;
            this.checkBox_dostepny.UseVisualStyleBackColor = true;
            // 
            // checkBox_Promocja
            // 
            this.checkBox_Promocja.AutoSize = true;
            this.checkBox_Promocja.Location = new System.Drawing.Point(217, 222);
            this.checkBox_Promocja.Name = "checkBox_Promocja";
            this.checkBox_Promocja.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Promocja.TabIndex = 19;
            this.checkBox_Promocja.UseVisualStyleBackColor = true;
            // 
            // button_anuluj
            // 
            this.button_anuluj.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_anuluj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_anuluj.Location = new System.Drawing.Point(16, 354);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(120, 44);
            this.button_anuluj.TabIndex = 35;
            this.button_anuluj.Text = "Wyłącz filtry";
            this.button_anuluj.UseVisualStyleBackColor = false;
            this.button_anuluj.Click += new System.EventHandler(this.button_anuluj_Click);
            // 
            // Oferta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 675);
            this.ControlBox = false;
            this.Controls.Add(this.button_Koszyk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button10_Home);
            this.Controls.Add(this.dataGridView1_Oferta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Oferta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oferta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Oferta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CenaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CenaMin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1_Oferta;
        private System.Windows.Forms.Button button10_Home;
        private System.Windows.Forms.Label label1_Tytul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Filtruj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Pupil;
        private System.Windows.Forms.ComboBox comboBox_Rodzaj;
        private System.Windows.Forms.NumericUpDown numericUpDown_CenaMax;
        private System.Windows.Forms.NumericUpDown numericUpDown_CenaMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Koszyk;
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.CheckBox checkBox_Promocja;
        private System.Windows.Forms.CheckBox checkBox_dostepny;
    }
}