using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReBrunchV1.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Restaurant = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Diet = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ReviewerId = table.Column<string>(nullable: true),
                    AuthorAddress = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IsPublished = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");
        }
    }
}
