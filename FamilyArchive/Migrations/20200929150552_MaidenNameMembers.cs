using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class MaidenNameMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaidenName",
                table: "Member",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "114bdcfb-731e-4d14-85f5-0b6559db4533", "AQAAAAEAACcQAAAAEAjVqUwEzU0b8oe+mzdDQxPmaSK/uUQZfJ9LSSPzxOSDyL//LXI5rZdDLfG96iIwJg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaidenName",
                table: "Member");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74e6c660-120c-456c-9705-e148d1148dcc", "AQAAAAEAACcQAAAAEPsADQBTm7qHPWfxQXxB8XSyu34lh1npNuHpb5VjTedONZqnKPTmYwMHCGZpj0zAiQ==" });
        }
    }
}
