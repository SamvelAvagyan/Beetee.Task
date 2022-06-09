using Microsoft.EntityFrameworkCore.Migrations;

namespace Beetee.Task.Repository.Migrations
{
    public partial class ChangeFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialSecurityNumbe",
                table: "HumanResources",
                newName: "SocialSecurityNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialSecurityNumber",
                table: "HumanResources",
                newName: "SocialSecurityNumbe");
        }
    }
}
