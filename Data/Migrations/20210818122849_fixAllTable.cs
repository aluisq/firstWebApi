using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace firstWebApi.Data.Migrations
{
    public partial class fixAllTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ultimoAcesso",
                table: "Usuarios",
                newName: "updatedAt");

            migrationBuilder.RenameColumn(
                name: "setor",
                table: "Usuarios",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "nivelPermissao",
                table: "Usuarios",
                newName: "fullname");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Usuarios",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "idade",
                table: "Usuarios",
                newName: "active");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdAt",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "department",
                table: "Usuarios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "lastAccess",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "createdAt",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "department",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "lastAccess",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "updatedAt",
                table: "Usuarios",
                newName: "ultimoAcesso");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Usuarios",
                newName: "setor");

            migrationBuilder.RenameColumn(
                name: "fullname",
                table: "Usuarios",
                newName: "nivelPermissao");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Usuarios",
                newName: "idade");
        }
    }
}
