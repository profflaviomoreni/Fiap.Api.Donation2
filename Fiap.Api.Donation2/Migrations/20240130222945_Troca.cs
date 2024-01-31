using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiap.Api.Donation2.Migrations
{
    /// <inheritdoc />
    public partial class Troca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Troca",
                columns: table => new
                {
                    TrocaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProdutoId1 = table.Column<int>(type: "int", nullable: false),
                    ProdutoId2 = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Troca", x => x.TrocaId);
                    table.ForeignKey(
                        name: "FK_Troca_Produto_ProdutoId1",
                        column: x => x.ProdutoId1,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Troca_Produto_ProdutoId2",
                        column: x => x.ProdutoId2,
                        principalTable: "Produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1919), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1934), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1937), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1940), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1943), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1946), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1948), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1951), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1955), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1957), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1960), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1962), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1964), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1967), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1969), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1971), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1973), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1976), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1978), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1983), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1985), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1987), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1990), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1992), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1994), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1999), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2047), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2050), new DateTime(2025, 9, 30, 19, 29, 45, 764, DateTimeKind.Local).AddTicks(2051) });

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId1",
                table: "Troca",
                column: "ProdutoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Troca_ProdutoId2",
                table: "Troca",
                column: "ProdutoId2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Troca");

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 1,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1850), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1851) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 2,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1858), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 3,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1860), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 4,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1862), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 5,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1864), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 6,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1865), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 7,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1867), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 8,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1868), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 9,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1870), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 10,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1871), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 11,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1873), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 12,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1874), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 13,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1876), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 14,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1877), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 15,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1879), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 16,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1880), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 17,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1881), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 18,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1883), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 19,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1884), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 20,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1886), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 21,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1887), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 22,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1889), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 23,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1890), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 24,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1891), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 25,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1893), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 26,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1894), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 27,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1896), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 28,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1897), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 29,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1898), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 30,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1900), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "ProdutoId",
                keyValue: 31,
                columns: new[] { "DataCadastro", "DataExpiracao" },
                values: new object[] { new DateTime(2024, 1, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1901), new DateTime(2025, 9, 24, 20, 15, 38, 754, DateTimeKind.Local).AddTicks(1902) });
        }
    }
}
