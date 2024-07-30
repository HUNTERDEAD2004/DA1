using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Config
{
    public class OperatingSystemConfig : IEntityTypeConfiguration<OperatingSystems>
    {
        public void Configure(EntityTypeBuilder<OperatingSystems> builder)
        {
            builder.HasKey(x => x.OSID);       
        }
    }
}
