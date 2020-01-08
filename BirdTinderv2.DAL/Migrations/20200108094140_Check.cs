using Microsoft.EntityFrameworkCore.Migrations;

namespace BirdTinderv2.DAL.Migrations
{
    public partial class Check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BirdUser",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    UserImageUri = table.Column<string>(nullable: true),
                    UserBio = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BirdUser__1788CC4C632C9601", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "SystemUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    LastName = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Username = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Password = table.Column<string>(unicode: false, maxLength: 255, nullable: true),
                    Token = table.Column<string>(unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__User__1887C48C632236DJ", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirdUser");

            migrationBuilder.DropTable(
                name: "SystemUser");
        }
    }
}
