using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediaLibrary.Domain.Migrations
{
    /// <inheritdoc />
    public partial class LastFinish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tarck_album_album_id",
                table: "tarck");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tarck",
                table: "tarck");

            migrationBuilder.RenameTable(
                name: "tarck",
                newName: "track");

            migrationBuilder.RenameIndex(
                name: "IX_tarck_album_id",
                table: "track",
                newName: "IX_track_album_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_track",
                table: "track",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_track_album_album_id",
                table: "track",
                column: "album_id",
                principalTable: "album",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_track_album_album_id",
                table: "track");

            migrationBuilder.DropPrimaryKey(
                name: "PK_track",
                table: "track");

            migrationBuilder.RenameTable(
                name: "track",
                newName: "tarck");

            migrationBuilder.RenameIndex(
                name: "IX_track_album_id",
                table: "tarck",
                newName: "IX_tarck_album_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tarck",
                table: "tarck",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tarck_album_album_id",
                table: "tarck",
                column: "album_id",
                principalTable: "album",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
