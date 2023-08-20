using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Financeiro.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class configcategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_SistemaFinanceiro_FinanceSystemsId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_Categories_CategoryId",
                table: "Transacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categoria");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_FinanceSystemsId",
                table: "Categoria",
                newName: "IX_Categoria_FinanceSystemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categoria_SistemaFinanceiro_FinanceSystemsId",
                table: "Categoria",
                column: "FinanceSystemsId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_Categoria_CategoryId",
                table: "Transacao",
                column: "CategoryId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categoria_SistemaFinanceiro_FinanceSystemsId",
                table: "Categoria");

            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_Categoria_CategoryId",
                table: "Transacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Categoria_FinanceSystemsId",
                table: "Categories",
                newName: "IX_Categories_FinanceSystemsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_SistemaFinanceiro_FinanceSystemsId",
                table: "Categories",
                column: "FinanceSystemsId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_Categories_CategoryId",
                table: "Transacao",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
