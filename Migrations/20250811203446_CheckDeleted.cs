using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractManager.Migrations
{
    /// <inheritdoc />
    public partial class CheckDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataJedenMiesiac",
                table: "Dyspozycje");

            migrationBuilder.DropColumn(
                name: "JedneMiesiacCheck",
                table: "Dyspozycje");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataJedenMiesiac",
                table: "Dyspozycje",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "JedneMiesiacCheck",
                table: "Dyspozycje",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
