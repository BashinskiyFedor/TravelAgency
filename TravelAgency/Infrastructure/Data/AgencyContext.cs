using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ApplicationCore;
using Infrastructure.Data.Config;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AgencyContext : DbContext
    {
        public AgencyContext(DbContextOptions<AgencyContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // TODO:: строки конфигурации переделать по нормальному 
            modelBuilder.ApplyConfiguration(new AgencyConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new HotelRoomRentalConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new TourConfig());
            modelBuilder.ApplyConfiguration(new ManagerConfig());


        }

        public DbSet<Agency> Agency { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<HotelRoomRental> HotelRoomRental { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Tour> Tour { get; set; }


    }
}
