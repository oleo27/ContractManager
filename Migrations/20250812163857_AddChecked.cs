using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContractManager.Migrations
{
    /// <inheritdoc />
    public partial class AddChecked : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Checked",
                table: "Dyspozycje",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checked",
                table: "Dyspozycje");
        }
    }
}
