using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class UpdatePhoto1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Photo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Photo",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "538d2fc9-f6ba-4302-8281-790247dff47b", "AQAAAAEAACcQAAAAELR3yPR8NPKHSD5aRaeksy0M+4q/uG6n4MIATrjRmxS8E+1HNpsC+sXPWOZ6bW621A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Photo");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e61c0ed3-01fc-4b53-82b9-92d39c624e86", "AQAAAAEAACcQAAAAELDjzDG0lOyVNaSiIuUfL9gUfTNfDuYxefppNZk+LNfRgKYBYo9RICrROPHXatUl8g==" });
        }
    }
}
