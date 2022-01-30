using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kosorus_Arpad_Hotel.Migrations
{
    public partial class RoomModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "PetModel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "RoomID",
                table: "PetModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "PetModel",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "RoomModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetModel_RoomID",
                table: "PetModel",
                column: "RoomID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetModel_RoomModel_RoomID",
                table: "PetModel",
                column: "RoomID",
                principalTable: "RoomModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetModel_RoomModel_RoomID",
                table: "PetModel");

            migrationBuilder.DropTable(
                name: "RoomModel");

            migrationBuilder.DropIndex(
                name: "IX_PetModel_RoomID",
                table: "PetModel");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "PetModel");

            migrationBuilder.DropColumn(
                name: "RoomID",
                table: "PetModel");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "PetModel");
        }
    }
}
