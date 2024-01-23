namespace SklepZoologiczny
{
    partial class Magazyn
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
            this.textBox1_ProductName = new System.Windows.Forms.TextBox();
            this.label1_ProductName = new System.Windows.Forms.Label();
            this.label1_przypis = new System.Windows.Forms.Label();
            this.numericUpDown1_DodajArt = new System.Windows.Forms.NumericUpDown();
            this.button1_Zloz_zamowienie_produkty = new System.Windows.Forms.Button();
            this.button1_Home = new System.Windows.Forms.Button();
            this.dataGridView2_Magazyn = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1_Tytul = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_DodajArt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Magazyn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1_ProductName
            // 
            this.textBox1_ProductName.Location = new System.Drawing.Point(367, 469);
            this.textBox1_ProductName.Name = "textBox1_ProductName";
            this.textBox1_ProductName.Size = new System.Drawing.Size(200, 20);
            this.textBox1_ProductName.TabIndex = 102;
            this.textBox1_ProductName.TextChanged += new System.EventHandler(this.textBox1_ProductName_TextChanged);
            // 
            // label1_ProductName
            // 
            this.label1_ProductName.AutoSize = true;
            this.label1_ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_ProductName.Location = new System.Drawing.Point(96, 469);
            this.label1_ProductName.Name = "label1_ProductName";
            this.label1_ProductName.Size = new System.Drawing.Size(240, 20);
            this.label1_ProductName.TabIndex = 101;
            this.label1_ProductName.Text = "Wpisz tutaj nazwę produktu :";
            // 
            // label1_przypis
            // 
            this.label1_przypis.AutoSize = true;
            this.label1_przypis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_przypis.Location = new System.Drawing.Point(96, 429);
            this.label1_przypis.Name = "label1_przypis";
            this.label1_przypis.Size = new System.Drawing.Size(259, 20);
            this.label1_przypis.TabIndex = 100;
            this.label1_przypis.Text = "Ile artykółów chcesz zamówić : ";
            // 
            // numericUpDown1_DodajArt
            // 
            this.numericUpDown1_DodajArt.Location = new System.Drawing.Point(367, 429);
            this.numericUpDown1_DodajArt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1_DodajArt.Name = "numericUpDown1_DodajArt";
            this.numericUpDown1_DodajArt.Size = new System.Drawing.Size(200, 20);
            this.numericUpDown1_DodajArt.TabIndex = 99;
            // 
            // button1_Zloz_zamowienie_produkty
            // 
            this.button1_Zloz_zamowienie_produkty.BackColor = System.Drawing.Color.White;
            this.button1_Zloz_zamowienie_produkty.Enabled = false;
            this.button1_Zloz_zamowienie_produkty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Zloz_zamowienie_produkty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1_Zloz_zamowienie_produkty.Location = new System.Drawing.Point(100, 525);
            this.button1_Zloz_zamowienie_produkty.Name = "button1_Zloz_zamowienie_produkty";
            this.button1_Zloz_zamowienie_produkty.Size = new System.Drawing.Size(228, 54);
            this.button1_Zloz_zamowienie_produkty.TabIndex = 98;
            this.button1_Zloz_zamowienie_produkty.Text = "Złóż zamówienie ";
            this.button1_Zloz_zamowienie_produkty.UseVisualStyleBackColor = false;
            this.button1_Zloz_zamowienie_produkty.Click += new System.EventHandler(this.button1_Zloz_zamowienie_produkty_Click);
            // 
            // button1_Home
            // 
            this.button1_Home.BackColor = System.Drawing.Color.Red;
            this.button1_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Home.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1_Home.Location = new System.Drawing.Point(380, 525);
            this.button1_Home.Name = "button1_Home";
            this.button1_Home.Size = new System.Drawing.Size(228, 54);
            this.button1_Home.TabIndex = 97;
            this.button1_Home.Text = "Wyjście";
            this.button1_Home.UseVisualStyleBackColor = false;
            this.button1_Home.Click += new System.EventHandler(this.button1_Home_Click);
            // 
            // dataGridView2_Magazyn
            // 
            this.dataGridView2_Magazyn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2_Magazyn.Location = new System.Drawing.Point(131, 182);
            this.dataGridView2_Magazyn.Name = "dataGridView2_Magazyn";
            this.dataGridView2_Magazyn.Size = new System.Drawing.Size(419, 219);
            this.dataGridView2_Magazyn.TabIndex = 96;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1_Tytul);
            this.panel1.Location = new System.Drawing.Point(-62, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 176);
            this.panel1.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(334, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Magazyn";
            // 
            // label1_Tytul
            // 
            this.label1_Tytul.AutoSize = true;
            this.label1_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tytul.ForeColor = System.Drawing.Color.White;
            this.label1_Tytul.Location = new System.Drawing.Point(186, 22);
            this.label1_Tytul.Name = "label1_Tytul";
            this.label1_Tytul.Size = new System.Drawing.Size(419, 108);
            this.label1_Tytul.TabIndex = 25;
            this.label1_Tytul.Text = "Pupilove";
            // 
            // Magazyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1_ProductName);
            this.Controls.Add(this.label1_ProductName);
            this.Controls.Add(this.label1_przypis);
            this.Controls.Add(this.numericUpDown1_DodajArt);
            this.Controls.Add(this.button1_Zloz_zamowienie_produkty);
            this.Controls.Add(this.button1_Home);
            this.Controls.Add(this.dataGridView2_Magazyn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Magazyn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazyn";
            this.Load += new System.EventHandler(this.Magazyn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_DodajArt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2_Magazyn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_ProductName;
        private System.Windows.Forms.Label label1_ProductName;
        private System.Windows.Forms.Label label1_przypis;
        private System.Windows.Forms.NumericUpDown numericUpDown1_DodajArt;
        private System.Windows.Forms.Button button1_Zloz_zamowienie_produkty;
        private System.Windows.Forms.Button button1_Home;
        private System.Windows.Forms.DataGridView dataGridView2_Magazyn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1_Tytul;
    }
}