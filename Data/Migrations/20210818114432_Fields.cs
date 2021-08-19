using Microsoft.EntityFrameworkCore.Migrations;

namespace firstWebApi.Data.Migrations
{
    public partial class Fields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nivelPermissao",
                table: "Usuarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "setor",
                table: "Usuarios",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nivelPermissao",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "setor",
                table: "Usuarios");
        }
    }
}
