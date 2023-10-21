using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPS.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lineas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lineas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recorridos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    valor = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recorridos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoCarrocerias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCarrocerias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transitos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transitos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroServicio = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRecorrido = table.Column<int>(type: "int", nullable: false),
                    RecorridoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicios_Recorridos_RecorridoId",
                        column: x => x.RecorridoId,
                        principalTable: "Recorridos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehiculos",
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
                    NumeroChasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTransito = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    IdLinea = table.Column<int>(type: "int", nullable: false),
                    IdTipoCarroceria = table.Column<int>(type: "int", nullable: false),
                    TransitoId = table.Column<int>(type: "int", nullable: true),
                    marcaId = table.Column<int>(type: "int", nullable: true),
                    lineaId = table.Column<int>(type: "int", nullable: true),
                    TipoCarroceriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehiculos_Lineas_lineaId",
                        column: x => x.lineaId,
                        principalTable: "Lineas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Marcas_marcaId",
                        column: x => x.marcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_TipoCarrocerias_TipoCarroceriaId",
                        column: x => x.TipoCarroceriaId,
                        principalTable: "TipoCarrocerias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculos_Transitos_TransitoId",
                        column: x => x.TransitoId,
                        principalTable: "Transitos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EstadoServicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoServicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadoServicios_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Liquidacions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidacions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liquidacions_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo_Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicioId = table.Column<int>(type: "int", nullable: true),
                    IdServicio = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: true),
                    IdVehiculo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo_Servicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Servicio_Servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "Servicios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Vehiculo_Servicio_Vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "Vehiculos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstadoServicios_Estado",
                table: "EstadoServicios",
                column: "Estado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EstadoServicios_ServicioId",
                table: "EstadoServicios",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Lineas_Nombre",
                table: "Lineas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Liquidacions_ServicioId",
                table: "Liquidacions",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Liquidacions_Valor",
                table: "Liquidacions",
                column: "Valor",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Marcas_Nombre",
                table: "Marcas",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recorridos_Nombre",
                table: "Recorridos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_NumeroServicio",
                table: "Servicios",
                column: "NumeroServicio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicios_RecorridoId",
                table: "Servicios",
                column: "RecorridoId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCarrocerias_Nombre",
                table: "TipoCarrocerias",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transitos_Nombre",
                table: "Transitos",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Servicio_ServicioId",
                table: "Vehiculo_Servicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Servicio_VehiculoId",
                table: "Vehiculo_Servicio",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_lineaId",
                table: "Vehiculos",
                column: "lineaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_marcaId",
                table: "Vehiculos",
                column: "marcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_placa",
                table: "Vehiculos",
                column: "placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TipoCarroceriaId",
                table: "Vehiculos",
                column: "TipoCarroceriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_TransitoId",
                table: "Vehiculos",
                column: "TransitoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoServicios");

            migrationBuilder.DropTable(
                name: "Liquidacions");

            migrationBuilder.DropTable(
                name: "Vehiculo_Servicio");

            migrationBuilder.DropTable(
                name: "Servicios");

            migrationBuilder.DropTable(
                name: "Vehiculos");

            migrationBuilder.DropTable(
                name: "Recorridos");

            migrationBuilder.DropTable(
                name: "Lineas");

            migrationBuilder.DropTable(
                name: "Marcas");

            migrationBuilder.DropTable(
                name: "TipoCarrocerias");

            migrationBuilder.DropTable(
                name: "Transitos");
        }
    }
}
