using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Model.Migrations
{
    public partial class Abouttest123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberImage1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MemberImage2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MemberImage3",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MemberName1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MemberName2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "MemberName3",
                table: "Abouts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MemberImage1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberImage2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberImage3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberName1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberName2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberName3",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
