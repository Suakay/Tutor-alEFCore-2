using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textAdý_TextChanged(object sender, EventArgs e)
        {
            string personelAdý = textAdý.Text.ToLower();
        }

        private void txtSoyadý_TextChanged(object sender, EventArgs e)
        {
            string personelSoyadý = txtSoyadý.Text.ToLower();
        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {
            if (textTC.MaxLength != 11)
            {
                MessageBox.Show("TC Kimlik numarasý 11 haneli olmalýdýr.");
            }

            else
            {
                MessageBox.Show("TC Giriþiniz doðru");
            }
            int toplam1 = 0, toplam2 = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    toplam1 += Convert.ToInt32(textTC.Text[i].ToString());
                }
                else
                {
                    toplam2 += Convert.ToInt32(textTC.Text[i].ToString());
                }
            }
            int toplam3 = toplam1 * 7 - toplam2;
            int kontrolRakami = toplam3 % 10;
            if (kontrolRakami != Convert.ToInt32(textTC.Text[10].ToString())) // TextBox'tan metin alýnarak karþýlaþtýrma yapýn
            {
                MessageBox.Show("TC Kimlik Numarasý geçersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Fonksiyondan çýkýn
            }

            // 4. Adým:  Kontrol rakamý doðrulandýysa, TC geçerlidir.
            MessageBox.Show("TC Kimlik Numarasý geçerli.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSoyadý.Text = "";
            textAdý.Text = "";
            textTC.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tcNo = textTC.Text;
            string personelAdi = textAdý.Text;
            string peraonelSoyadi = txtSoyadý.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet";
            string soyad = "Yýlmaz";
            string TCNO = "98900";

            // Verileri TextBox'lara doldurun
            textAdý.Text = ad;
            txtSoyadý.Text = soyad;
            textTC.Text = TCNO;

        }
    }
}
