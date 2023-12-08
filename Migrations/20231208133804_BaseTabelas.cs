using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalAlue.Migrations
{
    public partial class BaseTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colaborador",
                columns: table => new
                {
                    ColaboradorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColaboradorNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColaboradorCpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColaboradorSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColaboradorTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaborador", x => x.ColaboradorId);
                });

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.EstadoId);
                });

            migrationBuilder.CreateTable(
                name: "TipoColaborador",
                columns: table => new
                {
                    TipoColaboradorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoColaboradorNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoColaborador", x => x.TipoColaboradorId);
                });

            migrationBuilder.CreateTable(
                name: "TipoProcedimento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoProcedimentoNome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoProcedimento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CidadeNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.CidadeId);
                    table.ForeignKey(
                        name: "FK_Cidade_Estado_EstadoId",
                        column: x => x.EstadoId,
                        principalTable: "Estado",
                        principalColumn: "EstadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Procedimentos",
                columns: table => new
                {
                    ProcedimentosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcedimentoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcedimentoObservacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProcedimentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procedimentos", x => x.ProcedimentosId);
                    table.ForeignKey(
                        name: "FK_Procedimentos_TipoProcedimento_TipoProcedimentoId",
                        column: x => x.TipoProcedimentoId,
                        principalTable: "TipoProcedimento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteCpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteSexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteTelefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteEndereço = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClienteNumero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Cliente_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalRealizacao",
                columns: table => new
                {
                    LocalRealizacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalRealizacaoNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalRealizacao", x => x.LocalRealizacaoId);
                    table.ForeignKey(
                        name: "FK_LocalRealizacao_Cidade_CidadeId",
                        column: x => x.CidadeId,
                        principalTable: "Cidade",
                        principalColumn: "CidadeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProcedimentosRealizados",
                columns: table => new
                {
                    ProcedimentosRealizadosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    ProcedimentosId = table.Column<int>(type: "int", nullable: true),
                    ColaboradorId = table.Column<int>(type: "int", nullable: true),
                    LocalRealizacaoId = table.Column<int>(type: "int", nullable: true),
                    DataRealizadoId = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObservacaoRealizadoId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcedimentosRealizados", x => x.ProcedimentosRealizadosId);
                    table.ForeignKey(
                        name: "FK_ProcedimentosRealizados_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId");
                    table.ForeignKey(
                        name: "FK_ProcedimentosRealizados_Colaborador_ColaboradorId",
                        column: x => x.ColaboradorId,
                        principalTable: "Colaborador",
                        principalColumn: "ColaboradorId");
                    table.ForeignKey(
                        name: "FK_ProcedimentosRealizados_LocalRealizacao_LocalRealizacaoId",
                        column: x => x.LocalRealizacaoId,
                        principalTable: "LocalRealizacao",
                        principalColumn: "LocalRealizacaoId");
                    table.ForeignKey(
                        name: "FK_ProcedimentosRealizados_Procedimentos_ProcedimentosId",
                        column: x => x.ProcedimentosId,
                        principalTable: "Procedimentos",
                        principalColumn: "ProcedimentosId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_EstadoId",
                table: "Cidade",
                column: "EstadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CidadeId",
                table: "Cliente",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalRealizacao_CidadeId",
                table: "LocalRealizacao",
                column: "CidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Procedimentos_TipoProcedimentoId",
                table: "Procedimentos",
                column: "TipoProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentosRealizados_ClienteId",
                table: "ProcedimentosRealizados",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentosRealizados_ColaboradorId",
                table: "ProcedimentosRealizados",
                column: "ColaboradorId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentosRealizados_LocalRealizacaoId",
                table: "ProcedimentosRealizados",
                column: "LocalRealizacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProcedimentosRealizados_ProcedimentosId",
                table: "ProcedimentosRealizados",
                column: "ProcedimentosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProcedimentosRealizados");

            migrationBuilder.DropTable(
                name: "TipoColaborador");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Colaborador");

            migrationBuilder.DropTable(
                name: "LocalRealizacao");

            migrationBuilder.DropTable(
                name: "Procedimentos");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "TipoProcedimento");

            migrationBuilder.DropTable(
                name: "Estado");
        }
    }
}
