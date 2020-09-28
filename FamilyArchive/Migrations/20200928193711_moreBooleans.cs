using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class moreBooleans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isMaidenName",
                table: "Member",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37871936-0f0f-49ce-9a84-3e41b6b72780", "AQAAAAEAACcQAAAAEL69JQOWTL3GRNiVt4e3BgfyUoVL9tDStfyu+wtn/KhC1uvBPXukJ4/8VL3lxj7gWg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isMaidenName",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08a03f17-6125-45ba-956a-e0bb9267d408", "AQAAAAEAACcQAAAAEMD+ih/QRJOZdmB7VEPreHVQLrovlrXh5qDSVW4W7nPMH0D3ajdFlQBVSPA0LZ/Lew==" });
        }
    }
}
