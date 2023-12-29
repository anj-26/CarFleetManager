using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarDetails.Data.Migrations
{
    /// <inheritdoc />
    public partial class FourthMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationNum",
                table: "Cars");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cars",
                newName: "RegistrationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegistrationId",
                table: "Cars",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNum",
                table: "Cars",
                type: "TEXT",
                nullable: true);
        }
    }
}
