using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiIgreja.Migrations
{
    public partial class MyWebAppMiration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Classificacao",
                table: "Filmes",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Classificacao",
                table: "Filmes",
                nullable: false,
                oldClrType: typeof(double));
        }
    }
}
