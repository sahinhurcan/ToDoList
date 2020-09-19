using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoTest.Migrations
{
    public partial class iliski : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "kullanicilarID",
                table: "kullanicilars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "gorevlers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevDetay = table.Column<string>(nullable: true),
                    OlusturmaTarihi = table.Column<DateTime>(nullable: false),
                    Durumu = table.Column<int>(nullable: false),
                    Grubu = table.Column<string>(nullable: true),
                    kullaniciID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gorevlers", x => x.id);
                    table.ForeignKey(
                        name: "FK_gorevlers_kullanicilars_kullaniciID",
                        column: x => x.kullaniciID,
                        principalTable: "kullanicilars",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_kullanicilars_kullanicilarID",
                table: "kullanicilars",
                column: "kullanicilarID");

            migrationBuilder.CreateIndex(
                name: "IX_gorevlers_kullaniciID",
                table: "gorevlers",
                column: "kullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_kullanicilars_kullanicilars_kullanicilarID",
                table: "kullanicilars",
                column: "kullanicilarID",
                principalTable: "kullanicilars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_kullanicilars_kullanicilars_kullanicilarID",
                table: "kullanicilars");

            migrationBuilder.DropTable(
                name: "gorevlers");

            migrationBuilder.DropIndex(
                name: "IX_kullanicilars_kullanicilarID",
                table: "kullanicilars");

            migrationBuilder.DropColumn(
                name: "kullanicilarID",
                table: "kullanicilars");
        }
    }
}
