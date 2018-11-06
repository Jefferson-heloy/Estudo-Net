﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Supremo.Util.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supremo.Models
{
    public class MyWebAppContext:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> Itens { get; set; }

        public MyWebAppContext(DbContextOptions<MyWebAppContext> options):base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasKey(p => p.Id);
            modelBuilder.Entity<Pedido>().HasKey(p => p.Id);
            modelBuilder.Entity<ItemPedido>().HasKey(p => p.Id);
        base.OnModelCreating(modelBuilder);
    }

    public override int SaveChanges() {
        ChangeTracker.DetectChanges();
        return base.SaveChanges();
        }
    }
}
