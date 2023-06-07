using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    /// <inheritdoc />
    public partial class fixBd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_organizations_Locality_TypeOfId",
                table: "organizations");

            migrationBuilder.AddForeignKey(
                name: "FK_organizations_type_Of_Organizations_TypeOfId",
                table: "organizations",
                column: "TypeOfId",
                principalTable: "type_Of_Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_organizations_type_Of_Organizations_TypeOfId",
                table: "organizations");

            migrationBuilder.AddForeignKey(
                name: "FK_organizations_Locality_TypeOfId",
                table: "organizations",
                column: "TypeOfId",
                principalTable: "Locality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
