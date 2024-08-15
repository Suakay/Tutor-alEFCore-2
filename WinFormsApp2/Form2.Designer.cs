namespace WinFormsApp2
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textİletişimBilgilerninTamamala = new TextBox();
            btnGiriş = new Button();
            grpBoxİletişimEkranı = new GroupBox();
            txtEvAdresi = new TextBox();
            lblEvAdresi = new Label();
            txtTelefonnumarsı = new TextBox();
            label3 = new Label();
            txtposta = new TextBox();
            label2 = new Label();
            btnKaydet = new Button();
            btnYeniPersonel = new Button();
            btnTümKayıtlar = new Button();
            grpBoxİletişimEkranı.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(438, 25);
            label1.TabIndex = 0;
            label1.Text = "İletişim Bilgilerini Tamamlamak İçin Bir Personel Seçiniz";
            // 
            // textİletişimBilgilerninTamamala
            // 
            textİletişimBilgilerninTamamala.Location = new Point(44, 63);
            textİletişimBilgilerninTamamala.Name = "textİletişimBilgilerninTamamala";
            textİletişimBilgilerninTamamala.Size = new Size(522, 31);
            textİletişimBilgilerninTamamala.TabIndex = 1;
            textİletişimBilgilerninTamamala.TextChanged += textİletişimBilgilerninTamamala_TextChanged;
            // 
            // btnGiriş
            // 
            btnGiriş.Location = new Point(98, 115);
            btnGiriş.Name = "btnGiriş";
            btnGiriş.Size = new Size(355, 34);
            btnGiriş.TabIndex = 2;
            btnGiriş.Text = "Giriş Ya Da Güncelleme Yap";
            btnGiriş.UseVisualStyleBackColor = true;
            btnGiriş.Click += btnGiriş_Click;
            // 
            // grpBoxİletişimEkranı
            // 
            grpBoxİletişimEkranı.Controls.Add(txtEvAdresi);
            grpBoxİletişimEkranı.Controls.Add(lblEvAdresi);
            grpBoxİletişimEkranı.Controls.Add(txtTelefonnumarsı);
            grpBoxİletişimEkranı.Controls.Add(label3);
            grpBoxİletişimEkranı.Controls.Add(txtposta);
            grpBoxİletişimEkranı.Controls.Add(label2);
            grpBoxİletişimEkranı.Location = new Point(69, 184);
            grpBoxİletişimEkranı.Name = "grpBoxİletişimEkranı";
            grpBoxİletişimEkranı.Size = new Size(426, 218);
            grpBoxİletişimEkranı.TabIndex = 3;
            grpBoxİletişimEkranı.TabStop = false;
            grpBoxİletişimEkranı.Text = "İletişim Bilgisi Giriş Ekranı";
            // 
            // txtEvAdresi
            // 
            txtEvAdresi.Location = new Point(160, 163);
            txtEvAdresi.Name = "txtEvAdresi";
            txtEvAdresi.Size = new Size(150, 31);
            txtEvAdresi.TabIndex = 5;
            // 
            // lblEvAdresi
            // 
            lblEvAdresi.AutoSize = true;
            lblEvAdresi.Location = new Point(29, 166);
            lblEvAdresi.Name = "lblEvAdresi";
            lblEvAdresi.Size = new Size(85, 25);
            lblEvAdresi.TabIndex = 4;
            lblEvAdresi.Text = "Ev Adresi";
            // 
            // txtTelefonnumarsı
            // 
            txtTelefonnumarsı.Location = new Point(160, 89);
            txtTelefonnumarsı.Name = "txtTelefonnumarsı";
            txtTelefonnumarsı.Size = new Size(150, 31);
            txtTelefonnumarsı.TabIndex = 3;
            txtTelefonnumarsı.Text = "(__)__.___";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 85);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Telefonu";
            // 
            // txtposta
            // 
            txtposta.Location = new Point(159, 36);
            txtposta.Name = "txtposta";
            txtposta.Size = new Size(150, 31);
            txtposta.TabIndex = 1;
            txtposta.TextChanged += txtposta_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 0;
            label2.Text = "E-Posta Adres";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(313, 408);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(169, 34);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnYeniPersonel
            // 
            btnYeniPersonel.Location = new Point(44, 467);
            btnYeniPersonel.Name = "btnYeniPersonel";
            btnYeniPersonel.Size = new Size(183, 34);
            btnYeniPersonel.TabIndex = 5;
            btnYeniPersonel.Text = "Yeni Personel";
            btnYeniPersonel.UseVisualStyleBackColor = true;
            // 
            // btnTümKayıtlar
            // 
            btnTümKayıtlar.Location = new Point(379, 462);
            btnTümKayıtlar.Name = "btnTümKayıtlar";
            btnTümKayıtlar.Size = new Size(260, 34);
            btnTümKayıtlar.TabIndex = 6;
            btnTümKayıtlar.Text = "Tüm Kayıtlar";
            btnTümKayıtlar.UseVisualStyleBackColor = true;
            btnTümKayıtlar.Click += btnTümKayıtlar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(btnTümKayıtlar);
            Controls.Add(btnYeniPersonel);
            Controls.Add(btnKaydet);
            Controls.Add(grpBoxİletişimEkranı);
            Controls.Add(btnGiriş);
            Controls.Add(textİletişimBilgilerninTamamala);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            grpBoxİletişimEkranı.ResumeLayout(false);
            grpBoxİletişimEkranı.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textİletişimBilgilerninTamamala;
        private Button btnGiriş;
        private GroupBox grpBoxİletişimEkranı;
        private Label lblEvAdresi;
        private TextBox txtTelefonnumarsı;
        private Label label3;
        private TextBox txtposta;
        private Label label2;
        private TextBox txtEvAdresi;
        private Button btnKaydet;
        private Button btnYeniPersonel;
        private Button btnTümKayıtlar;
    }
}
