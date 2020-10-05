using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverse.Data.Migrations
{
    public partial class cloneplanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Uri = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    Edited = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RotationPeriod = table.Column<string>(nullable: true),
                    OrbitalPeriod = table.Column<string>(nullable: true),
                    Diameter = table.Column<string>(nullable: true),
                    Climate = table.Column<string>(nullable: true),
                    Gravity = table.Column<string>(nullable: true),
                    Terrain = table.Column<string>(nullable: true),
                    SurfaceWater = table.Column<string>(nullable: true),
                    Population = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Uri);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Uri", "Climate", "Created", "Diameter", "Edited", "Gravity", "Name", "OrbitalPeriod", "Population", "RotationPeriod", "SurfaceWater", "Terrain" },
                values: new object[,]
                {
                    { "http://swapi.dev/api/planets/1/", "arid", new DateTime(2014, 12, 9, 13, 50, 49, 641, DateTimeKind.Utc), "10465", new DateTime(2014, 12, 20, 20, 58, 18, 411, DateTimeKind.Utc), "1 standard", "Tatooine", "304", "200000", "23", "1", "desert" },
                    { "http://swapi.dev/api/planets/2/", "temperate", new DateTime(2014, 12, 10, 11, 35, 48, 479, DateTimeKind.Utc), "12500", new DateTime(2014, 12, 20, 20, 58, 18, 420, DateTimeKind.Utc), "1 standard", "Alderaan", "364", "2000000000", "24", "40", "grasslands, mountains" },
                    { "http://swapi.dev/api/planets/3/", "temperate, tropical", new DateTime(2014, 12, 10, 11, 37, 19, 144, DateTimeKind.Utc), "10200", new DateTime(2014, 12, 20, 20, 58, 18, 421, DateTimeKind.Utc), "1 standard", "Yavin IV", "4818", "1000", "24", "8", "jungle, rainforests" },
                    { "http://swapi.dev/api/planets/4/", "frozen", new DateTime(2014, 12, 10, 11, 39, 13, 934, DateTimeKind.Utc), "7200", new DateTime(2014, 12, 20, 20, 58, 18, 423, DateTimeKind.Utc), "1.1 standard", "Hoth", "549", "unknown", "23", "100", "tundra, ice caves, mountain ranges" },
                    { "http://swapi.dev/api/planets/5/", "murky", new DateTime(2014, 12, 10, 11, 42, 22, 590, DateTimeKind.Utc), "8900", new DateTime(2014, 12, 20, 20, 58, 18, 425, DateTimeKind.Utc), "N/A", "Dagobah", "341", "unknown", "23", "8", "swamp, jungles" },
                    { "http://swapi.dev/api/planets/6/", "temperate", new DateTime(2014, 12, 10, 11, 43, 55, 240, DateTimeKind.Utc), "118000", new DateTime(2014, 12, 20, 20, 58, 18, 427, DateTimeKind.Utc), "1.5 (surface), 1 standard (Cloud City)", "Bespin", "5110", "6000000", "12", "0", "gas giant" },
                    { "http://swapi.dev/api/planets/7/", "temperate", new DateTime(2014, 12, 10, 11, 50, 29, 349, DateTimeKind.Utc), "4900", new DateTime(2014, 12, 20, 20, 58, 18, 429, DateTimeKind.Utc), "0.85 standard", "Endor", "402", "30000000", "18", "8", "forests, mountains, lakes" },
                    { "http://swapi.dev/api/planets/8/", "temperate", new DateTime(2014, 12, 10, 11, 52, 31, 66, DateTimeKind.Utc), "12120", new DateTime(2014, 12, 20, 20, 58, 18, 430, DateTimeKind.Utc), "1 standard", "Naboo", "312", "4500000000", "26", "12", "grassy hills, swamps, forests, mountains" },
                    { "http://swapi.dev/api/planets/9/", "temperate", new DateTime(2014, 12, 10, 11, 54, 13, 921, DateTimeKind.Utc), "12240", new DateTime(2014, 12, 20, 20, 58, 18, 432, DateTimeKind.Utc), "1 standard", "Coruscant", "368", "1000000000000", "24", "unknown", "cityscape, mountains" },
                    { "http://swapi.dev/api/planets/10/", "temperate", new DateTime(2014, 12, 10, 12, 45, 6, 577, DateTimeKind.Utc), "19720", new DateTime(2014, 12, 20, 20, 58, 18, 434, DateTimeKind.Utc), "1 standard", "Kamino", "463", "1000000000", "27", "100", "ocean" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
