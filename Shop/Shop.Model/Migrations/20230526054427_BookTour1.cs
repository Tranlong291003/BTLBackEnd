using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Model.Migrations
{
    public partial class BookTour1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTours",
                table: "BookTours");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BookTours",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "BookTours",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTours",
                table: "BookTours",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookTours",
                table: "BookTours");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BookTours");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BookTours",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookTours",
                table: "BookTours",
                column: "Name");
        }
    }
}
