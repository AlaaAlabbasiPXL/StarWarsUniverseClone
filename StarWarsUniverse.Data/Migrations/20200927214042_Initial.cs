using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverse.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    EpisodeId = table.Column<int>(nullable: false),
                    OpeningCrawl = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Producer = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Uri);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
