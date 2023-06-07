using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    /// <inheritdoc />
    public partial class newBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Locality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Adress = table.Column<string>(type: "text", nullable: true),
                    Administration = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locality", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<string>(type: "text", nullable: true),
                    number = table.Column<int>(type: "integer", nullable: true),
                    Kategory = table.Column<string>(type: "text", nullable: true),
                    AnimalHabitat = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    UrgencyOfExecution = table.Column<bool>(type: "boolean", nullable: true),
                    LocalityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Applications_Locality_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Locality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "type_Of_Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    LocalityId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_Of_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_type_Of_Organizations_Locality_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Locality",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "card_Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Kategory = table.Column<long>(type: "bigint", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Breed = table.Column<string>(type: "text", nullable: true),
                    Color = table.Column<string>(type: "text", nullable: true),
                    Ears = table.Column<string>(type: "text", nullable: true),
                    Tail = table.Column<string>(type: "text", nullable: true),
                    Special_signs = table.Column<string>(type: "text", nullable: true),
                    Indentification_label = table.Column<string>(type: "text", nullable: true),
                    Chip_number = table.Column<string>(type: "text", nullable: true),
                    ApplicationId = table.Column<int>(type: "integer", nullable: false),
                    LocalityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_card_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_card_Animals_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_card_Animals_Locality_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Locality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    INN = table.Column<string>(type: "text", nullable: true),
                    KPP = table.Column<string>(type: "text", nullable: true),
                    Registation_addres = table.Column<string>(type: "text", nullable: true),
                    Sole_Properietor = table.Column<string>(type: "text", nullable: true),
                    LocalityId = table.Column<int>(type: "integer", nullable: false),
                    TypeOfId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_organizations_Locality_LocalityId",
                        column: x => x.LocalityId,
                        principalTable: "Locality",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_organizations_type_Of_Organizations_TypeOfId",
                        column: x => x.TypeOfId,
                        principalTable: "type_Of_Organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "municipal_Contracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<long>(type: "bigint", nullable: true),
                    Date_Of_Action = table.Column<string>(type: "text", nullable: true),
                    Date_Of_Conclusion = table.Column<string>(type: "text", nullable: true),
                    OrganizationId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipal_Contracts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipal_Contracts_organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "organizations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true),
                    OrganizationId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_organizations_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "organizations",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Applications_LocalityId",
                table: "Applications",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_card_Animals_ApplicationId",
                table: "card_Animals",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_card_Animals_LocalityId",
                table: "card_Animals",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_municipal_Contracts_OrganizationId",
                table: "municipal_Contracts",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_organizations_LocalityId",
                table: "organizations",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_organizations_TypeOfId",
                table: "organizations",
                column: "TypeOfId");

            migrationBuilder.CreateIndex(
                name: "IX_type_Of_Organizations_LocalityId",
                table: "type_Of_Organizations",
                column: "LocalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "act_Of_Captures");

            migrationBuilder.DropTable(
                name: "card_Animals");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "municipal_Contracts");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "organizations");

            migrationBuilder.DropTable(
                name: "type_Of_Organizations");

            migrationBuilder.DropTable(
                name: "Locality");
        }
    }
}
