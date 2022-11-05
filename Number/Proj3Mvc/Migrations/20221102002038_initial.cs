using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proj3Mvc.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SonEntitylar",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<long>(type: "INTEGER", nullable: false),
                    Ifoda = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SonEntitylar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 1L, " bir", 1L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 2L, " ikki", 2L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 3L, " uch", 3L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 4L, " to'rt", 4L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 5L, " besh", 5L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 6L, " olti", 6L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 7L, " yetti", 7L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 8L, " sakkiz", 8L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 9L, " to'qqiz", 9L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 10L, " o'n", 10L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 20L, " yigirma", 20L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 30L, " o'ttiz", 30L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 40L, " qirq", 40L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 50L, " ellik", 50L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 60L, " oltmish", 60L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 70L, " yetmish", 70L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 80L, " sakson", 80L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 90L, " to'qson", 90L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 100L, " yuz", 100L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 1000L, " ming", 1000L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 1000000L, " million", 1000000L });

            migrationBuilder.InsertData(
                table: "SonEntitylar",
                columns: new[] { "Id", "Ifoda", "Number" },
                values: new object[] { 1000000000L, " milliard", 1000000000L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SonEntitylar");
        }
    }
}
