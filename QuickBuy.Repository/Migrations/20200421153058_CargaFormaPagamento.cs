using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickBuy.Repository.Migrations
{
    public partial class CargaFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "FormasPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 1, "Forma de pagamento boleto", "Boleto" });

            migrationBuilder.InsertData(
                table: "FormasPagamentos",
                columns: new[] { "Id", "Descricao", "Nome" },
                values: new object[] { 2, "Forma de cartão de crédito", "Cartão de Crédito" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FormasPagamentos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormasPagamentos",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
