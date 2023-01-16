using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CertificateDb",
                columns: table => new
                {
                    CertificateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CertificateStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CertificateDb", x => x.CertificateId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CertificateDb");
        }
    }
}
