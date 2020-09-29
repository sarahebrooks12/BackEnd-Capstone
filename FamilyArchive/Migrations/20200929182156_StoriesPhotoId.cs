using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class StoriesPhotoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhotoId",
                table: "Story",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb31f4a4-29d0-46be-b1ef-42e73b0769ed", "AQAAAAEAACcQAAAAEKmE02DhcHZr0tVFa+wqf5m38NLyPmdTtw5koBDbd6kc5e6bGUhp/f4bcmsanBq2ZQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_Story_PhotoId",
                table: "Story",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Story_Photo_PhotoId",
                table: "Story",
                column: "PhotoId",
                principalTable: "Photo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Story_Photo_PhotoId",
                table: "Story");

            migrationBuilder.DropIndex(
                name: "IX_Story_PhotoId",
                table: "Story");

            migrationBuilder.DropColumn(
                name: "PhotoId",
                table: "Story");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "aea79185-aa33-4e41-b946-9b09d4424f9c", "AQAAAAEAACcQAAAAECREvbgSm3FXqscI5752FeMsYT/H9+2iD+q3Tdg+NN+0dYz5LVv77HWFaqIQDwqT9g==" });
        }
    }
}
