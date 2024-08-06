using DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Config
{
    public class ImeiConfig : IEntityTypeConfiguration<IMEI>
    {
        public void Configure(EntityTypeBuilder<IMEI> builder)
        {
            builder.HasKey(x => x.ImeiID);

            builder.Property(x => x.ImeiID)
                   .HasMaxLength(15)
                   .IsRequired();

            builder.Property(x => x.Status)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.CreatedAt)
                   .IsRequired();

            builder.Property(x => x.UpdatedAt)
                   .IsRequired();

            builder.Property(x => x.CreatedBy)
                   .HasMaxLength(255);

            builder.Property(x => x.UpdatedBy)
                   .HasMaxLength(255);

            builder.HasOne(x => x.ProductDetail)
                   .WithMany(p => p.Imeis)
                   .HasForeignKey(x => x.ProductDetailID)
                   .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(x => x.OrderDetail)
                   .WithMany(od => od.Imeis)
                   .HasForeignKey(x => x.OrderDetailID)
                   .OnDelete(DeleteBehavior.NoAction);
        }
    }
    
}
