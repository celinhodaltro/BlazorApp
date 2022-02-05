using Microsoft.EntityFrameworkCore.Migrations;

namespace Lib.Data.Migrations
{
    public partial class TestedeMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Usuarios");
        }
    }
}
