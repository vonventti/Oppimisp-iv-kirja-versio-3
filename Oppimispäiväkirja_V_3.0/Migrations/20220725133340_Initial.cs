using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Oppimispäiväkirja_V_3._0.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aihe",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    TimeToMaster = table.Column<int>(nullable: false),
                    TimeSpent = table.Column<int>(nullable: false),
                    Source = table.Column<string>(nullable: false),
                    StartLearningDate = table.Column<DateTime>(nullable: false),
                    InProgress = table.Column<bool>(nullable: false),
                    CompletionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aihe", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aihe");
        }
    }
}
