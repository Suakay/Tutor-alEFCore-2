namespace WinFormsApp1
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textTC = new TextBox();
            txtSoyadı = new TextBox();
            textAdı = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textTC);
            groupBox1.Controls.Add(txtSoyadı);
            groupBox1.Controls.Add(textAdı);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(687, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel Kayıt Ekranı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 339);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 340);
            label6.Name = "label6";
            label6.Size = new Size(56, 25);
            label6.TabIndex = 11;
            label6.Text = "Birimi";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(261, 267);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(81, 29);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kadın";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(123, 267);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(79, 29);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Erkek";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 8;
            // 
            // textTC
            // 
            textTC.Location = new Point(168, 156);
            textTC.Name = "textTC";
            textTC.Size = new Size(150, 31);
            textTC.TabIndex = 7;
            textTC.TextChanged += textTC_TextChanged;
            // 
            // txtSoyadı
            // 
            txtSoyadı.Location = new Point(112, 97);
            txtSoyadı.Name = "txtSoyadı";
            txtSoyadı.Size = new Size(150, 31);
            txtSoyadı.TabIndex = 6;
            txtSoyadı.TextChanged += txtSoyadı_TextChanged;
            // 
            // textAdı
            // 
            textAdı.Location = new Point(101, 47);
            textAdı.Name = "textAdı";
            textAdı.Size = new Size(150, 31);
            textAdı.TabIndex = 5;
            textAdı.TextChanged += textAdı_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 259);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 206);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 155);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 99);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 44);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // button1
            // 
            button1.Location = new Point(86, 457);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Temizle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(347, 457);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 2;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(157, 516);
            button3.Name = "button3";
            button3.Size = new Size(262, 34);
            button3.TabIndex = 3;
            button3.Text = "İletişim Bilgilerni Gör";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 589);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textAdı;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DateTimePicker dateTimePicker1;
        private TextBox textTC;
        private TextBox txtSoyadı;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
