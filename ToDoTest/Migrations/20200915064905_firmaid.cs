using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoTest.Migrations
{
    public partial class firmaid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grubu",
                table: "gorevlers");

            migrationBuilder.AddColumn<int>(
                name: "FirmaID",
                table: "gorevlers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_gorevlers_FirmaID",
                table: "gorevlers",
                column: "FirmaID");

            migrationBuilder.AddForeignKey(
                name: "FK_gorevlers_Firmalars_FirmaID",
                table: "gorevlers",
                column: "FirmaID",
                principalTable: "Firmalars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gorevlers_Firmalars_FirmaID",
                table: "gorevlers");

            migrationBuilder.DropIndex(
                name: "IX_gorevlers_FirmaID",
                table: "gorevlers");

            migrationBuilder.DropColumn(
                name: "FirmaID",
                table: "gorevlers");

            migrationBuilder.AddColumn<string>(
                name: "Grubu",
                table: "gorevlers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
