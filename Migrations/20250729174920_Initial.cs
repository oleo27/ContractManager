using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractManager.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dyspozycje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumerUmowy = table.Column<string>(type: "TEXT", nullable: false),
                    DataDyspozycji = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Uzytkownik = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dyspozycje", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dyspozycje");
        }
    }
}
