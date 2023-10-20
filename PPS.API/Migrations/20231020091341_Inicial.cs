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
                    Valor = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_liquidacions", x => x.Id);
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
                name: "servicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroServicio = table.Column<int>(type: "int", nullable: false),
                    Observacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdEstadoServicio = table.Column<int>(type: "int", nullable: false),
                    IdRecorrido = table.Column<int>(type: "int", nullable: false),
                    IdLiquidacion = table.Column<int>(type: "int", nullable: false),
                    EstadoServicioId = table.Column<int>(type: "int", nullable: false),
                    recorridoId = table.Column<int>(type: "int", nullable: false),
                    LiquidacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_servicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_servicios_estadoServicios_EstadoServicioId",
                        column: x => x.EstadoServicioId,
                        principalTable: "estadoServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_servicios_liquidacions_LiquidacionId",
                        column: x => x.LiquidacionId,
                        principalTable: "liquidacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_servicios_recorridos_recorridoId",
                        column: x => x.recorridoId,
                        principalTable: "recorridos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    NumeroChasis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTransito = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    IdLinea = table.Column<int>(type: "int", nullable: false),
                    IdTipoCarroceria = table.Column<int>(type: "int", nullable: false),
                    TransitoId = table.Column<int>(type: "int", nullable: false),
                    marcaId = table.Column<int>(type: "int", nullable: false),
                    lineaId = table.Column<int>(type: "int", nullable: false),
                    TipoCarroceriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehiculos_lineas_lineaId",
                        column: x => x.lineaId,
                        principalTable: "lineas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_marcas_marcaId",
                        column: x => x.marcaId,
                        principalTable: "marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_tipoCarrocerias_TipoCarroceriaId",
                        column: x => x.TipoCarroceriaId,
                        principalTable: "tipoCarrocerias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehiculos_transitos_TransitoId",
                        column: x => x.TransitoId,
                        principalTable: "transitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo_Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdServicioId = table.Column<int>(type: "int", nullable: false),
                    IdVehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo_Servicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Servicio_servicios_IdServicioId",
                        column: x => x.IdServicioId,
                        principalTable: "servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Servicio_vehiculos_IdVehiculoId",
                        column: x => x.IdVehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_liquidacions_Valor",
                table: "liquidacions",
                column: "Valor",
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
                name: "IX_servicios_EstadoServicioId",
                table: "servicios",
                column: "EstadoServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_servicios_LiquidacionId",
                table: "servicios",
                column: "LiquidacionId");

            migrationBuilder.CreateIndex(
                name: "IX_servicios_NumeroServicio",
                table: "servicios",
                column: "NumeroServicio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_servicios_recorridoId",
                table: "servicios",
                column: "recorridoId");

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
                name: "IX_Vehiculo_Servicio_IdServicioId",
                table: "Vehiculo_Servicio",
                column: "IdServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Servicio_IdVehiculoId",
                table: "Vehiculo_Servicio",
                column: "IdVehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_lineaId",
                table: "vehiculos",
                column: "lineaId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_marcaId",
                table: "vehiculos",
                column: "marcaId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_placa",
                table: "vehiculos",
                column: "placa",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_TipoCarroceriaId",
                table: "vehiculos",
                column: "TipoCarroceriaId");

            migrationBuilder.CreateIndex(
                name: "IX_vehiculos_TransitoId",
                table: "vehiculos",
                column: "TransitoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehiculo_Servicio");

            migrationBuilder.DropTable(
                name: "servicios");

            migrationBuilder.DropTable(
                name: "vehiculos");

            migrationBuilder.DropTable(
                name: "estadoServicios");

            migrationBuilder.DropTable(
                name: "liquidacions");

            migrationBuilder.DropTable(
                name: "recorridos");

            migrationBuilder.DropTable(
                name: "lineas");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "tipoCarrocerias");

            migrationBuilder.DropTable(
                name: "transitos");
        }
    }
}
