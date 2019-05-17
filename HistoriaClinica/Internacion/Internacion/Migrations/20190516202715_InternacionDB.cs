using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Internacion.Migrations
{
    public partial class InternacionDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InternacionPacientes",
                columns: table => new
                {
                    Id_internacion = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Id_expediente = table.Column<int>(nullable: false),
                    Id_personal = table.Column<int>(nullable: false),
                    Fecha_ingreso = table.Column<DateTime>(nullable: false),
                    Imp_diagnostica = table.Column<string>(nullable: true),
                    Tratamiento = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternacionPacientes", x => x.Id_internacion);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InternacionPacientes");
        }
    }
}
