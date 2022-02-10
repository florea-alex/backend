using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Configurations
{
    public class DescriereConfiguration : IEntityTypeConfiguration<Descriere>
    {
        public void Configure(EntityTypeBuilder<Descriere> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Pret)
                .HasColumnType("decimal(5, 2)")
                .IsRequired();

            builder.Property(x => x.Nota)
                .HasColumnType("decimal(2, 1)");

            builder.Property(x => x.Recomandare)
                .HasColumnType("int");

            builder.Property(x => x.An_aparitie)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Volum)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Gen_principal)
                .HasColumnType("nvarchar(100)")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}