using _15_DATA;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textÝletiþimBilgilerninTamamala_TextChanged(object sender, EventArgs e)
        {
            string PersonelAdiSoyadi = textÝletiþimBilgilerninTamamala.Text.Trim();
        }

        private void btnGiriþ_Click(object sender, EventArgs e)
        {
            string telefon = txtTelefonnumarsý.Text.Trim();
            string email = txtposta.Text.Trim();
            if (!string.IsNullOrEmpty(telefon))
            {
                Personel personel = new Personel();

                personel.Telefon = telefon;
                personel.Email = email;

                MessageBox.Show("Personel bilgileri güncellendi");
                txtEvAdresi.Text = "";
                txtposta.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen personel bilgilerini boþ geçmeyiniz");
            }
        }

        private void txtposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string telefon = txtTelefonnumarsý.Text.Trim();
            string email = txtposta.Text.Trim();
            Personel personel = new Personel
            {
                Telefon = telefon,
                Email = email,
            };

            MessageBox.Show("Personel bilgileri kaydedildi");

            txtTelefonnumarsý.Text = "";
            txtposta.Text = "";
        }

        private void btnTümKayýtlar_Click(object sender, EventArgs e)
        {
            List<Personel> personelListesi = new List<Personel>();

           foreach(Personel personel in personelListesi)
            {
                
            }
        }
    }
}
 