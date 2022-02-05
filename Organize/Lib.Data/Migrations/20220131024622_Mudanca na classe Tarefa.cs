using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lib.Data.Migrations
{
    public partial class MudancanaclasseTarefa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "DataDeCriacao",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "DataDoAniversario",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Tarefas");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "Tarefas");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "Tarefas",
                newName: "Nome");

            migrationBuilder.AddColumn<bool>(
                name: "Feito",
                table: "Tarefas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Feito",
                table: "Tarefas");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Tarefas",
                newName: "Senha");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeCriacao",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDoAniversario",
                table: "Tarefas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Tarefas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
