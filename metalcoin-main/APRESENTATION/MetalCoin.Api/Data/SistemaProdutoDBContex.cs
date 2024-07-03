using MetalCoin.Api.Data.Map;
using MetalCoin.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace MetalCoin.Api.Data
{
    public class SistemaProdutoDBContex : DbContext
    {
        public SistemaProdutoDBContex(DbContextOptions<SistemaProdutoDBContex> opcoes) : base(opcoes)
        {
           
        }
        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
