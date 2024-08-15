using _13_UrunEklemeOtomasyonu.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_UrunEklemeOtomasyonu.Context
{
    public class ProjectContextDb:DbContext
    {
        public DbSet<AppUser> Users { get; set; }   
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-785CG1C;Initial Catalog=EF-13-UrunEklemeOtomasyonu;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
