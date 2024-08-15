using _13_UrunEklemeOtomasyonu.Context;
using _13_UrunEklemeOtomasyonu.Entities;

namespace _13_UrunEklemeOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void btnGonder_Click(object sender, EventArgs e)
        {
            ProjectContextDb context;
            using (context = new ProjectContextDb())
            {
                var user = context.Users.SingleOrDefault(x => x.UserName == txtKullanýcýadý.Text && x.Password == txtSifre.Text);
                if (user != null)
                {
                    Entities.Form2 form1 = new Entities.Form2();
                    form1.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalý kullanýcý adý ya da þifre");
                }

            }

        }
    }
}
