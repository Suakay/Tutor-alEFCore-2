using _15_DATA;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listViewpesoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewpesoneller.Items.Clear();
            string[] personeler1 = { "8900*", "Ahmet", "Yýlmaz" };
            string[] personeler2 = { "8900*", "mehmet", "Yýlmaz" };
            string[] personeler3 = { "8900*", "ayþe", "Yýlmaz" };
            string[] personeler4 = { "8900*", "zehra", "Yýlmaz" };



            listViewpesoneller.Items.Add(new ListViewItem(personeler1));
            listViewpesoneller.Items.Add(new ListViewItem(personeler2));
            listViewpesoneller.Items.Add(new ListViewItem(personeler3));
            listViewpesoneller.Items.Add(new ListViewItem(personeler4));
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listViewpesoneller.Items.Clear();
        }

        private void btnAnamenü_Click(object sender, EventArgs e)
        {
            Form1 anamenü = new Form1();
            anamenü.ShowDialog();
            this.Hide();
        }

        private void lbxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Personel> personeller = new List<Personel>()
            {
                new Personel{TCKNO="7898900", AdiSoyadi="AHMET YILMAZ"},
                 new Personel{TCKNO="34555", AdiSoyadi="AYÞE YILMAZ"},
                  new Personel{TCKNO="23345", AdiSoyadi="ZEYNEP YILMAZ"},

            };

            lbxPersoneller.Items.Clear();
            foreach (Personel personel in personeller)
            {
                lbxPersoneller.Items.Add(personel.TCKNO + " " + personel.AdiSoyadi + " ");
            }
            if (lbxPersoneller.SelectedIndex != -1)
            {
                // Seçilen personel bilgilerini al
                Personel seciliPersonel = (Personel)lbxPersoneller.SelectedItem;

                // Ýsim ve soyadý göster
                MessageBox.Show("AdSoyad: " + seciliPersonel.AdiSoyadi + "");
            }
        }

        private void btn2temizle_Click(object sender, EventArgs e)
        {
            lbxPersoneller.Items.Clear();
        }

        private void btnVeritabanýndansil_Click(object sender, EventArgs e)
        {
            if (lbxPersoneller.Items.Count > 0)
            {
                // Son öðenin indeksini bulun
                int sonOgeIndeksi = lbxPersoneller.Items.Count - 1;

                // Son öðeyi silin
                lbxPersoneller.Items.RemoveAt(sonOgeIndeksi);
            }
            else
            {
                MessageBox.Show("Silinecek öðe bulunamadý.");
            }

        }
    }
}
