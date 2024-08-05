using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppData.Config
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.OrderDetailID);

            builder.Property(x => x.ProductName)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.UnitPrice)
                   .HasColumnType("decimal(18, 2)");

            builder.Property(x => x.DiscountValue)
                   .HasColumnType("decimal(18, 2)");

            builder.HasOne(x => x.Order)
                   .WithMany(o => o.OrderDetails)
                   .HasForeignKey(x => x.OrderID);

<<<<<<< HEAD
            builder.HasOne(x => x.ProductDetail)
                   .WithMany(p => p.OrderDetails)
                   .HasForeignKey(x => x.IMEI);
        }
=======
        builder.HasOne(x => x.ProductDetail)
               .WithMany(p => p.OrderDetails)
               .HasForeignKey(x => x.ProductDetailID)
               .OnDelete(DeleteBehavior.NoAction);  // Thêm dòng này để không cho phép cascade delete/update
>>>>>>> An-DBNew
    }
}
