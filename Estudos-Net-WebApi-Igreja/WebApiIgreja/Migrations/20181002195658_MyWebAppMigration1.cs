using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiIgreja.Migrations
{
    public partial class MyWebAppMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataFilme",
                table: "Filmes",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFilme",
                table: "Filmes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
