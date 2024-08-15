namespace _13_UrunEklemeOtomasyonu.Entities
{
    partial class Form3
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
            grpBoxÜrüneklemepaneli = new GroupBox();
            cmbKategoriler = new ComboBox();
            btnSil = new Button();
            Güncelle = new Button();
            btnKaydet = new Button();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            textBox2 = new TextBox();
            lblStokMiktarı = new Label();
            lblBirimfiyati = new Label();
            lblUrunAdı = new Label();
            lblKategorri = new Label();
            listView1 = new ListView();
            groupBox1Ürünler = new GroupBox();
            grpBoxÜrüneklemepaneli.SuspendLayout();
            groupBox1Ürünler.SuspendLayout();
            SuspendLayout();
            // 
            // grpBoxÜrüneklemepaneli
            // 
            grpBoxÜrüneklemepaneli.Controls.Add(cmbKategoriler);
            grpBoxÜrüneklemepaneli.Controls.Add(btnSil);
            grpBoxÜrüneklemepaneli.Controls.Add(Güncelle);
            grpBoxÜrüneklemepaneli.Controls.Add(btnKaydet);
            grpBoxÜrüneklemepaneli.Controls.Add(listBox2);
            grpBoxÜrüneklemepaneli.Controls.Add(listBox1);
            grpBoxÜrüneklemepaneli.Controls.Add(textBox2);
            grpBoxÜrüneklemepaneli.Controls.Add(lblStokMiktarı);
            grpBoxÜrüneklemepaneli.Controls.Add(lblBirimfiyati);
            grpBoxÜrüneklemepaneli.Controls.Add(lblUrunAdı);
            grpBoxÜrüneklemepaneli.Controls.Add(lblKategorri);
            grpBoxÜrüneklemepaneli.Location = new Point(25, 12);
            grpBoxÜrüneklemepaneli.Name = "grpBoxÜrüneklemepaneli";
            grpBoxÜrüneklemepaneli.Size = new Size(660, 284);
            grpBoxÜrüneklemepaneli.TabIndex = 0;
            grpBoxÜrüneklemepaneli.TabStop = false;
            grpBoxÜrüneklemepaneli.Text = "Ürün Ekleme Paneli";
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Items.AddRange(new object[] { "Kitap", "Oyuncak" });
            cmbKategoriler.Location = new Point(171, 46);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(182, 33);
            cmbKategoriler.TabIndex = 11;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(468, 148);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(112, 34);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            // 
            // Güncelle
            // 
            Güncelle.Location = new Point(468, 84);
            Güncelle.Name = "Güncelle";
            Güncelle.Size = new Size(112, 34);
            Güncelle.TabIndex = 9;
            Güncelle.Text = "Güncelle";
            Güncelle.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(468, 33);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 34);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(164, 180);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(180, 29);
            listBox2.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(166, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 29);
            listBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(166, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // lblStokMiktarı
            // 
            lblStokMiktarı.AutoSize = true;
            lblStokMiktarı.Location = new Point(26, 184);
            lblStokMiktarı.Name = "lblStokMiktarı";
            lblStokMiktarı.Size = new Size(106, 25);
            lblStokMiktarı.TabIndex = 3;
            lblStokMiktarı.Text = "Stok Miktarı";
            // 
            // lblBirimfiyati
            // 
            lblBirimfiyati.AutoSize = true;
            lblBirimfiyati.Location = new Point(26, 134);
            lblBirimfiyati.Name = "lblBirimfiyati";
            lblBirimfiyati.Size = new Size(102, 25);
            lblBirimfiyati.TabIndex = 2;
            lblBirimfiyati.Text = "Birim Fiyatı:";
            // 
            // lblUrunAdı
            // 
            lblUrunAdı.AutoSize = true;
            lblUrunAdı.Location = new Point(26, 84);
            lblUrunAdı.Name = "lblUrunAdı";
            lblUrunAdı.Size = new Size(86, 25);
            lblUrunAdı.TabIndex = 1;
            lblUrunAdı.Text = "Ürün Adı:";
            // 
            // lblKategorri
            // 
            lblKategorri.AutoSize = true;
            lblKategorri.Location = new Point(26, 43);
            lblKategorri.Name = "lblKategorri";
            lblKategorri.Size = new Size(78, 25);
            lblKategorri.TabIndex = 0;
            lblKategorri.Text = "Kategori";
            // 
            // listView1
            // 
            listView1.Location = new Point(22, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(235, 117);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1Ürünler
            // 
            groupBox1Ürünler.Controls.Add(listView1);
            groupBox1Ürünler.Location = new Point(92, 314);
            groupBox1Ürünler.Name = "groupBox1Ürünler";
            groupBox1Ürünler.Size = new Size(417, 182);
            groupBox1Ürünler.TabIndex = 9;
            groupBox1Ürünler.TabStop = false;
            groupBox1Ürünler.Text = "Ürünler";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 528);
            Controls.Add(groupBox1Ürünler);
            Controls.Add(grpBoxÜrüneklemepaneli);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            grpBoxÜrüneklemepaneli.ResumeLayout(false);
            grpBoxÜrüneklemepaneli.PerformLayout();
            groupBox1Ürünler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxÜrüneklemepaneli;
        private ListBox listBox2;
        private ListBox listBox1;
        private TextBox textBox2;
        private Label lblStokMiktarı;
        private Label lblBirimfiyati;
        private Label lblUrunAdı;
        private Label lblKategorri;
        private ListView listView1;
        private Button Güncelle;
        private Button btnKaydet;
        private Button btnSil;
        private GroupBox groupBox1Ürünler;
        private ComboBox cmbKategoriler;
    }
}