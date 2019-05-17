using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CapaAccesoAntecedentes.Migrations
{
    public partial class AntDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoAntecedentes",
                columns: table => new
                {
                    IdTipoAnt = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomTipoAnt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoAntecedentes", x => x.IdTipoAnt);
                });

            migrationBuilder.CreateTable(
                name: "EltoAntEvaluars",
                columns: table => new
                {
                    IdEltoAntEvaluar = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NombreEltoEvaluar = table.Column<string>(nullable: true),
                    EstadoEltoEvaluar = table.Column<bool>(nullable: false),
                    Observacion = table.Column<string>(nullable: true),
                    IdInternacion = table.Column<int>(nullable: false),
                    TipoAntecedenteIdTipoAnt = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EltoAntEvaluars", x => x.IdEltoAntEvaluar);
                    table.ForeignKey(
                        name: "FK_EltoAntEvaluars_TipoAntecedentes_TipoAntecedenteIdTipoAnt",
                        column: x => x.TipoAntecedenteIdTipoAnt,
                        principalTable: "TipoAntecedentes",
                        principalColumn: "IdTipoAnt",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EltoAntEvaluars_TipoAntecedenteIdTipoAnt",
                table: "EltoAntEvaluars",
                column: "TipoAntecedenteIdTipoAnt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EltoAntEvaluars");

            migrationBuilder.DropTable(
                name: "TipoAntecedentes");
        }
    }
}
