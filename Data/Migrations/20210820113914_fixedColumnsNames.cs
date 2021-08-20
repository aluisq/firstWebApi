using Microsoft.EntityFrameworkCore.Migrations;

namespace firstWebApi.Data.Migrations
{
    public partial class fixedColumnsNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "role",
                table: "Usuarios",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Usuarios",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "Usuarios",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "fullname",
                table: "Usuarios",
                newName: "Fullname");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "department",
                table: "Usuarios",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "active",
                table: "Usuarios",
                newName: "Active");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Usuarios",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Usuarios",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Usuarios",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Usuarios",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Usuarios",
                newName: "fullname");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Usuarios",
                newName: "department");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Usuarios",
                newName: "active");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "id");
        }
    }
}
