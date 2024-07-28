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
    public class AccountConfig : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.AccountID);

            builder.HasIndex(x => x.Username)
                   .IsUnique();

            builder.Property(x => x.Username)
                   .IsRequired()
                   .HasMaxLength(255);

            builder.Property(x => x.Password)
                   .IsRequired();

            builder.Property(x => x.Status)
                   .HasMaxLength(50);

            builder.Property(x => x.Roles)
                   .HasMaxLength(255);
        }
    }
}
