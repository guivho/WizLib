using Microsoft.EntityFrameworkCore.Migrations;

namespace WizLib_DataAccess.Migrations
{
    public partial class AddRawCategoryToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //manually inserted statements
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES('Cay 1')");
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES('Cay 2')");
            migrationBuilder.Sql("INSERT INTO tbl_category VALUES('Cay 3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
