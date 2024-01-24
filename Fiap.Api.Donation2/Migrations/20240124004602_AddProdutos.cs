using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fiap.Api.Donation2.Migrations
{
    /// <inheritdoc />
    public partial class AddProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "ProdutoId", "CategoriaId", "DataCadastro", "DataExpiracao", "Descricao", "Disponivel", "Nome", "SugestaoTroca", "UsuarioId", "Valor" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8180), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8181), "Descrição", true, "Produto 1", "Sugestão de troca", 1, 1.0 },
                    { 2, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8194), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8195), "Descrição", true, "Produto 2", "Sugestão de troca", 1, 1.0 },
                    { 3, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8198), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8199), "Descrição", true, "Produto 3", "Sugestão de troca", 1, 1.0 },
                    { 4, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8202), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8203), "Descrição", true, "Produto 4", "Sugestão de troca", 1, 1.0 },
                    { 5, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8272), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8273), "Descrição", true, "Produto 5", "Sugestão de troca", 1, 1.0 },
                    { 6, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8276), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8277), "Descrição", true, "Produto 6", "Sugestão de troca", 1, 1.0 },
                    { 7, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8279), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8280), "Descrição", true, "Produto 7", "Sugestão de troca", 1, 1.0 },
                    { 8, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8282), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8283), "Descrição", true, "Produto 8", "Sugestão de troca", 1, 1.0 },
                    { 9, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8285), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8286), "Descrição", true, "Produto 9", "Sugestão de troca", 1, 1.0 },
                    { 10, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8288), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8289), "Descrição", true, "Produto 10", "Sugestão de troca", 1, 1.0 },
                    { 11, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8291), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8291), "Descrição", true, "Produto 11", "Sugestão de troca", 1, 1.0 },
                    { 12, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8294), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8294), "Descrição", true, "Produto 12", "Sugestão de troca", 1, 1.0 },
                    { 13, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8296), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8297), "Descrição", true, "Produto 13", "Sugestão de troca", 1, 1.0 },
                    { 14, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8299), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8300), "Descrição", true, "Produto 14", "Sugestão de troca", 1, 1.0 },
                    { 15, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8302), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8303), "Descrição", true, "Produto 15", "Sugestão de troca", 1, 1.0 },
                    { 16, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8305), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8305), "Descrição", true, "Produto 16", "Sugestão de troca", 1, 1.0 },
                    { 17, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8307), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8308), "Descrição", true, "Produto 17", "Sugestão de troca", 1, 1.0 },
                    { 18, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8310), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8311), "Descrição", true, "Produto 18", "Sugestão de troca", 1, 1.0 },
                    { 19, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8314), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8314), "Descrição", true, "Produto 19", "Sugestão de troca", 1, 1.0 },
                    { 20, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8316), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8317), "Descrição", true, "Produto 20", "Sugestão de troca", 1, 1.0 },
                    { 21, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8319), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8320), "Descrição", true, "Produto 21", "Sugestão de troca", 1, 1.0 },
                    { 22, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8322), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8323), "Descrição", true, "Produto 22", "Sugestão de troca", 1, 1.0 },
                    { 23, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8325), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8326), "Descrição", true, "Produto 23", "Sugestão de troca", 1, 1.0 },
                    { 24, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8328), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8329), "Descrição", true, "Produto 24", "Sugestão de troca", 1, 1.0 },
                    { 25, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8331), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8332), "Descrição", true, "Produto 25", "Sugestão de troca", 1, 1.0 },
                    { 26, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8334), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8335), "Descrição", true, "Produto 26", "Sugestão de troca", 1, 1.0 },
                    { 27, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8337), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8338), "Descrição", true, "Produto 27", "Sugestão de troca", 1, 1.0 },
                    { 28, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8340), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8340), "Descrição", true, "Produto 28", "Sugestão de troca", 1, 1.0 },
                    { 29, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8343), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8343), "Descrição", true, "Produto 29", "Sugestão de troca", 1, 1.0 },
                    { 30, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8346), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8346), "Descrição", true, "Produto 30", "Sugestão de troca", 1, 1.0 },
                    { 31, 1, new DateTime(2024, 1, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8348), new DateTime(2025, 9, 23, 21, 46, 2, 102, DateTimeKind.Local).AddTicks(8349), "Descrição", true, "Produto 31", "Sugestão de troca", 1, 1.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31);
        }
    }
}
