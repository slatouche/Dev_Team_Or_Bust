using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_EF_Test.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestString = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    TestOtherString = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TestInt = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestModels", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestModels");
        }
    }
}
