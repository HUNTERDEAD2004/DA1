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
    public class YearOfManufactureConfig : IEntityTypeConfiguration<YearOfManufacture>
    {
        public void Configure(EntityTypeBuilder<YearOfManufacture> builder)
        {
            builder.HasKey(x => x.YearID);

            builder.Property(x => x.Year)
                   .IsRequired();

            builder.Property(x => x.CreatedAt)
                   .IsRequired();

            builder.Property(x => x.UpdatedAt)
                   .IsRequired();

            builder.Property(x => x.CreatedBy)
                   .HasMaxLength(50);

            builder.Property(x => x.UpdatedBy)
                   .HasMaxLength(50);
        }
    }
}
