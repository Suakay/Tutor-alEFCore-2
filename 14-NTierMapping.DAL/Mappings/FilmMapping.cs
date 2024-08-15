using _14_NTierMapping.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_NTierMapping.DAL.Mappings
{
    public class FilmMapping : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            //Konfigurasyon çalışmalarını context sınıfı yerine burda yaparım.
            builder.Property(x => x.FilmAdi).IsRequired();
            builder.ToTable("Filmler");

            builder.HasOne(x => x.FilmKategorisi)
                .WithMany(fk => fk.KategorininFilmleri)
                .HasForeignKey(x => x.KategoriID);

        }
    }
}
