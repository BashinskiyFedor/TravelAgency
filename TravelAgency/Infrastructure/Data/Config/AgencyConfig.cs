using ApplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class AgencyConfig : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.HasKey(a => a.IdAgency);
            builder.Property(a => a.IdAgency)
                .IsRequired();

            builder.Property(a => a.Img)
                .IsRequired();
        }
    }
}
