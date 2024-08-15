using _15_DATA;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void text�leti�imBilgilerninTamamala_TextChanged(object sender, EventArgs e)
        {
            string PersonelAdiSoyadi = text�leti�imBilgilerninTamamala.Text.Trim();
        }

        private void btnGiri�_Click(object sender, EventArgs e)
        {
            string telefon = txtTelefonnumars�.Text.Trim();
            string email = txtposta.Text.Trim();
            if (!string.IsNullOrEmpty(telefon))
            {
                Personel personel = new Personel();

                personel.Telefon = telefon;
                personel.Email = email;

                MessageBox.Show("Personel bilgileri g�ncellendi");
                txtEvAdresi.Text = "";
                txtposta.Text = "";
            }
            else
            {
                MessageBox.Show("L�tfen personel bilgilerini bo� ge�meyiniz");
            }
        }

        private void txtposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string telefon = txtTelefonnumars�.Text.Trim();
            string email = txtposta.Text.Trim();
            Personel personel = new Personel
            {
                Telefon = telefon,
                Email = email,
            };

            MessageBox.Show("Personel bilgileri kaydedildi");

            txtTelefonnumars�.Text = "";
            txtposta.Text = "";
        }

        private void btnT�mKay�tlar_Click(object sender, EventArgs e)
        {
            List<Personel> personelListesi = new List<Personel>();

           foreach(Personel personel in personelListesi)
            {
                
            }
        }
    }
}
 