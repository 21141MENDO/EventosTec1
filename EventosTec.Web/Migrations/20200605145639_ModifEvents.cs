using Microsoft.EntityFrameworkCore.Migrations;

namespace EventosTec.Web.Migrations
{
    public partial class ModifEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Managers",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Events",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Events",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ClientId",
                table: "Events",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Clients_ClientId",
                table: "Events",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_Clients_ClientId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ClientId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Managers",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Events",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Categories_CategoryId",
                table: "Events",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
