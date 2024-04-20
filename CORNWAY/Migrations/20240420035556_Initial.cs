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
                name: "Enemigo",
                columns: table => new
                {
                    EnemigoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Daño = table.Column<int>(type: "int", nullable: false),
                    Recompenza = table.Column<int>(type: "int", nullable: false)
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
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fertilizante", x => x.FertiId);
                });

            migrationBuilder.CreateTable(
                name: "Personaje",
                columns: table => new
                {
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Dinero = table.Column<int>(type: "int", nullable: false),
                    Maiz = table.Column<int>(type: "int", nullable: false),
                    EnemigoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personaje", x => x.PersonajeId);
                    table.ForeignKey(
                        name: "FK_Personaje_Enemigo_EnemigoId",
                        column: x => x.EnemigoId,
                        principalTable: "Enemigo",
                        principalColumn: "EnemigoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Arma",
                columns: table => new
                {
                    ArmaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Daño = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arma", x => x.ArmaId);
                    table.ForeignKey(
                        name: "FK_Arma_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Herramienta",
                columns: table => new
                {
                    HerramientaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Herramienta", x => x.HerramientaId);
                    table.ForeignKey(
                        name: "FK_Herramienta_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mascota",
                columns: table => new
                {
                    MascotaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vida = table.Column<int>(type: "int", nullable: false),
                    Daño = table.Column<int>(type: "int", nullable: false),
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascota", x => x.MascotaId);
                    table.ForeignKey(
                        name: "FK_Mascota_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semilla",
                columns: table => new
                {
                    SemillaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TiempoCrecimiento = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false),
                    PersonajeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semilla", x => x.SemillaId);
                    table.ForeignKey(
                        name: "FK_Semilla_Personaje_PersonajeId",
                        column: x => x.PersonajeId,
                        principalTable: "Personaje",
                        principalColumn: "PersonajeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Terreno",
                columns: table => new
                {
                    TerrenoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Humedad = table.Column<int>(type: "int", nullable: false),
                    Temperatura = table.Column<int>(type: "int", nullable: false),
                    FertiId = table.Column<int>(type: "int", nullable: false),
                    SemillaId = table.Column<int>(type: "int", nullable: false)
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
                        name: "FK_Terreno_Semilla_SemillaId",
                        column: x => x.SemillaId,
                        principalTable: "Semilla",
                        principalColumn: "SemillaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sensor",
                columns: table => new
                {
                    SensorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TerrenoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sensor", x => x.SensorId);
                    table.ForeignKey(
                        name: "FK_Sensor_Terreno_TerrenoId",
                        column: x => x.TerrenoId,
                        principalTable: "Terreno",
                        principalColumn: "TerrenoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arma_PersonajeId",
                table: "Arma",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Herramienta_PersonajeId",
                table: "Herramienta",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascota_PersonajeId",
                table: "Mascota",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personaje_EnemigoId",
                table: "Personaje",
                column: "EnemigoId");

            migrationBuilder.CreateIndex(
                name: "IX_Semilla_PersonajeId",
                table: "Semilla",
                column: "PersonajeId");

            migrationBuilder.CreateIndex(
                name: "IX_Sensor_TerrenoId",
                table: "Sensor",
                column: "TerrenoId");

            migrationBuilder.CreateIndex(
                name: "IX_Terreno_FertiId",
                table: "Terreno",
                column: "FertiId");

            migrationBuilder.CreateIndex(
                name: "IX_Terreno_SemillaId",
                table: "Terreno",
                column: "SemillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arma");

            migrationBuilder.DropTable(
                name: "Herramienta");

            migrationBuilder.DropTable(
                name: "Mascota");

            migrationBuilder.DropTable(
                name: "Sensor");

            migrationBuilder.DropTable(
                name: "Terreno");

            migrationBuilder.DropTable(
                name: "Fertilizante");

            migrationBuilder.DropTable(
                name: "Semilla");

            migrationBuilder.DropTable(
                name: "Personaje");

            migrationBuilder.DropTable(
                name: "Enemigo");
        }
    }
}
