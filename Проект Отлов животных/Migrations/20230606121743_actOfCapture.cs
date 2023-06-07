using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    /// <inheritdoc />
    public partial class actOfCapture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "act_Of_Captures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Act_Number = table.Column<long>(type: "bigint", nullable: true),
                    Amount_Of_Dogs = table.Column<string>(type: "text", nullable: true),
                    Amount_Of_Cats = table.Column<string>(type: "text", nullable: true),
                    Amount_Of_Animals = table.Column<string>(type: "text", nullable: true),
                    Date_Of_Capture = table.Column<string>(type: "text", nullable: true),
                    Target = table.Column<string>(type: "text", nullable: true),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false),
                    ApplicationId = table.Column<int>(type: "integer", nullable: false),
                    Municipal_ContractId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_act_Of_Captures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_act_Of_Captures_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_act_Of_Captures_municipal_Contracts_Municipal_ContractId",
                        column: x => x.Municipal_ContractId,
                        principalTable: "municipal_Contracts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_act_Of_Captures_organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_act_Of_Captures_ApplicationId",
                table: "act_Of_Captures",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_act_Of_Captures_Municipal_ContractId",
                table: "act_Of_Captures",
                column: "Municipal_ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_act_Of_Captures_OrganizationId",
                table: "act_Of_Captures",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "act_Of_Captures");
        }
    }
}
