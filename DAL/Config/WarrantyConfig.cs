using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Config
{
    public class WarrantyConfig : IEntityTypeConfiguration<Warranty>
    {
        public void Configure(EntityTypeBuilder<Warranty> builder)
        {
            builder.HasKey(x => x.WarrantyID);

            builder.Property(x => x.WarrantyStartDate)
                   .IsRequired();

            builder.Property(x => x.WarrantyEndDate)
                   .IsRequired();
<<<<<<< HEAD
=======

            builder.HasOne(x => x.ProductDetail)
               .WithMany(pd => pd.Warranties)
               .HasForeignKey(x => x.ProductDetailID)
               .OnDelete(DeleteBehavior.NoAction);
>>>>>>> An-DBNew
        }
    }
}
