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
    public class DisplayConfig : IEntityTypeConfiguration<Display>
    {
        public void Configure(EntityTypeBuilder<Display> builder)
        {
            builder.HasKey(x => x.DisplayID);

            builder.Property(x => x.DisplayName)
                   .HasMaxLength(20);
        }
    }
}
