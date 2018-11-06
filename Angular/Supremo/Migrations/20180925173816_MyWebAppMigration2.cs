using Microsoft.EntityFrameworkCore.Migrations;

namespace Supremo.Migrations
{
    public partial class MyWebAppMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_MyProperty_ProdutoId",
                table: "Itens");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Pedidos_PedidoId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_PedidoId",
                table: "Pedidos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.DropColumn(
                name: "PedidoId",
                table: "Pedidos");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "Produtos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Produtos_ProdutoId",
                table: "Itens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "MyProperty");

            migrationBuilder.AddColumn<int>(
                name: "PedidoId",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_PedidoId",
                table: "Pedidos",
                column: "PedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_MyProperty_ProdutoId",
                table: "Itens",
                column: "ProdutoId",
                principalTable: "MyProperty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Pedidos_PedidoId",
                table: "Pedidos",
                column: "PedidoId",
                principalTable: "Pedidos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
