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
                   .HasForeignKey(x => x.ProductID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.Color)
                   .WithMany(c => c.ProductDetails)
                   .HasForeignKey(x => x.ColorID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.RAM)
                   .WithMany(r => r.ProductDetails)
                   .HasForeignKey(x => x.RAMID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.CPU)
                   .WithMany(c => c.ProductDetails)
                   .HasForeignKey(x => x.CPUID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.GPU)
                   .WithMany(g => g.ProductDetails)
                   .HasForeignKey(x => x.GPUID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.ROM)
                   .WithMany(r => r.ProductDetails)
                   .HasForeignKey(x => x.ROMID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.Display)
                   .WithMany(d => d.ProductDetails)
                   .HasForeignKey(x => x.DisplayID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.Sale)
                   .WithMany(s => s.ProductDetail)
                   .HasForeignKey(x => x.SaleID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.Voucher)
                   .WithMany(s => s.ProductDetails)
                   .HasForeignKey(x => x.IDVoucher)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.BatteryCapacity)
                   .WithMany(s => s.ProductDetails)
                   .HasForeignKey(x => x.BatteryID)
                   .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.OperatingSystem)
                  .WithMany(s => s.ProductDetails)
                  .HasForeignKey(x => x.OSID)
                  .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa

            builder.HasOne(x => x.YearOfManufacture)
                  .WithMany(s => s.ProductDetails)
                  .HasForeignKey(x => x.YearID)
                  .OnDelete(DeleteBehavior.NoAction); // Thay đổi hành vi xóa     

            builder.HasOne(x => x.Warranty) // Cấu hình quan hệ với Warranty
                   .WithMany(w => w.ProductDetails)
                   .HasForeignKey(x => x.WarrantyID);
        }
    }

}
