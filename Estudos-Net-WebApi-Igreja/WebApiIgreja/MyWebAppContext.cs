using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiIgreja.AcessoDados.Entidades;

namespace WebApiIgreja
{
    public class MyWebAppContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }

        public MyWebAppContext(DbContextOptions<MyWebAppContext>options):base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Filme>().HasKey(p => p.Id);
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            return base.SaveChanges();
        }
    }
}
