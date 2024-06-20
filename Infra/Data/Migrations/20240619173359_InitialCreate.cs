using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    ID_BOOK = table.Column<Guid>(type: "char(36)", nullable: false),
                    BOOK_NAME = table.Column<string>(type: "longtext", nullable: true),
                    BOOK_AUTHOR = table.Column<string>(type: "longtext", nullable: true),
                    BOOK_RESUME = table.Column<string>(type: "longtext", nullable: true),
                    PUBLICATION_DATE = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.ID_BOOK);
                })
                .Annotation("MySQL:Charset", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
