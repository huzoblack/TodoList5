using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Migrations
{
    public partial class added_newTodo_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Listeler",
                table: "Listeler");

            migrationBuilder.RenameTable(
                name: "Listeler",
                newName: "Listelerim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listelerim",
                table: "Listelerim",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Yapacaklarim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapacaklarim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yapiyorum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yapiyorum", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yaptim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yaptim", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Yapacaklarim");

            migrationBuilder.DropTable(
                name: "Yapiyorum");

            migrationBuilder.DropTable(
                name: "Yaptim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Listelerim",
                table: "Listelerim");

            migrationBuilder.RenameTable(
                name: "Listelerim",
                newName: "Listeler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Listeler",
                table: "Listeler",
                column: "Id");
        }
    }
}
