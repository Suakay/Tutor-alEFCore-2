namespace _13_UrunEklemeOtomasyonu.Entities
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            txtKategoriadı = new TextBox();
            txtAçıklamaü = new TextBox();
            label1 = new Label();
            lblKategoriAdı = new Label();
            btnKategoriEkle = new Button();
            groupBox2 = new GroupBox();
            lstKategoriler = new ListView();
            bTNuRUNeKLE = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtKategoriadı);
            groupBox1.Controls.Add(txtAçıklamaü);
            groupBox1.Controls.Add(btnKategoriEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblKategoriAdı);
            groupBox1.Location = new Point(50, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(517, 207);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kategori Ekleme Paneli";
            // 
            // txtKategoriadı
            // 
            txtKategoriadı.Location = new Point(206, 37);
            txtKategoriadı.Name = "txtKategoriadı";
            txtKategoriadı.Size = new Size(150, 31);
            txtKategoriadı.TabIndex = 3;
            txtKategoriadı.TextChanged += txtKategoriadı_TextChanged;
            // 
            // txtAçıklamaü
            // 
            txtAçıklamaü.Location = new Point(206, 83);
            txtAçıklamaü.Name = "txtAçıklamaü";
            txtAçıklamaü.Size = new Size(150, 31);
            txtAçıklamaü.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 84);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 1;
            label1.Text = "Açıklaması:";
            // 
            // lblKategoriAdı
            // 
            lblKategoriAdı.AutoSize = true;
            lblKategoriAdı.Location = new Point(32, 43);
            lblKategoriAdı.Name = "lblKategoriAdı";
            lblKategoriAdı.Size = new Size(114, 25);
            lblKategoriAdı.TabIndex = 0;
            lblKategoriAdı.Text = "Kategori Adı:";
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(75, 140);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(311, 34);
            btnKategoriEkle.TabIndex = 1;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstKategoriler);
            groupBox2.Location = new Point(50, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 209);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kategoriler";
            // 
            // lstKategoriler
            // 
            lstKategoriler.GridLines = true;
            lstKategoriler.Location = new Point(133, 30);
            lstKategoriler.Name = "lstKategoriler";
            lstKategoriler.Size = new Size(356, 146);
            lstKategoriler.TabIndex = 0;
            lstKategoriler.UseCompatibleStateImageBehavior = false;
            lstKategoriler.SelectedIndexChanged += listView4_SelectedIndexChanged;
            // 
            // bTNuRUNeKLE
            // 
            bTNuRUNeKLE.Location = new Point(183, 509);
            bTNuRUNeKLE.Name = "bTNuRUNeKLE";
            bTNuRUNeKLE.Size = new Size(253, 34);
            bTNuRUNeKLE.TabIndex = 4;
            bTNuRUNeKLE.Text = "ÜRÜN EKLE";
            bTNuRUNeKLE.UseVisualStyleBackColor = true;
            bTNuRUNeKLE.Click += bTNuRUNeKLE_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 591);
            Controls.Add(bTNuRUNeKLE);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form1";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtKategoriadı;
        private TextBox txtAçıklamaü;
        private Label label1;
        private Label lblKategoriAdı;
        private Button btnKategoriEkle;
        private GroupBox groupBox2;
        private ListView lstKategoriler;
        private Button bTNuRUNeKLE;
    }
}