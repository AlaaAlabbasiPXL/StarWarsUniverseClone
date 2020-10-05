using Microsoft.EntityFrameworkCore.Migrations;

namespace StarWarsUniverse.Data.Migrations
{
    public partial class movieplanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MoviePlanet",
                columns: table => new
                {
                    MovieUri = table.Column<string>(nullable: false),
                    PlanetUri = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePlanet", x => new { x.MovieUri, x.PlanetUri });
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Movies_MovieUri",
                        column: x => x.MovieUri,
                        principalTable: "Movies",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Planets_PlanetUri",
                        column: x => x.PlanetUri,
                        principalTable: "Planets",
                        principalColumn: "Uri",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MoviePlanet",
                columns: new[] { "MovieUri", "PlanetUri" },
                values: new object[,]
                {
                    { "http://swapi.dev/api/films/1/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/5/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/2/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/10/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/5/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/4/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/4/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/4/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/8/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/7/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/5/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/1/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/6/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/5/" },
                    { "http://swapi.dev/api/films/2/", "http://swapi.dev/api/planets/4/" },
                    { "http://swapi.dev/api/films/1/", "http://swapi.dev/api/planets/3/" },
                    { "http://swapi.dev/api/films/1/", "http://swapi.dev/api/planets/2/" },
                    { "http://swapi.dev/api/films/3/", "http://swapi.dev/api/planets/9/" },
                    { "http://swapi.dev/api/films/6/", "http://swapi.dev/api/planets/9/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviePlanet_PlanetUri",
                table: "MoviePlanet",
                column: "PlanetUri");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviePlanet");
        }
    }
}
