using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Control_Gasto_Publico.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agregar_Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_edificio = table.Column<int>(type: "int", nullable: false),
                    id_servicio = table.Column<int>(type: "int", nullable: false),
                    fecha_servicio = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agregar_Servicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Edificio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cantidad_personas = table.Column<int>(type: "int", nullable: false),
                    fecha_alquiler = table.Column<DateTime>(type: "datetime2", nullable: false),
                    id_provincia = table.Column<int>(type: "int", nullable: false),
                    id_canton = table.Column<int>(type: "int", nullable: false),
                    id_destrito = table.Column<int>(type: "int", nullable: false),
                    tipo_edificio = table.Column<int>(type: "int", nullable: false),
                    fecha_final_alquiler = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Edificio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    nombre_empresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    tipo_servicio_id = table.Column<int>(type: "int", nullable: false),
                    unidad_medida_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tipo_Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo_Servicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Unidad_Medida",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidad_Medida", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agregar_Servicio");

            migrationBuilder.DropTable(
                name: "Edificio");

            migrationBuilder.DropTable(
                name: "Servicio");

            migrationBuilder.DropTable(
                name: "Tipo_Servicio");

            migrationBuilder.DropTable(
                name: "Unidad_Medida");
        }
    }
}
