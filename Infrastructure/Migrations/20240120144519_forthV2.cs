using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class forthV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Mother_MotherId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_MotherId",
                table: "Child");

            migrationBuilder.AlterColumn<int>(
                name: "MotherId",
                table: "Child",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Child_MotherId",
                table: "Child",
                column: "MotherId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Mother_MotherId",
                table: "Child",
                column: "MotherId",
                principalTable: "Mother",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Mother_MotherId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_MotherId",
                table: "Child");

            migrationBuilder.AlterColumn<int>(
                name: "MotherId",
                table: "Child",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Child_MotherId",
                table: "Child",
                column: "MotherId",
                unique: true,
                filter: "[MotherId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Mother_MotherId",
                table: "Child",
                column: "MotherId",
                principalTable: "Mother",
                principalColumn: "Id");
        }
    }
}
