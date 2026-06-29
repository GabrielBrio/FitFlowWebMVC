using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitFlowWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class RedisenoPlanSemanal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Domingo",
                table: "PlanesSemanales");

            migrationBuilder.DropColumn(
                name: "Jueves",
                table: "PlanesSemanales");

            migrationBuilder.DropColumn(
                name: "Lunes",
                table: "PlanesSemanales");

            migrationBuilder.DropColumn(
                name: "Martes",
                table: "PlanesSemanales");

            migrationBuilder.RenameColumn(
                name: "Viernes",
                table: "PlanesSemanales",
                newName: "GrupoMuscular");

            migrationBuilder.RenameColumn(
                name: "Sabado",
                table: "PlanesSemanales",
                newName: "Ejercicio");

            migrationBuilder.RenameColumn(
                name: "Miercoles",
                table: "PlanesSemanales",
                newName: "Dia");

            migrationBuilder.AddColumn<double>(
                name: "Peso",
                table: "PlanesSemanales",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Repeticiones",
                table: "PlanesSemanales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Series",
                table: "PlanesSemanales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Peso",
                table: "PlanesSemanales");

            migrationBuilder.DropColumn(
                name: "Repeticiones",
                table: "PlanesSemanales");

            migrationBuilder.DropColumn(
                name: "Series",
                table: "PlanesSemanales");

            migrationBuilder.RenameColumn(
                name: "GrupoMuscular",
                table: "PlanesSemanales",
                newName: "Viernes");

            migrationBuilder.RenameColumn(
                name: "Ejercicio",
                table: "PlanesSemanales",
                newName: "Sabado");

            migrationBuilder.RenameColumn(
                name: "Dia",
                table: "PlanesSemanales",
                newName: "Miercoles");

            migrationBuilder.AddColumn<string>(
                name: "Domingo",
                table: "PlanesSemanales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Jueves",
                table: "PlanesSemanales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Lunes",
                table: "PlanesSemanales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Martes",
                table: "PlanesSemanales",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
