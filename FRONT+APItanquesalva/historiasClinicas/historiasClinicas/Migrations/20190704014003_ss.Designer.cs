﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using historiasClinicas.Models;

namespace historiasClinicas.Migrations
{
    [DbContext(typeof(HcContext))]
    [Migration("20190704014003_ss")]
    partial class ss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("historiasClinicas.Models.EnfermedadPaciente", b =>
                {
                    b.Property<int>("IdEnfermedad")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Edad");

                    b.Property<string>("Enfermedad");

                    b.Property<DateTime>("Fecha_aprox");

                    b.Property<int>("HistoriaClinicaGral");

                    b.Property<string>("Secuela");

                    b.HasKey("IdEnfermedad");

                    b.ToTable("EnfermedadPacientes");
                });

            modelBuilder.Entity("historiasClinicas.Models.InternacPaciente", b =>
                {
                    b.Property<int>("Id_internacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha_ingreso");

                    b.Property<int>("HistoriaClinicaGral");

                    b.Property<int>("Id_expediente");

                    b.Property<int>("Id_personal");

                    b.Property<string>("Imp_diagnostica");

                    b.Property<string>("Tratamiento");

                    b.HasKey("Id_internacion");

                    b.ToTable("InternacPacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
