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
    public class CarteAutorConfiguration : IEntityTypeConfiguration<CarteAutor>
    {

        public void Configure(EntityTypeBuilder<CarteAutor> builder)
        {
            builder.HasOne(x => x.Carte)
                .WithMany(x => x.CarteAutori)
                .HasForeignKey(x => x.AutorId);

            builder.HasOne(x => x.Autor)
                .WithMany(x => x.CarteAutori)
                .HasForeignKey(x => x.CarteID);
        }
    }
}
