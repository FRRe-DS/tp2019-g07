using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace historiasClinicas.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternacPaciente",
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
                    table.PrimaryKey("PK_InternacPaciente", x => x.Id_internacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternacPaciente");
        }
    }
}
