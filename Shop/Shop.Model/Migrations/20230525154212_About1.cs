using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shop.Model.Migrations
{
    public partial class About1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberName1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberName2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberName3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberImage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    introduce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");
        }
    }
}
