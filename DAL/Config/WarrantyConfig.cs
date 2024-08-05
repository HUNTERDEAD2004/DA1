using AppData.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder.HasOne(x => x.ProductDetail)
               .WithMany(pd => pd.Warranties)
               .HasForeignKey(x => x.IMEI)
               .OnDelete(DeleteBehavior.NoAction);
        }
    }

}
