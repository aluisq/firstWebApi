using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace firstWebApi.Data.Migrations
{
    public partial class MoreFieldsUSers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "login",
                table: "Usuarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Usuarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ultimoAcesso",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "login",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "password",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ultimoAcesso",
                table: "Usuarios");
        }
    }
}
