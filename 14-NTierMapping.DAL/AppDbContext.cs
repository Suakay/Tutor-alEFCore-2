using _14_NTierMapping.DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DAL
{
     public class AppDbContext:DbContext
    {
       public DbSet<Film> Filmler { get; set; } 
       public DbSet<Oyuncu> Oyuncular { get; set;}
        public DbSet<FilmKategori> FilmKategori { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .Property(f => f.FilmAdi).IsRequired();

            modelBuilder.Entity<Film>()
                .ToTable("Filmler");

            modelBuilder.Entity<Film>()
                .HasOne(f => f.FilmKategorisi)
                .WithMany(fk => fk.KategorininFilmleri)
                .HasForeignKey(fk => fk.KategoriID);
        }

    }
}
