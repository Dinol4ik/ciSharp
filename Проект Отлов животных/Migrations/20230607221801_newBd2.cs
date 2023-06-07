using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    /// <inheritdoc />
    public partial class newBd2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_type_Of_Organizations_Locality_LocalityId",
                table: "type_Of_Organizations");

            migrationBuilder.DropIndex(
                name: "IX_type_Of_Organizations_LocalityId",
                table: "type_Of_Organizations");

            migrationBuilder.DropColumn(
                name: "LocalityId",
                table: "type_Of_Organizations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocalityId",
                table: "type_Of_Organizations",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_type_Of_Organizations_LocalityId",
                table: "type_Of_Organizations",
                column: "LocalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_type_Of_Organizations_Locality_LocalityId",
                table: "type_Of_Organizations",
                column: "LocalityId",
                principalTable: "Locality",
                principalColumn: "Id");
        }
    }
}
