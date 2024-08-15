using _02_DatabaseFirstCoreWA.Models;
using Microsoft.Extensions.Options;
using System.Linq;

namespace _02_DatabaseFirstCoreWA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void btnListele_Click(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();

            List<Category> kategoriler = db.Categories.ToList();
            foreach (Category c in kategoriler)
            {
                lstCategories.Items.Add(c.CategoryName + "||" + c.Description);
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {


            using (NorthwindContext db = new NorthwindContext())
            {
                Category c = new Category();

                c.CategoryName = txtCategoryName.Text;
                c.Description = txtDescription.Text;

                db.Categories.Add(c);
                db.SaveChanges();
                MessageBox.Show("Ekleme Gerçekleþti..");

                Select();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                Category removeCategory = db.Categories.First(c => c.CategoryName == txtCategoryName.Text);
                if (removeCategory != null)
                {
                    db.Categories.Remove(removeCategory);
                    db.SaveChanges();
                    Select();
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadý.");
                }
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                Category category = db.Categories.First(c => c.CategoryName == txtCategoryName.Text);
                if (category != null)
                {
                    category.CategoryName = txtCategoryName.Text;
                    category.Description = txtDescription.Text;

                    db.SaveChanges();
                    MessageBox.Show("Liste Güncellendi..");
                    Select();
                }
                else
                {
                    MessageBox.Show("Kategori bulunamadý.");
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            //db.Categories.ToList().ForEach(c => ListBox1);
        }
    }
}

