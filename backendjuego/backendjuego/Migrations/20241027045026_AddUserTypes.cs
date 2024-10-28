using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backendjuego.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsertypeId",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "usertypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usertypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_UsertypeId",
                table: "users",
                column: "UsertypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_usertypes_UsertypeId",
                table: "users",
                column: "UsertypeId",
                principalTable: "usertypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_usertypes_UsertypeId",
                table: "users");

            migrationBuilder.DropTable(
                name: "usertypes");

            migrationBuilder.DropIndex(
                name: "IX_users_UsertypeId",
                table: "users");

            migrationBuilder.DropColumn(
                name: "UsertypeId",
                table: "users");
        }
    }
}
