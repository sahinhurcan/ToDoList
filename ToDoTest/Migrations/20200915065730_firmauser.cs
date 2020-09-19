using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoTest.Migrations
{
    public partial class firmauser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_gorevlers_Firmalars_FirmaID",
                table: "gorevlers");

            migrationBuilder.DropForeignKey(
                name: "FK_gorevlers_kullanicilars_kullaniciID",
                table: "gorevlers");

            migrationBuilder.DropForeignKey(
                name: "FK_kullanicilars_kullanicilars_kullanicilarID",
                table: "kullanicilars");

            migrationBuilder.DropIndex(
                name: "IX_kullanicilars_kullanicilarID",
                table: "kullanicilars");

            migrationBuilder.DropIndex(
                name: "IX_gorevlers_FirmaID",
                table: "gorevlers");

            migrationBuilder.DropIndex(
                name: "IX_gorevlers_kullaniciID",
                table: "gorevlers");

            migrationBuilder.DropColumn(
                name: "kullanicilarID",
                table: "kullanicilars");

            migrationBuilder.DropColumn(
                name: "FirmaID",
                table: "gorevlers");

            migrationBuilder.RenameColumn(
                name: "kullaniciID",
                table: "gorevlers",
                newName: "KullaniciID");

            migrationBuilder.AlterColumn<string>(
                name: "KullaniciID",
                table: "gorevlers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Firma",
                table: "gorevlers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Firma",
                table: "gorevlers");

            migrationBuilder.RenameColumn(
                name: "KullaniciID",
                table: "gorevlers",
                newName: "kullaniciID");

            migrationBuilder.AddColumn<int>(
                name: "kullanicilarID",
                table: "kullanicilars",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "kullaniciID",
                table: "gorevlers",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FirmaID",
                table: "gorevlers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_kullanicilars_kullanicilarID",
                table: "kullanicilars",
                column: "kullanicilarID");

            migrationBuilder.CreateIndex(
                name: "IX_gorevlers_FirmaID",
                table: "gorevlers",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_gorevlers_kullaniciID",
                table: "gorevlers",
                column: "kullaniciID");

            migrationBuilder.AddForeignKey(
                name: "FK_gorevlers_Firmalars_FirmaID",
                table: "gorevlers",
                column: "FirmaID",
                principalTable: "Firmalars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_gorevlers_kullanicilars_kullaniciID",
                table: "gorevlers",
                column: "kullaniciID",
                principalTable: "kullanicilars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_kullanicilars_kullanicilars_kullanicilarID",
                table: "kullanicilars",
                column: "kullanicilarID",
                principalTable: "kullanicilars",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
