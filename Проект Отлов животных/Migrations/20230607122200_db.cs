using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Проект_Отлов_животных.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_Animal_Applications_ApplicationId",
                table: "Card_Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_Animal_Locality_LocalityId",
                table: "Card_Animal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card_Animal",
                table: "Card_Animal");

            migrationBuilder.RenameTable(
                name: "Card_Animal",
                newName: "card_Animals");

            migrationBuilder.RenameIndex(
                name: "IX_Card_Animal_LocalityId",
                table: "card_Animals",
                newName: "IX_card_Animals_LocalityId");

            migrationBuilder.RenameIndex(
                name: "IX_Card_Animal_ApplicationId",
                table: "card_Animals",
                newName: "IX_card_Animals_ApplicationId");

            migrationBuilder.AddColumn<int>(
                name: "number",
                table: "Applications",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_card_Animals",
                table: "card_Animals",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_card_Animals_Applications_ApplicationId",
                table: "card_Animals",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_card_Animals_Locality_LocalityId",
                table: "card_Animals",
                column: "LocalityId",
                principalTable: "Locality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_card_Animals_Applications_ApplicationId",
                table: "card_Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_card_Animals_Locality_LocalityId",
                table: "card_Animals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_card_Animals",
                table: "card_Animals");

            migrationBuilder.DropColumn(
                name: "number",
                table: "Applications");

            migrationBuilder.RenameTable(
                name: "card_Animals",
                newName: "Card_Animal");

            migrationBuilder.RenameIndex(
                name: "IX_card_Animals_LocalityId",
                table: "Card_Animal",
                newName: "IX_Card_Animal_LocalityId");

            migrationBuilder.RenameIndex(
                name: "IX_card_Animals_ApplicationId",
                table: "Card_Animal",
                newName: "IX_Card_Animal_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card_Animal",
                table: "Card_Animal",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Animal_Applications_ApplicationId",
                table: "Card_Animal",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Card_Animal_Locality_LocalityId",
                table: "Card_Animal",
                column: "LocalityId",
                principalTable: "Locality",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
