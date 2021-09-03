using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gorev.DAL.Migrations
{
    public partial class denemeGorev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gorevlers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevAdi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateLastChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedById = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ChangeById = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsRemoved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevlers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorevlers");
        }
    }
}
