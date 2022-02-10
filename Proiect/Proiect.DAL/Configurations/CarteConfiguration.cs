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
    public class CarteConfiguration : IEntityTypeConfiguration<Carte>
    {
        public void Configure(EntityTypeBuilder<Carte> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.ISBN)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Nume)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
