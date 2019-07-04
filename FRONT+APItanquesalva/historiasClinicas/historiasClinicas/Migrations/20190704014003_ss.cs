using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace historiasClinicas.Migrations
{
    public partial class ss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnfermedadPacientes",
                columns: table => new
                {
                    IdEnfermedad = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Enfermedad = table.Column<string>(nullable: true),
                    Edad = table.Column<string>(nullable: true),
                    Fecha_aprox = table.Column<DateTime>(nullable: false),
                    Secuela = table.Column<string>(nullable: true),
                    HistoriaClinicaGral = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnfermedadPacientes", x => x.IdEnfermedad);
                });

            migrationBuilder.CreateTable(
                name: "InternacPacientes",
                columns: table => new
                {
                    Id_internacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_expediente = table.Column<int>(nullable: false),
                    Id_personal = table.Column<int>(nullable: false),
                    Fecha_ingreso = table.Column<DateTime>(nullable: false),
                    Imp_diagnostica = table.Column<string>(nullable: true),
                    Tratamiento = table.Column<string>(nullable: true),
                    HistoriaClinicaGral = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternacPacientes", x => x.Id_internacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EnfermedadPacientes");

            migrationBuilder.DropTable(
                name: "InternacPacientes");
        }
    }
}
