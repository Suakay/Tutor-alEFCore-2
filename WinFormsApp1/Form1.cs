using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textAd�_TextChanged(object sender, EventArgs e)
        {
            string personelAd� = textAd�.Text.ToLower();
        }

        private void txtSoyad�_TextChanged(object sender, EventArgs e)
        {
            string personelSoyad� = txtSoyad�.Text.ToLower();
        }

        private void textTC_TextChanged(object sender, EventArgs e)
        {
            if (textTC.MaxLength != 11)
            {
                MessageBox.Show("TC Kimlik numaras� 11 haneli olmal�d�r.");
            }

            else
            {
                MessageBox.Show("TC Giri�iniz do�ru");
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
            if (kontrolRakami != Convert.ToInt32(textTC.Text[10].ToString())) // TextBox'tan metin al�narak kar��la�t�rma yap�n
            {
                MessageBox.Show("TC Kimlik Numaras� ge�ersiz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Fonksiyondan ��k�n
            }

            // 4. Ad�m:  Kontrol rakam� do�ruland�ysa, TC ge�erlidir.
            MessageBox.Show("TC Kimlik Numaras� ge�erli.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSoyad�.Text = "";
            textAd�.Text = "";
            textTC.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tcNo = textTC.Text;
            string personelAdi = textAd�.Text;
            string peraonelSoyadi = txtSoyad�.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = "Ahmet";
            string soyad = "Y�lmaz";
            string TCNO = "98900";

            // Verileri TextBox'lara doldurun
            textAd�.Text = ad;
            txtSoyad�.Text = soyad;
            textTC.Text = TCNO;

        }
    }
}
