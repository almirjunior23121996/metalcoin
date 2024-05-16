using Metalcoin.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalCoin.Infra.Data.Mappings
{
    internal class CuponMapping : IEntityTypeConfiguration<Cupon>
    {
        public void Configure(EntityTypeBuilder<Cupon> builder)
        {
            builder.ToTable("Cupons");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Code)
               .HasColumnType("varchar(100)")
               .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.ValorDesconto)
               
               .IsRequired();


            builder.Property(p => p.Desconto)
               .HasColumnType("datetime")
               .IsRequired();

            builder.Property(p => p.Validade)
                .HasColumnType("datetime")
                .IsRequired();

           

            builder.Property(p => p.Status)
                .HasColumnType("bit")
                .IsRequired();
            {
    }
}
