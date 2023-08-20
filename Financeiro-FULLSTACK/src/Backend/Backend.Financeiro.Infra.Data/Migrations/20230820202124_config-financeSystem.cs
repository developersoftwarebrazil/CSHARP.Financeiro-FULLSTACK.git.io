using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Financeiro.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class configfinanceSystem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_FinanceSystem_FinanceSystemsId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_FinanceSystemUsers_FinanceSystem_SystemId",
                table: "FinanceSystemUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinanceSystem",
                table: "FinanceSystem");

            migrationBuilder.RenameTable(
                name: "FinanceSystem",
                newName: "SistemaFinanceiro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SistemaFinanceiro",
                table: "SistemaFinanceiro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_SistemaFinanceiro_FinanceSystemsId",
                table: "Categories",
                column: "FinanceSystemsId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FinanceSystemUsers_SistemaFinanceiro_SystemId",
                table: "FinanceSystemUsers",
                column: "SystemId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_SistemaFinanceiro_FinanceSystemsId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_FinanceSystemUsers_SistemaFinanceiro_SystemId",
                table: "FinanceSystemUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SistemaFinanceiro",
                table: "SistemaFinanceiro");

            migrationBuilder.RenameTable(
                name: "SistemaFinanceiro",
                newName: "FinanceSystem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinanceSystem",
                table: "FinanceSystem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_FinanceSystem_FinanceSystemsId",
                table: "Categories",
                column: "FinanceSystemsId",
                principalTable: "FinanceSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FinanceSystemUsers_FinanceSystem_SystemId",
                table: "FinanceSystemUsers",
                column: "SystemId",
                principalTable: "FinanceSystem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
