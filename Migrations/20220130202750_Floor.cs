using Microsoft.EntityFrameworkCore.Migrations;

namespace Kosorus_Arpad_Hotel.Migrations
{
    public partial class Floor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Floor",
                table: "RoomModel",
                maxLength: 60,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Floor",
                table: "RoomModel");
        }
    }
}
