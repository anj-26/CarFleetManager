using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDetails.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RegistrationNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Brand = table.Column<string>(type: "TEXT", nullable: true),
                    FirstInspection = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    LastInspection = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    IsRoadWorthy = table.Column<bool>(type: "INTEGER", nullable: false),
                    NextInspection = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    IsInspectionExpired = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
