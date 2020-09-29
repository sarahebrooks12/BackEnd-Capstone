using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class PleaseWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6041f715-5bfb-4ca1-bb86-2756c5928b3b", "AQAAAAEAACcQAAAAEFSHRGtL2pfL09A1DQLxuLb8vgtuzITKRei/QMlHKqX02tO+ycTFrjVE8p1QleyEGA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "114bdcfb-731e-4d14-85f5-0b6559db4533", "AQAAAAEAACcQAAAAEAjVqUwEzU0b8oe+mzdDQxPmaSK/uUQZfJ9LSSPzxOSDyL//LXI5rZdDLfG96iIwJg==" });
        }
    }
}
