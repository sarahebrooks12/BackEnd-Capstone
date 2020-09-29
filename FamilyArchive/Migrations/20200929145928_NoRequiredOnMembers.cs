using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyArchive.Migrations
{
    public partial class NoRequiredOnMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74e6c660-120c-456c-9705-e148d1148dcc", "AQAAAAEAACcQAAAAEPsADQBTm7qHPWfxQXxB8XSyu34lh1npNuHpb5VjTedONZqnKPTmYwMHCGZpj0zAiQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37871936-0f0f-49ce-9a84-3e41b6b72780", "AQAAAAEAACcQAAAAEL69JQOWTL3GRNiVt4e3BgfyUoVL9tDStfyu+wtn/KhC1uvBPXukJ4/8VL3lxj7gWg==" });
        }
    }
}
