using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Data.Migrations
{
    public partial class createTableAgendamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agendamentos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    solicitacaoId = table.Column<int>(type: "integer", nullable: true),
                    motorista = table.Column<string>(type: "text", nullable: true),
                    placa = table.Column<string>(type: "text", nullable: true),
                    pesoMax = table.Column<decimal>(type: "numeric", nullable: false),
                    diaColeta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agendamentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_agendamentos_solicitacaos_solicitacaoId",
                        column: x => x.solicitacaoId,
                        principalTable: "solicitacaos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_agendamentos_solicitacaoId",
                table: "agendamentos",
                column: "solicitacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "agendamentos");
        }
    }
}
