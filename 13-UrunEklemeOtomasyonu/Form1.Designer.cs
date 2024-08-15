namespace _13_UrunEklemeOtomasyonu
{
    partial class Form1
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
            lblKullaniciAdi = new Label();
            lblSifre = new Label();
            txtKullanıcıadı = new TextBox();
            txtSifre = new TextBox();
            btnGonder = new Button();
            SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(128, 63);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(107, 25);
            lblKullaniciAdi.TabIndex = 0;
            lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(156, 133);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(47, 25);
            lblSifre.TabIndex = 1;
            lblSifre.Text = "Şifre";
            // 
            // txtKullanıcıadı
            // 
            txtKullanıcıadı.Location = new Point(336, 63);
            txtKullanıcıadı.Name = "txtKullanıcıadı";
            txtKullanıcıadı.Size = new Size(150, 31);
            txtKullanıcıadı.TabIndex = 2;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(339, 127);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(150, 31);
            txtSifre.TabIndex = 3;
         
            // 
            // btnGonder
            // 
            btnGonder.Location = new Point(277, 237);
            btnGonder.Name = "btnGonder";
            btnGonder.Size = new Size(112, 34);
            btnGonder.TabIndex = 4;
            btnGonder.Text = "Gönder";
            btnGonder.UseVisualStyleBackColor = true;
            btnGonder.Click += btnGonder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGonder);
            Controls.Add(txtSifre);
            Controls.Add(txtKullanıcıadı);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAdi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKullaniciAdi;
        private Label lblSifre;
        private TextBox txtKullanıcıadı;
        private TextBox txtSifre;
        private Button btnGonder;
    }
}
