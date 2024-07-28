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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.ProductID);

            builder.Property(x => x.ProductName)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.Description)
                   .HasMaxLength(int.MaxValue);
        }
    }
}
