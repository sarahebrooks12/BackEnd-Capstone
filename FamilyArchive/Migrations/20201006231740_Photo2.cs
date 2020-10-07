using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class Photo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Photo");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Photo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44cbb237-2ea4-4a0c-8f08-cede14c8beb2", "AQAAAAEAACcQAAAAECkzHsMFyR5pW2WCHQ+s+KbVB2F+iGfFoACodGVh/EKGhq5xIAz5dW8dfp992YLnMw==", "656e0c47-0ab8-447b-9a40-079c75dade1a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Photo");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Photo",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "538d2fc9-f6ba-4302-8281-790247dff47b", "AQAAAAEAACcQAAAAELR3yPR8NPKHSD5aRaeksy0M+4q/uG6n4MIATrjRmxS8E+1HNpsC+sXPWOZ6bW621A==", null });
        }
    }
}
