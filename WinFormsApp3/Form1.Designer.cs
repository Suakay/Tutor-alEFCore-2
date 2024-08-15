namespace WinFormsApp3
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
            grpboxPersonelBilgileri = new GroupBox();
            listViewpesoneller = new ListView();
            btnTemizle = new Button();
            groupBoxpersonelbul = new GroupBox();
            btn2temizle = new Button();
            lbxPersoneller = new ListBox();
            btnAnamenü = new Button();
            btnVeritabanındansil = new Button();
            grpboxPersonelBilgileri.SuspendLayout();
            groupBoxpersonelbul.SuspendLayout();
            SuspendLayout();
            // 
            // grpboxPersonelBilgileri
            // 
            grpboxPersonelBilgileri.Controls.Add(listViewpesoneller);
            grpboxPersonelBilgileri.Controls.Add(btnTemizle);
            grpboxPersonelBilgileri.Location = new Point(73, 43);
            grpboxPersonelBilgileri.Name = "grpboxPersonelBilgileri";
            grpboxPersonelBilgileri.Size = new Size(380, 257);
            grpboxPersonelBilgileri.TabIndex = 0;
            grpboxPersonelBilgileri.TabStop = false;
            grpboxPersonelBilgileri.Text = "Personel Bilgileri";
            // 
            // listViewpesoneller
            // 
            listViewpesoneller.Location = new Point(16, 46);
            listViewpesoneller.Name = "listViewpesoneller";
            listViewpesoneller.Size = new Size(326, 146);
            listViewpesoneller.TabIndex = 2;
            listViewpesoneller.UseCompatibleStateImageBehavior = false;
            listViewpesoneller.SelectedIndexChanged += listViewpesoneller_SelectedIndexChanged;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(16, 198);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(326, 34);
            btnTemizle.TabIndex = 1;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // groupBoxpersonelbul
            // 
            groupBoxpersonelbul.Controls.Add(btn2temizle);
            groupBoxpersonelbul.Controls.Add(lbxPersoneller);
            groupBoxpersonelbul.Location = new Point(549, 34);
            groupBoxpersonelbul.Name = "groupBoxpersonelbul";
            groupBoxpersonelbul.Size = new Size(617, 377);
            groupBoxpersonelbul.TabIndex = 1;
            groupBoxpersonelbul.TabStop = false;
            groupBoxpersonelbul.Text = "Personel Bul";
            // 
            // btn2temizle
            // 
            btn2temizle.Location = new Point(213, 311);
            btn2temizle.Name = "btn2temizle";
            btn2temizle.Size = new Size(188, 34);
            btn2temizle.TabIndex = 2;
            btn2temizle.Text = "Temizle";
            btn2temizle.UseVisualStyleBackColor = true;
            btn2temizle.Click += btn2temizle_Click;
            // 
            // lbxPersoneller
            // 
            lbxPersoneller.FormattingEnabled = true;
            lbxPersoneller.ItemHeight = 25;
            lbxPersoneller.Location = new Point(39, 72);
            lbxPersoneller.Name = "lbxPersoneller";
            lbxPersoneller.Size = new Size(509, 204);
            lbxPersoneller.TabIndex = 0;
            lbxPersoneller.SelectedIndexChanged += lbxPersoneller_SelectedIndexChanged;
            // 
            // btnAnamenü
            // 
            btnAnamenü.Location = new Point(123, 345);
            btnAnamenü.Name = "btnAnamenü";
            btnAnamenü.Size = new Size(209, 34);
            btnAnamenü.TabIndex = 2;
            btnAnamenü.Text = "ANA MENÜ";
            btnAnamenü.UseVisualStyleBackColor = true;
            btnAnamenü.Click += btnAnamenü_Click;
            // 
            // btnVeritabanındansil
            // 
            btnVeritabanındansil.Location = new Point(681, 433);
            btnVeritabanındansil.Name = "btnVeritabanındansil";
            btnVeritabanındansil.Size = new Size(269, 34);
            btnVeritabanındansil.TabIndex = 3;
            btnVeritabanındansil.Text = "Personeli Veritabanından Sil";
            btnVeritabanındansil.UseVisualStyleBackColor = true;
            btnVeritabanındansil.Click += btnVeritabanındansil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 522);
            Controls.Add(btnVeritabanındansil);
            Controls.Add(btnAnamenü);
            Controls.Add(groupBoxpersonelbul);
            Controls.Add(grpboxPersonelBilgileri);
            Name = "Form1";
            Text = "Form1";
            grpboxPersonelBilgileri.ResumeLayout(false);
            groupBoxpersonelbul.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpboxPersonelBilgileri;
        private Button btnTemizle;
        private ListView listViewpesoneller;
        private GroupBox groupBoxpersonelbul;
        private Button btn2temizle;
        private ListBox lbxPersoneller;
        private Button btnAnamenü;
        private Button btnVeritabanındansil;
    }
}
