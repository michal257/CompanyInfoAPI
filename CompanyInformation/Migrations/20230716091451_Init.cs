using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompanyInformation.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    statusVat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    krs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    workingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    registrationLegalDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    requestDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    requestId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyInfos");
        }
    }
}
