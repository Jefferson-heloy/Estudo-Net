using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiIgreja.Migrations
{
    public partial class MyWebAppMigration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFilme",
                table: "Filmes");

            migrationBuilder.AddColumn<int>(
                name: "AnoFilme",
                table: "Filmes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AnoFilme",
                table: "Filmes");

            migrationBuilder.AddColumn<string>(
                name: "DataFilme",
                table: "Filmes",
                nullable: true);
        }
    }
}
