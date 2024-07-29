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
    public class RamConfig : IEntityTypeConfiguration<Ram>
    {
        public void Configure(EntityTypeBuilder<Ram> builder)
        {
            builder.HasKey(x => x.RAMID);

            builder.Property(x => x.RAMSize)
                   .HasMaxLength(20);

            builder.Property(x => x.RAMType)
                   .HasMaxLength(20);
        }
    }
}
