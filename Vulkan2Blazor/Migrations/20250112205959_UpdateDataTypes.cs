using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vulkan2Blazor.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Naziv",
                table: "GasilskoDrustvo",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Naziv",
                table: "GasilskoDrustvo");
        }
    }
}
