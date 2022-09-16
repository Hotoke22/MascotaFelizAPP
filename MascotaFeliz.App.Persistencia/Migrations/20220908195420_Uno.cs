using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotaFeliz.App.Persistencia.Migrations
{
    public partial class Uno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "idMascota",
                table: "Personas",
                newName: "IdMascota");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaVisita",
                table: "Visitas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MascotaId",
                table: "Visitas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Visitas_MascotaId",
                table: "Visitas",
                column: "MascotaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitas_Mascotas_MascotaId",
                table: "Visitas",
                column: "MascotaId",
                principalTable: "Mascotas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitas_Mascotas_MascotaId",
                table: "Visitas");

            migrationBuilder.DropIndex(
                name: "IX_Visitas_MascotaId",
                table: "Visitas");

            migrationBuilder.DropColumn(
                name: "MascotaId",
                table: "Visitas");

            migrationBuilder.RenameColumn(
                name: "IdMascota",
                table: "Personas",
                newName: "idMascota");

            migrationBuilder.AlterColumn<string>(
                name: "FechaVisita",
                table: "Visitas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
