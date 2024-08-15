using _13_UrunEklemeOtomasyonu.Context;
using Microsoft.EntityFrameworkCore.Storage;
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
    public partial class Form3 : Form
    {
        ProjectContextDb context = new ProjectContextDb();
        private Form2 form2;
        public Form3(Form2 frm2)
        {
            form2 = frm2;
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            context = new ProjectContextDb();
            KategoriDoldur();
            ÜrünleriDoldur();

        }

        private void ÜrünleriDoldur()
        {


            List<Product> products = context.Products.Where(p => p.IsActive).ToList();


            foreach (Product item in products)
            {
                ListViewItem lvi = new ListViewItem(item.Id.ToString());
                lvi.SubItems.Add(item.Name);
                lvi.SubItems.Add(item.Stock.ToString());
                lvi.SubItems.Add(item.UnitPrice.ToString());
                lvi.SubItems.Add(item.Category.Name);



            }
        }

        private void KategoriDoldur()
        {
            
            List<Category> categories = context.Categories.Where(kat => kat.IsActive).ToList();
            /* foreach (Category category in categories)
             {
                 cmbKategoriler.Items.Add(category.Name);
             }*/


            cmbKategoriler.DataSource = categories;
            cmbKategoriler.DisplayMember = "CategoryName";
            cmbKategoriler.ValueMember = "ID";
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void cmbKategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            KategoriDoldur();
        }
    }
}
