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
    public class ReportConfig : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            // Khóa chính
            builder.HasKey(r => r.ReportID);

            // Các thuộc tính
            builder.Property(r => r.ReportDate).IsRequired();
            builder.Property(r => r.TotalSold).IsRequired();
            builder.Property(r => r.TotalAmount).HasColumnType("decimal(18,2)").IsRequired();
            builder.Property(r => r.SuccessfulOrders).IsRequired();
            builder.Property(r => r.CancelledOrders).IsRequired();
            builder.Property(r => r.PendingOrders).IsRequired();
            builder.Property(r => r.CreatedAt).IsRequired();
            builder.Property(r => r.UpdatedAt).IsRequired();
            builder.Property(r => r.CreatedBy).HasColumnType("nvarchar(50)").IsRequired(false);
            builder.Property(r => r.UpdatedBy).HasColumnType("nvarchar(50)").IsRequired(false);

            // Quan hệ với bảng Order
            builder.HasMany(r => r.Orders)
                   .WithOne(o => o.Report)
                   .HasForeignKey(o => o.ReportID);
        }
    }
}
