using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClinicSystem.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    NumMatricula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Especialidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.NumMatricula);
                });

            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    NumHistoriaClinica = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.NumHistoriaClinica);
                });

            migrationBuilder.CreateTable(
                name: "Tipos",
                columns: table => new
                {
                    TipoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos", x => x.TipoId);
                });

            migrationBuilder.CreateTable(
                name: "Consultas",
                columns: table => new
                {
                    ConsultaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumMatricula = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NumHistoriaClinica = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TipoId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Costo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostoMatDescartable = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultas", x => x.ConsultaId);
                    table.ForeignKey(
                        name: "FK_Consultas_Medicos_NumMatricula",
                        column: x => x.NumMatricula,
                        principalTable: "Medicos",
                        principalColumn: "NumMatricula",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultas_Pacientes_NumHistoriaClinica",
                        column: x => x.NumHistoriaClinica,
                        principalTable: "Pacientes",
                        principalColumn: "NumHistoriaClinica",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Consultas_Tipos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "Tipos",
                        principalColumn: "TipoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "NumMatricula", "Especialidad", "IsActive", "Nombre" },
                values: new object[,]
                {
                    { "123456", "Pediatria", true, "Juan Achaval" },
                    { "123457", "Neurologia", true, "Agus Repetto" },
                    { "123458", "Odontologia", true, "Lautaro Diaz" },
                    { "123459", "Oftalmologia", true, "Felipe Gonzales" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "NumHistoriaClinica", "IsActive", "Nombre" },
                values: new object[,]
                {
                    { "9876541", true, "Humberto Gorosito" },
                    { "9876542", true, "Gustavo Gustavino" },
                    { "9876543", true, "Hernando Hernandez" },
                    { "9876544", true, "Diego Torrado" },
                    { "9876545", true, "Facundo Niembro" }
                });

            migrationBuilder.InsertData(
                table: "Tipos",
                columns: new[] { "TipoId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Consultorio" },
                    { 2, "Practica Medica" }
                });

            migrationBuilder.InsertData(
                table: "Consultas",
                columns: new[] { "ConsultaId", "Active", "Costo", "CostoMatDescartable", "Descripcion", "Fecha", "NumHistoriaClinica", "NumMatricula", "TipoId" },
                values: new object[,]
                {
                    { 1, true, 1550.50m, 0m, "Consulta Pediatria", new DateTime(2022, 3, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876541", "123456", 1 },
                    { 2, true, 1550.50m, 0m, "Consulta Neuro", new DateTime(2022, 3, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876542", "123457", 1 },
                    { 3, true, 1550.50m, 0m, "Consulta Odonto", new DateTime(2022, 3, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876543", "123458", 1 },
                    { 4, true, 1550.50m, 0m, "Consulta Oftalmo", new DateTime(2022, 3, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876544", "123459", 1 },
                    { 5, true, 1550.50m, 1550.50m, "P.M. Pediatria", new DateTime(2022, 4, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876541", "123456", 2 },
                    { 6, true, 1550.50m, 1550.50m, "P.M. Neuro", new DateTime(2022, 4, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876542", "123457", 2 },
                    { 7, true, 1550.50m, 1550.50m, "P.M. Odonto", new DateTime(2022, 4, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876543", "123458", 2 },
                    { 8, true, 1550.50m, 1550.50m, "P.M. Oftalmo", new DateTime(2022, 4, 30, 12, 10, 15, 0, DateTimeKind.Unspecified), "9876544", "123459", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_NumHistoriaClinica",
                table: "Consultas",
                column: "NumHistoriaClinica");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_NumMatricula",
                table: "Consultas",
                column: "NumMatricula");

            migrationBuilder.CreateIndex(
                name: "IX_Consultas_TipoId",
                table: "Consultas",
                column: "TipoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Consultas");

            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropTable(
                name: "Pacientes");

            migrationBuilder.DropTable(
                name: "Tipos");
        }
    }
}
