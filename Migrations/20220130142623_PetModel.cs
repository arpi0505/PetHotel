using Microsoft.EntityFrameworkCore.Migrations;

namespace Kosorus_Arpad_Hotel.Migrations
{
    public partial class PetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "PetModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "OwnerModel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OwnerModel", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetModel_OwnerID",
                table: "PetModel",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_PetModel_OwnerModel_OwnerID",
                table: "PetModel",
                column: "OwnerID",
                principalTable: "OwnerModel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetModel_OwnerModel_OwnerID",
                table: "PetModel");

            migrationBuilder.DropTable(
                name: "OwnerModel");

            migrationBuilder.DropIndex(
                name: "IX_PetModel_OwnerID",
                table: "PetModel");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "PetModel");
        }
    }
}
