using _11_DataAnnotionFluentAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnnotionFluentAPI.Context
{
     public class AppDbContext:DbContext
    {
        public DbSet<Book>Books { get; set; }   
        public DbSet<Author> Authors { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-785CG1C;Initial Catalog=EF-11DataAnnotıon;Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Column
            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasColumnName("Description")
                .HasColumnType("nvarchar(50)")
                .HasColumnOrder(2);

            //DatabaseGenerated

            modelBuilder.Entity<Contact>()
                .Property(p => p.LastName)
                .ValueGeneratedOnAdd();

            //Key
            modelBuilder.Entity<Order>()
                .HasKey(a => a.OrderNumber);

            modelBuilder.Entity<Book>()
                .HasOne(e => e.Author)
                .WithMany()
                .HasForeignKey(e => e.AuthorFK);
            
           base.OnModelCreating(modelBuilder);

            


           
        }
    }
}
