using DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class CancelledOrderConfig : IEntityTypeConfiguration<CancelledOrder>
    {
        public void Configure(EntityTypeBuilder<CancelledOrder> builder)
        {
            // Khóa chính
            builder.HasKey(co => co.CancelledOrderID);

            // Các thuộc tính
            builder.Property(co => co.OrderID).IsRequired();
            builder.Property(co => co.Reason).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(co => co.CreatedAt).IsRequired();
            builder.Property(co => co.UpdatedAt).IsRequired();
            builder.Property(co => co.CreatedBy).HasColumnType("nvarchar(50)").IsRequired(false);
            builder.Property(co => co.UpdatedBy).HasColumnType("nvarchar(50)").IsRequired(false);

            // Quan hệ với bảng Order
            builder.HasOne(co => co.Order)
                   .WithMany(o => o.CancelledOrders)
                   .HasForeignKey(co => co.OrderID);
        }
    }
}
