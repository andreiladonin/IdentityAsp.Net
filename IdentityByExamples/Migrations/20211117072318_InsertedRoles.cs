using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityByExamples.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "73f3751f-2e2e-4163-b6e0-e4ad4e79ecdc", "18c97018-1ae1-4554-8c69-c5a714370cc2", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8027ef96-35fb-4189-98fc-b2e5a7f111cc", "79fad6fd-2930-4584-8611-92ebc8559a6a", "Visitor", "VISITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73f3751f-2e2e-4163-b6e0-e4ad4e79ecdc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8027ef96-35fb-4189-98fc-b2e5a7f111cc");
        }
    }
}
