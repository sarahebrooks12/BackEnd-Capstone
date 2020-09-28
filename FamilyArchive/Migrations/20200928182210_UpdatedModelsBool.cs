using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class UpdatedModelsBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isAnniversary",
                table: "Member",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDied",
                table: "Member",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isNickName",
                table: "Member",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08a03f17-6125-45ba-956a-e0bb9267d408", "AQAAAAEAACcQAAAAEMD+ih/QRJOZdmB7VEPreHVQLrovlrXh5qDSVW4W7nPMH0D3ajdFlQBVSPA0LZ/Lew==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isAnniversary",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "isDied",
                table: "Member");

            migrationBuilder.DropColumn(
                name: "isNickName",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37c3bdec-e95f-4010-a0b6-00b9290af3e5", "AQAAAAEAACcQAAAAEKiAp7cNqYJkfgkoh/crgzPUli4bpVIuEEFVanZEh66whkkfseGGtjpIy7c0XSUDQw==" });
        }
    }
}
