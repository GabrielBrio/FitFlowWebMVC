using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFlowWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class ProgresoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Progresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Pecho = table.Column<double>(type: "float", nullable: false),
                    Cintura = table.Column<double>(type: "float", nullable: false),
                    Brazos = table.Column<double>(type: "float", nullable: false),
                    Piernas = table.Column<double>(type: "float", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Progresos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Progresos");
        }
    }
}
