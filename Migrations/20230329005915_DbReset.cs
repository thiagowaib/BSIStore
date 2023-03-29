using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSIStore.Migrations
{
    /// <inheritdoc />
    public partial class DbReset : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nome = table.Column<string>(type: "TEXT", nullable: true),
                    dataNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    cargo = table.Column<string>(type: "TEXT", nullable: true),
                    salario = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    descricao = table.Column<string>(type: "TEXT", nullable: true),
                    dataValidade = table.Column<DateTime>(type: "TEXT", nullable: false),
                    categoria = table.Column<string>(type: "TEXT", nullable: true),
                    preco = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Produto");
        }
    }
}
