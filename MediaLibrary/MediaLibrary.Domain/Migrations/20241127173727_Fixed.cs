using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MediaLibrary.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_actor_genre_id",
                table: "actor");

            migrationBuilder.DropForeignKey(
                name: "FK_album_actor_id",
                table: "album");

            migrationBuilder.DropForeignKey(
                name: "FK_genre_actor_genre_id",
                table: "genre");

            migrationBuilder.DropForeignKey(
                name: "FK_tarck_album_id",
                table: "tarck");

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

            migrationBuilder.RenameColumn(
                name: "id",
                table: "actor",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "tarck",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "genre",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "album",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "actor",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_tarck_album_id",
                table: "tarck",
                column: "album_id");

            migrationBuilder.CreateIndex(
                name: "IX_album_actor_id",
                table: "album",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "IX_actor_genre_actor_id",
                table: "actor_genre",
                column: "actor_id");

            migrationBuilder.CreateIndex(
                name: "IX_actor_genre_genre_id",
                table: "actor_genre",
                column: "genre_id");

            migrationBuilder.AddForeignKey(
                name: "FK_actor_genre_actor_actor_id",
                table: "actor_genre",
                column: "actor_id",
                principalTable: "actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_actor_genre_genre_genre_id",
                table: "actor_genre",
                column: "genre_id",
                principalTable: "genre",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_album_actor_actor_id",
                table: "album",
                column: "actor_id",
                principalTable: "actor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tarck_album_album_id",
                table: "tarck",
                column: "album_id",
                principalTable: "album",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_actor_genre_actor_actor_id",
                table: "actor_genre");

            migrationBuilder.DropForeignKey(
                name: "FK_actor_genre_genre_genre_id",
                table: "actor_genre");

            migrationBuilder.DropForeignKey(
                name: "FK_album_actor_actor_id",
                table: "album");

            migrationBuilder.DropForeignKey(
                name: "FK_tarck_album_album_id",
                table: "tarck");

            migrationBuilder.DropIndex(
                name: "IX_tarck_album_id",
                table: "tarck");

            migrationBuilder.DropIndex(
                name: "IX_album_actor_id",
                table: "album");

            migrationBuilder.DropIndex(
                name: "IX_actor_genre_actor_id",
                table: "actor_genre");

            migrationBuilder.DropIndex(
                name: "IX_actor_genre_genre_id",
                table: "actor_genre");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "actor",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "tarck",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "genre",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "album",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "actor",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_actor_actor_genre_id",
                table: "actor",
                column: "id",
                principalTable: "actor_genre",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_album_actor_id",
                table: "album",
                column: "id",
                principalTable: "actor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_genre_actor_genre_id",
                table: "genre",
                column: "id",
                principalTable: "actor_genre",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tarck_album_id",
                table: "tarck",
                column: "id",
                principalTable: "album",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
