using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ContactTitle",
                table: "AboutDb",
                newName: "AboutTitle");

            migrationBuilder.RenameColumn(
                name: "ContactStatus",
                table: "AboutDb",
                newName: "AboutStatus");

            migrationBuilder.RenameColumn(
                name: "ContactDesciription",
                table: "AboutDb",
                newName: "AboutDesciription");

            migrationBuilder.RenameColumn(
                name: "ContactId",
                table: "AboutDb",
                newName: "AboutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutTitle",
                table: "AboutDb",
                newName: "ContactTitle");

            migrationBuilder.RenameColumn(
                name: "AboutStatus",
                table: "AboutDb",
                newName: "ContactStatus");

            migrationBuilder.RenameColumn(
                name: "AboutDesciription",
                table: "AboutDb",
                newName: "ContactDesciription");

            migrationBuilder.RenameColumn(
                name: "AboutId",
                table: "AboutDb",
                newName: "ContactId");
        }
    }
}
