using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaLibrary.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Fixed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "actor",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "actor",
                newName: "Id");
        }
    }
}
