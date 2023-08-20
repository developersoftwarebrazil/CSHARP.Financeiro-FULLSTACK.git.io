using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Financeiro.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class configfinanceSystemUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinanceSystemUsers_SistemaFinanceiro_SystemId",
                table: "FinanceSystemUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FinanceSystemUsers",
                table: "FinanceSystemUsers");

            migrationBuilder.RenameTable(
                name: "FinanceSystemUsers",
                newName: "UsuarioSistemaFinanceiro");

            migrationBuilder.RenameIndex(
                name: "IX_FinanceSystemUsers_SystemId",
                table: "UsuarioSistemaFinanceiro",
                newName: "IX_UsuarioSistemaFinanceiro_SystemId");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "UsuarioSistemaFinanceiro",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioSistemaFinanceiro",
                table: "UsuarioSistemaFinanceiro",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_SistemaFinanceiro_SystemId",
                table: "UsuarioSistemaFinanceiro",
                column: "SystemId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioSistemaFinanceiro_SistemaFinanceiro_SystemId",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioSistemaFinanceiro",
                table: "UsuarioSistemaFinanceiro");

            migrationBuilder.RenameTable(
                name: "UsuarioSistemaFinanceiro",
                newName: "FinanceSystemUsers");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioSistemaFinanceiro_SystemId",
                table: "FinanceSystemUsers",
                newName: "IX_FinanceSystemUsers_SystemId");

            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "FinanceSystemUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinanceSystemUsers",
                table: "FinanceSystemUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinanceSystemUsers_SistemaFinanceiro_SystemId",
                table: "FinanceSystemUsers",
                column: "SystemId",
                principalTable: "SistemaFinanceiro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
