using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalAlue.Migrations
{
    public partial class AjusteColaCidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Colaborador_CidadeId",
                table: "Colaborador",
                column: "CidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaborador_Cidade_CidadeId",
                table: "Colaborador",
                column: "CidadeId",
                principalTable: "Cidade",
                principalColumn: "CidadeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaborador_Cidade_CidadeId",
                table: "Colaborador");

            migrationBuilder.DropIndex(
                name: "IX_Colaborador_CidadeId",
                table: "Colaborador");
        }
    }
}
