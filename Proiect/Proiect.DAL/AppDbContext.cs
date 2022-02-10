using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Proiect.DAL.Configurations;
using Proiect.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL
{
    public class AppDbContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // adaugam logger in consola
        //    optionsBuilder.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()));
        //}

        // tranmitem ca exista tabela student
        public DbSet<Descriere> Descriere { get; set; }
        public DbSet<Carte> Carti { get; set; }
        public DbSet<Editura> Edituri { get; set; }
        public DbSet<Autor> Autori { get; set; }
        public DbSet<CarteAutor> CarteAutori { get; set; }
        public DbSet<Magazin> Magazine { get; set; }
        public DbSet<CarteMagazin> CarteMagazine { get; set; }
        public DbSet<Biografie> Biografii { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
        public DbSet<Factura> Facturi { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        // override la met numita OnModelCreating, primeste param de tip ModelBuilder numit modelBuilder

        // aici specificam anumite config pt tabelele pe care le cream din codul nostru 
        {
            // apelam met din clasa parinte 
            base.OnModelCreating(modelBuilder);

            // apelam configurarea; ce configurare aplicam => StudConfig 
            modelBuilder.ApplyConfiguration(new DescriereConfiguration());  // constructor fara param
            modelBuilder.ApplyConfiguration(new CarteConfiguration());
            modelBuilder.ApplyConfiguration(new EdituraConfiguration());
            modelBuilder.ApplyConfiguration(new AutorConfiguration());
            modelBuilder.ApplyConfiguration(new CarteAutorConfiguration());
            modelBuilder.ApplyConfiguration(new MagazinConfiguration());
            modelBuilder.ApplyConfiguration(new CarteMagazinConfiguration());
            modelBuilder.ApplyConfiguration(new AngajatConfiguration());
            modelBuilder.ApplyConfiguration(new FacturaConfiguration());
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new BiografieConfiguration());


            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });

                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRoles).HasForeignKey(ur => ur.UserId);
            });
        }
    }

}