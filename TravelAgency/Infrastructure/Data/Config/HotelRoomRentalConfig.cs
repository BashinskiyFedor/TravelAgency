using ApplicationCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Config
{
    public class HotelRoomRentalConfig : IEntityTypeConfiguration<HotelRoomRental>
    {
        public void Configure(EntityTypeBuilder<HotelRoomRental> builder)
        {
            builder.HasKey(ci => ci.IdRental);

            builder.Property(ci => ci.IdRental)
               .IsRequired();
        }
    }
}
