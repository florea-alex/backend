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
    public class MagazinConfiguration : IEntityTypeConfiguration<Magazin>
    {
        public void Configure(EntityTypeBuilder<Magazin> builder)
        {
            builder.Property(x => x.Adresa)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Cod_postal)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
