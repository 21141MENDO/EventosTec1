using Microsoft.EntityFrameworkCore.Migrations;

namespace EventosTec.Web.Migrations
{
    public partial class CoregirEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Events_CityId",
                table: "Events",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Cities_CityId",
                table: "Events",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Cities_CityId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_CityId",
                table: "Events");

            migrationBuilder.AlterColumn<string>(
                name: "CityId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Events",
                nullable: true);
        }
    }
}
