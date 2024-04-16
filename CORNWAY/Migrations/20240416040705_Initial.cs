using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CORNWAY.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arma",
                columns: table => new
                {
                    ArmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Daño = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arma", x => x.ArmaId);
                });

            migrationBuilder.CreateTable(
                name: "Enemigo",
                columns: table => new
                {
                    EnemigoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Daño = table.Column<int>(type: "int", nullable: false),
                    Recompensa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enemigo", x => x.EnemigoId);
                });

            migrationBuilder.CreateTable(
                name: "Fertilizante",
                columns: table => new
                {
                    FertiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizante", x => x.FertiId);
                });

            migrationBuilder.CreateTable(
                name: "Herramienta",
                columns: table => new
                {
                    HerramientaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herramienta", x => x.HerramientaId);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Daño = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.MascotaId);
                });

            migrationBuilder.CreateTable(
                name: "Semilla",
                columns: table => new
                {
                    SemillaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiempoCrecimiento = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semilla", x => x.SemillaId);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    SensorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.SensorId);
                });

            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Dinero = table.Column<int>(type: "int", nullable: false),
                    Maiz = table.Column<int>(type: "int", nullable: false),
                    EnemigoId = table.Column<int>(type: "int", nullable: false),
                    MascotaId = table.Column<int>(type: "int", nullable: false),
                    ArmaId = table.Column<int>(type: "int", nullable: false),
                    HerramientaId = table.Column<int>(type: "int", nullable: false),
                    SemillaId = table.Column<int>(type: "int", nullable: false),
                    FertiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personaje_Arma_ArmaId",
                        column: x => x.ArmaId,
                        principalTable: "Arma",
                        principalColumn: "ArmaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personaje_Enemigo_EnemigoId",
                        column: x => x.EnemigoId,
                        principalTable: "Enemigo",
                        principalColumn: "EnemigoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personaje_Fertilizante_FertiId",
                        column: x => x.FertiId,
                        principalTable: "Fertilizante",
                        principalColumn: "FertiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personaje_Herramienta_HerramientaId",
                        column: x => x.HerramientaId,
                        principalTable: "Herramienta",
                        principalColumn: "HerramientaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personaje_Mascota_MascotaId",
                        column: x => x.MascotaId,
                        principalTable: "Mascota",
                        principalColumn: "MascotaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personaje_Semilla_SemillaId",
                        column: x => x.SemillaId,
                        principalTable: "Semilla",
                        principalColumn: "SemillaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terreno",
                columns: table => new
                {
                    TerrenoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Humedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperatura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SensorId = table.Column<int>(type: "int", nullable: false),
                    FertiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terreno", x => x.TerrenoId);
                    table.ForeignKey(
                        name: "FK_Terreno_Fertilizante_FertiId",
                        column: x => x.FertiId,
                        principalTable: "Fertilizante",
                        principalColumn: "FertiId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Terreno_Sensor_SensorId",
                        column: x => x.SensorId,
                        principalTable: "Sensor",
                        principalColumn: "SensorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_ArmaId",
                table: "Personaje",
                column: "ArmaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_EnemigoId",
                table: "Personaje",
                column: "EnemigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_FertiId",
                table: "Personaje",
                column: "FertiId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_HerramientaId",
                table: "Personaje",
                column: "HerramientaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_MascotaId",
                table: "Personaje",
                column: "MascotaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_SemillaId",
                table: "Personaje",
                column: "SemillaId");

            migrationBuilder.CreateIndex(
                name: "IX_Terreno_FertiId",
                table: "Terreno",
                column: "FertiId");

            migrationBuilder.CreateIndex(
                name: "IX_Terreno_SensorId",
                table: "Terreno",
                column: "SensorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personaje");

            migrationBuilder.DropTable(
                name: "Terreno");

            migrationBuilder.DropTable(
                name: "Arma");

            migrationBuilder.DropTable(
                name: "Enemigo");

            migrationBuilder.DropTable(
                name: "Herramienta");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Semilla");

            migrationBuilder.DropTable(
                name: "Fertilizante");

            migrationBuilder.DropTable(
                name: "Sensor");
        }
    }
}
