using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiIgreja.Migrations
{
    public partial class MyWebAppMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Diretor",
                table: "Filmes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Filmes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diretor",
                table: "Filmes");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Filmes");
        }
    }
}
