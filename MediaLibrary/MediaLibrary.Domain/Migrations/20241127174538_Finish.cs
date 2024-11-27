using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaLibrary.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Finish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "tarck",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "genre",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "album",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "actor_genre",
                newName: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "tarck",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "genre",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "album",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "actor_genre",
                newName: "Id");
        }
    }
}
