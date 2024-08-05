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
        }
    }
}
