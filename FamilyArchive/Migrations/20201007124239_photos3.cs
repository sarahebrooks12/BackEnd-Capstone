using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class photos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94cc22a9-98c3-4977-bee0-a866d4c45e9b", "AQAAAAEAACcQAAAAEJtcD6ekoVV5fBpAxQcQ+/irBeaktfwrSCzy4XlajD00PHW0Q1qDurLp7FvfCmsCBQ==", "772dc7a9-89f4-4ae4-83fc-baf28637a88f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb64645c-62e0-41e0-a8d4-d082ec5b2984", "AQAAAAEAACcQAAAAEDCLphhYSZuYoyb5v/LB2OVO0Kh2pDQufoGGr7hruoLhXXM6Ed0pKmj6JEsrYminZQ==", "ad12be7a-e9f6-4009-92c2-e40dc656a56f" });
        }
    }
}
