namespace SklepZoologiczny
{
    partial class Historia_zakupow
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
            this.button1_Detale = new System.Windows.Forms.Button();
            this.button1_wyjście = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1_Tytul = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_detale = new System.Windows.Forms.DataGridView();
            this.label_adres = new System.Windows.Forms.Label();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detale)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_Detale
            // 
            this.button1_Detale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_Detale.Location = new System.Drawing.Point(513, 456);
            this.button1_Detale.Name = "button1_Detale";
            this.button1_Detale.Size = new System.Drawing.Size(226, 43);
            this.button1_Detale.TabIndex = 38;
            this.button1_Detale.Text = "Pokaż Detale";
            this.button1_Detale.UseVisualStyleBackColor = true;
            this.button1_Detale.Click += new System.EventHandler(this.button1_Detale_Click);
            // 
            // button1_wyjście
            // 
            this.button1_wyjście.BackColor = System.Drawing.Color.Red;
            this.button1_wyjście.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_wyjście.ForeColor = System.Drawing.Color.White;
            this.button1_wyjście.Location = new System.Drawing.Point(33, 456);
            this.button1_wyjście.Name = "button1_wyjście";
            this.button1_wyjście.Size = new System.Drawing.Size(226, 43);
            this.button1_wyjście.TabIndex = 37;
            this.button1_wyjście.Text = "Wyjście";
            this.button1_wyjście.UseVisualStyleBackColor = false;
            this.button1_wyjście.Click += new System.EventHandler(this.button1_wyjście_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 190);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(383, 263);
            this.dataGridView1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(286, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Historia zakupów";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1_Tytul
            // 
            this.label1_Tytul.AutoSize = true;
            this.label1_Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_Tytul.ForeColor = System.Drawing.Color.White;
            this.label1_Tytul.Location = new System.Drawing.Point(186, 11);
            this.label1_Tytul.Name = "label1_Tytul";
            this.label1_Tytul.Size = new System.Drawing.Size(419, 108);
            this.label1_Tytul.TabIndex = 3;
            this.label1_Tytul.Text = "Pupilove";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1_Tytul);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 159);
            this.panel1.TabIndex = 41;
            // 
            // dataGridView_detale
            // 
            this.dataGridView_detale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_detale.Location = new System.Drawing.Point(427, 268);
            this.dataGridView_detale.Name = "dataGridView_detale";
            this.dataGridView_detale.Size = new System.Drawing.Size(383, 185);
            this.dataGridView_detale.TabIndex = 42;
            // 
            // label_adres
            // 
            this.label_adres.AutoSize = true;
            this.label_adres.Location = new System.Drawing.Point(424, 228);
            this.label_adres.Name = "label_adres";
            this.label_adres.Size = new System.Drawing.Size(34, 13);
            this.label_adres.TabIndex = 43;
            this.label_adres.Text = "Adres";
            // 
            // comboBox_status
            // 
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Location = new System.Drawing.Point(274, 160);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(121, 21);
            this.comboBox_status.TabIndex = 44;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(122, 163);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(146, 13);
            this.label_status.TabIndex = 45;
            this.label_status.Text = "Sortuj po statusie zamówienia";
            // 
            // Historia_zakupow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 542);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.comboBox_status);
            this.Controls.Add(this.label_adres);
            this.Controls.Add(this.dataGridView_detale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1_Detale);
            this.Controls.Add(this.button1_wyjście);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historia_zakupow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia_zakupow";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_detale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1_Detale;
        private System.Windows.Forms.Button button1_wyjście;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1_Tytul;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_detale;
        private System.Windows.Forms.Label label_adres;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.Label label_status;
    }
}