using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPS.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "estadoServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estadoServicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lineas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lineas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "liquidacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Egreso = table.Column<int>(type: "int", nullable: false),
                    Ingreso = table.Column<int>(type: "int", nullable: false),
                    Facturar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liquidacions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lugars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lugars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "recorridos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    valor = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recorridos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroServicio = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipoCarrocerias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoCarrocerias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "transitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "vehiculos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    placa = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cilindraje = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Capacidad = table.Column<int>(type: "int", nullable: false),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroMotor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroChasis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_estadoServicios_Estado",
                table: "estadoServicios",
                column: "Estado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_lineas_Nombre",
                table: "lineas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_liquidacions_Facturar",
                table: "liquidacions",
                column: "Facturar",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_lugars_Nombre",
                table: "lugars",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_marcas_Nombre",
                table: "marcas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_recorridos_valor",
                table: "recorridos",
                column: "valor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_servicios_NumeroServicio",
                table: "servicios",
                column: "NumeroServicio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tipoCarrocerias_Nombre",
                table: "tipoCarrocerias",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_transitos_Nombre",
                table: "transitos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_placa",
                table: "vehiculos",
                column: "placa",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "estadoServicios");

            migrationBuilder.DropTable(
                name: "lineas");

            migrationBuilder.DropTable(
                name: "liquidacions");

            migrationBuilder.DropTable(
                name: "lugars");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "recorridos");

            migrationBuilder.DropTable(
                name: "servicios");

            migrationBuilder.DropTable(
                name: "tipoCarrocerias");

            migrationBuilder.DropTable(
                name: "transitos");

            migrationBuilder.DropTable(
                name: "vehiculos");
        }
    }
}
