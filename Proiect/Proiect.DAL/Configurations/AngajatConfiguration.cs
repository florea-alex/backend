﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proiect.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Configurations
{
    public class AngajatConfiguration : IEntityTypeConfiguration<Angajat>
    {
        public void Configure(EntityTypeBuilder<Angajat> builder)
        {
            builder.Property(x => x.Nume)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Prenume)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.Job)
                .HasColumnType("nvarchar(200)")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
