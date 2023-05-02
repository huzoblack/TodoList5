using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    public partial class added_TodoList_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Listelerim",
                table: "Listelerim");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Listelerim");

            migrationBuilder.RenameTable(
                name: "Listelerim",
                newName: "Listeler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listeler",
                table: "Listeler",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Listeler",
                table: "Listeler");

            migrationBuilder.RenameTable(
                name: "Listeler",
                newName: "Listelerim");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Listelerim",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listelerim",
                table: "Listelerim",
                column: "Id");
        }
    }
}
