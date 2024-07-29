using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppData.Config
{
    public class ProductDetailConfig : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.HasKey(x => x.IMEI);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.Price)
                   .HasColumnType("decimal(10, 2)");

            builder.HasOne(x => x.Product)
                   .WithMany(p => p.ProductDetails)
                   .HasForeignKey(x => x.ProductID);

            builder.HasOne(x => x.Color)
                   .WithMany(c => c.ProductDetails)
                   .HasForeignKey(x => x.ColorID);

            builder.HasOne(x => x.RAM)
                   .WithMany(r => r.ProductDetails)
                   .HasForeignKey(x => x.RAMID);

            builder.HasOne(x => x.CPU)
                   .WithMany(c => c.ProductDetails)
                   .HasForeignKey(x => x.CPUID);

            builder.HasOne(x => x.GPU)
                   .WithMany(g => g.ProductDetails)
                   .HasForeignKey(x => x.GPUID);

            builder.HasOne(x => x.ROM)
                   .WithMany(r => r.ProductDetails)
                   .HasForeignKey(x => x.ROMID);

            builder.HasOne(x => x.Display)
                   .WithMany(d => d.ProductDetails)
                   .HasForeignKey(x => x.DisplayID);

            builder.HasOne(x => x.Sale)
                   .WithMany(s => s.ProductDetail)
                   .HasForeignKey(x => x.SaleID);
        }
    }
}
