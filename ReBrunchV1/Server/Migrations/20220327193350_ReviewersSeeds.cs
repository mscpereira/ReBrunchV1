using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace ReBrunchV1.Server.Migrations
{
    public partial class ReviewersSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Reviewers",
               columns: new[] { "Id", "FirstName", "LastName", "BirthDate", "Email", "Avatar", "JoinedDate", "Role" },
               values: new object[] { 1, "Mário", "Pereira", new DateTime(1990, 7, 4), "mario@gmail.com", "", new DateTime(2022, 1, 1), 1 });

            migrationBuilder.InsertData(
               table: "Reviewers",
               columns: new[] { "Id", "FirstName", "LastName", "BirthDate", "Email", "Avatar", "JoinedDate", "Role" },
               values: new object[] { 2, "Ana", "Serrano", new DateTime(1990, 3, 7), "ana@gmail.com", "", new DateTime(2022, 2, 23), 2 });

            migrationBuilder.InsertData(
                table: "Reviewers",
               columns: new[] { "Id", "FirstName", "LastName", "BirthDate", "Email", "Avatar", "JoinedDate", "Role" },
               values: new object[] { 3, "Ana", "Maia", new DateTime(1989, 12, 14), "maia@gmail.com", "", new DateTime(2022, 3, 1), 3 });
        }

    protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviewers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
