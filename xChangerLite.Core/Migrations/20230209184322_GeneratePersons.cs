using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace xChangerLite.Core.Migrations
{
    /// <inheritdoc />
    public partial class GeneratePersons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_PersonId",
                table: "Pets",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Persons_PersonId",
                table: "Pets",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Persons_PersonId",
                table: "Pets");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Pets_PersonId",
                table: "Pets");
        }
    }
}
