using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class RemovedDateCreatedPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Photo");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e61c0ed3-01fc-4b53-82b9-92d39c624e86", "AQAAAAEAACcQAAAAELDjzDG0lOyVNaSiIuUfL9gUfTNfDuYxefppNZk+LNfRgKYBYo9RICrROPHXatUl8g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Photo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb31f4a4-29d0-46be-b1ef-42e73b0769ed", "AQAAAAEAACcQAAAAEKmE02DhcHZr0tVFa+wqf5m38NLyPmdTtw5koBDbd6kc5e6bGUhp/f4bcmsanBq2ZQ==" });
        }
    }
}
