using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiIgreja.Migrations
{
    public partial class MyWebAppMiration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Classificacao",
                table: "Filmes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Trailer",
                table: "Filmes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classificacao",
                table: "Filmes");

            migrationBuilder.DropColumn(
                name: "Trailer",
                table: "Filmes");
        }
    }
}
