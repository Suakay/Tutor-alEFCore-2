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
            string[] personeler1 = { "8900*", "Ahmet", "Y�lmaz" };
            string[] personeler2 = { "8900*", "mehmet", "Y�lmaz" };
            string[] personeler3 = { "8900*", "ay�e", "Y�lmaz" };
            string[] personeler4 = { "8900*", "zehra", "Y�lmaz" };



            listViewpesoneller.Items.Add(new ListViewItem(personeler1));
            listViewpesoneller.Items.Add(new ListViewItem(personeler2));
            listViewpesoneller.Items.Add(new ListViewItem(personeler3));
            listViewpesoneller.Items.Add(new ListViewItem(personeler4));
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listViewpesoneller.Items.Clear();
        }

        private void btnAnamen�_Click(object sender, EventArgs e)
        {
            Form1 anamen� = new Form1();
            anamen�.ShowDialog();
            this.Hide();
        }

        private void lbxPersoneller_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Personel> personeller = new List<Personel>()
            {
                new Personel{TCKNO="7898900", AdiSoyadi="AHMET YILMAZ"},
                 new Personel{TCKNO="34555", AdiSoyadi="AY�E YILMAZ"},
                  new Personel{TCKNO="23345", AdiSoyadi="ZEYNEP YILMAZ"},

            };

            lbxPersoneller.Items.Clear();
            foreach (Personel personel in personeller)
            {
                lbxPersoneller.Items.Add(personel.TCKNO + " " + personel.AdiSoyadi + " ");
            }
            if (lbxPersoneller.SelectedIndex != -1)
            {
                // Se�ilen personel bilgilerini al
                Personel seciliPersonel = (Personel)lbxPersoneller.SelectedItem;

                // �sim ve soyad� g�ster
                MessageBox.Show("AdSoyad: " + seciliPersonel.AdiSoyadi + "");
            }
        }

        private void btn2temizle_Click(object sender, EventArgs e)
        {
            lbxPersoneller.Items.Clear();
        }

        private void btnVeritaban�ndansil_Click(object sender, EventArgs e)
        {
            if (lbxPersoneller.Items.Count > 0)
            {
                // Son ��enin indeksini bulun
                int sonOgeIndeksi = lbxPersoneller.Items.Count - 1;

                // Son ��eyi silin
                lbxPersoneller.Items.RemoveAt(sonOgeIndeksi);
            }
            else
            {
                MessageBox.Show("Silinecek ��e bulunamad�.");
            }

        }
    }
}
