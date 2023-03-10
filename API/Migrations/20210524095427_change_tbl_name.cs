using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class Change_tbl_name : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "TB_M_Person");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_M_Person",
                table: "TB_M_Person",
                column: "NIK");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_M_Person",
                table: "TB_M_Person");

            migrationBuilder.RenameTable(
                name: "TB_M_Person",
                newName: "Persons");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "NIK");
        }
    }
}
