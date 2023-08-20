using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Financeiro.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class configtransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "Transacao");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_CategoryId",
                table: "Transacao",
                newName: "IX_Transacao_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transacao",
                table: "Transacao",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transacao_Categories_CategoryId",
                table: "Transacao",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transacao_Categories_CategoryId",
                table: "Transacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transacao",
                table: "Transacao");

            migrationBuilder.RenameTable(
                name: "Transacao",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_Transacao_CategoryId",
                table: "Transactions",
                newName: "IX_Transactions_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
