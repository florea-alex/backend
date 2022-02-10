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
    public class CarteMagazinConfiguration : IEntityTypeConfiguration<CarteMagazin>
    {
        public void Configure(EntityTypeBuilder<CarteMagazin> builder)
        {
            builder.HasOne(x => x.Carte)
                .WithMany(x => x.CarteMagazine)
                .HasForeignKey(x => x.MagazinId);

            builder.HasOne(x => x.Magazin)
                .WithMany(x => x.CarteMagazine)
                .HasForeignKey(x => x.CarteId);
        }
    }
}
