using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backendjuego.Migrations
{
    /// <inheritdoc />
    public partial class PuntosPersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_usertypes_UsertypeId",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usertypes",
                table: "usertypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "users");

            migrationBuilder.RenameTable(
                name: "usertypes",
                newName: "UserTypes");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "Users");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "UserTypes",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "UserTypes",
                newName: "UserTipeId");

            migrationBuilder.RenameColumn(
                name: "UsertypeId",
                table: "Users",
                newName: "UserTypeId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_users_UsertypeId",
                table: "Users",
                newName: "IX_Users_UserTypeId");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes",
                column: "UserTipeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    DocumentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "PuntosPersons",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<int>(type: "int", nullable: false),
                    LibroId = table.Column<int>(type: "int", nullable: false),
                    Puntos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PuntosPersons", x => x.PersonId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "UserTipeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserTypeId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "PuntosPersons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserTypes",
                table: "UserTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "UserTypes",
                newName: "usertypes");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "users");

            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "usertypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UserTipeId",
                table: "usertypes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "UserTypeId",
                table: "users",
                newName: "UsertypeId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "users",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserTypeId",
                table: "users",
                newName: "IX_users_UsertypeId");

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usertypes",
                table: "usertypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_users_usertypes_UsertypeId",
                table: "users",
                column: "UsertypeId",
                principalTable: "usertypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
