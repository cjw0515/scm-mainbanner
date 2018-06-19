using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace scm_mainbanner.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "banners",
                columns: table => new
                {
                    idx = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    bannerImageUrl = table.Column<string>(nullable: true),
                    gubun = table.Column<int>(nullable: false),
                    contentType = table.Column<int>(nullable: false),
                    linkType = table.Column<byte>(nullable: false),
                    releaseCycle = table.Column<int>(nullable: false),
                    startDate = table.Column<string>(nullable: true),
                    endDate = table.Column<string>(nullable: true),
                    isUsing = table.Column<string>(nullable: false),
                    priority = table.Column<int>(nullable: false),
                    registrant = table.Column<string>(nullable: true),
                    worker = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banners", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "banners");
        }
    }
}
