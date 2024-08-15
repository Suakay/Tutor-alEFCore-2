namespace _02_DatabaseFirstCoreWA
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
            btnEkle = new Button();
            txtCategoryId = new TextBox();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnListele = new Button();
            lstCategories = new ListBox();
            txtCategoryName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            txtDescription = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(13, 247);
            btnEkle.Margin = new Padding(4);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(166, 97);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(174, 58);
            txtCategoryId.Margin = new Padding(4);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(350, 29);
            txtCategoryId.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(204, 247);
            btnGuncelle.Margin = new Padding(4);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(166, 97);
            btnGuncelle.TabIndex = 3;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(385, 247);
            btnSil.Margin = new Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(166, 97);
            btnSil.TabIndex = 3;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(204, 352);
            btnListele.Margin = new Padding(4);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(166, 97);
            btnListele.TabIndex = 3;
            btnListele.Text = "LİSTELE";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // lstCategories
            // 
            lstCategories.FormattingEnabled = true;
            lstCategories.ItemHeight = 21;
            lstCategories.Location = new Point(583, 61);
            lstCategories.Margin = new Padding(4);
            lstCategories.Name = "lstCategories";
            lstCategories.Size = new Size(351, 424);
            lstCategories.TabIndex = 4;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(174, 112);
            txtCategoryName.Margin = new Padding(4);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(350, 29);
            txtCategoryName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 5;
            label1.Text = "CategoryId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 120);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 5;
            label2.Text = "CategoryName";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(174, 171);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 29);
            textBox3.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(174, 171);
            txtDescription.Margin = new Padding(4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 29);
            txtDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 5;
            label3.Text = "Description";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 514);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstCategories);
            Controls.Add(btnListele);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(txtDescription);
            Controls.Add(textBox3);
            Controls.Add(txtCategoryName);
            Controls.Add(txtCategoryId);
            Controls.Add(btnEkle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtCategoryId;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnListele;
        private ListBox lstCategories;
        private TextBox txtCategoryName;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private TextBox txtDescription;
        private Label label3;
    }
}
