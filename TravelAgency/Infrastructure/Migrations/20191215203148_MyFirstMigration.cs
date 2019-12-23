using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agency",
                columns: table => new
                {
                    IdAgency = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAgency = table.Column<string>(nullable: true),
                    NumTelephone = table.Column<long>(nullable: false),
                    Img = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agency", x => x.IdAgency);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    IdClient = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    PaspSerial = table.Column<int>(nullable: false),
                    PaspNomer = table.Column<int>(nullable: false),
                    Registration = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "HotelRoomRental",
                columns: table => new
                {
                    IdRental = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    Arrival = table.Column<DateTime>(nullable: false),
                    CheckOut = table.Column<DateTime>(nullable: false),
                    CountPerson = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelRoomRental", x => x.IdRental);
                });

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    IdManager = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    AgencyIdAgency = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.IdManager);
                    table.ForeignKey(
                        name: "FK_Manager_Agency_AgencyIdAgency",
                        column: x => x.AgencyIdAgency,
                        principalTable: "Agency",
                        principalColumn: "IdAgency",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tour",
                columns: table => new
                {
                    IdTour = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(nullable: false),
                    PictureUri = table.Column<string>(nullable: true),
                    isFavorite = table.Column<bool>(nullable: false),
                    AgencyIdAgency = table.Column<int>(nullable: true),
                    HotelRoomRentalIdRental = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tour", x => x.IdTour);
                    table.ForeignKey(
                        name: "FK_Tour_Agency_AgencyIdAgency",
                        column: x => x.AgencyIdAgency,
                        principalTable: "Agency",
                        principalColumn: "IdAgency",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tour_HotelRoomRental_HotelRoomRentalIdRental",
                        column: x => x.HotelRoomRentalIdRental,
                        principalTable: "HotelRoomRental",
                        principalColumn: "IdRental",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientIdClient = table.Column<int>(nullable: true),
                    ManagerIdManager = table.Column<int>(nullable: true),
                    TourIdTour = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.IdOrder);
                    table.ForeignKey(
                        name: "FK_Order_Client_ClientIdClient",
                        column: x => x.ClientIdClient,
                        principalTable: "Client",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Manager_ManagerIdManager",
                        column: x => x.ManagerIdManager,
                        principalTable: "Manager",
                        principalColumn: "IdManager",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Tour_TourIdTour",
                        column: x => x.TourIdTour,
                        principalTable: "Tour",
                        principalColumn: "IdTour",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manager_AgencyIdAgency",
                table: "Manager",
                column: "AgencyIdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ClientIdClient",
                table: "Order",
                column: "ClientIdClient");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ManagerIdManager",
                table: "Order",
                column: "ManagerIdManager");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TourIdTour",
                table: "Order",
                column: "TourIdTour");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_AgencyIdAgency",
                table: "Tour",
                column: "AgencyIdAgency");

            migrationBuilder.CreateIndex(
                name: "IX_Tour_HotelRoomRentalIdRental",
                table: "Tour",
                column: "HotelRoomRentalIdRental");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropTable(
                name: "Tour");

            migrationBuilder.DropTable(
                name: "Agency");

            migrationBuilder.DropTable(
                name: "HotelRoomRental");
        }
    }
}
