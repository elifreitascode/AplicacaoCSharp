using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aplicacao_PROVA.Migrations
{
    /// <inheritdoc />
    public partial class TabelaVendas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Situacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome_cliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco_da_venda = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendas");
        }
    }
}
