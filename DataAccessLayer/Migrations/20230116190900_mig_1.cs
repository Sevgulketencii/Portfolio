using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutDb",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDesciription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutDb", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "ContactDb",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDb", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "ProjectDb",
                columns: table => new
                {
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectDb", x => x.ProjectId);
                });

            migrationBuilder.CreateTable(
                name: "LanguageDb",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LanguageStatus = table.Column<bool>(type: "bit", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguageDb", x => x.LanguageId);
                    table.ForeignKey(
                        name: "FK_LanguageDb_ProjectDb_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "ProjectDb",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguageDb_ProjectId",
                table: "LanguageDb",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutDb");

            migrationBuilder.DropTable(
                name: "ContactDb");

            migrationBuilder.DropTable(
                name: "LanguageDb");

            migrationBuilder.DropTable(
                name: "ProjectDb");
        }
    }
}
