﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AgencyContext))]
    partial class AgencyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Agency", b =>
                {
                    b.Property<int>("IdAgency")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAgency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("NumTelephone")
                        .HasColumnType("bigint");

                    b.HasKey("IdAgency");

                    b.ToTable("Agency");
                });

            modelBuilder.Entity("ApplicationCore.Client", b =>
                {
                    b.Property<int>("IdClient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaspNomer")
                        .HasColumnType("int");

                    b.Property<int>("PaspSerial")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Registration")
                        .HasColumnType("int");

                    b.HasKey("IdClient");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("ApplicationCore.HotelRoomRental", b =>
                {
                    b.Property<int>("IdRental")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Arrival")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<int>("CountPerson")
                        .HasColumnType("int");

                    b.HasKey("IdRental");

                    b.ToTable("HotelRoomRental");
                });

            modelBuilder.Entity("ApplicationCore.Manager", b =>
                {
                    b.Property<int>("IdManager")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AgencyIdAgency")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdManager");

                    b.HasIndex("AgencyIdAgency");

                    b.ToTable("Manager");
                });

            modelBuilder.Entity("ApplicationCore.Order", b =>
                {
                    b.Property<int>("IdOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientIdClient")
                        .HasColumnType("int");

                    b.Property<int?>("ManagerIdManager")
                        .HasColumnType("int");

                    b.Property<string>("ShopCartId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TourIdTour")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdOrder");

                    b.HasIndex("ClientIdClient");

                    b.HasIndex("ManagerIdManager");

                    b.HasIndex("TourIdTour");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ApplicationCore.Tour", b =>
                {
                    b.Property<int>("IdTour")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AgencyIdAgency")
                        .HasColumnType("int");

                    b.Property<int?>("HotelRoomRentalIdRental")
                        .HasColumnType("int");

                    b.Property<string>("NameTour")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PictureUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("isFavorite")
                        .HasColumnType("bit");

                    b.HasKey("IdTour");

                    b.HasIndex("AgencyIdAgency");

                    b.HasIndex("HotelRoomRentalIdRental");

                    b.ToTable("Tour");
                });

            modelBuilder.Entity("ApplicationCore.Manager", b =>
                {
                    b.HasOne("ApplicationCore.Agency", null)
                        .WithMany("Managers")
                        .HasForeignKey("AgencyIdAgency");
                });

            modelBuilder.Entity("ApplicationCore.Order", b =>
                {
                    b.HasOne("ApplicationCore.Client", null)
                        .WithMany("Orders")
                        .HasForeignKey("ClientIdClient");

                    b.HasOne("ApplicationCore.Manager", null)
                        .WithMany("Orders")
                        .HasForeignKey("ManagerIdManager");

                    b.HasOne("ApplicationCore.Tour", "Tour")
                        .WithMany("Orders")
                        .HasForeignKey("TourIdTour");
                });

            modelBuilder.Entity("ApplicationCore.Tour", b =>
                {
                    b.HasOne("ApplicationCore.Agency", "Agency")
                        .WithMany("Tours")
                        .HasForeignKey("AgencyIdAgency");

                    b.HasOne("ApplicationCore.HotelRoomRental", "HotelRoomRental")
                        .WithMany()
                        .HasForeignKey("HotelRoomRentalIdRental");
                });
#pragma warning restore 612, 618
        }
    }
}
