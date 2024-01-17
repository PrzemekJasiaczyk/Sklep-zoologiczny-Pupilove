namespace SklepZoologiczny
{
    partial class Koszyk
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
            this.label1_Tytul = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2_platnosc = new System.Windows.Forms.Button();
            this.button1_usun = new System.Windows.Forms.Button();
            this.button1_wyjście = new System.Windows.Forms.Button();
            this.dataGridView_Koszyk = new System.Windows.Forms.DataGridView();
            this.button_clean = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_kwota = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Koszyk)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_Tytul
            // 
            this.label1_Tytul.AutoSize = true;
            this.label1_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tytul.ForeColor = System.Drawing.Color.White;
            this.label1_Tytul.Location = new System.Drawing.Point(206, 12);
            this.label1_Tytul.Name = "label1_Tytul";
            this.label1_Tytul.Size = new System.Drawing.Size(419, 108);
            this.label1_Tytul.TabIndex = 3;
            this.label1_Tytul.Text = "Pupilove";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1_Tytul);
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 181);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Koszyk";
            // 
            // button2_platnosc
            // 
            this.button2_platnosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2_platnosc.Location = new System.Drawing.Point(426, 505);
            this.button2_platnosc.Name = "button2_platnosc";
            this.button2_platnosc.Size = new System.Drawing.Size(167, 43);
            this.button2_platnosc.TabIndex = 34;
            this.button2_platnosc.Text = "Finalizacja zamówienia ";
            this.button2_platnosc.UseVisualStyleBackColor = true;
            this.button2_platnosc.Click += new System.EventHandler(this.button2_platnosc_Click);
            // 
            // button1_usun
            // 
            this.button1_usun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_usun.Location = new System.Drawing.Point(61, 506);
            this.button1_usun.Name = "button1_usun";
            this.button1_usun.Size = new System.Drawing.Size(167, 43);
            this.button1_usun.TabIndex = 33;
            this.button1_usun.Text = "Usuń z koszyka";
            this.button1_usun.UseVisualStyleBackColor = true;
            this.button1_usun.Click += new System.EventHandler(this.button1_usun_Click);
            // 
            // button1_wyjście
            // 
            this.button1_wyjście.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_wyjście.Location = new System.Drawing.Point(599, 505);
            this.button1_wyjście.Name = "button1_wyjście";
            this.button1_wyjście.Size = new System.Drawing.Size(167, 43);
            this.button1_wyjście.TabIndex = 32;
            this.button1_wyjście.Text = "Powrót ";
            this.button1_wyjście.UseVisualStyleBackColor = true;
            this.button1_wyjście.Click += new System.EventHandler(this.button1_wyjście_Click_1);
            // 
            // dataGridView_Koszyk
            // 
            this.dataGridView_Koszyk.AllowUserToAddRows = false;
            this.dataGridView_Koszyk.AllowUserToDeleteRows = false;
            this.dataGridView_Koszyk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_Koszyk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Koszyk.Location = new System.Drawing.Point(61, 193);
            this.dataGridView_Koszyk.MultiSelect = false;
            this.dataGridView_Koszyk.Name = "dataGridView_Koszyk";
            this.dataGridView_Koszyk.ReadOnly = true;
            this.dataGridView_Koszyk.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Koszyk.Size = new System.Drawing.Size(705, 263);
            this.dataGridView_Koszyk.TabIndex = 30;
            this.dataGridView_Koszyk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_clean
            // 
            this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_clean.Location = new System.Drawing.Point(234, 505);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(167, 43);
            this.button_clean.TabIndex = 35;
            this.button_clean.Text = "Wyczyść koszyk";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(496, 470);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 36;
            this.label6.Text = "Do zapłaty : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(595, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 37;
            // 
            // label_kwota
            // 
            this.label_kwota.AutoSize = true;
            this.label_kwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kwota.Location = new System.Drawing.Point(601, 470);
            this.label_kwota.Name = "label_kwota";
            this.label_kwota.Size = new System.Drawing.Size(18, 20);
            this.label_kwota.TabIndex = 38;
            this.label_kwota.Text = "0";
            // 
            // Koszyk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 561);
            this.Controls.Add(this.label_kwota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button2_platnosc);
            this.Controls.Add(this.button1_usun);
            this.Controls.Add(this.button1_wyjście);
            this.Controls.Add(this.dataGridView_Koszyk);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Koszyk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Koszyk";
            this.Load += new System.EventHandler(this.Koszyk_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Koszyk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_Tytul;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2_platnosc;
        private System.Windows.Forms.Button button1_usun;
        private System.Windows.Forms.Button button1_wyjście;
        private System.Windows.Forms.DataGridView dataGridView_Koszyk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_kwota;
    }
}