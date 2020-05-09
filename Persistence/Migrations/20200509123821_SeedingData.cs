using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Values",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "First value" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Values",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
