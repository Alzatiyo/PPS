using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PPS.API.Migrations
{
    /// <inheritdoc />
    public partial class relationsDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadoServicio_Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoServicioId = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoServicio_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstadoServicio_Servicio_estadoServicios_EstadoServicioId",
                        column: x => x.EstadoServicioId,
                        principalTable: "estadoServicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstadoServicio_Servicio_servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Linea_Vehiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineaId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linea_Vehiculo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Linea_Vehiculo_lineas_LineaId",
                        column: x => x.LineaId,
                        principalTable: "lineas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Linea_Vehiculo_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Liquidacion_Servicio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServicioId = table.Column<int>(type: "int", nullable: false),
                    LiquidacionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidacion_Servicio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Liquidacion_Servicio_liquidacions_LiquidacionId",
                        column: x => x.LiquidacionId,
                        principalTable: "liquidacions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Liquidacion_Servicio_servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Marca_Vehiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca_Vehiculo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Marca_Vehiculo_marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Marca_Vehiculo_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recorrido_Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecorridoId = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recorrido_Servicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recorrido_Servicio_recorridos_RecorridoId",
                        column: x => x.RecorridoId,
                        principalTable: "recorridos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recorrido_Servicio_servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoCarroceria_Vehiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCarroceriaId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCarroceria_Vehiculo", x => x.id);
                    table.ForeignKey(
                        name: "FK_TipoCarroceria_Vehiculo_tipoCarrocerias_TipoCarroceriaId",
                        column: x => x.TipoCarroceriaId,
                        principalTable: "tipoCarrocerias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TipoCarroceria_Vehiculo_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transito_Vehiculo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransitoId = table.Column<int>(type: "int", nullable: false),
                    TranditoId = table.Column<int>(type: "int", nullable: false),
                    VehiculoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transito_Vehiculo", x => x.id);
                    table.ForeignKey(
                        name: "FK_Transito_Vehiculo_transitos_TransitoId",
                        column: x => x.TransitoId,
                        principalTable: "transitos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transito_Vehiculo_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehiculo_Servicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehiculoId = table.Column<int>(type: "int", nullable: false),
                    ServicioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehiculo_Servicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Servicio_servicios_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "servicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehiculo_Servicio_vehiculos_VehiculoId",
                        column: x => x.VehiculoId,
                        principalTable: "vehiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstadoServicio_Servicio_EstadoServicioId",
                table: "EstadoServicio_Servicio",
                column: "EstadoServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoServicio_Servicio_ServicioId",
                table: "EstadoServicio_Servicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Linea_Vehiculo_LineaId",
                table: "Linea_Vehiculo",
                column: "LineaId");

            migrationBuilder.CreateIndex(
                name: "IX_Linea_Vehiculo_VehiculoId",
                table: "Linea_Vehiculo",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Liquidacion_Servicio_LiquidacionId",
                table: "Liquidacion_Servicio",
                column: "LiquidacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Liquidacion_Servicio_ServicioId",
                table: "Liquidacion_Servicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_Vehiculo_MarcaId",
                table: "Marca_Vehiculo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_Marca_Vehiculo_VehiculoId",
                table: "Marca_Vehiculo",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recorrido_Servicio_RecorridoId",
                table: "Recorrido_Servicio",
                column: "RecorridoId");

            migrationBuilder.CreateIndex(
                name: "IX_Recorrido_Servicio_ServicioId",
                table: "Recorrido_Servicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCarroceria_Vehiculo_TipoCarroceriaId",
                table: "TipoCarroceria_Vehiculo",
                column: "TipoCarroceriaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCarroceria_Vehiculo_VehiculoId",
                table: "TipoCarroceria_Vehiculo",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Transito_Vehiculo_TransitoId",
                table: "Transito_Vehiculo",
                column: "TransitoId");

            migrationBuilder.CreateIndex(
                name: "IX_Transito_Vehiculo_VehiculoId",
                table: "Transito_Vehiculo",
                column: "VehiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Servicio_ServicioId",
                table: "Vehiculo_Servicio",
                column: "ServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_Servicio_VehiculoId",
                table: "Vehiculo_Servicio",
                column: "VehiculoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadoServicio_Servicio");

            migrationBuilder.DropTable(
                name: "Linea_Vehiculo");

            migrationBuilder.DropTable(
                name: "Liquidacion_Servicio");

            migrationBuilder.DropTable(
                name: "Marca_Vehiculo");

            migrationBuilder.DropTable(
                name: "Recorrido_Servicio");

            migrationBuilder.DropTable(
                name: "TipoCarroceria_Vehiculo");

            migrationBuilder.DropTable(
                name: "Transito_Vehiculo");

            migrationBuilder.DropTable(
                name: "Vehiculo_Servicio");
        }
    }
}
