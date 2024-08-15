using _13_UrunEklemeOtomasyonu.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_UrunEklemeOtomasyonu.Entities
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        ProjectContextDb context;
        private void Form2_Load(object sender, EventArgs e)
        {
            context= new ProjectContextDb();
            bTNuRUNeKLE.Enabled=context.Categories.ToList().Count>0?true:false;
            KategorileriDoldur();
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
        private void BtnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriadı.Text.Trim() == "")
            {
                MessageBox.Show("Lütfen kategori adı bilgisini boş bırakmayınız");
            }
            else
            {
                Category eklenecekKategori = new Category()
                {
                    Name = txtKategoriadı.Text,
                    Description = txtAçıklamaü.Text,
                    IsActive = true,
                    AddedDate = DateTime.Now

                };
                context.Categories.Add(eklenecekKategori);
                context.SaveChanges();
                KategorileriDoldur();
                bTNuRUNeKLE.Enabled = true;
                txtAçıklamaü.Text = txtKategoriadı.Text = "";//temizle
                MessageBox.Show("Kategori başarıyla eklenmiştir");
            }
            context = new ProjectContextDb();
            bTNuRUNeKLE.Enabled = context.Categories.ToList().Count > 0 ? true : false;
            KategorileriDoldur();
        }

        private void KategorileriDoldur()
        {
            lstKategoriler.Items.Clear();//Ekleme yada yükleme işleminde satırları tekrar tekrar eklemesin diye.
            List<Category> categories = context.Categories.Where(x => x.IsActive).ToList();

            foreach (Category item in categories)
            {
                
                ListViewItem lvi = new ListViewItem(item.Id.ToString());
                lvi.SubItems.Add(item.Description);

                lstKategoriler.Items.Add(lvi); //Oluşturulan satır LşstVIew eklenir.
            }

        }

        private void bTNuRUNeKLE_Click(object sender, EventArgs e)
        {
          Form3 form3=new Form3(this);
            form3.Show();
            this.Hide();
        }

        private void txtKategoriadı_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
